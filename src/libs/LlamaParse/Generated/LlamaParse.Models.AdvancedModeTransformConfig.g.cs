
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AdvancedModeTransformConfig
    {
        /// <summary>
        /// Default Value: advanced
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        public string? Mode { get; set; }

        /// <summary>
        /// Configuration for the segmentation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segmentation_config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.NoneSegmentationConfig, global::LlamaParse.PageSegmentationConfig, global::LlamaParse.ElementSegmentationConfig>))]
        public global::LlamaParse.AnyOf<global::LlamaParse.NoneSegmentationConfig, global::LlamaParse.PageSegmentationConfig, global::LlamaParse.ElementSegmentationConfig>? SegmentationConfig { get; set; }

        /// <summary>
        /// Configuration for the chunking.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunking_config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.NoneChunkingConfig, global::LlamaParse.CharacterChunkingConfig, global::LlamaParse.TokenChunkingConfig, global::LlamaParse.SentenceChunkingConfig, global::LlamaParse.SemanticChunkingConfig>))]
        public global::LlamaParse.AnyOf<global::LlamaParse.NoneChunkingConfig, global::LlamaParse.CharacterChunkingConfig, global::LlamaParse.TokenChunkingConfig, global::LlamaParse.SentenceChunkingConfig, global::LlamaParse.SemanticChunkingConfig>? ChunkingConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedModeTransformConfig" /> class.
        /// </summary>
        /// <param name="mode">
        /// Default Value: advanced
        /// </param>
        /// <param name="segmentationConfig">
        /// Configuration for the segmentation.
        /// </param>
        /// <param name="chunkingConfig">
        /// Configuration for the chunking.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdvancedModeTransformConfig(
            string? mode,
            global::LlamaParse.AnyOf<global::LlamaParse.NoneSegmentationConfig, global::LlamaParse.PageSegmentationConfig, global::LlamaParse.ElementSegmentationConfig>? segmentationConfig,
            global::LlamaParse.AnyOf<global::LlamaParse.NoneChunkingConfig, global::LlamaParse.CharacterChunkingConfig, global::LlamaParse.TokenChunkingConfig, global::LlamaParse.SentenceChunkingConfig, global::LlamaParse.SemanticChunkingConfig>? chunkingConfig)
        {
            this.Mode = mode;
            this.SegmentationConfig = segmentationConfig;
            this.ChunkingConfig = chunkingConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedModeTransformConfig" /> class.
        /// </summary>
        public AdvancedModeTransformConfig()
        {
        }
    }
}