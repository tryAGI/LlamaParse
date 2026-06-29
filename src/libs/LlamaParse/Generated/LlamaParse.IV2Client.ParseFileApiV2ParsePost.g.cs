#nullable enable

namespace LlamaParse
{
    public partial interface IV2Client
    {
        /// <summary>
        /// Parse File<br/>
        /// Parse a file by file ID or URL.<br/>
        /// Provide either `file_id` (a previously uploaded file) or<br/>
        /// `source_url` (a publicly accessible URL). Configure parsing<br/>
        /// with options like `tier`, `target_pages`, and `lang`.<br/>
        /// ## Tiers<br/>
        /// - `fast` — rule-based, cheapest, no AI<br/>
        /// - `cost_effective` — balanced speed and quality<br/>
        /// - `agentic` — full AI-powered parsing<br/>
        /// - `agentic_plus` — premium AI with specialized features<br/>
        /// The job runs asynchronously. Poll `GET /parse/{job_id}` with<br/>
        /// `expand=text` or `expand=markdown` to retrieve results.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.ParseJobResponse> ParseFileApiV2ParsePostAsync(

            global::LlamaParse.ParseRequestConfiguration request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Parse File<br/>
        /// Parse a file by file ID or URL.<br/>
        /// Provide either `file_id` (a previously uploaded file) or<br/>
        /// `source_url` (a publicly accessible URL). Configure parsing<br/>
        /// with options like `tier`, `target_pages`, and `lang`.<br/>
        /// ## Tiers<br/>
        /// - `fast` — rule-based, cheapest, no AI<br/>
        /// - `cost_effective` — balanced speed and quality<br/>
        /// - `agentic` — full AI-powered parsing<br/>
        /// - `agentic_plus` — premium AI with specialized features<br/>
        /// The job runs asynchronously. Poll `GET /parse/{job_id}` with<br/>
        /// `expand=text` or `expand=markdown` to retrieve results.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.ParseJobResponse>> ParseFileApiV2ParsePostAsResponseAsync(

            global::LlamaParse.ParseRequestConfiguration request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Parse File<br/>
        /// Parse a file by file ID or URL.<br/>
        /// Provide either `file_id` (a previously uploaded file) or<br/>
        /// `source_url` (a publicly accessible URL). Configure parsing<br/>
        /// with options like `tier`, `target_pages`, and `lang`.<br/>
        /// ## Tiers<br/>
        /// - `fast` — rule-based, cheapest, no AI<br/>
        /// - `cost_effective` — balanced speed and quality<br/>
        /// - `agentic` — full AI-powered parsing<br/>
        /// - `agentic_plus` — premium AI with specialized features<br/>
        /// The job runs asynchronously. Poll `GET /parse/{job_id}` with<br/>
        /// `expand=text` or `expand=markdown` to retrieve results.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="userMetadata">
        /// Arbitrary key/value tags to attach to this job. Returned when retrieving the job. Not searchable. Limits apply to the number of entries and the length of keys and values; oversized metadata is rejected.
        /// </param>
        /// <param name="tier">
        /// Parsing tier: 'fast' (rule-based, cheapest), 'cost_effective' (balanced), 'agentic' (AI-powered with custom prompts), or 'agentic_plus' (premium AI with highest accuracy)
        /// </param>
        /// <param name="version">
        /// Version for the selected tier. Use `latest`, or pin one of that tier's dated versions.<br/>
        /// Current `latest` by tier:<br/>
        /// - `fast`: `2025-12-11`<br/>
        /// - `cost_effective`: `2026-06-26`<br/>
        /// - `agentic`: `2026-06-18`<br/>
        /// - `agentic_plus`: `2026-06-18`<br/>
        /// Full list: `GET /api/v2/parse/versions`.
        /// </param>
        /// <param name="clientName">
        /// Identifier for the client/application making the request. Used for analytics and debugging. Example: 'my-app-v2'
        /// </param>
        /// <param name="processingOptions">
        /// Document processing options including OCR, table extraction, and chart parsing
        /// </param>
        /// <param name="fastOptions">
        /// Fast tier configuration options. Auto-initialized when tier='fast'. Cannot be used with other tiers
        /// </param>
        /// <param name="agenticOptions">
        /// AI-powered tier configuration (custom prompts). Auto-initialized for cost_effective/agentic/agentic_plus tiers. Cannot be used with fast tier
        /// </param>
        /// <param name="webhookConfigurations">
        /// Webhook endpoints for job status notifications. Multiple webhooks can be configured for different events or services
        /// </param>
        /// <param name="webhookConfigurationIds">
        /// IDs of saved webhook configurations to notify for this job.
        /// </param>
        /// <param name="inputOptions">
        /// Format-specific options (HTML, PDF, spreadsheet, presentation). Applied based on detected input file type
        /// </param>
        /// <param name="cropBox">
        /// Crop boundaries to process only a portion of each page. Values are ratios 0-1 from page edges
        /// </param>
        /// <param name="pageRanges">
        /// Page selection: limit total pages or specify exact pages to process
        /// </param>
        /// <param name="disableCache">
        /// Bypass result caching and force re-parsing. Use when document content may have changed or you need fresh results
        /// </param>
        /// <param name="outputOptions">
        /// Output formatting options for markdown, text, and extracted images
        /// </param>
        /// <param name="processingControl">
        /// Job execution controls including timeouts and failure thresholds
        /// </param>
        /// <param name="configurationId">
        /// ID of a saved parse configuration. When set, `tier` and `version` default to the saved configuration's values — omit them or pass `'configured'`.
        /// </param>
        /// <param name="fileId">
        /// ID of an existing file in the project to parse. Mutually exclusive with source_url
        /// </param>
        /// <param name="sourceUrl">
        /// Public URL of the document to parse. Mutually exclusive with file_id
        /// </param>
        /// <param name="httpProxy">
        /// HTTP/HTTPS proxy for fetching source_url. Ignored if using file_id
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.ParseJobResponse> ParseFileApiV2ParsePostAsync(
            global::LlamaParse.AnyOf<global::LlamaParse.ParseRequestConfigurationTier?, string> tier,
            global::LlamaParse.AnyOf<global::LlamaParse.ParseRequestConfigurationVersion?, string> version,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Collections.Generic.Dictionary<string, string>? userMetadata = default,
            string? clientName = default,
            global::LlamaParse.LlamaParseProcessingOptions? processingOptions = default,
            global::LlamaParse.LlamaParseFastOptions? fastOptions = default,
            global::LlamaParse.LlamaParseAgenticOptions? agenticOptions = default,
            global::System.Collections.Generic.IList<global::LlamaParse.LlamaParseWebhookConfiguration>? webhookConfigurations = default,
            global::System.Collections.Generic.IList<string>? webhookConfigurationIds = default,
            global::LlamaParse.LlamaParseInputOptions? inputOptions = default,
            global::LlamaParse.LlamaParseCropBox? cropBox = default,
            global::LlamaParse.LlamaParsePageRanges? pageRanges = default,
            bool? disableCache = default,
            global::LlamaParse.LlamaParseOutputOptions? outputOptions = default,
            global::LlamaParse.LlamaParseProcessingControl? processingControl = default,
            string? configurationId = default,
            string? fileId = default,
            string? sourceUrl = default,
            string? httpProxy = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}