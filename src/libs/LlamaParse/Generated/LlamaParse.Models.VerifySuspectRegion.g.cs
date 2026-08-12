
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// A region that led to the suspected fraud, with why it is suspect.<br/>
    /// A curated, high-signal subset of ``regions``: reviewer-dismissed candidates<br/>
    /// are dropped and the remainder is ranked by suspicion, so consumers can act<br/>
    /// on ``verdict`` + ``confidence`` + this list without reading the raw signals.
    /// </summary>
    public sealed partial class VerifySuspectRegion
    {
        /// <summary>
        /// Page number the region belongs to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Page { get; set; }

        /// <summary>
        /// Region bounding box as [x, y, w, h] in page-render pixels
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bbox")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Bbox { get; set; }

        /// <summary>
        /// Suspicion score for this region (0 to 1)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        /// Kind of anomaly detected in this region
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Kind { get; set; }

        /// <summary>
        /// Detector that flagged this region
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// Human-readable explanation of what makes this region suspect
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("explanation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Explanation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifySuspectRegion" /> class.
        /// </summary>
        /// <param name="page">
        /// Page number the region belongs to
        /// </param>
        /// <param name="bbox">
        /// Region bounding box as [x, y, w, h] in page-render pixels
        /// </param>
        /// <param name="score">
        /// Suspicion score for this region (0 to 1)
        /// </param>
        /// <param name="kind">
        /// Kind of anomaly detected in this region
        /// </param>
        /// <param name="source">
        /// Detector that flagged this region
        /// </param>
        /// <param name="explanation">
        /// Human-readable explanation of what makes this region suspect
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VerifySuspectRegion(
            int page,
            global::System.Collections.Generic.IList<int> bbox,
            double score,
            string kind,
            string source,
            string explanation)
        {
            this.Page = page;
            this.Bbox = bbox ?? throw new global::System.ArgumentNullException(nameof(bbox));
            this.Score = score;
            this.Kind = kind ?? throw new global::System.ArgumentNullException(nameof(kind));
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Explanation = explanation ?? throw new global::System.ArgumentNullException(nameof(explanation));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifySuspectRegion" /> class.
        /// </summary>
        public VerifySuspectRegion()
        {
        }

    }
}