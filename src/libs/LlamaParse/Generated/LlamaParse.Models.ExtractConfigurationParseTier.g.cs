
#nullable enable

namespace LlamaParse
{
    /// <summary>
    ///
    /// </summary>
    public enum ExtractConfigurationParseTier
    {
        /// <summary>
        ///
        /// </summary>
        Agentic,
        /// <summary>
        ///
        /// </summary>
        AgenticPlus,
        /// <summary>
        ///
        /// </summary>
        CostEffective,
        /// <summary>
        ///
        /// </summary>
        Fast,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtractConfigurationParseTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractConfigurationParseTier value)
        {
            return value switch
            {
                ExtractConfigurationParseTier.Agentic => "agentic",
                ExtractConfigurationParseTier.AgenticPlus => "agentic_plus",
                ExtractConfigurationParseTier.CostEffective => "cost_effective",
                ExtractConfigurationParseTier.Fast => "fast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractConfigurationParseTier? ToEnum(string value)
        {
            return value switch
            {
                "agentic" => ExtractConfigurationParseTier.Agentic,
                "agentic_plus" => ExtractConfigurationParseTier.AgenticPlus,
                "cost_effective" => ExtractConfigurationParseTier.CostEffective,
                "fast" => ExtractConfigurationParseTier.Fast,
                _ => null,
            };
        }
    }
}