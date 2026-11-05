#nullable enable

namespace LlamaParse
{
    public partial interface IV2Client
    {
        /// <summary>
        /// Reject Extract Review<br/>
        /// Beta: answers 403 until extract review is enabled for the caller and their organization.<br/>
        /// Reject the result, with a reason. A job that failed or was cancelled can be rejected,<br/>
        /// which closes a review turned on while it ran. A job still queued or running answers<br/>
        /// 409 with `code: job_not_reviewable`. A `revision` other than the review's latest answers 409 with `code: stale_revision` and the latest `revision`.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.ExtractReviewResponse> RejectExtractReviewApiV2ExtractJobIdReviewRejectPostAsync(
            string jobId,

            global::LlamaParse.ExtractReviewRejectRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reject Extract Review<br/>
        /// Beta: answers 403 until extract review is enabled for the caller and their organization.<br/>
        /// Reject the result, with a reason. A job that failed or was cancelled can be rejected,<br/>
        /// which closes a review turned on while it ran. A job still queued or running answers<br/>
        /// 409 with `code: job_not_reviewable`. A `revision` other than the review's latest answers 409 with `code: stale_revision` and the latest `revision`.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.ExtractReviewResponse>> RejectExtractReviewApiV2ExtractJobIdReviewRejectPostAsResponseAsync(
            string jobId,

            global::LlamaParse.ExtractReviewRejectRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reject Extract Review<br/>
        /// Beta: answers 403 until extract review is enabled for the caller and their organization.<br/>
        /// Reject the result, with a reason. A job that failed or was cancelled can be rejected,<br/>
        /// which closes a review turned on while it ran. A job still queued or running answers<br/>
        /// 409 with `code: job_not_reviewable`. A `revision` other than the review's latest answers 409 with `code: stale_revision` and the latest `revision`.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="revision">
        /// The review's revision as the caller last read it.
        /// </param>
        /// <param name="reason">
        /// Why the result was rejected.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.ExtractReviewResponse> RejectExtractReviewApiV2ExtractJobIdReviewRejectPostAsync(
            string jobId,
            int revision,
            string reason,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}