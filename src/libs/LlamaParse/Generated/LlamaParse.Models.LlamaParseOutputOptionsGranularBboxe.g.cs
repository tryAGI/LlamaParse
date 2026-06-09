
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public enum LlamaParseOutputOptionsGranularBboxe
    {
        /// <summary>
        /// 
        /// </summary>
        Cell,
        /// <summary>
        /// 
        /// </summary>
        Line,
        /// <summary>
        /// 
        /// </summary>
        Word,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LlamaParseOutputOptionsGranularBboxeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LlamaParseOutputOptionsGranularBboxe value)
        {
            return value switch
            {
                LlamaParseOutputOptionsGranularBboxe.Cell => "cell",
                LlamaParseOutputOptionsGranularBboxe.Line => "line",
                LlamaParseOutputOptionsGranularBboxe.Word => "word",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LlamaParseOutputOptionsGranularBboxe? ToEnum(string value)
        {
            return value switch
            {
                "cell" => LlamaParseOutputOptionsGranularBboxe.Cell,
                "line" => LlamaParseOutputOptionsGranularBboxe.Line,
                "word" => LlamaParseOutputOptionsGranularBboxe.Word,
                _ => null,
            };
        }
    }
}