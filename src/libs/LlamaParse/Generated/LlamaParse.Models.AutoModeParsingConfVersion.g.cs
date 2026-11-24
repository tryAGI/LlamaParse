
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
        x20261112,
        /// <summary>
        ///
        /// </summary>
        x20261119,
        /// <summary>
        ///
        /// </summary>
        x20261122,
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
                AutoModeParsingConfVersion.x20261112 => "2026-11-12",
                AutoModeParsingConfVersion.x20261119 => "2026-11-19",
                AutoModeParsingConfVersion.x20261122 => "2026-11-22",
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
                "2026-11-12" => AutoModeParsingConfVersion.x20261112,
                "2026-11-19" => AutoModeParsingConfVersion.x20261119,
                "2026-11-22" => AutoModeParsingConfVersion.x20261122,
                "latest" => AutoModeParsingConfVersion.Latest,
                _ => null,
            };
        }
    }
}