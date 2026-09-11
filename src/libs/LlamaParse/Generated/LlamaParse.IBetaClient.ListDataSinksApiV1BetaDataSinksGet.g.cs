#nullable enable

namespace LlamaParse
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// List Data Sinks<br/>
        /// List the data sinks in a project, newest first.
        /// </summary>
        /// <param name="pageSize">
        /// Number of items per page<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="pageToken">
        /// Cursor from the previous page's `next_page_token`.
        /// </param>
        /// <param name="includeTotal">
        /// Return `total_size`, a count of every row matching the filter. It is a second query on every page, so it is off unless asked for.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.DataSinkQueryResponse> ListDataSinksApiV1BetaDataSinksGetAsync(
            int? pageSize = default,
            string? pageToken = default,
            bool? includeTotal = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Data Sinks<br/>
        /// List the data sinks in a project, newest first.
        /// </summary>
        /// <param name="pageSize">
        /// Number of items per page<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="pageToken">
        /// Cursor from the previous page's `next_page_token`.
        /// </param>
        /// <param name="includeTotal">
        /// Return `total_size`, a count of every row matching the filter. It is a second query on every page, so it is off unless asked for.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.DataSinkQueryResponse>> ListDataSinksApiV1BetaDataSinksGetAsResponseAsync(
            int? pageSize = default,
            string? pageToken = default,
            bool? includeTotal = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}