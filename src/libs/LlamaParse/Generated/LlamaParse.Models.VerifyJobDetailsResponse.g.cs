
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Raw per-signal detail for a completed Verify job.<br/>
    /// Forensic drill-down behind the simplified result: the full evidence list,<br/>
    /// per-family sub-scores, raw localized regions, and heatmap overlays.
    /// </summary>
    public sealed partial class VerifyJobDetailsResponse
    {
        /// <summary>
        /// ID of the Verify job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JobId { get; set; }

        /// <summary>
        /// Per-family scores (metadata, ai_generation, splicing, copy_move, compression, noise, coherence, pdf_structure)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sub_scores")]
        public global::System.Collections.Generic.Dictionary<string, double>? SubScores { get; set; }

        /// <summary>
        /// Suspicious regions localized on rendered pages
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regions")]
        public global::System.Collections.Generic.IList<global::LlamaParse.VerifyRegion>? Regions { get; set; }

        /// <summary>
        /// Evidence items produced by detection tools
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evidence")]
        public global::System.Collections.Generic.IList<global::LlamaParse.VerifyEvidence>? Evidence { get; set; }

        /// <summary>
        /// Checks that could not run on this job (with the reason). A check listed here produced no findings because it could not run, not because the document is clean
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("degraded_tools")]
        public global::System.Collections.Generic.IList<global::LlamaParse.VerifyDegradedTool>? DegradedTools { get; set; }

        /// <summary>
        /// Per-page forensic heatmap overlays as presigned image URLs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("heatmaps")]
        public global::System.Collections.Generic.IList<global::LlamaParse.VerifyHeatmap>? Heatmaps { get; set; }

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
        /// Initializes a new instance of the <see cref="VerifyJobDetailsResponse" /> class.
        /// </summary>
        /// <param name="jobId">
        /// ID of the Verify job
        /// </param>
        /// <param name="subScores">
        /// Per-family scores (metadata, ai_generation, splicing, copy_move, compression, noise, coherence, pdf_structure)
        /// </param>
        /// <param name="regions">
        /// Suspicious regions localized on rendered pages
        /// </param>
        /// <param name="evidence">
        /// Evidence items produced by detection tools
        /// </param>
        /// <param name="degradedTools">
        /// Checks that could not run on this job (with the reason). A check listed here produced no findings because it could not run, not because the document is clean
        /// </param>
        /// <param name="heatmaps">
        /// Per-page forensic heatmap overlays as presigned image URLs
        /// </param>
        /// <param name="pageDimensions">
        /// Rendered pixel size per page, so region bboxes can be scaled onto the page
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VerifyJobDetailsResponse(
            string jobId,
            global::System.Collections.Generic.Dictionary<string, double>? subScores,
            global::System.Collections.Generic.IList<global::LlamaParse.VerifyRegion>? regions,
            global::System.Collections.Generic.IList<global::LlamaParse.VerifyEvidence>? evidence,
            global::System.Collections.Generic.IList<global::LlamaParse.VerifyDegradedTool>? degradedTools,
            global::System.Collections.Generic.IList<global::LlamaParse.VerifyHeatmap>? heatmaps,
            global::System.Collections.Generic.IList<global::LlamaParse.VerifyPageDimension>? pageDimensions)
        {
            this.JobId = jobId ?? throw new global::System.ArgumentNullException(nameof(jobId));
            this.SubScores = subScores;
            this.Regions = regions;
            this.Evidence = evidence;
            this.DegradedTools = degradedTools;
            this.Heatmaps = heatmaps;
            this.PageDimensions = pageDimensions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyJobDetailsResponse" /> class.
        /// </summary>
        public VerifyJobDetailsResponse()
        {
        }

    }
}