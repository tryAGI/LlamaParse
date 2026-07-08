
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookConfigResponseWebhookOutputFormat2
    {
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookConfigResponseWebhookOutputFormat2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookConfigResponseWebhookOutputFormat2 value)
        {
            return value switch
            {
                WebhookConfigResponseWebhookOutputFormat2.Json => "json",
                WebhookConfigResponseWebhookOutputFormat2.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookConfigResponseWebhookOutputFormat2? ToEnum(string value)
        {
            return value switch
            {
                "json" => WebhookConfigResponseWebhookOutputFormat2.Json,
                "string" => WebhookConfigResponseWebhookOutputFormat2.String,
                _ => null,
            };
        }
    }
}