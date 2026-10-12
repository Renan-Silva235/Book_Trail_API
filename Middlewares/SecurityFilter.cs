namespace BookTrail_Api.Middlewares;

public class SecurityFilter
{
    private readonly RequestDelegate _next;
    
    public SecurityFilter(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        await _next(context);   
    }
}