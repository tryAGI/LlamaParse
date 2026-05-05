
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public enum ParseVersionsResponseAgenticItem
    {
        /// <summary>
        /// 
        /// </summary>
        x20251211,
        /// <summary>
        /// 
        /// </summary>
        x20251218,
        /// <summary>
        /// 
        /// </summary>
        x20251231,
        /// <summary>
        /// 
        /// </summary>
        x20260108,
        /// <summary>
        /// 
        /// </summary>
        x20260116,
        /// <summary>
        /// 
        /// </summary>
        x20260121,
        /// <summary>
        /// 
        /// </summary>
        x20260122,
        /// <summary>
        /// 
        /// </summary>
        x20260130,
        /// <summary>
        /// 
        /// </summary>
        x20260224,
        /// <summary>
        /// 
        /// </summary>
        x20260226,
        /// <summary>
        /// 
        /// </summary>
        x20260302,
        /// <summary>
        /// 
        /// </summary>
        x20260303,
        /// <summary>
        /// 
        /// </summary>
        x20260309,
        /// <summary>
        /// 
        /// </summary>
        x20260310,
        /// <summary>
        /// 
        /// </summary>
        x20260311,
        /// <summary>
        /// 
        /// </summary>
        x20260320,
        /// <summary>
        /// 
        /// </summary>
        x20260322,
        /// <summary>
        /// 
        /// </summary>
        x20260323,
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
        x20260330,
        /// <summary>
        /// 
        /// </summary>
        x20260331,
        /// <summary>
        /// 
        /// </summary>
        x20260402,
        /// <summary>
        /// 
        /// </summary>
        x20260406,
        /// <summary>
        /// 
        /// </summary>
        x20260409,
        /// <summary>
        /// 
        /// </summary>
        x20260422,
        /// <summary>
        /// 
        /// </summary>
        x20260427,
        /// <summary>
        /// 
        /// </summary>
        x20260504,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ParseVersionsResponseAgenticItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ParseVersionsResponseAgenticItem value)
        {
            return value switch
            {
                ParseVersionsResponseAgenticItem.x20251211 => "2025-12-11",
                ParseVersionsResponseAgenticItem.x20251218 => "2025-12-18",
                ParseVersionsResponseAgenticItem.x20251231 => "2025-12-31",
                ParseVersionsResponseAgenticItem.x20260108 => "2026-01-08",
                ParseVersionsResponseAgenticItem.x20260116 => "2026-01-16",
                ParseVersionsResponseAgenticItem.x20260121 => "2026-01-21",
                ParseVersionsResponseAgenticItem.x20260122 => "2026-01-22",
                ParseVersionsResponseAgenticItem.x20260130 => "2026-01-30",
                ParseVersionsResponseAgenticItem.x20260224 => "2026-02-24",
                ParseVersionsResponseAgenticItem.x20260226 => "2026-02-26",
                ParseVersionsResponseAgenticItem.x20260302 => "2026-03-02",
                ParseVersionsResponseAgenticItem.x20260303 => "2026-03-03",
                ParseVersionsResponseAgenticItem.x20260309 => "2026-03-09",
                ParseVersionsResponseAgenticItem.x20260310 => "2026-03-10",
                ParseVersionsResponseAgenticItem.x20260311 => "2026-03-11",
                ParseVersionsResponseAgenticItem.x20260320 => "2026-03-20",
                ParseVersionsResponseAgenticItem.x20260322 => "2026-03-22",
                ParseVersionsResponseAgenticItem.x20260323 => "2026-03-23",
                ParseVersionsResponseAgenticItem.x20260325 => "2026-03-25",
                ParseVersionsResponseAgenticItem.x20260327 => "2026-03-27",
                ParseVersionsResponseAgenticItem.x20260330 => "2026-03-30",
                ParseVersionsResponseAgenticItem.x20260331 => "2026-03-31",
                ParseVersionsResponseAgenticItem.x20260402 => "2026-04-02",
                ParseVersionsResponseAgenticItem.x20260406 => "2026-04-06",
                ParseVersionsResponseAgenticItem.x20260409 => "2026-04-09",
                ParseVersionsResponseAgenticItem.x20260422 => "2026-04-22",
                ParseVersionsResponseAgenticItem.x20260427 => "2026-04-27",
                ParseVersionsResponseAgenticItem.x20260504 => "2026-05-04",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ParseVersionsResponseAgenticItem? ToEnum(string value)
        {
            return value switch
            {
                "2025-12-11" => ParseVersionsResponseAgenticItem.x20251211,
                "2025-12-18" => ParseVersionsResponseAgenticItem.x20251218,
                "2025-12-31" => ParseVersionsResponseAgenticItem.x20251231,
                "2026-01-08" => ParseVersionsResponseAgenticItem.x20260108,
                "2026-01-16" => ParseVersionsResponseAgenticItem.x20260116,
                "2026-01-21" => ParseVersionsResponseAgenticItem.x20260121,
                "2026-01-22" => ParseVersionsResponseAgenticItem.x20260122,
                "2026-01-30" => ParseVersionsResponseAgenticItem.x20260130,
                "2026-02-24" => ParseVersionsResponseAgenticItem.x20260224,
                "2026-02-26" => ParseVersionsResponseAgenticItem.x20260226,
                "2026-03-02" => ParseVersionsResponseAgenticItem.x20260302,
                "2026-03-03" => ParseVersionsResponseAgenticItem.x20260303,
                "2026-03-09" => ParseVersionsResponseAgenticItem.x20260309,
                "2026-03-10" => ParseVersionsResponseAgenticItem.x20260310,
                "2026-03-11" => ParseVersionsResponseAgenticItem.x20260311,
                "2026-03-20" => ParseVersionsResponseAgenticItem.x20260320,
                "2026-03-22" => ParseVersionsResponseAgenticItem.x20260322,
                "2026-03-23" => ParseVersionsResponseAgenticItem.x20260323,
                "2026-03-25" => ParseVersionsResponseAgenticItem.x20260325,
                "2026-03-27" => ParseVersionsResponseAgenticItem.x20260327,
                "2026-03-30" => ParseVersionsResponseAgenticItem.x20260330,
                "2026-03-31" => ParseVersionsResponseAgenticItem.x20260331,
                "2026-04-02" => ParseVersionsResponseAgenticItem.x20260402,
                "2026-04-06" => ParseVersionsResponseAgenticItem.x20260406,
                "2026-04-09" => ParseVersionsResponseAgenticItem.x20260409,
                "2026-04-22" => ParseVersionsResponseAgenticItem.x20260422,
                "2026-04-27" => ParseVersionsResponseAgenticItem.x20260427,
                "2026-05-04" => ParseVersionsResponseAgenticItem.x20260504,
                _ => null,
            };
        }
    }
}