#nullable enable

namespace LlamaParse
{
    public partial interface IV2Client
    {
        /// <summary>
        /// Cancel Batch<br/>
        /// Cancel a running batch.<br/>
        /// Returns immediately; the batch reaches `CANCELLED` once processing stops.<br/>
        /// Files that already finished keep their results. A batch in a terminal<br/>
        /// status cannot be cancelled.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.BatchResponse> CancelBatchApiV2BatchesBatchIdCancelPostAsync(
            string batchId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel Batch<br/>
        /// Cancel a running batch.<br/>
        /// Returns immediately; the batch reaches `CANCELLED` once processing stops.<br/>
        /// Files that already finished keep their results. A batch in a terminal<br/>
        /// status cannot be cancelled.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.BatchResponse>> CancelBatchApiV2BatchesBatchIdCancelPostAsResponseAsync(
            string batchId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}