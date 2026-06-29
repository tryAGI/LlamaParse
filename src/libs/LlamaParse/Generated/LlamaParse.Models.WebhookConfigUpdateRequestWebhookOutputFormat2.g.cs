
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookConfigUpdateRequestWebhookOutputFormat2
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
    public static class WebhookConfigUpdateRequestWebhookOutputFormat2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookConfigUpdateRequestWebhookOutputFormat2 value)
        {
            return value switch
            {
                WebhookConfigUpdateRequestWebhookOutputFormat2.Json => "json",
                WebhookConfigUpdateRequestWebhookOutputFormat2.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookConfigUpdateRequestWebhookOutputFormat2? ToEnum(string value)
        {
            return value switch
            {
                "json" => WebhookConfigUpdateRequestWebhookOutputFormat2.Json,
                "string" => WebhookConfigUpdateRequestWebhookOutputFormat2.String,
                _ => null,
            };
        }
    }
}