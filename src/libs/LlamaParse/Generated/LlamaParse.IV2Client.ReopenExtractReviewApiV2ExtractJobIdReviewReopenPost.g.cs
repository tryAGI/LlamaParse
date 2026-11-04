#nullable enable

namespace LlamaParse
{
    public partial interface IV2Client
    {
        /// <summary>
        /// Reopen Extract Review<br/>
        /// Beta: answers 403 until extract review is enabled for the caller and their organization.<br/>
        /// Put an approved or rejected review back to pending. Its field actions stay.<br/>
        /// A `revision` other than the review's latest answers 409 with `code: stale_revision` and the latest `revision`.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.ExtractReviewResponse> ReopenExtractReviewApiV2ExtractJobIdReviewReopenPostAsync(
            string jobId,

            global::LlamaParse.ExtractReviewRevisionRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reopen Extract Review<br/>
        /// Beta: answers 403 until extract review is enabled for the caller and their organization.<br/>
        /// Put an approved or rejected review back to pending. Its field actions stay.<br/>
        /// A `revision` other than the review's latest answers 409 with `code: stale_revision` and the latest `revision`.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.ExtractReviewResponse>> ReopenExtractReviewApiV2ExtractJobIdReviewReopenPostAsResponseAsync(
            string jobId,

            global::LlamaParse.ExtractReviewRevisionRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reopen Extract Review<br/>
        /// Beta: answers 403 until extract review is enabled for the caller and their organization.<br/>
        /// Put an approved or rejected review back to pending. Its field actions stay.<br/>
        /// A `revision` other than the review's latest answers 409 with `code: stale_revision` and the latest `revision`.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="revision">
        /// The review's revision as the caller last read it.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.ExtractReviewResponse> ReopenExtractReviewApiV2ExtractJobIdReviewReopenPostAsync(
            string jobId,
            int revision,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}