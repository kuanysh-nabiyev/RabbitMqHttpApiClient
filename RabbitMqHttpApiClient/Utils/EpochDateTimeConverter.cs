using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace RabbitMqHttpApiClient.Utils
{
    public class EpochDateTimeConverter : DateTimeConverterBase
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            double seconds;
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                    seconds = (long)reader.Value;
                    break;
                case JsonToken.Float:
                    seconds = (double)reader.Value;
                    break;
                default:
                    throw new JsonSerializationException(
                        $"Unexpected token parsing date. Expected an integer or double and got {existingValue}.");
            }

            var date = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(seconds);
            return date;
        }
    }
}
