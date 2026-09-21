#nullable enable

namespace LlamaParse
{
    public partial interface ISplitClient
    {
        /// <summary>
        /// Create Split Job<br/>
        /// Create a split job.<br/>
        /// ## Document input<br/>
        /// Set `file_input` to a file ID or a completed parse job ID (`pjb-...`). Supplying a parse job reuses its output instead of reading the document again.<br/>
        /// ## Page selection<br/>
        /// `configuration.target_pages` selects which pages of a supplied parse job to split (1-based; `1-50`, `1,3,5-7`). Pages are read in ascending document order, and each segment's `pages` are the parse job's own page numbers, so segments map straight back to the original document. Requires a parse job as `file_input`; passing it with a file ID returns 400.<br/>
        /// ## Parse settings<br/>
        /// `configuration.parse_tier` and `configuration.parse_config_id` control how the document is read before splitting; both are ignored when a parse job is supplied. A parse configuration restricted to a page subset (`target_pages` or `max_pages`) is rejected, since split results always number pages relative to the full document.<br/>
        /// The job runs asynchronously. Poll `GET /split/jobs/{split_job_id}` or register a webhook to monitor completion.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.SplitJobResponse> CreateSplitJobApiV1SplitJobsPostAsync(

            global::LlamaParse.SplitCreateRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Split Job<br/>
        /// Create a split job.<br/>
        /// ## Document input<br/>
        /// Set `file_input` to a file ID or a completed parse job ID (`pjb-...`). Supplying a parse job reuses its output instead of reading the document again.<br/>
        /// ## Page selection<br/>
        /// `configuration.target_pages` selects which pages of a supplied parse job to split (1-based; `1-50`, `1,3,5-7`). Pages are read in ascending document order, and each segment's `pages` are the parse job's own page numbers, so segments map straight back to the original document. Requires a parse job as `file_input`; passing it with a file ID returns 400.<br/>
        /// ## Parse settings<br/>
        /// `configuration.parse_tier` and `configuration.parse_config_id` control how the document is read before splitting; both are ignored when a parse job is supplied. A parse configuration restricted to a page subset (`target_pages` or `max_pages`) is rejected, since split results always number pages relative to the full document.<br/>
        /// The job runs asynchronously. Poll `GET /split/jobs/{split_job_id}` or register a webhook to monitor completion.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.SplitJobResponse>> CreateSplitJobApiV1SplitJobsPostAsResponseAsync(

            global::LlamaParse.SplitCreateRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Split Job<br/>
        /// Create a split job.<br/>
        /// ## Document input<br/>
        /// Set `file_input` to a file ID or a completed parse job ID (`pjb-...`). Supplying a parse job reuses its output instead of reading the document again.<br/>
        /// ## Page selection<br/>
        /// `configuration.target_pages` selects which pages of a supplied parse job to split (1-based; `1-50`, `1,3,5-7`). Pages are read in ascending document order, and each segment's `pages` are the parse job's own page numbers, so segments map straight back to the original document. Requires a parse job as `file_input`; passing it with a file ID returns 400.<br/>
        /// ## Parse settings<br/>
        /// `configuration.parse_tier` and `configuration.parse_config_id` control how the document is read before splitting; both are ignored when a parse job is supplied. A parse configuration restricted to a page subset (`target_pages` or `max_pages`) is rejected, since split results always number pages relative to the full document.<br/>
        /// The job runs asynchronously. Poll `GET /split/jobs/{split_job_id}` or register a webhook to monitor completion.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="transactionId">
        /// Idempotency key scoped to the project. Reusing a key returns the original job; the new request body is ignored.
        /// </param>
        /// <param name="webhookConfigurationIds">
        /// IDs of saved webhook configurations to notify for this job.
        /// </param>
        /// <param name="webhookConfigurations">
        /// Outbound webhook endpoints to notify on job status changes
        /// </param>
        /// <param name="configurationId">
        /// Saved configuration ID
        /// </param>
        /// <param name="configuration">
        /// Inline configuration
        /// </param>
        /// <param name="fileInput">
        /// File ID or parse job ID
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.SplitJobResponse> CreateSplitJobApiV1SplitJobsPostAsync(
            string fileInput,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            string? transactionId = default,
            global::System.Collections.Generic.IList<string>? webhookConfigurationIds = default,
            global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfiguration>? webhookConfigurations = default,
            string? configurationId = default,
            global::LlamaParse.SplitConfiguration? configuration = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}