#nullable enable

namespace LlamaParse
{
    public partial interface IIndexesClient
    {
        /// <summary>
        /// List Indexes<br/>
        /// List indexes for the current project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="sourceDirectoryId"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.IndexQueryResponse> ListIndexesApiV1IndexesGetAsync(
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? sourceDirectoryId = default,
            int? pageSize = default,
            string? pageToken = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Indexes<br/>
        /// List indexes for the current project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="sourceDirectoryId"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.IndexQueryResponse>> ListIndexesApiV1IndexesGetAsResponseAsync(
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? sourceDirectoryId = default,
            int? pageSize = default,
            string? pageToken = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}