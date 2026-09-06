
#nullable enable

namespace LlamaParse
{
    /// <summary>
    ///
    /// </summary>
    public enum ListBatchesApiV2BatchesGetStatus
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
    public static class ListBatchesApiV2BatchesGetStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListBatchesApiV2BatchesGetStatus value)
        {
            return value switch
            {
                ListBatchesApiV2BatchesGetStatus.Cancelled => "CANCELLED",
                ListBatchesApiV2BatchesGetStatus.Completed => "COMPLETED",
                ListBatchesApiV2BatchesGetStatus.Failed => "FAILED",
                ListBatchesApiV2BatchesGetStatus.Pending => "PENDING",
                ListBatchesApiV2BatchesGetStatus.Running => "RUNNING",
                ListBatchesApiV2BatchesGetStatus.Throttled => "THROTTLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListBatchesApiV2BatchesGetStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLED" => ListBatchesApiV2BatchesGetStatus.Cancelled,
                "COMPLETED" => ListBatchesApiV2BatchesGetStatus.Completed,
                "FAILED" => ListBatchesApiV2BatchesGetStatus.Failed,
                "PENDING" => ListBatchesApiV2BatchesGetStatus.Pending,
                "RUNNING" => ListBatchesApiV2BatchesGetStatus.Running,
                "THROTTLED" => ListBatchesApiV2BatchesGetStatus.Throttled,
                _ => null,
            };
        }
    }
}