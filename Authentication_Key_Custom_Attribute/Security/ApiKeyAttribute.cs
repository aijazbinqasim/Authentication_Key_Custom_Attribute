using Microsoft.AspNetCore.Mvc;

namespace Authentication_Key_Custom_Attribute.Security
{
    public class ApiKeyAttribute : ServiceFilterAttribute
    {
        public ApiKeyAttribute()
            : base(typeof(ApiKeyAuthFilter))
        {
        }
    }
}
