
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Whether the input was a file or parse job
    /// </summary>
    public enum SplitJobResponseDocumentInputType
    {
        /// <summary>
        /// 
        /// </summary>
        FileId,
        /// <summary>
        /// 
        /// </summary>
        ParseJobId,
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SplitJobResponseDocumentInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SplitJobResponseDocumentInputType value)
        {
            return value switch
            {
                SplitJobResponseDocumentInputType.FileId => "file_id",
                SplitJobResponseDocumentInputType.ParseJobId => "parse_job_id",
                SplitJobResponseDocumentInputType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SplitJobResponseDocumentInputType? ToEnum(string value)
        {
            return value switch
            {
                "file_id" => SplitJobResponseDocumentInputType.FileId,
                "parse_job_id" => SplitJobResponseDocumentInputType.ParseJobId,
                "url" => SplitJobResponseDocumentInputType.Url,
                _ => null,
            };
        }
    }
}