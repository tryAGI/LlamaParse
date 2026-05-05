
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public enum ParseV2ParametersVersion
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
    public static class ParseV2ParametersVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ParseV2ParametersVersion value)
        {
            return value switch
            {
                ParseV2ParametersVersion.x20251211 => "2025-12-11",
                ParseV2ParametersVersion.x20260409 => "2026-04-09",
                ParseV2ParametersVersion.x20260504 => "2026-05-04",
                ParseV2ParametersVersion.Latest => "latest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ParseV2ParametersVersion? ToEnum(string value)
        {
            return value switch
            {
                "2025-12-11" => ParseV2ParametersVersion.x20251211,
                "2026-04-09" => ParseV2ParametersVersion.x20260409,
                "2026-05-04" => ParseV2ParametersVersion.x20260504,
                "latest" => ParseV2ParametersVersion.Latest,
                _ => null,
            };
        }
    }
}