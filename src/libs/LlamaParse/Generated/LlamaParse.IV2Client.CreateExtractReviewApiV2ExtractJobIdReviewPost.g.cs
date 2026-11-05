#nullable enable

namespace LlamaParse
{
    public partial interface IV2Client
    {
        /// <summary>
        /// Create Extract Review<br/>
        /// Beta: answers 403 until extract review is enabled for the caller and their organization.<br/>
        /// Turn review on for an extract job.<br/>
        /// Fields read below `confidence_threshold`, and required fields left empty, are<br/>
        /// flagged for a person to check. Every setting has a default, so the body can be<br/>
        /// left out. A job still running can be named: it waits for review once it<br/>
        /// completes. A job that failed or was cancelled without a review, or that cannot<br/>
        /// be reviewed, answers 409 with `code: job_not_reviewable`; a field in<br/>
        /// `fields_in_scope` the job's schema does not have answers 400.<br/>
        /// Answers 201 with the new review, or 200 with the job's existing review, whose<br/>
        /// settings stay as they are.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="origin">
        /// Where in the app review was turned on.
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.ExtractReviewResponse> CreateExtractReviewApiV2ExtractJobIdReviewPostAsync(
            string jobId,

            global::LlamaParse.ExtractReviewCreateRequest request,
            global::LlamaParse.CreateExtractReviewApiV2ExtractJobIdReviewPostOrigin? origin = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Extract Review<br/>
        /// Beta: answers 403 until extract review is enabled for the caller and their organization.<br/>
        /// Turn review on for an extract job.<br/>
        /// Fields read below `confidence_threshold`, and required fields left empty, are<br/>
        /// flagged for a person to check. Every setting has a default, so the body can be<br/>
        /// left out. A job still running can be named: it waits for review once it<br/>
        /// completes. A job that failed or was cancelled without a review, or that cannot<br/>
        /// be reviewed, answers 409 with `code: job_not_reviewable`; a field in<br/>
        /// `fields_in_scope` the job's schema does not have answers 400.<br/>
        /// Answers 201 with the new review, or 200 with the job's existing review, whose<br/>
        /// settings stay as they are.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="origin">
        /// Where in the app review was turned on.
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.ExtractReviewResponse>> CreateExtractReviewApiV2ExtractJobIdReviewPostAsResponseAsync(
            string jobId,

            global::LlamaParse.ExtractReviewCreateRequest request,
            global::LlamaParse.CreateExtractReviewApiV2ExtractJobIdReviewPostOrigin? origin = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Extract Review<br/>
        /// Beta: answers 403 until extract review is enabled for the caller and their organization.<br/>
        /// Turn review on for an extract job.<br/>
        /// Fields read below `confidence_threshold`, and required fields left empty, are<br/>
        /// flagged for a person to check. Every setting has a default, so the body can be<br/>
        /// left out. A job still running can be named: it waits for review once it<br/>
        /// completes. A job that failed or was cancelled without a review, or that cannot<br/>
        /// be reviewed, answers 409 with `code: job_not_reviewable`; a field in<br/>
        /// `fields_in_scope` the job's schema does not have answers 400.<br/>
        /// Answers 201 with the new review, or 200 with the job's existing review, whose<br/>
        /// settings stay as they are.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="origin">
        /// Where in the app review was turned on.
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="confidenceThreshold">
        /// Fields read below this confidence are flagged.<br/>
        /// Default Value: 0.7F
        /// </param>
        /// <param name="fieldsInScope">
        /// JSON Pointers of the fields the threshold applies to; empty means all.
        /// </param>
        /// <param name="requiredFields">
        /// JSON Pointers of fields flagged when empty; defaults to the schema's required.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.ExtractReviewResponse> CreateExtractReviewApiV2ExtractJobIdReviewPostAsync(
            string jobId,
            global::LlamaParse.CreateExtractReviewApiV2ExtractJobIdReviewPostOrigin? origin = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            double? confidenceThreshold = default,
            global::System.Collections.Generic.IList<string>? fieldsInScope = default,
            global::System.Collections.Generic.IList<string>? requiredFields = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}