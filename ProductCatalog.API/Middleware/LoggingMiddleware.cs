using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using static ProductCatalog.Constants.Constants;

namespace ProductCatalog.API.Middleware
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public LoggingMiddleware(RequestDelegate next, ILogger<LoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
           
            var userName = Roles.Guest;
            var status = string.Empty;
            var path = context.Request.Path;
            var date = DateTime.Now.ToString(Log.DateFormat);

            var token = context.Request.Headers[Log.Header].FirstOrDefault()?.Split(" ").Last();
            if (!string.IsNullOrWhiteSpace(token))
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var jwtToken = tokenHandler.ReadJwtToken(token);

                userName = jwtToken.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name).Value;
            }
            
            try
            {
                await _next(context);

                if (context.Response.StatusCode >= StatusCodes.Status200OK &&
                    context.Response.StatusCode < StatusCodes.Status300MultipleChoices)
                {
                    status = Log.SuccessStatus;
                }

                if(context.Response.StatusCode >= StatusCodes.Status400BadRequest &&
                    context.Response.StatusCode < StatusCodes.Status500InternalServerError)
                {
                    status = Log.FailedStatus;
                }

                _logger.LogInformation(string.Format(Log.LogInfoPattern, status, date, path, userName));
            }
            catch (Exception ex)
            {
                _logger.LogError(string.Format(Log.LogExceptionPattern, status, date, path, userName, ex.Message));
                throw;
            }
        }
    }
}
