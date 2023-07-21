public class LoggingMiddleware
{
    private readonly RequestDelegate _next;

    public LoggingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        // Loglama işlemleri burada yapılır (örneğin, konsola log yazdırabilir)
        // Bu örnekte sadece action ismi loglanıyor.
        Console.WriteLine($"Action Invoked: {context.Request.Path}");
        
        await _next(context);
    }
}

// Startup.cs içerisinde
app.UseMiddleware<LoggingMiddleware>();
