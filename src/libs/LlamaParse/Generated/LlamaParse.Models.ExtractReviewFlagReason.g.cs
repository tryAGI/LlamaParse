
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// below_threshold, or required_empty for a required field left empty.
    /// </summary>
    public enum ExtractReviewFlagReason
    {
        /// <summary>
        ///
        /// </summary>
        BelowThreshold,
        /// <summary>
        ///
        /// </summary>
        RequiredEmpty,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtractReviewFlagReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractReviewFlagReason value)
        {
            return value switch
            {
                ExtractReviewFlagReason.BelowThreshold => "below_threshold",
                ExtractReviewFlagReason.RequiredEmpty => "required_empty",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractReviewFlagReason? ToEnum(string value)
        {
            return value switch
            {
                "below_threshold" => ExtractReviewFlagReason.BelowThreshold,
                "required_empty" => ExtractReviewFlagReason.RequiredEmpty,
                _ => null,
            };
        }
    }
}