
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Request to create a Verify job.
    /// </summary>
    public sealed partial class VerifyRequest
    {
        /// <summary>
        /// Outbound webhook endpoints to notify on job status changes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_configurations")]
        public global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfiguration>? WebhookConfigurations { get; set; }

        /// <summary>
        /// File ID of the document to analyze
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
        /// Verify configuration (defaults applied when omitted)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        public global::LlamaParse.VerifyConfiguration? Configuration { get; set; }

        /// <summary>
        /// Idempotency key scoped to the project. Reusing a key returns the original job; the new request body is ignored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        public string? TransactionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyRequest" /> class.
        /// </summary>
        /// <param name="webhookConfigurations">
        /// Outbound webhook endpoints to notify on job status changes
        /// </param>
        /// <param name="fileInput">
        /// File ID of the document to analyze
        /// </param>
        /// <param name="configuration">
        /// Verify configuration (defaults applied when omitted)
        /// </param>
        /// <param name="transactionId">
        /// Idempotency key scoped to the project. Reusing a key returns the original job; the new request body is ignored.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VerifyRequest(
            global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfiguration>? webhookConfigurations,
            string? fileInput,
            global::LlamaParse.VerifyConfiguration? configuration,
            string? transactionId)
        {
            this.WebhookConfigurations = webhookConfigurations;
            this.FileInput = fileInput;
            this.Configuration = configuration;
            this.TransactionId = transactionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyRequest" /> class.
        /// </summary>
        public VerifyRequest()
        {
        }

    }
}