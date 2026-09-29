
#nullable enable

namespace LlamaParse
{
    /// <summary>
    ///
    /// </summary>
    public enum LlamaParseOutputOptionsWatermarkHandling
    {
        /// <summary>
        ///
        /// </summary>
        MoveToEnd,
        /// <summary>
        ///
        /// </summary>
        MoveToStart,
        /// <summary>
        ///
        /// </summary>
        Remove,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LlamaParseOutputOptionsWatermarkHandlingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LlamaParseOutputOptionsWatermarkHandling value)
        {
            return value switch
            {
                LlamaParseOutputOptionsWatermarkHandling.MoveToEnd => "move_to_end",
                LlamaParseOutputOptionsWatermarkHandling.MoveToStart => "move_to_start",
                LlamaParseOutputOptionsWatermarkHandling.Remove => "remove",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LlamaParseOutputOptionsWatermarkHandling? ToEnum(string value)
        {
            return value switch
            {
                "move_to_end" => LlamaParseOutputOptionsWatermarkHandling.MoveToEnd,
                "move_to_start" => LlamaParseOutputOptionsWatermarkHandling.MoveToStart,
                "remove" => LlamaParseOutputOptionsWatermarkHandling.Remove,
                _ => null,
            };
        }
    }
}