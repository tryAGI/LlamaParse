
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public enum LlamaParseWebhookConfigurationWebhookOutputFormat2
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
    public static class LlamaParseWebhookConfigurationWebhookOutputFormat2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LlamaParseWebhookConfigurationWebhookOutputFormat2 value)
        {
            return value switch
            {
                LlamaParseWebhookConfigurationWebhookOutputFormat2.Json => "json",
                LlamaParseWebhookConfigurationWebhookOutputFormat2.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LlamaParseWebhookConfigurationWebhookOutputFormat2? ToEnum(string value)
        {
            return value switch
            {
                "json" => LlamaParseWebhookConfigurationWebhookOutputFormat2.Json,
                "string" => LlamaParseWebhookConfigurationWebhookOutputFormat2.String,
                _ => null,
            };
        }
    }
}