
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// A single retrieval result.
    /// </summary>
    public sealed partial class RetrievalResultResponse
    {
        /// <summary>
        /// Text content of the retrieved chunk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Hybrid search relevance score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// Relevance score from the reranker, if reranking was applied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rerank_score")]
        public double? RerankScore { get; set; }

        /// <summary>
        /// User-defined metadata associated with the chunk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Built-in fields stored for every exported chunk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("static_fields")]
        public global::LlamaParse.StaticFieldsResponse? StaticFields { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrievalResultResponse" /> class.
        /// </summary>
        /// <param name="content">
        /// Text content of the retrieved chunk.
        /// </param>
        /// <param name="score">
        /// Hybrid search relevance score.
        /// </param>
        /// <param name="rerankScore">
        /// Relevance score from the reranker, if reranking was applied.
        /// </param>
        /// <param name="metadata">
        /// User-defined metadata associated with the chunk.
        /// </param>
        /// <param name="staticFields">
        /// Built-in fields stored for every exported chunk.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetrievalResultResponse(
            string content,
            double? score,
            double? rerankScore,
            object? metadata,
            global::LlamaParse.StaticFieldsResponse? staticFields)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Score = score;
            this.RerankScore = rerankScore;
            this.Metadata = metadata;
            this.StaticFields = staticFields;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrievalResultResponse" /> class.
        /// </summary>
        public RetrievalResultResponse()
        {
        }

    }
}