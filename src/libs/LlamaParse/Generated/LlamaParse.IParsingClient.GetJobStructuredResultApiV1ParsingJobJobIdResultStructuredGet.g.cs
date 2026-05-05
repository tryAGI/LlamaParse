#nullable enable

namespace LlamaParse
{
    public partial interface IParsingClient
    {
        /// <summary>
        /// Get Job Structured Result<br/>
        /// Get a job by id<br/>
        /// Note: The 'credits_used' and 'job_credits_usage' fields in the response metadata are deprecated<br/>
        /// and will be removed in a future release.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="organizationId"></param>
        /// <param name="projectId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.ParsingJobStructuredResult> GetJobStructuredResultApiV1ParsingJobJobIdResultStructuredGetAsync(
            string jobId,
            global::System.Guid? organizationId = default,
            global::System.Guid? projectId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Job Structured Result<br/>
        /// Get a job by id<br/>
        /// Note: The 'credits_used' and 'job_credits_usage' fields in the response metadata are deprecated<br/>
        /// and will be removed in a future release.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="organizationId"></param>
        /// <param name="projectId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.ParsingJobStructuredResult>> GetJobStructuredResultApiV1ParsingJobJobIdResultStructuredGetAsResponseAsync(
            string jobId,
            global::System.Guid? organizationId = default,
            global::System.Guid? projectId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}