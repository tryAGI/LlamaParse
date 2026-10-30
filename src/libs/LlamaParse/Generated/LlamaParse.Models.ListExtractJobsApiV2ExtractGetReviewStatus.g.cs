
#nullable enable

namespace LlamaParse
{
    /// <summary>
    ///
    /// </summary>
    public enum ListExtractJobsApiV2ExtractGetReviewStatus
    {
        /// <summary>
        ///
        /// </summary>
        Approved,
        /// <summary>
        ///
        /// </summary>
        None,
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
    public static class ListExtractJobsApiV2ExtractGetReviewStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListExtractJobsApiV2ExtractGetReviewStatus value)
        {
            return value switch
            {
                ListExtractJobsApiV2ExtractGetReviewStatus.Approved => "approved",
                ListExtractJobsApiV2ExtractGetReviewStatus.None => "none",
                ListExtractJobsApiV2ExtractGetReviewStatus.Pending => "pending",
                ListExtractJobsApiV2ExtractGetReviewStatus.Rejected => "rejected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListExtractJobsApiV2ExtractGetReviewStatus? ToEnum(string value)
        {
            return value switch
            {
                "approved" => ListExtractJobsApiV2ExtractGetReviewStatus.Approved,
                "none" => ListExtractJobsApiV2ExtractGetReviewStatus.None,
                "pending" => ListExtractJobsApiV2ExtractGetReviewStatus.Pending,
                "rejected" => ListExtractJobsApiV2ExtractGetReviewStatus.Rejected,
                _ => null,
            };
        }
    }
}