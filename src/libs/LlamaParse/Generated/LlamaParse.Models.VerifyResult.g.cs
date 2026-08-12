
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Result of a Verify (doctored-document) analysis.<br/>
    /// Raw per-signal detail (evidence list, per-family sub-scores, raw regions,<br/>
    /// forensic heatmaps) is available separately via the job's details endpoint.
    /// </summary>
    public sealed partial class VerifyResult
    {
        /// <summary>
        /// Overall doctoring likelihood (0 to 1)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overall_score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double OverallScore { get; set; }

        /// <summary>
        /// Overall verdict for the document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verdict")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LlamaParse.JsonConverters.VerifyResultVerdictJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.VerifyResultVerdict Verdict { get; set; }

        /// <summary>
        /// Confidence in the verdict (0 to 1): how firmly the detected signals support the verdict bucket, independent of the doctoring likelihood itself<br/>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// Likelihood (0 to 1) that a real captured document was locally edited — a genuine capture with regions altered after the fact. Null for jobs completed before this score was introduced
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tampering_score")]
        public double? TamperingScore { get; set; }

        /// <summary>
        /// Likelihood (0 to 1) that the document is wholly generated or fabricated rather than a capture of a real document. Null for jobs completed before this score was introduced
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("synthetic_score")]
        public double? SyntheticScore { get; set; }

        /// <summary>
        /// Composite scores, each answering one question about the document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("composite_scores")]
        public global::LlamaParse.VerifyCompositeScores? CompositeScores { get; set; }

        /// <summary>
        /// Regions that led to the suspected fraud, ranked most-suspect first, each with an explanation of what makes it suspect
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suspect_regions")]
        public global::System.Collections.Generic.IList<global::LlamaParse.VerifySuspectRegion>? SuspectRegions { get; set; }

        /// <summary>
        /// Explanation of the verdict
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public string? Reasoning { get; set; }

        /// <summary>
        /// Worker-side error detail, if any
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Version of the detector that produced the result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detector_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DetectorVersion { get; set; }

        /// <summary>
        /// Number of analysed pages (1 for images/docx)<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_count")]
        public int? PageCount { get; set; }

        /// <summary>
        /// Rendered pixel size per page, so region bboxes can be scaled onto the page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_dimensions")]
        public global::System.Collections.Generic.IList<global::LlamaParse.VerifyPageDimension>? PageDimensions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyResult" /> class.
        /// </summary>
        /// <param name="overallScore">
        /// Overall doctoring likelihood (0 to 1)
        /// </param>
        /// <param name="verdict">
        /// Overall verdict for the document
        /// </param>
        /// <param name="detectorVersion">
        /// Version of the detector that produced the result
        /// </param>
        /// <param name="confidence">
        /// Confidence in the verdict (0 to 1): how firmly the detected signals support the verdict bucket, independent of the doctoring likelihood itself<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="tamperingScore">
        /// Likelihood (0 to 1) that a real captured document was locally edited — a genuine capture with regions altered after the fact. Null for jobs completed before this score was introduced
        /// </param>
        /// <param name="syntheticScore">
        /// Likelihood (0 to 1) that the document is wholly generated or fabricated rather than a capture of a real document. Null for jobs completed before this score was introduced
        /// </param>
        /// <param name="compositeScores">
        /// Composite scores, each answering one question about the document
        /// </param>
        /// <param name="suspectRegions">
        /// Regions that led to the suspected fraud, ranked most-suspect first, each with an explanation of what makes it suspect
        /// </param>
        /// <param name="reasoning">
        /// Explanation of the verdict
        /// </param>
        /// <param name="error">
        /// Worker-side error detail, if any
        /// </param>
        /// <param name="pageCount">
        /// Number of analysed pages (1 for images/docx)<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="pageDimensions">
        /// Rendered pixel size per page, so region bboxes can be scaled onto the page
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VerifyResult(
            double overallScore,
            global::LlamaParse.VerifyResultVerdict verdict,
            string detectorVersion,
            double? confidence,
            double? tamperingScore,
            double? syntheticScore,
            global::LlamaParse.VerifyCompositeScores? compositeScores,
            global::System.Collections.Generic.IList<global::LlamaParse.VerifySuspectRegion>? suspectRegions,
            string? reasoning,
            string? error,
            int? pageCount,
            global::System.Collections.Generic.IList<global::LlamaParse.VerifyPageDimension>? pageDimensions)
        {
            this.OverallScore = overallScore;
            this.Verdict = verdict;
            this.Confidence = confidence;
            this.TamperingScore = tamperingScore;
            this.SyntheticScore = syntheticScore;
            this.CompositeScores = compositeScores;
            this.SuspectRegions = suspectRegions;
            this.Reasoning = reasoning;
            this.Error = error;
            this.DetectorVersion = detectorVersion ?? throw new global::System.ArgumentNullException(nameof(detectorVersion));
            this.PageCount = pageCount;
            this.PageDimensions = pageDimensions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyResult" /> class.
        /// </summary>
        public VerifyResult()
        {
        }

    }
}