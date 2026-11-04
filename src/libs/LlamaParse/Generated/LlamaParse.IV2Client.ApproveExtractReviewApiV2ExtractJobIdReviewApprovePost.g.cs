#nullable enable

namespace LlamaParse
{
    public partial interface IV2Client
    {
        /// <summary>
        /// Approve Extract Review<br/>
        /// Beta: answers 403 until extract review is enabled for the caller and their organization.<br/>
        /// Approve the reviewed result.<br/>
        /// While flagged fields nobody checked remain, answers 409 with `code: open_flags`<br/>
        /// and their `paths`, unless `sign_off` confirms them as part of approving.<br/>
        /// A job that has not completed answers 409 with `code: job_not_reviewable`. A `revision` other than the review's latest answers 409 with `code: stale_revision` and the latest `revision`.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.ExtractReviewResponse> ApproveExtractReviewApiV2ExtractJobIdReviewApprovePostAsync(
            string jobId,

            global::LlamaParse.ExtractReviewApproveRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Approve Extract Review<br/>
        /// Beta: answers 403 until extract review is enabled for the caller and their organization.<br/>
        /// Approve the reviewed result.<br/>
        /// While flagged fields nobody checked remain, answers 409 with `code: open_flags`<br/>
        /// and their `paths`, unless `sign_off` confirms them as part of approving.<br/>
        /// A job that has not completed answers 409 with `code: job_not_reviewable`. A `revision` other than the review's latest answers 409 with `code: stale_revision` and the latest `revision`.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.ExtractReviewResponse>> ApproveExtractReviewApiV2ExtractJobIdReviewApprovePostAsResponseAsync(
            string jobId,

            global::LlamaParse.ExtractReviewApproveRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Approve Extract Review<br/>
        /// Beta: answers 403 until extract review is enabled for the caller and their organization.<br/>
        /// Approve the reviewed result.<br/>
        /// While flagged fields nobody checked remain, answers 409 with `code: open_flags`<br/>
        /// and their `paths`, unless `sign_off` confirms them as part of approving.<br/>
        /// A job that has not completed answers 409 with `code: job_not_reviewable`. A `revision` other than the review's latest answers 409 with `code: stale_revision` and the latest `revision`.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="revision">
        /// The review's revision as the caller last read it.
        /// </param>
        /// <param name="signOff">
        /// Confirm the flagged fields nobody checked as part of approving.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.ExtractReviewResponse> ApproveExtractReviewApiV2ExtractJobIdReviewApprovePostAsync(
            string jobId,
            int revision,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            bool? signOff = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}