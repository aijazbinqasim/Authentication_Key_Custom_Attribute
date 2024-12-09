using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Authentication_Key_Custom_Attribute.Security
{
    public class ApiKeyAuthFilter(IApiKeyValidation apiKeyValidation) : IAuthorizationFilter
    {
        private readonly IApiKeyValidation _apiKeyValidation = apiKeyValidation;

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var userApiKey = context.HttpContext.Request.Headers[Constant.ApiKeyHeaderName].ToString();
            if (string.IsNullOrWhiteSpace(userApiKey))
            {
                context.Result = new BadRequestResult();
                return;
            }
            if (!_apiKeyValidation.IsValidApiKey(userApiKey))
            {
                context.Result = new UnauthorizedResult();
            }
        }
    }
}
