using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Globalization;
using System.Threading.Tasks;

namespace middleware.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class RequestCultureMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestCultureMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            var cultureQuery = httpContext.Request.Query["culture"];
            if (!string.IsNullOrWhiteSpace(cultureQuery))
            {
                var culture = new CultureInfo(cultureQuery);

                CultureInfo.CurrentCulture = culture;
                CultureInfo.CurrentUICulture = culture;
            }

            return _next(httpContext);

        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class RequestCultureMiddlewareExtensions
    {
        public static IApplicationBuilder Userc(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RequestCultureMiddleware>();
        }
    }
}
