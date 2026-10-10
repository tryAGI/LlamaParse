
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Current job status: PENDING, RUNNING, COMPLETED, FAILED, or CANCELLED
    /// </summary>
    public enum VerifyJobResponseStatus
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
    public static class VerifyJobResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VerifyJobResponseStatus value)
        {
            return value switch
            {
                VerifyJobResponseStatus.Cancelled => "CANCELLED",
                VerifyJobResponseStatus.Completed => "COMPLETED",
                VerifyJobResponseStatus.Failed => "FAILED",
                VerifyJobResponseStatus.Pending => "PENDING",
                VerifyJobResponseStatus.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VerifyJobResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLED" => VerifyJobResponseStatus.Cancelled,
                "COMPLETED" => VerifyJobResponseStatus.Completed,
                "FAILED" => VerifyJobResponseStatus.Failed,
                "PENDING" => VerifyJobResponseStatus.Pending,
                "RUNNING" => VerifyJobResponseStatus.Running,
                _ => null,
            };
        }
    }
}