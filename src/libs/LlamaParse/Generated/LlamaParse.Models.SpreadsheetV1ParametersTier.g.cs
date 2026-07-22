
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Spreadsheet extraction tier. `cost_effective` uses the rule-based/ML-only pipeline; `agentic` uses the full pipeline.<br/>
    /// Default Value: agentic
    /// </summary>
    public enum SpreadsheetV1ParametersTier
    {
        /// <summary>
        /// 
        /// </summary>
        Agentic,
        /// <summary>
        /// 
        /// </summary>
        CostEffective,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpreadsheetV1ParametersTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpreadsheetV1ParametersTier value)
        {
            return value switch
            {
                SpreadsheetV1ParametersTier.Agentic => "agentic",
                SpreadsheetV1ParametersTier.CostEffective => "cost_effective",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpreadsheetV1ParametersTier? ToEnum(string value)
        {
            return value switch
            {
                "agentic" => SpreadsheetV1ParametersTier.Agentic,
                "cost_effective" => SpreadsheetV1ParametersTier.CostEffective,
                _ => null,
            };
        }
    }
}