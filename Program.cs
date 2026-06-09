using Cavex.Principal.Core.Contract;
using Cavex.Principal.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

builder.Services.AddDbContext<CavexContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddSwaggerGen(options =>
{
    options.EnableAnnotations();

    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Cavex Principal API",
        Version = "v1",
        Description = "API principal para catalogos y procesos de Cavex."
    });
});




// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();

    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "Cavex Principal API v1");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
