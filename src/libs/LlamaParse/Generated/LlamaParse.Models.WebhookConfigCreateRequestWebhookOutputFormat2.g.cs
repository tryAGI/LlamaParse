
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookConfigCreateRequestWebhookOutputFormat2
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
    public static class WebhookConfigCreateRequestWebhookOutputFormat2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookConfigCreateRequestWebhookOutputFormat2 value)
        {
            return value switch
            {
                WebhookConfigCreateRequestWebhookOutputFormat2.Json => "json",
                WebhookConfigCreateRequestWebhookOutputFormat2.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookConfigCreateRequestWebhookOutputFormat2? ToEnum(string value)
        {
            return value switch
            {
                "json" => WebhookConfigCreateRequestWebhookOutputFormat2.Json,
                "string" => WebhookConfigCreateRequestWebhookOutputFormat2.String,
                _ => null,
            };
        }
    }
}