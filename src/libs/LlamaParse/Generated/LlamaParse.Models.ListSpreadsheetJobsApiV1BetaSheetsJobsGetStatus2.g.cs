
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListSpreadsheetJobsApiV1BetaSheetsJobsGetStatus2
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
    public static class ListSpreadsheetJobsApiV1BetaSheetsJobsGetStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListSpreadsheetJobsApiV1BetaSheetsJobsGetStatus2 value)
        {
            return value switch
            {
                ListSpreadsheetJobsApiV1BetaSheetsJobsGetStatus2.Cancelled => "CANCELLED",
                ListSpreadsheetJobsApiV1BetaSheetsJobsGetStatus2.Error => "ERROR",
                ListSpreadsheetJobsApiV1BetaSheetsJobsGetStatus2.PartialSuccess => "PARTIAL_SUCCESS",
                ListSpreadsheetJobsApiV1BetaSheetsJobsGetStatus2.Pending => "PENDING",
                ListSpreadsheetJobsApiV1BetaSheetsJobsGetStatus2.Success => "SUCCESS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListSpreadsheetJobsApiV1BetaSheetsJobsGetStatus2? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLED" => ListSpreadsheetJobsApiV1BetaSheetsJobsGetStatus2.Cancelled,
                "ERROR" => ListSpreadsheetJobsApiV1BetaSheetsJobsGetStatus2.Error,
                "PARTIAL_SUCCESS" => ListSpreadsheetJobsApiV1BetaSheetsJobsGetStatus2.PartialSuccess,
                "PENDING" => ListSpreadsheetJobsApiV1BetaSheetsJobsGetStatus2.Pending,
                "SUCCESS" => ListSpreadsheetJobsApiV1BetaSheetsJobsGetStatus2.Success,
                _ => null,
            };
        }
    }
}