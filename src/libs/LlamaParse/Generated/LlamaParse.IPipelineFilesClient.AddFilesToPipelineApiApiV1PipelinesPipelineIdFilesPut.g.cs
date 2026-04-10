#nullable enable

namespace LlamaParse
{
    public partial interface IPipelineFilesClient
    {
        /// <summary>
        /// Add Files To Pipeline Api<br/>
        /// Add files to a pipeline.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LlamaParse.PipelineFile>> AddFilesToPipelineApiApiV1PipelinesPipelineIdFilesPutAsync(
            global::System.Guid pipelineId,

            global::System.Collections.Generic.IList<global::LlamaParse.PipelineFileCreate> request,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}