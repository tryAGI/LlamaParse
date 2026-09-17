
#nullable enable

namespace LlamaParse
{
    /// <summary>
    ///
    /// </summary>
    public enum SplitConfigurationParseTier
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
    public static class SplitConfigurationParseTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SplitConfigurationParseTier value)
        {
            return value switch
            {
                SplitConfigurationParseTier.Agentic => "agentic",
                SplitConfigurationParseTier.AgenticPlus => "agentic_plus",
                SplitConfigurationParseTier.CostEffective => "cost_effective",
                SplitConfigurationParseTier.Fast => "fast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SplitConfigurationParseTier? ToEnum(string value)
        {
            return value switch
            {
                "agentic" => SplitConfigurationParseTier.Agentic,
                "agentic_plus" => SplitConfigurationParseTier.AgenticPlus,
                "cost_effective" => SplitConfigurationParseTier.CostEffective,
                "fast" => SplitConfigurationParseTier.Fast,
                _ => null,
            };
        }
    }
}