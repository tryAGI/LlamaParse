#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace LlamaParse
{
    public partial interface IV2Client
    {
        /// <summary>
        /// List Extract Jobs<br/>
        /// List extraction jobs with optional filtering and pagination.<br/>
        /// Filter by `configuration_id`, `status`, `file_input`,<br/>
        /// or creation date range. Results are returned newest-first.<br/>
        /// Use `expand=configuration` to include the full configuration used,<br/>
        /// and `expand=extract_metadata` for per-field metadata.
        /// </summary>
        /// <param name="documentInputType">
        /// Filter by document input type (file_id or parse_job_id)
        /// </param>
        /// <param name="fileInput">
        /// Filter by file input value
        /// </param>
        /// <param name="documentInputValue">
        /// Deprecated: use file_input instead
        /// </param>
        /// <param name="status">
        /// Filter by status
        /// </param>
        /// <param name="pageSize">
        /// Number of items per page
        /// </param>
        /// <param name="pageToken">
        /// Token for pagination
        /// </param>
        /// <param name="jobIds">
        /// Filter by specific job IDs
        /// </param>
        /// <param name="expand">
        /// Additional fields to include: configuration, extract_metadata
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="configurationId">
        /// Filter by configuration ID
        /// </param>
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
        global::System.Threading.Tasks.Task<global::LlamaParse.ExtractV2JobQueryResponse> ListExtractJobsApiV2ExtractGetAsync(
            string? documentInputType = default,
            string? fileInput = default,
            string? documentInputValue = default,
            global::LlamaParse.ListExtractJobsApiV2ExtractGetStatus2? status = default,
            int? pageSize = default,
            string? pageToken = default,
            global::System.Collections.Generic.IList<string>? jobIds = default,
            global::System.Collections.Generic.IList<string>? expand = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? configurationId = default,
            global::System.DateTime? createdAtOnOrAfter = default,
            global::System.DateTime? createdAtOnOrBefore = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Extract Jobs<br/>
        /// List extraction jobs with optional filtering and pagination.<br/>
        /// Filter by `configuration_id`, `status`, `file_input`,<br/>
        /// or creation date range. Results are returned newest-first.<br/>
        /// Use `expand=configuration` to include the full configuration used,<br/>
        /// and `expand=extract_metadata` for per-field metadata.
        /// </summary>
        /// <param name="documentInputType">
        /// Filter by document input type (file_id or parse_job_id)
        /// </param>
        /// <param name="fileInput">
        /// Filter by file input value
        /// </param>
        /// <param name="documentInputValue">
        /// Deprecated: use file_input instead
        /// </param>
        /// <param name="status">
        /// Filter by status
        /// </param>
        /// <param name="pageSize">
        /// Number of items per page
        /// </param>
        /// <param name="pageToken">
        /// Token for pagination
        /// </param>
        /// <param name="jobIds">
        /// Filter by specific job IDs
        /// </param>
        /// <param name="expand">
        /// Additional fields to include: configuration, extract_metadata
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="configurationId">
        /// Filter by configuration ID
        /// </param>
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
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.ExtractV2JobQueryResponse>> ListExtractJobsApiV2ExtractGetAsResponseAsync(
            string? documentInputType = default,
            string? fileInput = default,
            string? documentInputValue = default,
            global::LlamaParse.ListExtractJobsApiV2ExtractGetStatus2? status = default,
            int? pageSize = default,
            string? pageToken = default,
            global::System.Collections.Generic.IList<string>? jobIds = default,
            global::System.Collections.Generic.IList<string>? expand = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? configurationId = default,
            global::System.DateTime? createdAtOnOrAfter = default,
            global::System.DateTime? createdAtOnOrBefore = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}