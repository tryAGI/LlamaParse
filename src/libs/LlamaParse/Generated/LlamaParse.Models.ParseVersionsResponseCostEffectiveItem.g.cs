
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
        /// <summary>
        /// 
        /// </summary>
        x20260528,
        /// <summary>
        /// 
        /// </summary>
        x20260605,
        /// <summary>
        /// 
        /// </summary>
        x20260608,
        /// <summary>
        /// 
        /// </summary>
        x20260611,
        /// <summary>
        /// 
        /// </summary>
        x20260617,
        /// <summary>
        /// 
        /// </summary>
        x20260618,
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
                ParseVersionsResponseCostEffectiveItem.x20260528 => "2026-05-28",
                ParseVersionsResponseCostEffectiveItem.x20260605 => "2026-06-05",
                ParseVersionsResponseCostEffectiveItem.x20260608 => "2026-06-08",
                ParseVersionsResponseCostEffectiveItem.x20260611 => "2026-06-11",
                ParseVersionsResponseCostEffectiveItem.x20260617 => "2026-06-17",
                ParseVersionsResponseCostEffectiveItem.x20260618 => "2026-06-18",
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
                "2026-05-28" => ParseVersionsResponseCostEffectiveItem.x20260528,
                "2026-06-05" => ParseVersionsResponseCostEffectiveItem.x20260605,
                "2026-06-08" => ParseVersionsResponseCostEffectiveItem.x20260608,
                "2026-06-11" => ParseVersionsResponseCostEffectiveItem.x20260611,
                "2026-06-17" => ParseVersionsResponseCostEffectiveItem.x20260617,
                "2026-06-18" => ParseVersionsResponseCostEffectiveItem.x20260618,
                _ => null,
            };
        }
    }
}