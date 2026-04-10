#nullable enable

namespace LlamaParse
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Create Pipeline<br/>
        /// Create a new managed ingestion pipeline.<br/>
        /// A pipeline connects data sources to a vector store for RAG.<br/>
        /// After creation, call `POST /pipelines/{id}/sync` to start<br/>
        /// ingesting documents.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.Pipeline> CreatePipelineApiV1PipelinesPostAsync(

            global::LlamaParse.PipelineCreate request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Pipeline<br/>
        /// Create a new managed ingestion pipeline.<br/>
        /// A pipeline connects data sources to a vector store for RAG.<br/>
        /// After creation, call `POST /pipelines/{id}/sync` to start<br/>
        /// ingesting documents.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="embeddingConfig"></param>
        /// <param name="transformConfig">
        /// Configuration for the transformation.
        /// </param>
        /// <param name="sparseModelConfig">
        /// Configuration for the sparse model used in hybrid search.
        /// </param>
        /// <param name="dataSinkId">
        /// Data sink ID. When provided instead of data_sink, the data sink will be looked up by ID.
        /// </param>
        /// <param name="embeddingModelConfigId">
        /// Embedding model config ID. When provided instead of embedding_config, the embedding model config will be looked up by ID.
        /// </param>
        /// <param name="dataSink">
        /// Data sink. When provided instead of data_sink_id, the data sink will be created.
        /// </param>
        /// <param name="presetRetrievalParameters">
        /// Preset retrieval parameters for the pipeline.
        /// </param>
        /// <param name="llamaParseParameters">
        /// Settings that can be configured for how to use LlamaParse to parse files within a LlamaCloud pipeline.
        /// </param>
        /// <param name="status">
        /// Status of the pipeline deployment.
        /// </param>
        /// <param name="metadataConfig">
        /// Metadata configuration for the pipeline.
        /// </param>
        /// <param name="name"></param>
        /// <param name="pipelineType">
        /// Type of pipeline. Either PLAYGROUND or MANAGED.<br/>
        /// Default Value: MANAGED
        /// </param>
        /// <param name="managedPipelineId">
        /// The ID of the ManagedPipeline this playground pipeline is linked to.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.Pipeline> CreatePipelineApiV1PipelinesPostAsync(
            string name,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.EmbeddingConfigVariant12? embeddingConfig = default,
            global::LlamaParse.AnyOf<global::LlamaParse.AutoTransformConfig, global::LlamaParse.AdvancedModeTransformConfig, object>? transformConfig = default,
            global::LlamaParse.SparseModelConfig? sparseModelConfig = default,
            global::System.Guid? dataSinkId = default,
            global::System.Guid? embeddingModelConfigId = default,
            global::LlamaParse.DataSinkCreate? dataSink = default,
            global::LlamaParse.PresetRetrievalParams? presetRetrievalParameters = default,
            global::LlamaParse.LlamaParseParameters? llamaParseParameters = default,
            string? status = default,
            global::LlamaParse.PipelineMetadataConfig2? metadataConfig = default,
            global::LlamaParse.PipelineType? pipelineType = default,
            global::System.Guid? managedPipelineId = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}