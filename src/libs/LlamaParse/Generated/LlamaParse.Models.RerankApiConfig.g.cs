
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Reranking configuration to apply after hybrid search.
    /// </summary>
    public sealed partial class RerankApiConfig
    {
        /// <summary>
        /// Set to false to disable reranking.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Number of results to return after reranking.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_n")]
        public int? TopN { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankApiConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Set to false to disable reranking.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="topN">
        /// Number of results to return after reranking.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RerankApiConfig(
            bool? enabled,
            int? topN)
        {
            this.Enabled = enabled;
            this.TopN = topN;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankApiConfig" /> class.
        /// </summary>
        public RerankApiConfig()
        {
        }

    }
}