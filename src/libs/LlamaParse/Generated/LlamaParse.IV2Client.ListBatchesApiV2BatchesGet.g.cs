#nullable enable

namespace LlamaParse
{
    public partial interface IV2Client
    {
        /// <summary>
        /// List Batches<br/>
        /// List batches for the current project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="createdAtOnOrAfter"></param>
        /// <param name="createdAtOnOrBefore"></param>
        /// <param name="status"></param>
        /// <param name="sourceDirectoryId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.BatchQueryResponse> ListBatchesApiV2BatchesGetAsync(
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            int? pageSize = default,
            string? pageToken = default,
            global::System.DateTime? createdAtOnOrAfter = default,
            global::System.DateTime? createdAtOnOrBefore = default,
            global::LlamaParse.ListBatchesApiV2BatchesGetStatus2? status = default,
            string? sourceDirectoryId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Batches<br/>
        /// List batches for the current project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="createdAtOnOrAfter"></param>
        /// <param name="createdAtOnOrBefore"></param>
        /// <param name="status"></param>
        /// <param name="sourceDirectoryId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.BatchQueryResponse>> ListBatchesApiV2BatchesGetAsResponseAsync(
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            int? pageSize = default,
            string? pageToken = default,
            global::System.DateTime? createdAtOnOrAfter = default,
            global::System.DateTime? createdAtOnOrBefore = default,
            global::LlamaParse.ListBatchesApiV2BatchesGetStatus2? status = default,
            string? sourceDirectoryId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}