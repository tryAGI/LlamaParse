
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Hashes for the configuration of a pipeline.
    /// </summary>
    public sealed partial class PipelineConfigurationHashes
    {
        /// <summary>
        /// Hash of the embedding config. Null in API responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_config_hash")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? EmbeddingConfigHash { get; set; }

        /// <summary>
        /// Hash of the llama parse parameters. Null in API responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parsing_config_hash")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? ParsingConfigHash { get; set; }

        /// <summary>
        /// Hash of the transform config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transform_config_hash")]
        public string? TransformConfigHash { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineConfigurationHashes" /> class.
        /// </summary>
        /// <param name="transformConfigHash">
        /// Hash of the transform config.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PipelineConfigurationHashes(
            string? transformConfigHash)
        {
            this.TransformConfigHash = transformConfigHash;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineConfigurationHashes" /> class.
        /// </summary>
        public PipelineConfigurationHashes()
        {
        }

    }
}