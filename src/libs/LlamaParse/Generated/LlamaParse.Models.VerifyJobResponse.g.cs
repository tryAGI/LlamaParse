
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Response for a Verify job.
    /// </summary>
    public sealed partial class VerifyJobResponse
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
        /// ID of the input file
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
        /// Current job status: PENDING, RUNNING, COMPLETED, FAILED, or CANCELLED
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LlamaParse.JsonConverters.VerifyJobResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.VerifyJobResponseStatus Status { get; set; }

        /// <summary>
        /// Type of the document input (FILE)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_input_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LlamaParse.JsonConverters.VerifyJobResponseDocumentInputTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.VerifyJobResponseDocumentInputType DocumentInputType { get; set; }

        /// <summary>
        /// Verify configuration used for this job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.VerifyConfiguration Configuration { get; set; }

        /// <summary>
        /// Verify result — populated when status is COMPLETED and the result was requested via expand=result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public global::LlamaParse.VerifyResult? Result { get; set; }

        /// <summary>
        /// Error message if job failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Idempotency key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        public string? TransactionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyJobResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier
        /// </param>
        /// <param name="fileInput">
        /// ID of the input file
        /// </param>
        /// <param name="projectId">
        /// Project this job belongs to
        /// </param>
        /// <param name="userId">
        /// User who created this job
        /// </param>
        /// <param name="status">
        /// Current job status: PENDING, RUNNING, COMPLETED, FAILED, or CANCELLED
        /// </param>
        /// <param name="documentInputType">
        /// Type of the document input (FILE)
        /// </param>
        /// <param name="configuration">
        /// Verify configuration used for this job
        /// </param>
        /// <param name="createdAt">
        /// Creation datetime
        /// </param>
        /// <param name="updatedAt">
        /// Update datetime
        /// </param>
        /// <param name="result">
        /// Verify result — populated when status is COMPLETED and the result was requested via expand=result
        /// </param>
        /// <param name="errorMessage">
        /// Error message if job failed
        /// </param>
        /// <param name="transactionId">
        /// Idempotency key
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VerifyJobResponse(
            global::LlamaParse.AnyOf<string, global::System.Guid?> id,
            string fileInput,
            string projectId,
            string userId,
            global::LlamaParse.VerifyJobResponseStatus status,
            global::LlamaParse.VerifyJobResponseDocumentInputType documentInputType,
            global::LlamaParse.VerifyConfiguration configuration,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::LlamaParse.VerifyResult? result,
            string? errorMessage,
            string? transactionId)
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
            this.TransactionId = transactionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyJobResponse" /> class.
        /// </summary>
        public VerifyJobResponse()
        {
        }

    }
}