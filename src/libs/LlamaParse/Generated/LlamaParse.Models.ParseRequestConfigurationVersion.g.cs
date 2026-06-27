
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public enum ParseRequestConfigurationVersion
    {
        /// <summary>
        /// 
        /// </summary>
        x20251211,
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
        Latest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ParseRequestConfigurationVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ParseRequestConfigurationVersion value)
        {
            return value switch
            {
                ParseRequestConfigurationVersion.x20251211 => "2025-12-11",
                ParseRequestConfigurationVersion.x20260618 => "2026-06-18",
                ParseRequestConfigurationVersion.x20260626 => "2026-06-26",
                ParseRequestConfigurationVersion.Latest => "latest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ParseRequestConfigurationVersion? ToEnum(string value)
        {
            return value switch
            {
                "2025-12-11" => ParseRequestConfigurationVersion.x20251211,
                "2026-06-18" => ParseRequestConfigurationVersion.x20260618,
                "2026-06-26" => ParseRequestConfigurationVersion.x20260626,
                "latest" => ParseRequestConfigurationVersion.Latest,
                _ => null,
            };
        }
    }
}