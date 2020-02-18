using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Builder;
using System.Threading.Tasks;

namespace Coba.Middleware
{
    public class CustomAuthMiddleware
    {
                    private readonly RequestDelegate _next;

                    public CustomAuthMiddleware(RequestDelegate next)
                    {
                        _next = next;
                    } 

                    public async Task InvokeAsync(HttpContext context)
                    {
                        if(context.Request.Headers["Authorization"] == "hello")
                        {
                            await _next(context);
                        
                        } else {
                                var text = "Not authorized";

                        var data = System.Text.Encoding.UTF8.GetBytes(text);
                        await context.Response.Body.WriteAsync(data, 0, data.Length);
                        }
                        
                    }
    }
    public static class AuthMiddlewareExtension
    {
        public static IApplicationBuilder UserCustomAuthMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomAuthMiddleware>();
        }
    }
}