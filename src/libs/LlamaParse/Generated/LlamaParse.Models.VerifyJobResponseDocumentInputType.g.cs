
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Type of the document input (FILE)
    /// </summary>
    public enum VerifyJobResponseDocumentInputType
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
    public static class VerifyJobResponseDocumentInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VerifyJobResponseDocumentInputType value)
        {
            return value switch
            {
                VerifyJobResponseDocumentInputType.FileId => "file_id",
                VerifyJobResponseDocumentInputType.ParseJobId => "parse_job_id",
                VerifyJobResponseDocumentInputType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VerifyJobResponseDocumentInputType? ToEnum(string value)
        {
            return value switch
            {
                "file_id" => VerifyJobResponseDocumentInputType.FileId,
                "parse_job_id" => VerifyJobResponseDocumentInputType.ParseJobId,
                "url" => VerifyJobResponseDocumentInputType.Url,
                _ => null,
            };
        }
    }
}