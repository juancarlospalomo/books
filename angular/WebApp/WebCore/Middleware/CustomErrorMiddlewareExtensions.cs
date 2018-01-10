using Microsoft.AspNetCore.Builder;

namespace WebCore.Middleware
{
    public static class CustomErrorMiddlewareExtensions
    {
        public static IApplicationBuilder UseCustomError(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomErrorMiddleware>();
        }
    }
}
