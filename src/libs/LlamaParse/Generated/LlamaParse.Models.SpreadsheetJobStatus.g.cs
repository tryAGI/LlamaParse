
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// The status of the parsing job
    /// </summary>
    public enum SpreadsheetJobStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        PartialSuccess,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpreadsheetJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpreadsheetJobStatus value)
        {
            return value switch
            {
                SpreadsheetJobStatus.Cancelled => "CANCELLED",
                SpreadsheetJobStatus.Error => "ERROR",
                SpreadsheetJobStatus.PartialSuccess => "PARTIAL_SUCCESS",
                SpreadsheetJobStatus.Pending => "PENDING",
                SpreadsheetJobStatus.Success => "SUCCESS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpreadsheetJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLED" => SpreadsheetJobStatus.Cancelled,
                "ERROR" => SpreadsheetJobStatus.Error,
                "PARTIAL_SUCCESS" => SpreadsheetJobStatus.PartialSuccess,
                "PENDING" => SpreadsheetJobStatus.Pending,
                "SUCCESS" => SpreadsheetJobStatus.Success,
                _ => null,
            };
        }
    }
}