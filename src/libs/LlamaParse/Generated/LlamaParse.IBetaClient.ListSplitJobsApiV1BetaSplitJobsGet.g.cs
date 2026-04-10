#nullable enable

namespace LlamaParse
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// List Split Jobs<br/>
        /// List document split jobs.
        /// </summary>
        /// <param name="status">
        /// Filter by job status (pending, processing, completed, failed, cancelled)
        /// </param>
        /// <param name="jobIds">
        /// Filter by specific job IDs
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="createdAtOnOrAfter">
        /// Include items created at or after this timestamp (inclusive)
        /// </param>
        /// <param name="createdAtOnOrBefore">
        /// Include items created at or before this timestamp (inclusive)
        /// </param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.SplitJobQueryResponse> ListSplitJobsApiV1BetaSplitJobsGetAsync(
            global::LlamaParse.ListSplitJobsApiV1BetaSplitJobsGetStatus2? status = default,
            global::System.Collections.Generic.IList<string>? jobIds = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            int? pageSize = default,
            string? pageToken = default,
            global::System.DateTime? createdAtOnOrAfter = default,
            global::System.DateTime? createdAtOnOrBefore = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}