#nullable enable

namespace LlamaParse
{
    public partial interface ISplitClient
    {
        /// <summary>
        /// Cancel Split Job<br/>
        /// Cancel a running split job.<br/>
        /// Requests cancellation; the job transitions to CANCELLED asynchronously once processing stops. Returns the job, which may still be in its current non-terminal state. Jobs already in a terminal state (COMPLETED, FAILED, CANCELLED) cannot be cancelled.
        /// </summary>
        /// <param name="splitJobId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.SplitJobResponse> CancelSplitJobApiV1SplitJobsSplitJobIdCancelPostAsync(
            string splitJobId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel Split Job<br/>
        /// Cancel a running split job.<br/>
        /// Requests cancellation; the job transitions to CANCELLED asynchronously once processing stops. Returns the job, which may still be in its current non-terminal state. Jobs already in a terminal state (COMPLETED, FAILED, CANCELLED) cannot be cancelled.
        /// </summary>
        /// <param name="splitJobId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.SplitJobResponse>> CancelSplitJobApiV1SplitJobsSplitJobIdCancelPostAsResponseAsync(
            string splitJobId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}