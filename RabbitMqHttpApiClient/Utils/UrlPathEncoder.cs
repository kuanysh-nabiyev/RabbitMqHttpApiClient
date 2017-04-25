using System;

namespace RabbitMqHttpApiClient.Utils
{
    public static class UrlPathEncoder
    {
        public static string Encode(this string str)
        {
            var returnStr = Uri.EscapeDataString(str);
            return returnStr;
        }
    }
}