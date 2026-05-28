
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListBatchesApiV2BatchesGetStatus2
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
        Running,
        /// <summary>
        /// 
        /// </summary>
        Throttled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListBatchesApiV2BatchesGetStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListBatchesApiV2BatchesGetStatus2 value)
        {
            return value switch
            {
                ListBatchesApiV2BatchesGetStatus2.Cancelled => "CANCELLED",
                ListBatchesApiV2BatchesGetStatus2.Completed => "COMPLETED",
                ListBatchesApiV2BatchesGetStatus2.Failed => "FAILED",
                ListBatchesApiV2BatchesGetStatus2.Pending => "PENDING",
                ListBatchesApiV2BatchesGetStatus2.Running => "RUNNING",
                ListBatchesApiV2BatchesGetStatus2.Throttled => "THROTTLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListBatchesApiV2BatchesGetStatus2? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLED" => ListBatchesApiV2BatchesGetStatus2.Cancelled,
                "COMPLETED" => ListBatchesApiV2BatchesGetStatus2.Completed,
                "FAILED" => ListBatchesApiV2BatchesGetStatus2.Failed,
                "PENDING" => ListBatchesApiV2BatchesGetStatus2.Pending,
                "RUNNING" => ListBatchesApiV2BatchesGetStatus2.Running,
                "THROTTLED" => ListBatchesApiV2BatchesGetStatus2.Throttled,
                _ => null,
            };
        }
    }
}