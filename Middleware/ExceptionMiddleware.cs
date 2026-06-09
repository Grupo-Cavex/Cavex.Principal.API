using Cavex.Principal.API.Errors;
using Cavex.Principal.Common.Transfer;
using System.Net;
using System.Text.Json;

namespace Cavex.Principal.API.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionMiddleware> _logger;
        private readonly IHostEnvironment _environment;

        public ExceptionMiddleware(
            RequestDelegate next,
            ILogger<ExceptionMiddleware> logger,
            IHostEnvironment environment)
        {
            _next = next;
            _logger = logger;
            _environment = environment;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception exception)
            {
                await HandleExceptionAsync(context, exception);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var traceId = context.TraceIdentifier;
            var path = context.Request.Path.Value;

            using (_logger.BeginScope(new Dictionary<string, object?>
            {
                ["TraceId"] = traceId,
                ["Path"] = path
            }))
            {
                _logger.LogError(exception, "Excepcion no controlada. TraceId: {TraceId}. Path: {Path}", traceId, path);
            }

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = StatusCodes.Status500InternalServerError;

            var message = _environment.IsDevelopment()
                ? exception.Message
                : "Ocurrio un error interno en el servidor.";

            var error = new ApiErrorResponse
            {
                StatusCode = StatusCodes.Status500InternalServerError,
                Message = message,
                TraceId = traceId,
                Path = path
            };

            var response = new ResponseWrapper<ApiErrorResponse>
            {
                StatusCode = HttpStatusCode.InternalServerError,
                Message = "Error interno del servidor.",
                Data = error
            };

            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            var json = JsonSerializer.Serialize(response, options);

            await context.Response.WriteAsync(json);
        }
    }
}
