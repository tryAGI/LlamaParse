
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Deprecated: controlled by `tier`. Influences how likely similar-looking regions are merged into a single table. Honored only on `agentic`.<br/>
    /// Default Value: strong
    /// </summary>
    public enum SpreadsheetParsingConfigTableMergeSensitivity
    {
        /// <summary>
        /// 
        /// </summary>
        Strong,
        /// <summary>
        /// 
        /// </summary>
        Weak,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpreadsheetParsingConfigTableMergeSensitivityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpreadsheetParsingConfigTableMergeSensitivity value)
        {
            return value switch
            {
                SpreadsheetParsingConfigTableMergeSensitivity.Strong => "strong",
                SpreadsheetParsingConfigTableMergeSensitivity.Weak => "weak",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpreadsheetParsingConfigTableMergeSensitivity? ToEnum(string value)
        {
            return value switch
            {
                "strong" => SpreadsheetParsingConfigTableMergeSensitivity.Strong,
                "weak" => SpreadsheetParsingConfigTableMergeSensitivity.Weak,
                _ => null,
            };
        }
    }
}