
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// confirm, correct to `value`, clear, restore the model's value, or undo.
    /// </summary>
    public enum ExtractReviewFieldChangeChange
    {
        /// <summary>
        ///
        /// </summary>
        Clear,
        /// <summary>
        ///
        /// </summary>
        Confirm,
        /// <summary>
        ///
        /// </summary>
        Correct,
        /// <summary>
        ///
        /// </summary>
        Restore,
        /// <summary>
        ///
        /// </summary>
        Undo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtractReviewFieldChangeChangeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractReviewFieldChangeChange value)
        {
            return value switch
            {
                ExtractReviewFieldChangeChange.Clear => "clear",
                ExtractReviewFieldChangeChange.Confirm => "confirm",
                ExtractReviewFieldChangeChange.Correct => "correct",
                ExtractReviewFieldChangeChange.Restore => "restore",
                ExtractReviewFieldChangeChange.Undo => "undo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractReviewFieldChangeChange? ToEnum(string value)
        {
            return value switch
            {
                "clear" => ExtractReviewFieldChangeChange.Clear,
                "confirm" => ExtractReviewFieldChangeChange.Confirm,
                "correct" => ExtractReviewFieldChangeChange.Correct,
                "restore" => ExtractReviewFieldChangeChange.Restore,
                "undo" => ExtractReviewFieldChangeChange.Undo,
                _ => null,
            };
        }
    }
}