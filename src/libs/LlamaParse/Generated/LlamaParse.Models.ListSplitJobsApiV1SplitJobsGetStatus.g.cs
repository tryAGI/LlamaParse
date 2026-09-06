
#nullable enable

namespace LlamaParse
{
    /// <summary>
    ///
    /// </summary>
    public enum ListSplitJobsApiV1SplitJobsGetStatus
    {
        /// <summary>
        ///
        /// </summary>
        Cancelled,
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Pending,
        /// <summary>
        ///
        /// </summary>
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListSplitJobsApiV1SplitJobsGetStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListSplitJobsApiV1SplitJobsGetStatus value)
        {
            return value switch
            {
                ListSplitJobsApiV1SplitJobsGetStatus.Cancelled => "cancelled",
                ListSplitJobsApiV1SplitJobsGetStatus.Completed => "completed",
                ListSplitJobsApiV1SplitJobsGetStatus.Failed => "failed",
                ListSplitJobsApiV1SplitJobsGetStatus.Pending => "pending",
                ListSplitJobsApiV1SplitJobsGetStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListSplitJobsApiV1SplitJobsGetStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => ListSplitJobsApiV1SplitJobsGetStatus.Cancelled,
                "completed" => ListSplitJobsApiV1SplitJobsGetStatus.Completed,
                "failed" => ListSplitJobsApiV1SplitJobsGetStatus.Failed,
                "pending" => ListSplitJobsApiV1SplitJobsGetStatus.Pending,
                "processing" => ListSplitJobsApiV1SplitJobsGetStatus.Processing,
                _ => null,
            };
        }
    }
}