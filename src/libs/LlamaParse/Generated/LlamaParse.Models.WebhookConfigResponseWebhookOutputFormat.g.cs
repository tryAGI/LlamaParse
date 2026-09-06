
#nullable enable

namespace LlamaParse
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookConfigResponseWebhookOutputFormat
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
    public static class WebhookConfigResponseWebhookOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookConfigResponseWebhookOutputFormat value)
        {
            return value switch
            {
                WebhookConfigResponseWebhookOutputFormat.Json => "json",
                WebhookConfigResponseWebhookOutputFormat.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookConfigResponseWebhookOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "json" => WebhookConfigResponseWebhookOutputFormat.Json,
                "string" => WebhookConfigResponseWebhookOutputFormat.String,
                _ => null,
            };
        }
    }
}