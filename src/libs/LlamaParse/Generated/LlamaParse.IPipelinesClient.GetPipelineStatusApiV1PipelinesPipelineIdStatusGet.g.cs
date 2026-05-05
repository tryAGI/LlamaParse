#nullable enable

namespace LlamaParse
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Get Pipeline Status<br/>
        /// Get the ingestion status of a managed pipeline.<br/>
        /// Returns document counts, sync progress, and the last<br/>
        /// effective timestamp. Only available for managed pipelines.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="fullDetails"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.ManagedIngestionStatusResponse> GetPipelineStatusApiV1PipelinesPipelineIdStatusGetAsync(
            global::System.Guid pipelineId,
            bool? fullDetails = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Pipeline Status<br/>
        /// Get the ingestion status of a managed pipeline.<br/>
        /// Returns document counts, sync progress, and the last<br/>
        /// effective timestamp. Only available for managed pipelines.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="fullDetails"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.ManagedIngestionStatusResponse>> GetPipelineStatusApiV1PipelinesPipelineIdStatusGetAsResponseAsync(
            global::System.Guid pipelineId,
            bool? fullDetails = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}