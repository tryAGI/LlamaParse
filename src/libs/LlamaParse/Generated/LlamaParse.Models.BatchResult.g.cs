
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Result projection for one source directory file in a batch.<br/>
    /// Example:<br/>
    ///     {<br/>
    ///         "source_directory_file_id": "dfl-aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeeee",<br/>
    ///         "job_reference": {<br/>
    ///             "type": "parse_v2",<br/>
    ///             "id": "pjb-aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeeee"<br/>
    ///         },<br/>
    ///         "error_message": null<br/>
    ///     }<br/>
    /// This is a projection of directory-sync state, not a separate child<br/>
    /// resource that callers need to create. The source directory file ID is the<br/>
    /// stable correlation key. Underlying job progress and failures should be<br/>
    /// resolved through the referenced product job endpoint.
    /// </summary>
    public sealed partial class BatchResult
    {
        /// <summary>
        /// Source directory file processed by this batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_directory_file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceDirectoryFileId { get; set; }

        /// <summary>
        /// Job created for this file, once known.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_reference")]
        public global::LlamaParse.BatchJobReference? JobReference { get; set; }

        /// <summary>
        /// Batch-level mapping error if the system could not create or associate a job for this source file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchResult" /> class.
        /// </summary>
        /// <param name="sourceDirectoryFileId">
        /// Source directory file processed by this batch.
        /// </param>
        /// <param name="jobReference">
        /// Job created for this file, once known.
        /// </param>
        /// <param name="errorMessage">
        /// Batch-level mapping error if the system could not create or associate a job for this source file.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchResult(
            string sourceDirectoryFileId,
            global::LlamaParse.BatchJobReference? jobReference,
            string? errorMessage)
        {
            this.SourceDirectoryFileId = sourceDirectoryFileId ?? throw new global::System.ArgumentNullException(nameof(sourceDirectoryFileId));
            this.JobReference = jobReference;
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchResult" /> class.
        /// </summary>
        public BatchResult()
        {
        }

    }
}