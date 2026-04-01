
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Response for a classify job.
    /// </summary>
    public sealed partial class ClassifyV2JobResponse
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
        /// ID of the input file or parse job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileInput { get; set; }

        /// <summary>
        /// Project this job belongs to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// User who created this job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Current job status: PENDING, RUNNING, COMPLETED, or FAILED
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LlamaParse.JsonConverters.ClassifyV2JobResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.ClassifyV2JobResponseStatus Status { get; set; }

        /// <summary>
        /// Whether the input was a file or parse job (FILE or PARSE_JOB)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_input_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LlamaParse.JsonConverters.ClassifyV2JobResponseDocumentInputTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.ClassifyV2JobResponseDocumentInputType DocumentInputType { get; set; }

        /// <summary>
        /// Classify configuration used for this job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.ClassifyV2Configuration Configuration { get; set; }

        /// <summary>
        /// Classify result — available when status is COMPLETED
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public global::LlamaParse.ClassifyV2Result? Result { get; set; }

        /// <summary>
        /// Error message if job failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Product configuration ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration_id")]
        public string? ConfigurationId { get; set; }

        /// <summary>
        /// Idempotency key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        public string? TransactionId { get; set; }

        /// <summary>
        /// Associated parse job ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parse_job_id")]
        public string? ParseJobId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyV2JobResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier
        /// </param>
        /// <param name="fileInput">
        /// ID of the input file or parse job
        /// </param>
        /// <param name="projectId">
        /// Project this job belongs to
        /// </param>
        /// <param name="userId">
        /// User who created this job
        /// </param>
        /// <param name="status">
        /// Current job status: PENDING, RUNNING, COMPLETED, or FAILED
        /// </param>
        /// <param name="documentInputType">
        /// Whether the input was a file or parse job (FILE or PARSE_JOB)
        /// </param>
        /// <param name="configuration">
        /// Classify configuration used for this job
        /// </param>
        /// <param name="createdAt">
        /// Creation datetime
        /// </param>
        /// <param name="updatedAt">
        /// Update datetime
        /// </param>
        /// <param name="result">
        /// Classify result — available when status is COMPLETED
        /// </param>
        /// <param name="errorMessage">
        /// Error message if job failed
        /// </param>
        /// <param name="configurationId">
        /// Product configuration ID
        /// </param>
        /// <param name="transactionId">
        /// Idempotency key
        /// </param>
        /// <param name="parseJobId">
        /// Associated parse job ID
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClassifyV2JobResponse(
            global::LlamaParse.AnyOf<string, global::System.Guid?> id,
            string fileInput,
            string projectId,
            string userId,
            global::LlamaParse.ClassifyV2JobResponseStatus status,
            global::LlamaParse.ClassifyV2JobResponseDocumentInputType documentInputType,
            global::LlamaParse.ClassifyV2Configuration configuration,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::LlamaParse.ClassifyV2Result? result,
            string? errorMessage,
            string? configurationId,
            string? transactionId,
            string? parseJobId)
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.FileInput = fileInput ?? throw new global::System.ArgumentNullException(nameof(fileInput));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Status = status;
            this.DocumentInputType = documentInputType;
            this.Configuration = configuration ?? throw new global::System.ArgumentNullException(nameof(configuration));
            this.Result = result;
            this.ErrorMessage = errorMessage;
            this.ConfigurationId = configurationId;
            this.TransactionId = transactionId;
            this.ParseJobId = parseJobId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyV2JobResponse" /> class.
        /// </summary>
        public ClassifyV2JobResponse()
        {
        }
    }
}