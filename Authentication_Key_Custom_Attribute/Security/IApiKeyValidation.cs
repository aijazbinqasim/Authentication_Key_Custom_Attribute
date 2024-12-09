namespace Authentication_Key_Custom_Attribute.Security
{
    public interface IApiKeyValidation
    {
        bool IsValidApiKey(string userApiKey);
    }
}
