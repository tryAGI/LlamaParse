
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Request to create a spreadsheet parsing job.<br/>
    /// Exactly one of `configuration` (inline) or `configuration_id` (saved<br/>
    /// preset) must be provided.
    /// </summary>
    public sealed partial class SpreadsheetJobCreate
    {
        /// <summary>
        /// Saved configuration ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration_id")]
        public string? ConfigurationId { get; set; }

        /// <summary>
        /// Inline configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        public global::LlamaParse.SpreadsheetParsingConfig? Configuration { get; set; }

        /// <summary>
        /// Outbound webhook endpoints to notify on job status changes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_configurations")]
        public global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfiguration>? WebhookConfigurations { get; set; }

        /// <summary>
        /// Deprecated: use `configuration` instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::LlamaParse.SpreadsheetParsingConfig? Config { get; set; }

        /// <summary>
        /// The ID of the file to parse
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid FileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpreadsheetJobCreate" /> class.
        /// </summary>
        /// <param name="fileId">
        /// The ID of the file to parse
        /// </param>
        /// <param name="configurationId">
        /// Saved configuration ID
        /// </param>
        /// <param name="configuration">
        /// Inline configuration
        /// </param>
        /// <param name="webhookConfigurations">
        /// Outbound webhook endpoints to notify on job status changes
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpreadsheetJobCreate(
            global::System.Guid fileId,
            string? configurationId,
            global::LlamaParse.SpreadsheetParsingConfig? configuration,
            global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfiguration>? webhookConfigurations)
        {
            this.ConfigurationId = configurationId;
            this.Configuration = configuration;
            this.WebhookConfigurations = webhookConfigurations;
            this.FileId = fileId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpreadsheetJobCreate" /> class.
        /// </summary>
        public SpreadsheetJobCreate()
        {
        }

    }
}