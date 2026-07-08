
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListSplitJobsApiV1SplitJobsGetStatus2
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
    public static class ListSplitJobsApiV1SplitJobsGetStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListSplitJobsApiV1SplitJobsGetStatus2 value)
        {
            return value switch
            {
                ListSplitJobsApiV1SplitJobsGetStatus2.Cancelled => "cancelled",
                ListSplitJobsApiV1SplitJobsGetStatus2.Completed => "completed",
                ListSplitJobsApiV1SplitJobsGetStatus2.Failed => "failed",
                ListSplitJobsApiV1SplitJobsGetStatus2.Pending => "pending",
                ListSplitJobsApiV1SplitJobsGetStatus2.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListSplitJobsApiV1SplitJobsGetStatus2? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => ListSplitJobsApiV1SplitJobsGetStatus2.Cancelled,
                "completed" => ListSplitJobsApiV1SplitJobsGetStatus2.Completed,
                "failed" => ListSplitJobsApiV1SplitJobsGetStatus2.Failed,
                "pending" => ListSplitJobsApiV1SplitJobsGetStatus2.Pending,
                "processing" => ListSplitJobsApiV1SplitJobsGetStatus2.Processing,
                _ => null,
            };
        }
    }
}