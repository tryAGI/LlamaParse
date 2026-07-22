
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Extract tier: cost_effective (5 credits/page), agentic (15 credits/page), or agentic_plus (50 credits/page)<br/>
    /// Default Value: cost_effective
    /// </summary>
    public enum ExtractConfigurationTier
    {
        /// <summary>
        /// cost_effective (5 credits/page), agentic (15 credits/page), or agentic_plus (50 credits/page)
        /// </summary>
        Agentic,
        /// <summary>
        /// cost_effective (5 credits/page), agentic (15 credits/page), or agentic_plus (50 credits/page)
        /// </summary>
        AgenticPlus,
        /// <summary>
        /// cost_effective (5 credits/page), agentic (15 credits/page), or agentic_plus (50 credits/page)
        /// </summary>
        CostEffective,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtractConfigurationTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractConfigurationTier value)
        {
            return value switch
            {
                ExtractConfigurationTier.Agentic => "agentic",
                ExtractConfigurationTier.AgenticPlus => "agentic_plus",
                ExtractConfigurationTier.CostEffective => "cost_effective",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractConfigurationTier? ToEnum(string value)
        {
            return value switch
            {
                "agentic" => ExtractConfigurationTier.Agentic,
                "agentic_plus" => ExtractConfigurationTier.AgenticPlus,
                "cost_effective" => ExtractConfigurationTier.CostEffective,
                _ => null,
            };
        }
    }
}