
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListVerifyJobsApiAlphaVerifyGetStatus2
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
    public static class ListVerifyJobsApiAlphaVerifyGetStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListVerifyJobsApiAlphaVerifyGetStatus2 value)
        {
            return value switch
            {
                ListVerifyJobsApiAlphaVerifyGetStatus2.Cancelled => "CANCELLED",
                ListVerifyJobsApiAlphaVerifyGetStatus2.Completed => "COMPLETED",
                ListVerifyJobsApiAlphaVerifyGetStatus2.Failed => "FAILED",
                ListVerifyJobsApiAlphaVerifyGetStatus2.Pending => "PENDING",
                ListVerifyJobsApiAlphaVerifyGetStatus2.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListVerifyJobsApiAlphaVerifyGetStatus2? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLED" => ListVerifyJobsApiAlphaVerifyGetStatus2.Cancelled,
                "COMPLETED" => ListVerifyJobsApiAlphaVerifyGetStatus2.Completed,
                "FAILED" => ListVerifyJobsApiAlphaVerifyGetStatus2.Failed,
                "PENDING" => ListVerifyJobsApiAlphaVerifyGetStatus2.Pending,
                "RUNNING" => ListVerifyJobsApiAlphaVerifyGetStatus2.Running,
                _ => null,
            };
        }
    }
}