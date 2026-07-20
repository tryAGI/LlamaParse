
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
        x20260615,
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
        x20260715,
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
                ParseV2ParametersVersion.x20260615 => "2026-06-15",
                ParseV2ParametersVersion.x20260626 => "2026-06-26",
                ParseV2ParametersVersion.x20260708 => "2026-07-08",
                ParseV2ParametersVersion.x20260715 => "2026-07-15",
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
                "2026-06-15" => ParseV2ParametersVersion.x20260615,
                "2026-06-26" => ParseV2ParametersVersion.x20260626,
                "2026-07-08" => ParseV2ParametersVersion.x20260708,
                "2026-07-15" => ParseV2ParametersVersion.x20260715,
                "latest" => ParseV2ParametersVersion.Latest,
                _ => null,
            };
        }
    }
}