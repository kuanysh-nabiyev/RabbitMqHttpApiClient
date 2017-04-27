using System;

namespace RabbitMqHttpApiClient.Utils
{
    internal static class UrlPathEncoder
    {
        internal static string Encode(this string str)
        {
            var returnStr = Uri.EscapeDataString(str);
            return returnStr;
        }
    }
}