
#nullable enable

namespace LlamaParse
{
    /// <summary>
    ///
    /// </summary>
    public enum SplitV1ParametersParseTier
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
    public static class SplitV1ParametersParseTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SplitV1ParametersParseTier value)
        {
            return value switch
            {
                SplitV1ParametersParseTier.Agentic => "agentic",
                SplitV1ParametersParseTier.AgenticPlus => "agentic_plus",
                SplitV1ParametersParseTier.CostEffective => "cost_effective",
                SplitV1ParametersParseTier.Fast => "fast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SplitV1ParametersParseTier? ToEnum(string value)
        {
            return value switch
            {
                "agentic" => SplitV1ParametersParseTier.Agentic,
                "agentic_plus" => SplitV1ParametersParseTier.AgenticPlus,
                "cost_effective" => SplitV1ParametersParseTier.CostEffective,
                "fast" => SplitV1ParametersParseTier.Fast,
                _ => null,
            };
        }
    }
}