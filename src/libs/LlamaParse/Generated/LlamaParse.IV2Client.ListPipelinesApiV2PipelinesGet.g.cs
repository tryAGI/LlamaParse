#nullable enable

namespace LlamaParse
{
    public partial interface IV2Client
    {
        /// <summary>
        /// List Pipelines<br/>
        /// List the pipelines in a project, newest first.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="name"></param>
        /// <param name="pipelineType"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.PipelineQueryResponse> ListPipelinesApiV2PipelinesGetAsync(
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? name = default,
            global::LlamaParse.ListPipelinesApiV2PipelinesGetPipelineType2? pipelineType = default,
            int? pageSize = default,
            string? pageToken = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Pipelines<br/>
        /// List the pipelines in a project, newest first.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="name"></param>
        /// <param name="pipelineType"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.PipelineQueryResponse>> ListPipelinesApiV2PipelinesGetAsResponseAsync(
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? name = default,
            global::LlamaParse.ListPipelinesApiV2PipelinesGetPipelineType2? pipelineType = default,
            int? pageSize = default,
            string? pageToken = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}