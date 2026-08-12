
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// A suspicious region localized on a rendered page.
    /// </summary>
    public sealed partial class VerifyRegion
    {
        /// <summary>
        /// Region bounding box as [x, y, w, h] in page-render pixels
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bbox")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Bbox { get; set; }

        /// <summary>
        /// Kind of anomaly detected in this region
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Kind { get; set; }

        /// <summary>
        /// Region-level doctoring likelihood score
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        /// Detector/tool that produced this region
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// Human-readable detail about the region
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Detail { get; set; }

        /// <summary>
        /// Page number the region belongs to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Page { get; set; }

        /// <summary>
        /// Review status/verdict for this region
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("review")]
        public string? Review { get; set; }

        /// <summary>
        /// Free-form review note for this region
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("review_note")]
        public string? ReviewNote { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyRegion" /> class.
        /// </summary>
        /// <param name="bbox">
        /// Region bounding box as [x, y, w, h] in page-render pixels
        /// </param>
        /// <param name="kind">
        /// Kind of anomaly detected in this region
        /// </param>
        /// <param name="score">
        /// Region-level doctoring likelihood score
        /// </param>
        /// <param name="source">
        /// Detector/tool that produced this region
        /// </param>
        /// <param name="detail">
        /// Human-readable detail about the region
        /// </param>
        /// <param name="page">
        /// Page number the region belongs to
        /// </param>
        /// <param name="review">
        /// Review status/verdict for this region
        /// </param>
        /// <param name="reviewNote">
        /// Free-form review note for this region
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VerifyRegion(
            global::System.Collections.Generic.IList<int> bbox,
            string kind,
            double score,
            string source,
            string detail,
            int page,
            string? review,
            string? reviewNote)
        {
            this.Bbox = bbox ?? throw new global::System.ArgumentNullException(nameof(bbox));
            this.Kind = kind ?? throw new global::System.ArgumentNullException(nameof(kind));
            this.Score = score;
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Detail = detail ?? throw new global::System.ArgumentNullException(nameof(detail));
            this.Page = page;
            this.Review = review;
            this.ReviewNote = reviewNote;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyRegion" /> class.
        /// </summary>
        public VerifyRegion()
        {
        }

    }
}