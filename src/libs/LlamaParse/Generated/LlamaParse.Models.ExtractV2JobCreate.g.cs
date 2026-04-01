
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Request to create an extraction job. Provide configuration_id or inline configuration.
    /// </summary>
    public sealed partial class ExtractV2JobCreate
    {
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
        /// Inline configuration with extract options and optional parse settings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        public global::LlamaParse.ExtractConfiguration? Configuration { get; set; }

        /// <summary>
        /// File ID or parse job ID to extract from
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
        /// Initializes a new instance of the <see cref="ExtractV2JobCreate" /> class.
        /// </summary>
        /// <param name="fileInput">
        /// File ID or parse job ID to extract from
        /// </param>
        /// <param name="webhookConfigurations">
        /// Outbound webhook endpoints to notify on job status changes
        /// </param>
        /// <param name="configurationId">
        /// Saved configuration ID
        /// </param>
        /// <param name="configuration">
        /// Inline configuration with extract options and optional parse settings
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractV2JobCreate(
            string fileInput,
            global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfiguration>? webhookConfigurations,
            string? configurationId,
            global::LlamaParse.ExtractConfiguration? configuration)
        {
            this.WebhookConfigurations = webhookConfigurations;
            this.ConfigurationId = configurationId;
            this.Configuration = configuration;
            this.FileInput = fileInput ?? throw new global::System.ArgumentNullException(nameof(fileInput));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractV2JobCreate" /> class.
        /// </summary>
        public ExtractV2JobCreate()
        {
        }
    }
}