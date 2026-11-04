
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// pending until approved or rejected.
    /// </summary>
    public enum ExtractReviewResponseStatus
    {
        /// <summary>
        ///
        /// </summary>
        Approved,
        /// <summary>
        ///
        /// </summary>
        Pending,
        /// <summary>
        ///
        /// </summary>
        Rejected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtractReviewResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractReviewResponseStatus value)
        {
            return value switch
            {
                ExtractReviewResponseStatus.Approved => "approved",
                ExtractReviewResponseStatus.Pending => "pending",
                ExtractReviewResponseStatus.Rejected => "rejected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractReviewResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "approved" => ExtractReviewResponseStatus.Approved,
                "pending" => ExtractReviewResponseStatus.Pending,
                "rejected" => ExtractReviewResponseStatus.Rejected,
                _ => null,
            };
        }
    }
}