
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
        x20260615,
        /// <summary>
        /// 
        /// </summary>
        x20260618,
        /// <summary>
        /// 
        /// </summary>
        x20260626,
        /// <summary>
        /// 
        /// </summary>
        x20260708,
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
                AutoModeParsingConfVersion.x20260615 => "2026-06-15",
                AutoModeParsingConfVersion.x20260618 => "2026-06-18",
                AutoModeParsingConfVersion.x20260626 => "2026-06-26",
                AutoModeParsingConfVersion.x20260708 => "2026-07-08",
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
                "2026-06-15" => AutoModeParsingConfVersion.x20260615,
                "2026-06-18" => AutoModeParsingConfVersion.x20260618,
                "2026-06-26" => AutoModeParsingConfVersion.x20260626,
                "2026-07-08" => AutoModeParsingConfVersion.x20260708,
                "latest" => AutoModeParsingConfVersion.Latest,
                _ => null,
            };
        }
    }
}