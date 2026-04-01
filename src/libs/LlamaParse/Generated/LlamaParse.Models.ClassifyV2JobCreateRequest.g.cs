
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Request to create a classify job.
    /// </summary>
    public sealed partial class ClassifyV2JobCreateRequest
    {
        /// <summary>
        /// Saved configuration ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration_id")]
        public string? ConfigurationId { get; set; }

        /// <summary>
        /// Inline classify configuration (required if configuration_id is not provided)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        public global::LlamaParse.ClassifyV2Configuration? Configuration { get; set; }

        /// <summary>
        /// File ID or parse job ID to classify
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_input")]
        public string? FileInput { get; set; }

        /// <summary>
        /// Deprecated: use file_input instead
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? FileId { get; set; }

        /// <summary>
        /// Deprecated: use file_input instead
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parse_job_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? ParseJobId { get; set; }

        /// <summary>
        /// Idempotency key scoped to the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        public string? TransactionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyV2JobCreateRequest" /> class.
        /// </summary>
        /// <param name="configurationId">
        /// Saved configuration ID
        /// </param>
        /// <param name="configuration">
        /// Inline classify configuration (required if configuration_id is not provided)
        /// </param>
        /// <param name="fileInput">
        /// File ID or parse job ID to classify
        /// </param>
        /// <param name="transactionId">
        /// Idempotency key scoped to the project
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClassifyV2JobCreateRequest(
            string? configurationId,
            global::LlamaParse.ClassifyV2Configuration? configuration,
            string? fileInput,
            string? transactionId)
        {
            this.ConfigurationId = configurationId;
            this.Configuration = configuration;
            this.FileInput = fileInput;
            this.TransactionId = transactionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyV2JobCreateRequest" /> class.
        /// </summary>
        public ClassifyV2JobCreateRequest()
        {
        }
    }
}