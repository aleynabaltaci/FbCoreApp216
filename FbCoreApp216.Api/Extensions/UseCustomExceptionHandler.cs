using FbCoreApp216.Api.DTOs;
using Microsoft.AspNetCore.Diagnostics;
using Newtonsoft.Json;

namespace FbCoreApp216.Api.Extensions
{
    public static class UseCustomExceptionHandler
    {
        public static void UseCustomException(this IApplicationBuilder app)
        {

            //Extension'lar static yapıdadır. static'ler new'lenmeye gerek duymaz. hızlıdır ama çok yer kaplar işi bitince kapatılmalı.
            // çaışması için middleware eklenmeli. program.cs
            app.UseExceptionHandler(config =>
            {
                config.Run(async context =>
                {
                    context.Response.StatusCode = 500;
                    context.Response.ContentType = "application/json";
                    var error = context.Features.Get<IExceptionHandlerFeature>();


                    if (error != null)
                    {
                        var ex = error.Error;
                        if (ex != null)
                        {
                            ErrorDto errorDto = new ErrorDto();
                            errorDto.Status = 500;
                            errorDto.Errors.Add(ex.Message);
                            await context.Response.WriteAsync(JsonConvert.SerializeObject(errorDto));
                        }

                    }
                });
            });
        }
    }
}
