
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public enum LlamaParseProcessingOptionsForms2
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Enrich,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LlamaParseProcessingOptionsForms2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LlamaParseProcessingOptionsForms2 value)
        {
            return value switch
            {
                LlamaParseProcessingOptionsForms2.Default => "default",
                LlamaParseProcessingOptionsForms2.Enrich => "enrich",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LlamaParseProcessingOptionsForms2? ToEnum(string value)
        {
            return value switch
            {
                "default" => LlamaParseProcessingOptionsForms2.Default,
                "enrich" => LlamaParseProcessingOptionsForms2.Enrich,
                _ => null,
            };
        }
    }
}