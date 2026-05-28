
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Current batch status.
    /// </summary>
    public enum BatchResponseStatus
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
    public static class BatchResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchResponseStatus value)
        {
            return value switch
            {
                BatchResponseStatus.Cancelled => "CANCELLED",
                BatchResponseStatus.Completed => "COMPLETED",
                BatchResponseStatus.Failed => "FAILED",
                BatchResponseStatus.Pending => "PENDING",
                BatchResponseStatus.Running => "RUNNING",
                BatchResponseStatus.Throttled => "THROTTLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLED" => BatchResponseStatus.Cancelled,
                "COMPLETED" => BatchResponseStatus.Completed,
                "FAILED" => BatchResponseStatus.Failed,
                "PENDING" => BatchResponseStatus.Pending,
                "RUNNING" => BatchResponseStatus.Running,
                "THROTTLED" => BatchResponseStatus.Throttled,
                _ => null,
            };
        }
    }
}