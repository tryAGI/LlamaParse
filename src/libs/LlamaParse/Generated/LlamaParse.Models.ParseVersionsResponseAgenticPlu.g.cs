
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public enum ParseVersionsResponseAgenticPlu
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
        x20260124,
        /// <summary>
        /// 
        /// </summary>
        x20260129,
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
        x20260309,
        /// <summary>
        /// 
        /// </summary>
        x20260310,
        /// <summary>
        /// 
        /// </summary>
        x20260312,
        /// <summary>
        /// 
        /// </summary>
        x20260317,
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
        x20260325,
        /// <summary>
        /// 
        /// </summary>
        x20260326,
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
        x20260409,
        /// <summary>
        /// 
        /// </summary>
        x20260414,
        /// <summary>
        /// 
        /// </summary>
        x20260419,
        /// <summary>
        /// 
        /// </summary>
        x20260427,
        /// <summary>
        /// 
        /// </summary>
        x20260501,
        /// <summary>
        /// 
        /// </summary>
        x20260504,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ParseVersionsResponseAgenticPluExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ParseVersionsResponseAgenticPlu value)
        {
            return value switch
            {
                ParseVersionsResponseAgenticPlu.x20251211 => "2025-12-11",
                ParseVersionsResponseAgenticPlu.x20251218 => "2025-12-18",
                ParseVersionsResponseAgenticPlu.x20251231 => "2025-12-31",
                ParseVersionsResponseAgenticPlu.x20260116 => "2026-01-16",
                ParseVersionsResponseAgenticPlu.x20260121 => "2026-01-21",
                ParseVersionsResponseAgenticPlu.x20260122 => "2026-01-22",
                ParseVersionsResponseAgenticPlu.x20260124 => "2026-01-24",
                ParseVersionsResponseAgenticPlu.x20260129 => "2026-01-29",
                ParseVersionsResponseAgenticPlu.x20260130 => "2026-01-30",
                ParseVersionsResponseAgenticPlu.x20260224 => "2026-02-24",
                ParseVersionsResponseAgenticPlu.x20260226 => "2026-02-26",
                ParseVersionsResponseAgenticPlu.x20260302 => "2026-03-02",
                ParseVersionsResponseAgenticPlu.x20260309 => "2026-03-09",
                ParseVersionsResponseAgenticPlu.x20260310 => "2026-03-10",
                ParseVersionsResponseAgenticPlu.x20260312 => "2026-03-12",
                ParseVersionsResponseAgenticPlu.x20260317 => "2026-03-17",
                ParseVersionsResponseAgenticPlu.x20260320 => "2026-03-20",
                ParseVersionsResponseAgenticPlu.x20260322 => "2026-03-22",
                ParseVersionsResponseAgenticPlu.x20260325 => "2026-03-25",
                ParseVersionsResponseAgenticPlu.x20260326 => "2026-03-26",
                ParseVersionsResponseAgenticPlu.x20260331 => "2026-03-31",
                ParseVersionsResponseAgenticPlu.x20260402 => "2026-04-02",
                ParseVersionsResponseAgenticPlu.x20260409 => "2026-04-09",
                ParseVersionsResponseAgenticPlu.x20260414 => "2026-04-14",
                ParseVersionsResponseAgenticPlu.x20260419 => "2026-04-19",
                ParseVersionsResponseAgenticPlu.x20260427 => "2026-04-27",
                ParseVersionsResponseAgenticPlu.x20260501 => "2026-05-01",
                ParseVersionsResponseAgenticPlu.x20260504 => "2026-05-04",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ParseVersionsResponseAgenticPlu? ToEnum(string value)
        {
            return value switch
            {
                "2025-12-11" => ParseVersionsResponseAgenticPlu.x20251211,
                "2025-12-18" => ParseVersionsResponseAgenticPlu.x20251218,
                "2025-12-31" => ParseVersionsResponseAgenticPlu.x20251231,
                "2026-01-16" => ParseVersionsResponseAgenticPlu.x20260116,
                "2026-01-21" => ParseVersionsResponseAgenticPlu.x20260121,
                "2026-01-22" => ParseVersionsResponseAgenticPlu.x20260122,
                "2026-01-24" => ParseVersionsResponseAgenticPlu.x20260124,
                "2026-01-29" => ParseVersionsResponseAgenticPlu.x20260129,
                "2026-01-30" => ParseVersionsResponseAgenticPlu.x20260130,
                "2026-02-24" => ParseVersionsResponseAgenticPlu.x20260224,
                "2026-02-26" => ParseVersionsResponseAgenticPlu.x20260226,
                "2026-03-02" => ParseVersionsResponseAgenticPlu.x20260302,
                "2026-03-09" => ParseVersionsResponseAgenticPlu.x20260309,
                "2026-03-10" => ParseVersionsResponseAgenticPlu.x20260310,
                "2026-03-12" => ParseVersionsResponseAgenticPlu.x20260312,
                "2026-03-17" => ParseVersionsResponseAgenticPlu.x20260317,
                "2026-03-20" => ParseVersionsResponseAgenticPlu.x20260320,
                "2026-03-22" => ParseVersionsResponseAgenticPlu.x20260322,
                "2026-03-25" => ParseVersionsResponseAgenticPlu.x20260325,
                "2026-03-26" => ParseVersionsResponseAgenticPlu.x20260326,
                "2026-03-31" => ParseVersionsResponseAgenticPlu.x20260331,
                "2026-04-02" => ParseVersionsResponseAgenticPlu.x20260402,
                "2026-04-09" => ParseVersionsResponseAgenticPlu.x20260409,
                "2026-04-14" => ParseVersionsResponseAgenticPlu.x20260414,
                "2026-04-19" => ParseVersionsResponseAgenticPlu.x20260419,
                "2026-04-27" => ParseVersionsResponseAgenticPlu.x20260427,
                "2026-05-01" => ParseVersionsResponseAgenticPlu.x20260501,
                "2026-05-04" => ParseVersionsResponseAgenticPlu.x20260504,
                _ => null,
            };
        }
    }
}