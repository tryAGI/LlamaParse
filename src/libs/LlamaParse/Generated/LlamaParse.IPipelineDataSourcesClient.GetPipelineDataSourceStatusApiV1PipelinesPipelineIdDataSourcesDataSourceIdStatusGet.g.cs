#nullable enable

namespace LlamaParse
{
    public partial interface IPipelineDataSourcesClient
    {
        /// <summary>
        /// Get Pipeline Data Source Status<br/>
        /// Get the status of a data source for a pipeline.
        /// </summary>
        /// <param name="dataSourceId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.ManagedIngestionStatusResponse> GetPipelineDataSourceStatusApiV1PipelinesPipelineIdDataSourcesDataSourceIdStatusGetAsync(
            global::System.Guid dataSourceId,
            global::System.Guid pipelineId,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}