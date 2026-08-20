
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Current job status: PENDING, RUNNING, COMPLETED, FAILED, or CANCELLED
    /// </summary>
    public enum ClassifyV2JobResponseStatus
    {
        /// <summary>
        /// PENDING, RUNNING, COMPLETED, FAILED, or CANCELLED
        /// </summary>
        Cancelled,
        /// <summary>
        /// PENDING, RUNNING, COMPLETED, FAILED, or CANCELLED
        /// </summary>
        Completed,
        /// <summary>
        /// PENDING, RUNNING, COMPLETED, FAILED, or CANCELLED
        /// </summary>
        Failed,
        /// <summary>
        /// PENDING, RUNNING, COMPLETED, FAILED, or CANCELLED
        /// </summary>
        Pending,
        /// <summary>
        /// PENDING, RUNNING, COMPLETED, FAILED, or CANCELLED
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClassifyV2JobResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClassifyV2JobResponseStatus value)
        {
            return value switch
            {
                ClassifyV2JobResponseStatus.Cancelled => "CANCELLED",
                ClassifyV2JobResponseStatus.Completed => "COMPLETED",
                ClassifyV2JobResponseStatus.Failed => "FAILED",
                ClassifyV2JobResponseStatus.Pending => "PENDING",
                ClassifyV2JobResponseStatus.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClassifyV2JobResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLED" => ClassifyV2JobResponseStatus.Cancelled,
                "COMPLETED" => ClassifyV2JobResponseStatus.Completed,
                "FAILED" => ClassifyV2JobResponseStatus.Failed,
                "PENDING" => ClassifyV2JobResponseStatus.Pending,
                "RUNNING" => ClassifyV2JobResponseStatus.Running,
                _ => null,
            };
        }
    }
}