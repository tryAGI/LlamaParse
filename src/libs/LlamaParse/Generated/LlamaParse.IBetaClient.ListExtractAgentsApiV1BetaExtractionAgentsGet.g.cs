#nullable enable

namespace LlamaParse
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// List Extract Agents<br/>
        /// List the extraction agents in a project, newest first.
        /// </summary>
        /// <param name="includeDefault">
        /// Whether to include default agents in the results<br/>
        /// Default Value: false
        /// </param>
        /// <param name="pageSize">
        /// Number of items per page<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="pageToken">
        /// Cursor from the previous page's `next_page_token`.
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.ExtractAgentQueryResponse> ListExtractAgentsApiV1BetaExtractionAgentsGetAsync(
            bool? includeDefault = default,
            int? pageSize = default,
            string? pageToken = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Extract Agents<br/>
        /// List the extraction agents in a project, newest first.
        /// </summary>
        /// <param name="includeDefault">
        /// Whether to include default agents in the results<br/>
        /// Default Value: false
        /// </param>
        /// <param name="pageSize">
        /// Number of items per page<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="pageToken">
        /// Cursor from the previous page's `next_page_token`.
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.ExtractAgentQueryResponse>> ListExtractAgentsApiV1BetaExtractionAgentsGetAsResponseAsync(
            bool? includeDefault = default,
            int? pageSize = default,
            string? pageToken = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}