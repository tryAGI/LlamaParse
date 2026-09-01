
#nullable enable

namespace LlamaParse
{
    /// <summary>
    ///
    /// </summary>
    public enum ExtractConfigurationParseTier2
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
    public static class ExtractConfigurationParseTier2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractConfigurationParseTier2 value)
        {
            return value switch
            {
                ExtractConfigurationParseTier2.Agentic => "agentic",
                ExtractConfigurationParseTier2.AgenticPlus => "agentic_plus",
                ExtractConfigurationParseTier2.CostEffective => "cost_effective",
                ExtractConfigurationParseTier2.Fast => "fast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractConfigurationParseTier2? ToEnum(string value)
        {
            return value switch
            {
                "agentic" => ExtractConfigurationParseTier2.Agentic,
                "agentic_plus" => ExtractConfigurationParseTier2.AgenticPlus,
                "cost_effective" => ExtractConfigurationParseTier2.CostEffective,
                "fast" => ExtractConfigurationParseTier2.Fast,
                _ => null,
            };
        }
    }
}