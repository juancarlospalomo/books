using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;

namespace WebCore.Middleware
{
    public class CustomErrorMiddleware
    {
        private readonly RequestDelegate _next;

        public CustomErrorMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            await _next(context);
            if (context.Response.StatusCode == StatusCodes.Status404NotFound &&
                Path.HasExtension(context.Request.Path.Value))
            {
                context.Request.Path = "/error.html";
                await _next(context);
            }
            else
            {
                await _next(context);
            }
        }

    }
}
