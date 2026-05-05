#nullable enable

namespace LlamaParse
{
    public partial interface ILlamaExtractClient
    {
        /// <summary>
        /// List Extract Runs
        /// </summary>
        /// <param name="extractionAgentId"></param>
        /// <param name="skip">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 25
        /// </param>
        /// <param name="status">
        /// Filter by status
        /// </param>
        /// <param name="runId">
        /// Filter by run ID
        /// </param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.PaginatedExtractRunsResponse> ListExtractRunsApiV1ExtractionRunsGetAsync(
            global::System.Guid extractionAgentId,
            int? skip = default,
            int? limit = default,
            string? status = default,
            string? runId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Extract Runs
        /// </summary>
        /// <param name="extractionAgentId"></param>
        /// <param name="skip">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 25
        /// </param>
        /// <param name="status">
        /// Filter by status
        /// </param>
        /// <param name="runId">
        /// Filter by run ID
        /// </param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.PaginatedExtractRunsResponse>> ListExtractRunsApiV1ExtractionRunsGetAsResponseAsync(
            global::System.Guid extractionAgentId,
            int? skip = default,
            int? limit = default,
            string? status = default,
            string? runId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}