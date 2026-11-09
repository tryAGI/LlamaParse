
#nullable enable

namespace LlamaParse
{
    /// <summary>
    ///
    /// </summary>
    public enum StoredParseWebhookConfigurationWebhookOutputFormat
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
    public static class StoredParseWebhookConfigurationWebhookOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StoredParseWebhookConfigurationWebhookOutputFormat value)
        {
            return value switch
            {
                StoredParseWebhookConfigurationWebhookOutputFormat.Json => "json",
                StoredParseWebhookConfigurationWebhookOutputFormat.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StoredParseWebhookConfigurationWebhookOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "json" => StoredParseWebhookConfigurationWebhookOutputFormat.Json,
                "string" => StoredParseWebhookConfigurationWebhookOutputFormat.String,
                _ => null,
            };
        }
    }
}