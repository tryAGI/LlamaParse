#nullable enable

namespace LlamaParse
{
    public partial interface IV2Client
    {
        /// <summary>
        /// Change Extract Review Fields<br/>
        /// Beta: answers 403 until extract review is enabled for the caller and their organization.<br/>
        /// Confirm, correct, clear, restore or undo fields of a completed job.<br/>
        /// The changes apply in order, in one write. A job without a review gets one with<br/>
        /// the default settings, at revision 0. A path that is not a field of the job, or a<br/>
        /// value the field's schema refuses, answers 400 and changes nothing.<br/>
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
        global::System.Threading.Tasks.Task<global::LlamaParse.ExtractReviewResponse> ChangeExtractReviewFieldsApiV2ExtractJobIdReviewFieldsPostAsync(
            string jobId,

            global::LlamaParse.ExtractReviewFieldsRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change Extract Review Fields<br/>
        /// Beta: answers 403 until extract review is enabled for the caller and their organization.<br/>
        /// Confirm, correct, clear, restore or undo fields of a completed job.<br/>
        /// The changes apply in order, in one write. A job without a review gets one with<br/>
        /// the default settings, at revision 0. A path that is not a field of the job, or a<br/>
        /// value the field's schema refuses, answers 400 and changes nothing.<br/>
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
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.ExtractReviewResponse>> ChangeExtractReviewFieldsApiV2ExtractJobIdReviewFieldsPostAsResponseAsync(
            string jobId,

            global::LlamaParse.ExtractReviewFieldsRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change Extract Review Fields<br/>
        /// Beta: answers 403 until extract review is enabled for the caller and their organization.<br/>
        /// Confirm, correct, clear, restore or undo fields of a completed job.<br/>
        /// The changes apply in order, in one write. A job without a review gets one with<br/>
        /// the default settings, at revision 0. A path that is not a field of the job, or a<br/>
        /// value the field's schema refuses, answers 400 and changes nothing.<br/>
        /// A job that has not completed answers 409 with `code: job_not_reviewable`. A `revision` other than the review's latest answers 409 with `code: stale_revision` and the latest `revision`.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="revision">
        /// The review's revision as the caller last read it.
        /// </param>
        /// <param name="changes">
        /// Changes to apply, in order.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.ExtractReviewResponse> ChangeExtractReviewFieldsApiV2ExtractJobIdReviewFieldsPostAsync(
            string jobId,
            int revision,
            global::System.Collections.Generic.IList<global::LlamaParse.ExtractReviewFieldChange> changes,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}