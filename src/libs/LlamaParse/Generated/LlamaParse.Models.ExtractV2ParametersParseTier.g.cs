
#nullable enable

namespace LlamaParse
{
    /// <summary>
    ///
    /// </summary>
    public enum ExtractV2ParametersParseTier
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
    public static class ExtractV2ParametersParseTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractV2ParametersParseTier value)
        {
            return value switch
            {
                ExtractV2ParametersParseTier.Agentic => "agentic",
                ExtractV2ParametersParseTier.AgenticPlus => "agentic_plus",
                ExtractV2ParametersParseTier.CostEffective => "cost_effective",
                ExtractV2ParametersParseTier.Fast => "fast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractV2ParametersParseTier? ToEnum(string value)
        {
            return value switch
            {
                "agentic" => ExtractV2ParametersParseTier.Agentic,
                "agentic_plus" => ExtractV2ParametersParseTier.AgenticPlus,
                "cost_effective" => ExtractV2ParametersParseTier.CostEffective,
                "fast" => ExtractV2ParametersParseTier.Fast,
                _ => null,
            };
        }
    }
}