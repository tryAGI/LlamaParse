#nullable enable

namespace LlamaParse
{
    public partial interface IAlphaClient
    {
        /// <summary>
        /// Get Verify Job<br/>
        /// Get a Verify job by ID.<br/>
        /// Returns the job status and configuration. Pass `expand=result`<br/>
        /// to include the Verify result (overall score, verdict, confidence,<br/>
        /// composite scores, and suspect regions) when the job is complete.<br/>
        /// Raw per-signal detail is available via `GET /verify/{job_id}/details`.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="expand">
        /// Optional fields to include (e.g. `result`).
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.VerifyJobResponse> GetVerifyJobApiAlphaVerifyJobIdGetAsync(
            string jobId,
            global::System.Collections.Generic.IList<string>? expand = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Verify Job<br/>
        /// Get a Verify job by ID.<br/>
        /// Returns the job status and configuration. Pass `expand=result`<br/>
        /// to include the Verify result (overall score, verdict, confidence,<br/>
        /// composite scores, and suspect regions) when the job is complete.<br/>
        /// Raw per-signal detail is available via `GET /verify/{job_id}/details`.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="expand">
        /// Optional fields to include (e.g. `result`).
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.VerifyJobResponse>> GetVerifyJobApiAlphaVerifyJobIdGetAsResponseAsync(
            string jobId,
            global::System.Collections.Generic.IList<string>? expand = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}