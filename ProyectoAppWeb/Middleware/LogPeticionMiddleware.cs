using Microsoft.AspNetCore.Builder;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ProyectoAppWeb.Middleware
{
    public class LogPeticionMiddleware
    {
        private readonly RequestDelegate request;
        public LogPeticionMiddleware(RequestDelegate request)
        {
            this.request = request;
        }
        public Task Invoke(HttpContext httpContext) {
            Debug.WriteLine($"Fecha: {DateTime.Now.ToLongDateString}");
            return request(httpContext);
        }
    }
    public static class ElementoLogPeticionMiddleware{
        public static IApplicationBuilder UseLogPeticionMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LogPeticionMiddleware>();
        }
    }
}
