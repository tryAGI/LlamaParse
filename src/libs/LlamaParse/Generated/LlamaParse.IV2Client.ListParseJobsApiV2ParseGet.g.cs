#nullable enable

namespace LlamaParse
{
    public partial interface IV2Client
    {
        /// <summary>
        /// List Parse Jobs<br/>
        /// List parse jobs for the current project.<br/>
        /// Filter by `status` or creation date range. Results are<br/>
        /// paginated — use `page_token` from the response to fetch<br/>
        /// subsequent pages.
        /// </summary>
        /// <param name="pageSize">
        /// Number of items per page
        /// </param>
        /// <param name="pageToken">
        /// Token for pagination
        /// </param>
        /// <param name="status">
        /// Filter by job status (PENDING, RUNNING, COMPLETED, FAILED, CANCELLED)
        /// </param>
        /// <param name="jobIds">
        /// Filter by specific job IDs
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="createdAtOnOrAfter">
        /// Include items created at or after this timestamp (inclusive)
        /// </param>
        /// <param name="createdAtOnOrBefore">
        /// Include items created at or before this timestamp (inclusive)
        /// </param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.ParseJobQueryResponse> ListParseJobsApiV2ParseGetAsync(
            int? pageSize = default,
            string? pageToken = default,
            global::LlamaParse.ListParseJobsApiV2ParseGetStatus2? status = default,
            global::System.Collections.Generic.IList<string>? jobIds = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            global::System.DateTime? createdAtOnOrAfter = default,
            global::System.DateTime? createdAtOnOrBefore = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}