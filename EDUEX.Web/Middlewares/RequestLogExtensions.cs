using Microsoft.AspNetCore.Builder;

namespace EDUEX.Web.Middlewares
{
    public static class RequestLogExtensions
    {
        public static IApplicationBuilder UseRequestLog(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RequestLogMiddleware>();
        }
    }
}
