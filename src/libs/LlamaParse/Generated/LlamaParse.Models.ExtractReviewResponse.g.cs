
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// An extract job's review: its settings, flags, field actions and decision,<br/>
    /// with the result as read and as reviewed.
    /// </summary>
    public sealed partial class ExtractReviewResponse
    {
        /// <summary>
        /// Unique identifier of the review.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The extract job reviewed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JobId { get; set; }

        /// <summary>
        /// pending until approved or rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LlamaParse.JsonConverters.ExtractReviewResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.ExtractReviewResponseStatus Status { get; set; }

        /// <summary>
        /// Bumped by every change; actions name the one they saw.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revision")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Revision { get; set; }

        /// <summary>
        /// Fields read below this confidence are flagged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence_threshold")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ConfidenceThreshold { get; set; }

        /// <summary>
        /// JSON Pointers of the fields the threshold applies to; empty means all.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields_in_scope")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> FieldsInScope { get; set; }

        /// <summary>
        /// JSON Pointers of fields flagged when empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_fields")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> RequiredFields { get; set; }

        /// <summary>
        /// The latest action per field, keyed by JSON Pointer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field_actions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::LlamaParse.ExtractReviewFieldAction> FieldActions { get; set; }

        /// <summary>
        /// Fields the review asks a person to check.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LlamaParse.ExtractReviewFlag> Flags { get; set; }

        /// <summary>
        /// JSON Pointers of flagged fields nobody checked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("open_flags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> OpenFlags { get; set; }

        /// <summary>
        /// The result as the model read it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_result")]
        public object? OriginalResult { get; set; }

        /// <summary>
        /// The result with the field actions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewed_result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object ReviewedResult { get; set; }

        /// <summary>
        /// The file the job read, or the file behind the parse job it read; null for a URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_file_id")]
        public string? SourceFileId { get; set; }

        /// <summary>
        /// When the job and its document may be deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retain_until")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime RetainUntil { get; set; }

        /// <summary>
        /// ID of the user who approved or rejected it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decided_by")]
        public string? DecidedBy { get; set; }

        /// <summary>
        /// When it was approved or rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decided_at")]
        public global::System.DateTime? DecidedAt { get; set; }

        /// <summary>
        /// Why it was rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decided_reason")]
        public string? DecidedReason { get; set; }

        /// <summary>
        /// When review was turned on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// When the review last changed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractReviewResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the review.
        /// </param>
        /// <param name="jobId">
        /// The extract job reviewed.
        /// </param>
        /// <param name="status">
        /// pending until approved or rejected.
        /// </param>
        /// <param name="revision">
        /// Bumped by every change; actions name the one they saw.
        /// </param>
        /// <param name="confidenceThreshold">
        /// Fields read below this confidence are flagged.
        /// </param>
        /// <param name="fieldsInScope">
        /// JSON Pointers of the fields the threshold applies to; empty means all.
        /// </param>
        /// <param name="requiredFields">
        /// JSON Pointers of fields flagged when empty.
        /// </param>
        /// <param name="fieldActions">
        /// The latest action per field, keyed by JSON Pointer.
        /// </param>
        /// <param name="flags">
        /// Fields the review asks a person to check.
        /// </param>
        /// <param name="openFlags">
        /// JSON Pointers of flagged fields nobody checked.
        /// </param>
        /// <param name="reviewedResult">
        /// The result with the field actions.
        /// </param>
        /// <param name="retainUntil">
        /// When the job and its document may be deleted.
        /// </param>
        /// <param name="createdAt">
        /// When review was turned on.
        /// </param>
        /// <param name="updatedAt">
        /// When the review last changed.
        /// </param>
        /// <param name="originalResult">
        /// The result as the model read it.
        /// </param>
        /// <param name="sourceFileId">
        /// The file the job read, or the file behind the parse job it read; null for a URL.
        /// </param>
        /// <param name="decidedBy">
        /// ID of the user who approved or rejected it.
        /// </param>
        /// <param name="decidedAt">
        /// When it was approved or rejected.
        /// </param>
        /// <param name="decidedReason">
        /// Why it was rejected.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractReviewResponse(
            string id,
            string jobId,
            global::LlamaParse.ExtractReviewResponseStatus status,
            int revision,
            double confidenceThreshold,
            global::System.Collections.Generic.IList<string> fieldsInScope,
            global::System.Collections.Generic.IList<string> requiredFields,
            global::System.Collections.Generic.Dictionary<string, global::LlamaParse.ExtractReviewFieldAction> fieldActions,
            global::System.Collections.Generic.IList<global::LlamaParse.ExtractReviewFlag> flags,
            global::System.Collections.Generic.IList<string> openFlags,
            object reviewedResult,
            global::System.DateTime retainUntil,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            object? originalResult,
            string? sourceFileId,
            string? decidedBy,
            global::System.DateTime? decidedAt,
            string? decidedReason)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.JobId = jobId ?? throw new global::System.ArgumentNullException(nameof(jobId));
            this.Status = status;
            this.Revision = revision;
            this.ConfidenceThreshold = confidenceThreshold;
            this.FieldsInScope = fieldsInScope ?? throw new global::System.ArgumentNullException(nameof(fieldsInScope));
            this.RequiredFields = requiredFields ?? throw new global::System.ArgumentNullException(nameof(requiredFields));
            this.FieldActions = fieldActions ?? throw new global::System.ArgumentNullException(nameof(fieldActions));
            this.Flags = flags ?? throw new global::System.ArgumentNullException(nameof(flags));
            this.OpenFlags = openFlags ?? throw new global::System.ArgumentNullException(nameof(openFlags));
            this.OriginalResult = originalResult;
            this.ReviewedResult = reviewedResult ?? throw new global::System.ArgumentNullException(nameof(reviewedResult));
            this.SourceFileId = sourceFileId;
            this.RetainUntil = retainUntil;
            this.DecidedBy = decidedBy;
            this.DecidedAt = decidedAt;
            this.DecidedReason = decidedReason;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractReviewResponse" /> class.
        /// </summary>
        public ExtractReviewResponse()
        {
        }

    }
}