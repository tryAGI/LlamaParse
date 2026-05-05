#nullable enable

namespace LlamaParse
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Cancel Pipeline Sync<br/>
        /// Cancel all running sync jobs for a pipeline.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.Pipeline> CancelPipelineSyncApiV1PipelinesPipelineIdSyncCancelPostAsync(
            global::System.Guid pipelineId,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel Pipeline Sync<br/>
        /// Cancel all running sync jobs for a pipeline.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.Pipeline>> CancelPipelineSyncApiV1PipelinesPipelineIdSyncCancelPostAsResponseAsync(
            global::System.Guid pipelineId,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}