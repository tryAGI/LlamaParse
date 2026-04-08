
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Influences how likely similar-looking regions are merged into a single table. Useful for spreadsheets that either have sparse tables (strong merging) or many distinct tables close together (weak merging).<br/>
    /// Default Value: strong
    /// </summary>
    public enum SpreadsheetV1ParametersTableMergeSensitivity
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
    public static class SpreadsheetV1ParametersTableMergeSensitivityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpreadsheetV1ParametersTableMergeSensitivity value)
        {
            return value switch
            {
                SpreadsheetV1ParametersTableMergeSensitivity.Strong => "strong",
                SpreadsheetV1ParametersTableMergeSensitivity.Weak => "weak",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpreadsheetV1ParametersTableMergeSensitivity? ToEnum(string value)
        {
            return value switch
            {
                "strong" => SpreadsheetV1ParametersTableMergeSensitivity.Strong,
                "weak" => SpreadsheetV1ParametersTableMergeSensitivity.Weak,
                _ => null,
            };
        }
    }
}