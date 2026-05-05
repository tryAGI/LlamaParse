#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace LlamaParse
{
    public partial interface IV2Client
    {
        /// <summary>
        /// Create Classify Job<br/>
        /// Create a classify job.<br/>
        /// Classifies a document against a set of rules. Set `file_input`<br/>
        /// to a file ID (`dfl-...`) or parse job ID (`pjb-...`), and provide<br/>
        /// either inline `configuration` with rules or a `configuration_id`<br/>
        /// referencing a saved preset.<br/>
        /// Each rule has a `type` (the label to assign) and a `description`<br/>
        /// (natural language criteria). The classifier returns the best<br/>
        /// matching rule with a confidence score.<br/>
        /// The job runs asynchronously. Poll `GET /classify/{job_id}` to<br/>
        /// check status and retrieve results.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.ClassifyV2JobResponse> CreateClassifyJobApiV2ClassifyPostAsync(

            global::LlamaParse.ClassifyV2JobCreateRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Classify Job<br/>
        /// Create a classify job.<br/>
        /// Classifies a document against a set of rules. Set `file_input`<br/>
        /// to a file ID (`dfl-...`) or parse job ID (`pjb-...`), and provide<br/>
        /// either inline `configuration` with rules or a `configuration_id`<br/>
        /// referencing a saved preset.<br/>
        /// Each rule has a `type` (the label to assign) and a `description`<br/>
        /// (natural language criteria). The classifier returns the best<br/>
        /// matching rule with a confidence score.<br/>
        /// The job runs asynchronously. Poll `GET /classify/{job_id}` to<br/>
        /// check status and retrieve results.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.ClassifyV2JobResponse>> CreateClassifyJobApiV2ClassifyPostAsResponseAsync(

            global::LlamaParse.ClassifyV2JobCreateRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Classify Job<br/>
        /// Create a classify job.<br/>
        /// Classifies a document against a set of rules. Set `file_input`<br/>
        /// to a file ID (`dfl-...`) or parse job ID (`pjb-...`), and provide<br/>
        /// either inline `configuration` with rules or a `configuration_id`<br/>
        /// referencing a saved preset.<br/>
        /// Each rule has a `type` (the label to assign) and a `description`<br/>
        /// (natural language criteria). The classifier returns the best<br/>
        /// matching rule with a confidence score.<br/>
        /// The job runs asynchronously. Poll `GET /classify/{job_id}` to<br/>
        /// check status and retrieve results.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="configurationId">
        /// Saved configuration ID
        /// </param>
        /// <param name="configuration">
        /// Inline classify configuration (required if configuration_id is not provided)
        /// </param>
        /// <param name="fileInput">
        /// File ID or parse job ID to classify
        /// </param>
        /// <param name="transactionId">
        /// Idempotency key scoped to the project
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.ClassifyV2JobResponse> CreateClassifyJobApiV2ClassifyPostAsync(
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            string? configurationId = default,
            global::LlamaParse.ClassifyV2Configuration? configuration = default,
            string? fileInput = default,
            string? transactionId = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}