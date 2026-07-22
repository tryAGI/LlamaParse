
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Spreadsheet extraction tier. `cost_effective` uses the rule-based/ML-only pipeline; `agentic` uses the full pipeline.<br/>
    /// Default Value: agentic
    /// </summary>
    public enum SpreadsheetParsingConfigTier
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
    public static class SpreadsheetParsingConfigTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpreadsheetParsingConfigTier value)
        {
            return value switch
            {
                SpreadsheetParsingConfigTier.Agentic => "agentic",
                SpreadsheetParsingConfigTier.CostEffective => "cost_effective",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpreadsheetParsingConfigTier? ToEnum(string value)
        {
            return value switch
            {
                "agentic" => SpreadsheetParsingConfigTier.Agentic,
                "cost_effective" => SpreadsheetParsingConfigTier.CostEffective,
                _ => null,
            };
        }
    }
}