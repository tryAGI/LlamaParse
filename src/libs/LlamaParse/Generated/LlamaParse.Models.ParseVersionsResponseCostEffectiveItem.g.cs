
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public enum ParseVersionsResponseCostEffectiveItem
    {
        /// <summary>
        /// 
        /// </summary>
        x20260325,
        /// <summary>
        /// 
        /// </summary>
        x20260327,
        /// <summary>
        /// 
        /// </summary>
        x20260331,
        /// <summary>
        /// 
        /// </summary>
        x20260409,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ParseVersionsResponseCostEffectiveItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ParseVersionsResponseCostEffectiveItem value)
        {
            return value switch
            {
                ParseVersionsResponseCostEffectiveItem.x20260325 => "2026-03-25",
                ParseVersionsResponseCostEffectiveItem.x20260327 => "2026-03-27",
                ParseVersionsResponseCostEffectiveItem.x20260331 => "2026-03-31",
                ParseVersionsResponseCostEffectiveItem.x20260409 => "2026-04-09",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ParseVersionsResponseCostEffectiveItem? ToEnum(string value)
        {
            return value switch
            {
                "2026-03-25" => ParseVersionsResponseCostEffectiveItem.x20260325,
                "2026-03-27" => ParseVersionsResponseCostEffectiveItem.x20260327,
                "2026-03-31" => ParseVersionsResponseCostEffectiveItem.x20260331,
                "2026-04-09" => ParseVersionsResponseCostEffectiveItem.x20260409,
                _ => null,
            };
        }
    }
}