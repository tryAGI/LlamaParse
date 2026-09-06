
#nullable enable

namespace LlamaParse
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookConfigUpdateRequestWebhookOutputFormat
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
    public static class WebhookConfigUpdateRequestWebhookOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookConfigUpdateRequestWebhookOutputFormat value)
        {
            return value switch
            {
                WebhookConfigUpdateRequestWebhookOutputFormat.Json => "json",
                WebhookConfigUpdateRequestWebhookOutputFormat.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookConfigUpdateRequestWebhookOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "json" => WebhookConfigUpdateRequestWebhookOutputFormat.Json,
                "string" => WebhookConfigUpdateRequestWebhookOutputFormat.String,
                _ => null,
            };
        }
    }
}