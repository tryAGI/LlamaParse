#nullable enable

namespace LlamaParse
{
    public partial interface IJobDashboardClient
    {
        /// <summary>
        /// Query project job data points<br/>
        /// Returns paginated job data points for the current project.
        /// </summary>
        /// <param name="jobType">
        /// Job type to query.
        /// </param>
        /// <param name="hours">
        /// Hours of history to include.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="status">
        /// Filter by status.
        /// </param>
        /// <param name="pageSize">
        /// Number of items per page.
        /// </param>
        /// <param name="pageToken">
        /// Cursor token for the next page.
        /// </param>
        /// <param name="createdAtOnOrAfter">
        /// Include items created at or after this timestamp (inclusive)
        /// </param>
        /// <param name="createdAtOnOrBefore">
        /// Include items created at or before this timestamp (inclusive)
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.JobDataPointResponse> ListProjectJobDataPointsApiV1JobDataPointsGetAsync(
            global::LlamaParse.ListProjectJobDataPointsApiV1JobDataPointsGetJobType jobType,
            int? hours = default,
            global::System.Collections.Generic.IList<string>? status = default,
            int? pageSize = default,
            string? pageToken = default,
            global::System.DateTime? createdAtOnOrAfter = default,
            global::System.DateTime? createdAtOnOrBefore = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query project job data points<br/>
        /// Returns paginated job data points for the current project.
        /// </summary>
        /// <param name="jobType">
        /// Job type to query.
        /// </param>
        /// <param name="hours">
        /// Hours of history to include.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="status">
        /// Filter by status.
        /// </param>
        /// <param name="pageSize">
        /// Number of items per page.
        /// </param>
        /// <param name="pageToken">
        /// Cursor token for the next page.
        /// </param>
        /// <param name="createdAtOnOrAfter">
        /// Include items created at or after this timestamp (inclusive)
        /// </param>
        /// <param name="createdAtOnOrBefore">
        /// Include items created at or before this timestamp (inclusive)
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.JobDataPointResponse>> ListProjectJobDataPointsApiV1JobDataPointsGetAsResponseAsync(
            global::LlamaParse.ListProjectJobDataPointsApiV1JobDataPointsGetJobType jobType,
            int? hours = default,
            global::System.Collections.Generic.IList<string>? status = default,
            int? pageSize = default,
            string? pageToken = default,
            global::System.DateTime? createdAtOnOrAfter = default,
            global::System.DateTime? createdAtOnOrBefore = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}