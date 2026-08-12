
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// A per-page forensic heatmap overlay, as a presigned image URL.
    /// </summary>
    public sealed partial class VerifyHeatmap
    {
        /// <summary>
        /// 0-based page index (0 for standalone images)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Page { get; set; }

        /// <summary>
        /// Producing signal, e.g. double_compression, ela, noise
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Kind { get; set; }

        /// <summary>
        /// Presigned URL to the heatmap PNG (page overlay)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Producing tool's max score (for ranking)<br/>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyHeatmap" /> class.
        /// </summary>
        /// <param name="page">
        /// 0-based page index (0 for standalone images)
        /// </param>
        /// <param name="kind">
        /// Producing signal, e.g. double_compression, ela, noise
        /// </param>
        /// <param name="url">
        /// Presigned URL to the heatmap PNG (page overlay)
        /// </param>
        /// <param name="score">
        /// Producing tool's max score (for ranking)<br/>
        /// Default Value: 0F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VerifyHeatmap(
            int page,
            string kind,
            string url,
            double? score)
        {
            this.Page = page;
            this.Kind = kind ?? throw new global::System.ArgumentNullException(nameof(kind));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyHeatmap" /> class.
        /// </summary>
        public VerifyHeatmap()
        {
        }

    }
}