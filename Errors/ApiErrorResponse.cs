namespace Cavex.Principal.API.Errors
{
    public class ApiErrorResponse
    {
        public int StatusCode { get; set; }

        public string Message { get; set; } = string.Empty;

        public string? TraceId { get; set; }

        public string? Path { get; set; }
    }
}
