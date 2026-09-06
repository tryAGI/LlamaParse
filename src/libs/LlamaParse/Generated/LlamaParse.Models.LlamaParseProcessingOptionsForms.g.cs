
#nullable enable

namespace LlamaParse
{
    /// <summary>
    ///
    /// </summary>
    public enum LlamaParseProcessingOptionsForms
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
    public static class LlamaParseProcessingOptionsFormsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LlamaParseProcessingOptionsForms value)
        {
            return value switch
            {
                LlamaParseProcessingOptionsForms.Default => "default",
                LlamaParseProcessingOptionsForms.Enrich => "enrich",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LlamaParseProcessingOptionsForms? ToEnum(string value)
        {
            return value switch
            {
                "default" => LlamaParseProcessingOptionsForms.Default,
                "enrich" => LlamaParseProcessingOptionsForms.Enrich,
                _ => null,
            };
        }
    }
}