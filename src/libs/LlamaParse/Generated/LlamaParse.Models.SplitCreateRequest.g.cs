
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Create a split job.
    /// </summary>
    public sealed partial class SplitCreateRequest
    {
        /// <summary>
        /// Idempotency key scoped to the project. Reusing a key returns the original job; the new request body is ignored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        public string? TransactionId { get; set; }

        /// <summary>
        /// Outbound webhook endpoints to notify on job status changes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_configurations")]
        public global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfiguration>? WebhookConfigurations { get; set; }

        /// <summary>
        /// Saved configuration ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration_id")]
        public string? ConfigurationId { get; set; }

        /// <summary>
        /// Inline configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        public global::LlamaParse.SplitConfiguration? Configuration { get; set; }

        /// <summary>
        /// File ID or parse job ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileInput { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitCreateRequest" /> class.
        /// </summary>
        /// <param name="fileInput">
        /// File ID or parse job ID
        /// </param>
        /// <param name="transactionId">
        /// Idempotency key scoped to the project. Reusing a key returns the original job; the new request body is ignored.
        /// </param>
        /// <param name="webhookConfigurations">
        /// Outbound webhook endpoints to notify on job status changes
        /// </param>
        /// <param name="configurationId">
        /// Saved configuration ID
        /// </param>
        /// <param name="configuration">
        /// Inline configuration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SplitCreateRequest(
            string fileInput,
            string? transactionId,
            global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfiguration>? webhookConfigurations,
            string? configurationId,
            global::LlamaParse.SplitConfiguration? configuration)
        {
            this.TransactionId = transactionId;
            this.WebhookConfigurations = webhookConfigurations;
            this.ConfigurationId = configurationId;
            this.Configuration = configuration;
            this.FileInput = fileInput ?? throw new global::System.ArgumentNullException(nameof(fileInput));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitCreateRequest" /> class.
        /// </summary>
        public SplitCreateRequest()
        {
        }

    }
}