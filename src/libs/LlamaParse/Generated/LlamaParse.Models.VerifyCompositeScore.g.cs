
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// One composite score, answering a single question about the document.
    /// </summary>
    public sealed partial class VerifyCompositeScore
    {
        /// <summary>
        /// Score (0 to 1); null when the composite was not applicable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// Whether the checks feeding this composite ran on this document. When false the document was not checked for this — not cleared of it<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("applicable")]
        public bool? Applicable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyCompositeScore" /> class.
        /// </summary>
        /// <param name="score">
        /// Score (0 to 1); null when the composite was not applicable
        /// </param>
        /// <param name="applicable">
        /// Whether the checks feeding this composite ran on this document. When false the document was not checked for this — not cleared of it<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VerifyCompositeScore(
            double? score,
            bool? applicable)
        {
            this.Score = score;
            this.Applicable = applicable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyCompositeScore" /> class.
        /// </summary>
        public VerifyCompositeScore()
        {
        }

    }
}