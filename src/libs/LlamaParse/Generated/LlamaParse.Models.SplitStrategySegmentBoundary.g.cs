
#nullable enable

namespace LlamaParse
{
    /// <summary>
    ///
    /// </summary>
    public enum SplitStrategySegmentBoundary
    {
        /// <summary>
        ///
        /// </summary>
        Category,
        /// <summary>
        ///
        /// </summary>
        Document,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SplitStrategySegmentBoundaryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SplitStrategySegmentBoundary value)
        {
            return value switch
            {
                SplitStrategySegmentBoundary.Category => "category",
                SplitStrategySegmentBoundary.Document => "document",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SplitStrategySegmentBoundary? ToEnum(string value)
        {
            return value switch
            {
                "category" => SplitStrategySegmentBoundary.Category,
                "document" => SplitStrategySegmentBoundary.Document,
                _ => null,
            };
        }
    }
}