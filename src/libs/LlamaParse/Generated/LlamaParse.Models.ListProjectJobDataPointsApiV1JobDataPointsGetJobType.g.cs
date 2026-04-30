
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Job type to query.
    /// </summary>
    public enum ListProjectJobDataPointsApiV1JobDataPointsGetJobType
    {
        /// <summary>
        /// 
        /// </summary>
        Classify,
        /// <summary>
        /// 
        /// </summary>
        Extract,
        /// <summary>
        /// 
        /// </summary>
        Parse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListProjectJobDataPointsApiV1JobDataPointsGetJobTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectJobDataPointsApiV1JobDataPointsGetJobType value)
        {
            return value switch
            {
                ListProjectJobDataPointsApiV1JobDataPointsGetJobType.Classify => "classify",
                ListProjectJobDataPointsApiV1JobDataPointsGetJobType.Extract => "extract",
                ListProjectJobDataPointsApiV1JobDataPointsGetJobType.Parse => "parse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectJobDataPointsApiV1JobDataPointsGetJobType? ToEnum(string value)
        {
            return value switch
            {
                "classify" => ListProjectJobDataPointsApiV1JobDataPointsGetJobType.Classify,
                "extract" => ListProjectJobDataPointsApiV1JobDataPointsGetJobType.Extract,
                "parse" => ListProjectJobDataPointsApiV1JobDataPointsGetJobType.Parse,
                _ => null,
            };
        }
    }
}