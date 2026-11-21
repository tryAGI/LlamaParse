
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
        x20261109,
        /// <summary>
        ///
        /// </summary>
        x20261112,
        /// <summary>
        ///
        /// </summary>
        x20261119,
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
                ParseRequestConfigurationVersion.x20261109 => "2026-11-09",
                ParseRequestConfigurationVersion.x20261112 => "2026-11-12",
                ParseRequestConfigurationVersion.x20261119 => "2026-11-19",
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
                "2026-11-09" => ParseRequestConfigurationVersion.x20261109,
                "2026-11-12" => ParseRequestConfigurationVersion.x20261112,
                "2026-11-19" => ParseRequestConfigurationVersion.x20261119,
                "latest" => ParseRequestConfigurationVersion.Latest,
                _ => null,
            };
        }
    }
}