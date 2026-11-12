
#nullable enable

namespace LlamaParse
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoModeConfigurationEntryMinComplexity
    {
        /// <summary>
        ///
        /// </summary>
        High,
        /// <summary>
        ///
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoModeConfigurationEntryMinComplexityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoModeConfigurationEntryMinComplexity value)
        {
            return value switch
            {
                AutoModeConfigurationEntryMinComplexity.High => "high",
                AutoModeConfigurationEntryMinComplexity.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoModeConfigurationEntryMinComplexity? ToEnum(string value)
        {
            return value switch
            {
                "high" => AutoModeConfigurationEntryMinComplexity.High,
                "medium" => AutoModeConfigurationEntryMinComplexity.Medium,
                _ => null,
            };
        }
    }
}