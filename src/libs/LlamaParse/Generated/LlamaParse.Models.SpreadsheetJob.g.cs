
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// A spreadsheet parsing job.
    /// </summary>
    public sealed partial class SpreadsheetJob
    {
        /// <summary>
        /// The ID of the job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The ID of the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// The ID of the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// Configuration applied to the parsing job (inline or resolved from a saved preset).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.SpreadsheetParsingConfig Configuration { get; set; }

        /// <summary>
        /// Deprecated: use `configuration` instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::LlamaParse.SpreadsheetParsingConfig? Config { get; set; }

        /// <summary>
        /// The status of the parsing job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LlamaParse.JsonConverters.SpreadsheetJobStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.SpreadsheetJobStatus Status { get; set; }

        /// <summary>
        /// Job-time parameters such as webhook configurations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::LlamaParse.SpreadsheetJobParameters? Parameters { get; set; }

        /// <summary>
        /// The saved product configuration ID used at create time, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration_id")]
        public string? ConfigurationId { get; set; }

        /// <summary>
        /// Per-status entry timestamps. Returned only when requested via `?expand=metadata_state_transitions`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_state_transitions")]
        public object? MetadataStateTransitions { get; set; }

        /// <summary>
        /// When the job was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// When the job was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// Whether the job completed successfully
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// All extracted regions (populated when job is complete)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regions")]
        public global::System.Collections.Generic.IList<global::LlamaParse.ExtractedRegionSummary>? Regions { get; set; }

        /// <summary>
        /// Metadata for each processed worksheet (populated when job is complete)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("worksheet_metadata")]
        public global::System.Collections.Generic.IList<global::LlamaParse.WorksheetMetadata>? WorksheetMetadata { get; set; }

        /// <summary>
        /// Any errors encountered
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<string>? Errors { get; set; }

        /// <summary>
        /// The ID of the input file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public global::System.Guid? FileId { get; set; }

        /// <summary>
        /// [DEPRECATED] The file that was parsed. Use file_id instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::LlamaParse.File? File { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpreadsheetJob" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the job
        /// </param>
        /// <param name="userId">
        /// The ID of the user
        /// </param>
        /// <param name="projectId">
        /// The ID of the project
        /// </param>
        /// <param name="configuration">
        /// Configuration applied to the parsing job (inline or resolved from a saved preset).
        /// </param>
        /// <param name="status">
        /// The status of the parsing job
        /// </param>
        /// <param name="createdAt">
        /// When the job was created
        /// </param>
        /// <param name="updatedAt">
        /// When the job was last updated
        /// </param>
        /// <param name="parameters">
        /// Job-time parameters such as webhook configurations.
        /// </param>
        /// <param name="configurationId">
        /// The saved product configuration ID used at create time, if any.
        /// </param>
        /// <param name="metadataStateTransitions">
        /// Per-status entry timestamps. Returned only when requested via `?expand=metadata_state_transitions`.
        /// </param>
        /// <param name="success">
        /// Whether the job completed successfully
        /// </param>
        /// <param name="regions">
        /// All extracted regions (populated when job is complete)
        /// </param>
        /// <param name="worksheetMetadata">
        /// Metadata for each processed worksheet (populated when job is complete)
        /// </param>
        /// <param name="errors">
        /// Any errors encountered
        /// </param>
        /// <param name="fileId">
        /// The ID of the input file
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpreadsheetJob(
            string id,
            string userId,
            global::System.Guid projectId,
            global::LlamaParse.SpreadsheetParsingConfig configuration,
            global::LlamaParse.SpreadsheetJobStatus status,
            string createdAt,
            string updatedAt,
            global::LlamaParse.SpreadsheetJobParameters? parameters,
            string? configurationId,
            object? metadataStateTransitions,
            bool? success,
            global::System.Collections.Generic.IList<global::LlamaParse.ExtractedRegionSummary>? regions,
            global::System.Collections.Generic.IList<global::LlamaParse.WorksheetMetadata>? worksheetMetadata,
            global::System.Collections.Generic.IList<string>? errors,
            global::System.Guid? fileId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.ProjectId = projectId;
            this.Configuration = configuration ?? throw new global::System.ArgumentNullException(nameof(configuration));
            this.Status = status;
            this.Parameters = parameters;
            this.ConfigurationId = configurationId;
            this.MetadataStateTransitions = metadataStateTransitions;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.Success = success;
            this.Regions = regions;
            this.WorksheetMetadata = worksheetMetadata;
            this.Errors = errors;
            this.FileId = fileId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpreadsheetJob" /> class.
        /// </summary>
        public SpreadsheetJob()
        {
        }

    }
}