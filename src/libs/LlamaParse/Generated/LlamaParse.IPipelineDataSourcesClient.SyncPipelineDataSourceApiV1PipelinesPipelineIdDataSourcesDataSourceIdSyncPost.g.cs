#nullable enable

namespace LlamaParse
{
    public partial interface IPipelineDataSourcesClient
    {
        /// <summary>
        /// Sync Pipeline Data Source<br/>
        /// Run incremental ingestion: pull upstream changes from the data source into the data sink.
        /// </summary>
        /// <param name="dataSourceId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.Pipeline> SyncPipelineDataSourceApiV1PipelinesPipelineIdDataSourcesDataSourceIdSyncPostAsync(
            global::System.Guid dataSourceId,
            global::System.Guid pipelineId,

            global::LlamaParse.DataSourceSyncRequest request,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sync Pipeline Data Source<br/>
        /// Run incremental ingestion: pull upstream changes from the data source into the data sink.
        /// </summary>
        /// <param name="dataSourceId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.Pipeline>> SyncPipelineDataSourceApiV1PipelinesPipelineIdDataSourcesDataSourceIdSyncPostAsResponseAsync(
            global::System.Guid dataSourceId,
            global::System.Guid pipelineId,

            global::LlamaParse.DataSourceSyncRequest request,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sync Pipeline Data Source<br/>
        /// Run incremental ingestion: pull upstream changes from the data source into the data sink.
        /// </summary>
        /// <param name="dataSourceId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.Pipeline> SyncPipelineDataSourceApiV1PipelinesPipelineIdDataSourcesDataSourceIdSyncPostAsync(
            global::System.Guid dataSourceId,
            global::System.Guid pipelineId,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}