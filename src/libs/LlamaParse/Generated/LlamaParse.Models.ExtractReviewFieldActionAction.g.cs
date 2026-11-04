
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// confirm, correct or clear.
    /// </summary>
    public enum ExtractReviewFieldActionAction
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtractReviewFieldActionActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractReviewFieldActionAction value)
        {
            return value switch
            {
                ExtractReviewFieldActionAction.Clear => "clear",
                ExtractReviewFieldActionAction.Confirm => "confirm",
                ExtractReviewFieldActionAction.Correct => "correct",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractReviewFieldActionAction? ToEnum(string value)
        {
            return value switch
            {
                "clear" => ExtractReviewFieldActionAction.Clear,
                "confirm" => ExtractReviewFieldActionAction.Confirm,
                "correct" => ExtractReviewFieldActionAction.Correct,
                _ => null,
            };
        }
    }
}