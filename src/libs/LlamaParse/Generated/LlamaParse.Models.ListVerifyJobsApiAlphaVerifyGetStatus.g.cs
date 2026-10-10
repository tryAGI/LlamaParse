
#nullable enable

namespace LlamaParse
{
    /// <summary>
    ///
    /// </summary>
    public enum ListVerifyJobsApiAlphaVerifyGetStatus
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListVerifyJobsApiAlphaVerifyGetStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListVerifyJobsApiAlphaVerifyGetStatus value)
        {
            return value switch
            {
                ListVerifyJobsApiAlphaVerifyGetStatus.Cancelled => "CANCELLED",
                ListVerifyJobsApiAlphaVerifyGetStatus.Completed => "COMPLETED",
                ListVerifyJobsApiAlphaVerifyGetStatus.Failed => "FAILED",
                ListVerifyJobsApiAlphaVerifyGetStatus.Pending => "PENDING",
                ListVerifyJobsApiAlphaVerifyGetStatus.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListVerifyJobsApiAlphaVerifyGetStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLED" => ListVerifyJobsApiAlphaVerifyGetStatus.Cancelled,
                "COMPLETED" => ListVerifyJobsApiAlphaVerifyGetStatus.Completed,
                "FAILED" => ListVerifyJobsApiAlphaVerifyGetStatus.Failed,
                "PENDING" => ListVerifyJobsApiAlphaVerifyGetStatus.Pending,
                "RUNNING" => ListVerifyJobsApiAlphaVerifyGetStatus.Running,
                _ => null,
            };
        }
    }
}