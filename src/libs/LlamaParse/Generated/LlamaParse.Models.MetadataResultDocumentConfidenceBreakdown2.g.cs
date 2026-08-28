
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Coverage and worst-page details for document confidence.
    /// </summary>
    public sealed partial class MetadataResultDocumentConfidenceBreakdown2
    {
        /// <summary>
        /// Lowest confidence score among pages scored by the high-effort confidence judge
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_page_score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MinPageScore { get; set; }

        /// <summary>
        /// Number of pages successfully scored by the high-effort confidence judge
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scored_pages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ScoredPages { get; set; }

        /// <summary>
        /// Total number of pages in the parsed document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_pages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalPages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataResultDocumentConfidenceBreakdown2" /> class.
        /// </summary>
        /// <param name="minPageScore">
        /// Lowest confidence score among pages scored by the high-effort confidence judge
        /// </param>
        /// <param name="scoredPages">
        /// Number of pages successfully scored by the high-effort confidence judge
        /// </param>
        /// <param name="totalPages">
        /// Total number of pages in the parsed document
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetadataResultDocumentConfidenceBreakdown2(
            double minPageScore,
            int scoredPages,
            int totalPages)
        {
            this.MinPageScore = minPageScore;
            this.ScoredPages = scoredPages;
            this.TotalPages = totalPages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataResultDocumentConfidenceBreakdown2" /> class.
        /// </summary>
        public MetadataResultDocumentConfidenceBreakdown2()
        {
        }

    }
}