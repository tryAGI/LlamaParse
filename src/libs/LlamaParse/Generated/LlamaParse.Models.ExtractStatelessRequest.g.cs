
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Schema for stateless extraction requests.
    /// </summary>
    public sealed partial class ExtractStatelessRequest
    {
        /// <summary>
        /// Outbound webhook endpoints to notify on job status changes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_configurations")]
        public global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfiguration>? WebhookConfigurations { get; set; }

        /// <summary>
        /// The schema of the data to extract
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_schema")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.AnyOf<object, string> DataSchema { get; set; }

        /// <summary>
        /// The configuration parameters for the extraction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.ExtractConfig Config { get; set; }

        /// <summary>
        /// The ID of the file to extract from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public global::System.Guid? FileId { get; set; }

        /// <summary>
        /// The text content to extract from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The file data with base64 content and MIME type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public global::LlamaParse.FileData? File { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractStatelessRequest" /> class.
        /// </summary>
        /// <param name="webhookConfigurations">
        /// Outbound webhook endpoints to notify on job status changes
        /// </param>
        /// <param name="dataSchema">
        /// The schema of the data to extract
        /// </param>
        /// <param name="config">
        /// The configuration parameters for the extraction
        /// </param>
        /// <param name="fileId">
        /// The ID of the file to extract from
        /// </param>
        /// <param name="text">
        /// The text content to extract from
        /// </param>
        /// <param name="file">
        /// The file data with base64 content and MIME type
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractStatelessRequest(
            global::LlamaParse.AnyOf<object, string> dataSchema,
            global::LlamaParse.ExtractConfig config,
            global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfiguration>? webhookConfigurations,
            global::System.Guid? fileId,
            string? text,
            global::LlamaParse.FileData? file)
        {
            this.DataSchema = dataSchema;
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.WebhookConfigurations = webhookConfigurations;
            this.FileId = fileId;
            this.Text = text;
            this.File = file;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractStatelessRequest" /> class.
        /// </summary>
        public ExtractStatelessRequest()
        {
        }
    }
}