#nullable enable

namespace LlamaParse
{
    public partial interface IV2Client
    {
        /// <summary>
        /// List Extract Review Events<br/>
        /// Beta: answers 403 until extract review is enabled for the caller and their organization.<br/>
        /// List a review's history, newest first.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="pageSize">
        /// Events per page.<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="pageToken">
        /// Token from the previous page.
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.ExtractReviewEventListResponse> ListExtractReviewEventsApiV2ExtractJobIdReviewEventsGetAsync(
            string jobId,
            int? pageSize = default,
            string? pageToken = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Extract Review Events<br/>
        /// Beta: answers 403 until extract review is enabled for the caller and their organization.<br/>
        /// List a review's history, newest first.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="pageSize">
        /// Events per page.<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="pageToken">
        /// Token from the previous page.
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.ExtractReviewEventListResponse>> ListExtractReviewEventsApiV2ExtractJobIdReviewEventsGetAsResponseAsync(
            string jobId,
            int? pageSize = default,
            string? pageToken = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}