
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public enum ParseVersionsResponseFastItem
    {
        /// <summary>
        /// 
        /// </summary>
        x20251211,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ParseVersionsResponseFastItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ParseVersionsResponseFastItem value)
        {
            return value switch
            {
                ParseVersionsResponseFastItem.x20251211 => "2025-12-11",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ParseVersionsResponseFastItem? ToEnum(string value)
        {
            return value switch
            {
                "2025-12-11" => ParseVersionsResponseFastItem.x20251211,
                _ => null,
            };
        }
    }
}