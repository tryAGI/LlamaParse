
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Document-level metadata information.
    /// </summary>
    public sealed partial class MetadataResultDocument2
    {
        /// <summary>
        /// Mean confidence score across pages scored by the high-effort confidence judge (0-1)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// Worst-page confidence and scoring coverage for the document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence_breakdown")]
        public global::LlamaParse.MetadataResultDocumentConfidenceBreakdown2? ConfidenceBreakdown { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataResultDocument2" /> class.
        /// </summary>
        /// <param name="confidence">
        /// Mean confidence score across pages scored by the high-effort confidence judge (0-1)
        /// </param>
        /// <param name="confidenceBreakdown">
        /// Worst-page confidence and scoring coverage for the document
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetadataResultDocument2(
            double? confidence,
            global::LlamaParse.MetadataResultDocumentConfidenceBreakdown2? confidenceBreakdown)
        {
            this.Confidence = confidence;
            this.ConfidenceBreakdown = confidenceBreakdown;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataResultDocument2" /> class.
        /// </summary>
        public MetadataResultDocument2()
        {
        }

    }
}