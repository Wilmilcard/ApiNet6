using Newtonsoft.Json;
using System.Net;

namespace ApiNet6
{
    public class GlobalExceptionHandler : IMiddleware
    {
        private ILogger<GlobalExceptionHandler> _logger;
        public GlobalExceptionHandler(ILogger<GlobalExceptionHandler> logger)
        {
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                string message = ex.Message.ToString();
                context.Response.ContentType = "application/json";
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                //Log the Exception Details
                _logger.LogError($"Exception Details: {message}");
                var response = new
                {
                    juan = "mensaje interno",
                    StatusCode = context.Response.StatusCode,
                    Message = message
                };
                await context.Response.WriteAsync(JsonConvert.SerializeObject(response));
            }
        }
    }
}
