
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// A top-level batch.<br/>
    /// Example:<br/>
    ///     {<br/>
    ///         "id": "bat-aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeeee",<br/>
    ///         "project_id": "prj-aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeeee",<br/>
    ///         "source_directory_id": "dir-aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeeee",<br/>
    ///         "config": {<br/>
    ///             "job": {<br/>
    ///                 "type": "parse_v2",<br/>
    ///                 "configuration_id": "cfg-PARSE_AGENTIC"<br/>
    ///             }<br/>
    ///         },<br/>
    ///         "status": "COMPLETED",<br/>
    ///         "results": [<br/>
    ///             {<br/>
    ///                 "source_directory_file_id": "dfl-aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeeee",<br/>
    ///                 "job_reference": {<br/>
    ///                     "type": "parse_v2",<br/>
    ///                     "id": "pjb-aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeeee"<br/>
    ///                 },<br/>
    ///                 "error_message": null<br/>
    ///             }<br/>
    ///         ]<br/>
    ///     }<br/>
    /// Batch-level ``FAILED`` means the orchestration failed and cannot provide a<br/>
    /// reliable per-file result set. ``results`` is only populated when explicitly<br/>
    /// requested with ``expand=results`` and may be ``null`` while a batch is still<br/>
    /// running.
    /// </summary>
    public sealed partial class BatchResponse
    {
        /// <summary>
        /// Unique identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.AnyOf<string, global::System.Guid?> Id { get; set; }

        /// <summary>
        /// Creation datetime
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Update datetime
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Project this batch belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Directory being processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_directory_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceDirectoryId { get; set; }

        /// <summary>
        /// Batch configuration snapshot.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.BatchConfiguration Config { get; set; }

        /// <summary>
        /// Current batch status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LlamaParse.JsonConverters.BatchResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.BatchResponseStatus Status { get; set; }

        /// <summary>
        /// Expanded per-file result mappings. Null unless requested with expand=results, or while the batch is still running.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<global::LlamaParse.BatchResult>? Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier
        /// </param>
        /// <param name="projectId">
        /// Project this batch belongs to.
        /// </param>
        /// <param name="sourceDirectoryId">
        /// Directory being processed.
        /// </param>
        /// <param name="config">
        /// Batch configuration snapshot.
        /// </param>
        /// <param name="status">
        /// Current batch status.
        /// </param>
        /// <param name="createdAt">
        /// Creation datetime
        /// </param>
        /// <param name="updatedAt">
        /// Update datetime
        /// </param>
        /// <param name="results">
        /// Expanded per-file result mappings. Null unless requested with expand=results, or while the batch is still running.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchResponse(
            global::LlamaParse.AnyOf<string, global::System.Guid?> id,
            string projectId,
            string sourceDirectoryId,
            global::LlamaParse.BatchConfiguration config,
            global::LlamaParse.BatchResponseStatus status,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::System.Collections.Generic.IList<global::LlamaParse.BatchResult>? results)
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.SourceDirectoryId = sourceDirectoryId ?? throw new global::System.ArgumentNullException(nameof(sourceDirectoryId));
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Status = status;
            this.Results = results;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchResponse" /> class.
        /// </summary>
        public BatchResponse()
        {
        }

    }
}