
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public enum LlamaParseProcessingOptionsConfidenceScores2
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Verified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LlamaParseProcessingOptionsConfidenceScores2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LlamaParseProcessingOptionsConfidenceScores2 value)
        {
            return value switch
            {
                LlamaParseProcessingOptionsConfidenceScores2.Default => "default",
                LlamaParseProcessingOptionsConfidenceScores2.Verified => "verified",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LlamaParseProcessingOptionsConfidenceScores2? ToEnum(string value)
        {
            return value switch
            {
                "default" => LlamaParseProcessingOptionsConfidenceScores2.Default,
                "verified" => LlamaParseProcessingOptionsConfidenceScores2.Verified,
                _ => null,
            };
        }
    }
}