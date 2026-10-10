#nullable enable

namespace LlamaParse
{
    public partial interface IAlphaClient
    {
        /// <summary>
        /// Cancel Verify Job<br/>
        /// Cancel a running Verify job.<br/>
        /// Stops processing and marks the job as CANCELLED. Returns the updated job. Jobs already in a terminal state (COMPLETED, FAILED, CANCELLED) cannot be cancelled.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.VerifyJobResponse> CancelVerifyJobApiAlphaVerifyJobIdCancelPostAsync(
            string jobId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel Verify Job<br/>
        /// Cancel a running Verify job.<br/>
        /// Stops processing and marks the job as CANCELLED. Returns the updated job. Jobs already in a terminal state (COMPLETED, FAILED, CANCELLED) cannot be cancelled.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.VerifyJobResponse>> CancelVerifyJobApiAlphaVerifyJobIdCancelPostAsResponseAsync(
            string jobId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}