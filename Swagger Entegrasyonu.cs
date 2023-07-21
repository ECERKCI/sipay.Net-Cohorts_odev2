// Startup.cs içerisine Swagger ekleyin
using Microsoft.OpenApi.Models;

// ConfigureServices metodunda
services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "RESTful API", Version = "v1" });
});

// Configure metodunda
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "RESTful API V1");
});
