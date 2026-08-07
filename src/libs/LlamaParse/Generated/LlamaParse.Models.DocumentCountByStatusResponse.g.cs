
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Counts of the documents in a pipeline, grouped by ingestion status.
    /// </summary>
    public sealed partial class DocumentCountByStatusResponse
    {
        /// <summary>
        /// Number of documents per ingestion status; every status is present.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("counts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, int> Counts { get; set; }

        /// <summary>
        /// Total number of documents counted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// ID of the pipeline the documents belong to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipeline_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid PipelineId { get; set; }

        /// <summary>
        /// File the counts were restricted to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public global::System.Guid? FileId { get; set; }

        /// <summary>
        /// Data source the counts were restricted to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_source_id")]
        public global::System.Guid? DataSourceId { get; set; }

        /// <summary>
        /// Whether only directly uploaded documents were counted.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("only_direct_upload")]
        public bool? OnlyDirectUpload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentCountByStatusResponse" /> class.
        /// </summary>
        /// <param name="counts">
        /// Number of documents per ingestion status; every status is present.
        /// </param>
        /// <param name="totalCount">
        /// Total number of documents counted.
        /// </param>
        /// <param name="pipelineId">
        /// ID of the pipeline the documents belong to.
        /// </param>
        /// <param name="fileId">
        /// File the counts were restricted to.
        /// </param>
        /// <param name="dataSourceId">
        /// Data source the counts were restricted to.
        /// </param>
        /// <param name="onlyDirectUpload">
        /// Whether only directly uploaded documents were counted.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentCountByStatusResponse(
            global::System.Collections.Generic.Dictionary<string, int> counts,
            int totalCount,
            global::System.Guid pipelineId,
            global::System.Guid? fileId,
            global::System.Guid? dataSourceId,
            bool? onlyDirectUpload)
        {
            this.Counts = counts ?? throw new global::System.ArgumentNullException(nameof(counts));
            this.TotalCount = totalCount;
            this.PipelineId = pipelineId;
            this.FileId = fileId;
            this.DataSourceId = dataSourceId;
            this.OnlyDirectUpload = onlyDirectUpload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentCountByStatusResponse" /> class.
        /// </summary>
        public DocumentCountByStatusResponse()
        {
        }

    }
}