#nullable enable

namespace LlamaParse
{
    public partial interface IAlphaClient
    {
        /// <summary>
        /// List Verify Jobs<br/>
        /// List Verify jobs with optional filtering and pagination.<br/>
        /// Filter by `status`, specific `job_ids`, or creation date range.
        /// </summary>
        /// <param name="pageSize">
        /// Number of items per page
        /// </param>
        /// <param name="pageToken">
        /// Token for pagination
        /// </param>
        /// <param name="status">
        /// Filter by job status
        /// </param>
        /// <param name="jobIds">
        /// Filter by specific job IDs
        /// </param>
        /// <param name="expand">
        /// Optional fields to include (e.g. `result`).
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.VerifyJobQueryResponse> ListVerifyJobsApiAlphaVerifyGetAsync(
            int? pageSize = default,
            string? pageToken = default,
            global::LlamaParse.ListVerifyJobsApiAlphaVerifyGetStatus2? status = default,
            global::System.Collections.Generic.IList<string>? jobIds = default,
            global::System.Collections.Generic.IList<string>? expand = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            global::System.DateTime? createdAtOnOrAfter = default,
            global::System.DateTime? createdAtOnOrBefore = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Verify Jobs<br/>
        /// List Verify jobs with optional filtering and pagination.<br/>
        /// Filter by `status`, specific `job_ids`, or creation date range.
        /// </summary>
        /// <param name="pageSize">
        /// Number of items per page
        /// </param>
        /// <param name="pageToken">
        /// Token for pagination
        /// </param>
        /// <param name="status">
        /// Filter by job status
        /// </param>
        /// <param name="jobIds">
        /// Filter by specific job IDs
        /// </param>
        /// <param name="expand">
        /// Optional fields to include (e.g. `result`).
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.VerifyJobQueryResponse>> ListVerifyJobsApiAlphaVerifyGetAsResponseAsync(
            int? pageSize = default,
            string? pageToken = default,
            global::LlamaParse.ListVerifyJobsApiAlphaVerifyGetStatus2? status = default,
            global::System.Collections.Generic.IList<string>? jobIds = default,
            global::System.Collections.Generic.IList<string>? expand = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            global::System.DateTime? createdAtOnOrAfter = default,
            global::System.DateTime? createdAtOnOrBefore = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}