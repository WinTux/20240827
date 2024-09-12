using System.Diagnostics;

namespace ProyectoAppWeb.Middleware
{
    public class DatosClienteMiddleware
    {
        private readonly RequestDelegate request;
        public DatosClienteMiddleware(RequestDelegate request)
        {
            this.request = request;
        }
        public Task Invoke(HttpContext httpContext)
        {
            var userAgent = httpContext.Request.Headers["User-Agent"].ToString();
            var ipAddress = httpContext.Connection.RemoteIpAddress.ToString();
            var endpoint = httpContext.Request.Path;
            Debug.WriteLine($"User Agent: {userAgent}, IP petición: {ipAddress}, Ruta: {endpoint}");
            return request(httpContext);
        }
    }
    public static class DatosClienteMiddlewareExtensions
    {
        public static IApplicationBuilder UseDatosClienteMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<DatosClienteMiddleware>();
        }
    }
}
