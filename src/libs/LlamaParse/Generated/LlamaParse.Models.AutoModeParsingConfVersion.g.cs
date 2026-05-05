
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public enum AutoModeParsingConfVersion
    {
        /// <summary>
        /// 
        /// </summary>
        x20251211,
        /// <summary>
        /// 
        /// </summary>
        x20260409,
        /// <summary>
        /// 
        /// </summary>
        x20260504,
        /// <summary>
        /// 
        /// </summary>
        Latest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoModeParsingConfVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoModeParsingConfVersion value)
        {
            return value switch
            {
                AutoModeParsingConfVersion.x20251211 => "2025-12-11",
                AutoModeParsingConfVersion.x20260409 => "2026-04-09",
                AutoModeParsingConfVersion.x20260504 => "2026-05-04",
                AutoModeParsingConfVersion.Latest => "latest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoModeParsingConfVersion? ToEnum(string value)
        {
            return value switch
            {
                "2025-12-11" => AutoModeParsingConfVersion.x20251211,
                "2026-04-09" => AutoModeParsingConfVersion.x20260409,
                "2026-05-04" => AutoModeParsingConfVersion.x20260504,
                "latest" => AutoModeParsingConfVersion.Latest,
                _ => null,
            };
        }
    }
}