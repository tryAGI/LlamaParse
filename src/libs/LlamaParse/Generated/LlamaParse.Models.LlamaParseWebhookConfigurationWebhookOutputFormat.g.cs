
#nullable enable

namespace LlamaParse
{
    /// <summary>
    ///
    /// </summary>
    public enum LlamaParseWebhookConfigurationWebhookOutputFormat
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
    public static class LlamaParseWebhookConfigurationWebhookOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LlamaParseWebhookConfigurationWebhookOutputFormat value)
        {
            return value switch
            {
                LlamaParseWebhookConfigurationWebhookOutputFormat.Json => "json",
                LlamaParseWebhookConfigurationWebhookOutputFormat.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LlamaParseWebhookConfigurationWebhookOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "json" => LlamaParseWebhookConfigurationWebhookOutputFormat.Json,
                "string" => LlamaParseWebhookConfigurationWebhookOutputFormat.String,
                _ => null,
            };
        }
    }
}