
#nullable enable

namespace LlamaParse
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookConfigCreateRequestWebhookOutputFormat
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
    public static class WebhookConfigCreateRequestWebhookOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookConfigCreateRequestWebhookOutputFormat value)
        {
            return value switch
            {
                WebhookConfigCreateRequestWebhookOutputFormat.Json => "json",
                WebhookConfigCreateRequestWebhookOutputFormat.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookConfigCreateRequestWebhookOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "json" => WebhookConfigCreateRequestWebhookOutputFormat.Json,
                "string" => WebhookConfigCreateRequestWebhookOutputFormat.String,
                _ => null,
            };
        }
    }
}