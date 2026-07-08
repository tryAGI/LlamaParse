
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public enum ParseRequestConfigurationTier
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
    public static class ParseRequestConfigurationTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ParseRequestConfigurationTier value)
        {
            return value switch
            {
                ParseRequestConfigurationTier.Agentic => "agentic",
                ParseRequestConfigurationTier.AgenticPlus => "agentic_plus",
                ParseRequestConfigurationTier.CostEffective => "cost_effective",
                ParseRequestConfigurationTier.Fast => "fast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ParseRequestConfigurationTier? ToEnum(string value)
        {
            return value switch
            {
                "agentic" => ParseRequestConfigurationTier.Agentic,
                "agentic_plus" => ParseRequestConfigurationTier.AgenticPlus,
                "cost_effective" => ParseRequestConfigurationTier.CostEffective,
                "fast" => ParseRequestConfigurationTier.Fast,
                _ => null,
            };
        }
    }
}