#nullable enable

namespace LlamaParse
{
    public partial interface IV2Client
    {
        /// <summary>
        /// List Projects<br/>
        /// List projects in an organization. Requires `organization_id` or a project-scoped API key.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="name"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.ProjectQueryResponse> ListProjectsApiV2ProjectsGetAsync(
            string? organizationId = default,
            string? name = default,
            int? pageSize = default,
            string? pageToken = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Projects<br/>
        /// List projects in an organization. Requires `organization_id` or a project-scoped API key.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="name"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.ProjectQueryResponse>> ListProjectsApiV2ProjectsGetAsResponseAsync(
            string? organizationId = default,
            string? name = default,
            int? pageSize = default,
            string? pageToken = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}