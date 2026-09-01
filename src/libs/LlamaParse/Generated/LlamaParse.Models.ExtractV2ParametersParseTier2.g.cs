
#nullable enable

namespace LlamaParse
{
    /// <summary>
    ///
    /// </summary>
    public enum ExtractV2ParametersParseTier2
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
    public static class ExtractV2ParametersParseTier2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractV2ParametersParseTier2 value)
        {
            return value switch
            {
                ExtractV2ParametersParseTier2.Agentic => "agentic",
                ExtractV2ParametersParseTier2.AgenticPlus => "agentic_plus",
                ExtractV2ParametersParseTier2.CostEffective => "cost_effective",
                ExtractV2ParametersParseTier2.Fast => "fast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractV2ParametersParseTier2? ToEnum(string value)
        {
            return value switch
            {
                "agentic" => ExtractV2ParametersParseTier2.Agentic,
                "agentic_plus" => ExtractV2ParametersParseTier2.AgenticPlus,
                "cost_effective" => ExtractV2ParametersParseTier2.CostEffective,
                "fast" => ExtractV2ParametersParseTier2.Fast,
                _ => null,
            };
        }
    }
}