
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Extract tier: cost_effective (5 credits/page), agentic (15 credits/page), agentic_plus (50 credits/page), or turbo (35 credits/page, experimental)<br/>
    /// Default Value: cost_effective
    /// </summary>
    public enum ExtractV2ParametersTier
    {
        /// <summary>
        /// cost_effective (5 credits/page), agentic (15 credits/page), agentic_plus (50 credits/page), or turbo (35 credits/page, experimental)
        /// </summary>
        Agentic,
        /// <summary>
        /// cost_effective (5 credits/page), agentic (15 credits/page), agentic_plus (50 credits/page), or turbo (35 credits/page, experimental)
        /// </summary>
        AgenticPlus,
        /// <summary>
        /// cost_effective (5 credits/page), agentic (15 credits/page), agentic_plus (50 credits/page), or turbo (35 credits/page, experimental)
        /// </summary>
        CostEffective,
        /// <summary>
        /// cost_effective (5 credits/page), agentic (15 credits/page), agentic_plus (50 credits/page), or turbo (35 credits/page, experimental)
        /// </summary>
        Turbo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtractV2ParametersTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractV2ParametersTier value)
        {
            return value switch
            {
                ExtractV2ParametersTier.Agentic => "agentic",
                ExtractV2ParametersTier.AgenticPlus => "agentic_plus",
                ExtractV2ParametersTier.CostEffective => "cost_effective",
                ExtractV2ParametersTier.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractV2ParametersTier? ToEnum(string value)
        {
            return value switch
            {
                "agentic" => ExtractV2ParametersTier.Agentic,
                "agentic_plus" => ExtractV2ParametersTier.AgenticPlus,
                "cost_effective" => ExtractV2ParametersTier.CostEffective,
                "turbo" => ExtractV2ParametersTier.Turbo,
                _ => null,
            };
        }
    }
}