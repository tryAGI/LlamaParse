
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Composite scores, each answering one question about the document.
    /// </summary>
    public sealed partial class VerifyCompositeScores
    {
        /// <summary>
        /// Was this content synthesized by a generative model?
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_generated")]
        public global::LlamaParse.VerifyCompositeScore? AiGenerated { get; set; }

        /// <summary>
        /// Was this document altered after creation (splice, retype, redact, inpaint)?
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manually_edited")]
        public global::LlamaParse.VerifyCompositeScore? ManuallyEdited { get; set; }

        /// <summary>
        /// Does the file's provenance / toolchain history look suspicious? Advisory: individually weak workflow-hygiene signals
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_metadata")]
        public global::LlamaParse.VerifyCompositeScore? DocumentMetadata { get; set; }

        /// <summary>
        /// Does the document's content agree with itself (checksums, arithmetic, machine-readable zones)?
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_coherence")]
        public global::LlamaParse.VerifyCompositeScore? DocumentCoherence { get; set; }

        /// <summary>
        /// Was the document captured through a channel that destroys forensic evidence (photo of a screen, print-then-rescan)?
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recapture")]
        public global::LlamaParse.VerifyCompositeScore? Recapture { get; set; }

        /// <summary>
        /// Has this asset (or its template) been seen in fraud before?
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("known_fraud")]
        public global::LlamaParse.VerifyCompositeScore? KnownFraud { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyCompositeScores" /> class.
        /// </summary>
        /// <param name="aiGenerated">
        /// Was this content synthesized by a generative model?
        /// </param>
        /// <param name="manuallyEdited">
        /// Was this document altered after creation (splice, retype, redact, inpaint)?
        /// </param>
        /// <param name="documentMetadata">
        /// Does the file's provenance / toolchain history look suspicious? Advisory: individually weak workflow-hygiene signals
        /// </param>
        /// <param name="documentCoherence">
        /// Does the document's content agree with itself (checksums, arithmetic, machine-readable zones)?
        /// </param>
        /// <param name="recapture">
        /// Was the document captured through a channel that destroys forensic evidence (photo of a screen, print-then-rescan)?
        /// </param>
        /// <param name="knownFraud">
        /// Has this asset (or its template) been seen in fraud before?
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VerifyCompositeScores(
            global::LlamaParse.VerifyCompositeScore? aiGenerated,
            global::LlamaParse.VerifyCompositeScore? manuallyEdited,
            global::LlamaParse.VerifyCompositeScore? documentMetadata,
            global::LlamaParse.VerifyCompositeScore? documentCoherence,
            global::LlamaParse.VerifyCompositeScore? recapture,
            global::LlamaParse.VerifyCompositeScore? knownFraud)
        {
            this.AiGenerated = aiGenerated;
            this.ManuallyEdited = manuallyEdited;
            this.DocumentMetadata = documentMetadata;
            this.DocumentCoherence = documentCoherence;
            this.Recapture = recapture;
            this.KnownFraud = knownFraud;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyCompositeScores" /> class.
        /// </summary>
        public VerifyCompositeScores()
        {
        }

    }
}