
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Hybrid retrieval request combining vector and full-text search.
    /// </summary>
    public sealed partial class RetrieveParams
    {
        /// <summary>
        /// ID of the index to retrieve against.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IndexId { get; set; }

        /// <summary>
        /// Natural-language query to retrieve relevant chunks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// Maximum number of results to return.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// Number of candidates for approximate nearest neighbor search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_candidates")]
        public int? NumCandidates { get; set; }

        /// <summary>
        /// Weight of the vector search pipeline (0-1).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_pipeline_weight")]
        public double? VectorPipelineWeight { get; set; }

        /// <summary>
        /// Weight of the full-text search pipeline (0-1).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_text_pipeline_weight")]
        public double? FullTextPipelineWeight { get; set; }

        /// <summary>
        /// Minimum score threshold for returned results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_threshold")]
        public double? ScoreThreshold { get; set; }

        /// <summary>
        /// Filters on built-in document fields (page range, chunk index, etc.).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("static_filters")]
        public global::LlamaParse.MongoStaticFilters? StaticFilters { get; set; }

        /// <summary>
        /// Filters on user-defined metadata fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_filters")]
        public object? CustomFilters { get; set; }

        /// <summary>
        /// Reranking configuration applied after hybrid search. Enabled by default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rerank")]
        public global::LlamaParse.RerankApiConfig? Rerank { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveParams" /> class.
        /// </summary>
        /// <param name="indexId">
        /// ID of the index to retrieve against.
        /// </param>
        /// <param name="query">
        /// Natural-language query to retrieve relevant chunks.
        /// </param>
        /// <param name="topK">
        /// Maximum number of results to return.
        /// </param>
        /// <param name="numCandidates">
        /// Number of candidates for approximate nearest neighbor search.
        /// </param>
        /// <param name="vectorPipelineWeight">
        /// Weight of the vector search pipeline (0-1).
        /// </param>
        /// <param name="fullTextPipelineWeight">
        /// Weight of the full-text search pipeline (0-1).
        /// </param>
        /// <param name="scoreThreshold">
        /// Minimum score threshold for returned results.
        /// </param>
        /// <param name="staticFilters">
        /// Filters on built-in document fields (page range, chunk index, etc.).
        /// </param>
        /// <param name="customFilters">
        /// Filters on user-defined metadata fields.
        /// </param>
        /// <param name="rerank">
        /// Reranking configuration applied after hybrid search. Enabled by default.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetrieveParams(
            string indexId,
            string query,
            int? topK,
            int? numCandidates,
            double? vectorPipelineWeight,
            double? fullTextPipelineWeight,
            double? scoreThreshold,
            global::LlamaParse.MongoStaticFilters? staticFilters,
            object? customFilters,
            global::LlamaParse.RerankApiConfig? rerank)
        {
            this.IndexId = indexId ?? throw new global::System.ArgumentNullException(nameof(indexId));
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.TopK = topK;
            this.NumCandidates = numCandidates;
            this.VectorPipelineWeight = vectorPipelineWeight;
            this.FullTextPipelineWeight = fullTextPipelineWeight;
            this.ScoreThreshold = scoreThreshold;
            this.StaticFilters = staticFilters;
            this.CustomFilters = customFilters;
            this.Rerank = rerank;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveParams" /> class.
        /// </summary>
        public RetrieveParams()
        {
        }

    }
}