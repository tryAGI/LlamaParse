
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// A classify job.
    /// </summary>
    public sealed partial class ClassifyJobCreate
    {
        /// <summary>
        /// The rules to classify the files
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LlamaParse.ClassifierRule> Rules { get; set; }

        /// <summary>
        /// The classification mode to use<br/>
        /// Default Value: FAST
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LlamaParse.JsonConverters.ClassifyModeJsonConverter))]
        public global::LlamaParse.ClassifyMode? Mode { get; set; }

        /// <summary>
        /// The IDs of the files to classify
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> FileIds { get; set; }

        /// <summary>
        /// The configuration for the parsing job<br/>
        /// Default Value: {"lang":"en","max_pages":5}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parsing_configuration")]
        public global::LlamaParse.ClassifyParsingConfiguration? ParsingConfiguration { get; set; }

        /// <summary>
        /// List of webhook configurations for notifications
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_configurations")]
        public global::System.Collections.Generic.IList<global::LlamaParse.LlamaParseWebhookConfiguration>? WebhookConfigurations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyJobCreate" /> class.
        /// </summary>
        /// <param name="rules">
        /// The rules to classify the files
        /// </param>
        /// <param name="mode">
        /// The classification mode to use<br/>
        /// Default Value: FAST
        /// </param>
        /// <param name="fileIds">
        /// The IDs of the files to classify
        /// </param>
        /// <param name="parsingConfiguration">
        /// The configuration for the parsing job<br/>
        /// Default Value: {"lang":"en","max_pages":5}
        /// </param>
        /// <param name="webhookConfigurations">
        /// List of webhook configurations for notifications
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClassifyJobCreate(
            global::System.Collections.Generic.IList<global::LlamaParse.ClassifierRule> rules,
            global::System.Collections.Generic.IList<global::System.Guid> fileIds,
            global::LlamaParse.ClassifyMode? mode,
            global::LlamaParse.ClassifyParsingConfiguration? parsingConfiguration,
            global::System.Collections.Generic.IList<global::LlamaParse.LlamaParseWebhookConfiguration>? webhookConfigurations)
        {
            this.Rules = rules ?? throw new global::System.ArgumentNullException(nameof(rules));
            this.FileIds = fileIds ?? throw new global::System.ArgumentNullException(nameof(fileIds));
            this.Mode = mode;
            this.ParsingConfiguration = parsingConfiguration;
            this.WebhookConfigurations = webhookConfigurations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyJobCreate" /> class.
        /// </summary>
        public ClassifyJobCreate()
        {
        }
    }
}