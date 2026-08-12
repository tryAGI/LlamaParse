#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace LlamaParse
{
    public partial interface IAlphaClient
    {
        /// <summary>
        /// Create Verify Job<br/>
        /// Create a Verify job.<br/>
        /// Analyzes a document for signs of doctoring (splicing, copy-move,<br/>
        /// AI generation, metadata tampering, ...). Set `file_input` to a<br/>
        /// file ID (`dfl-...`). Optionally provide a `configuration` object<br/>
        /// to control the semantic agent.<br/>
        /// The job runs asynchronously. Poll `GET /verify/{job_id}`<br/>
        /// with `expand=result` to check status and retrieve results.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.VerifyJobResponse> CreateVerifyJobApiAlphaVerifyPostAsync(

            global::LlamaParse.VerifyRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Verify Job<br/>
        /// Create a Verify job.<br/>
        /// Analyzes a document for signs of doctoring (splicing, copy-move,<br/>
        /// AI generation, metadata tampering, ...). Set `file_input` to a<br/>
        /// file ID (`dfl-...`). Optionally provide a `configuration` object<br/>
        /// to control the semantic agent.<br/>
        /// The job runs asynchronously. Poll `GET /verify/{job_id}`<br/>
        /// with `expand=result` to check status and retrieve results.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.VerifyJobResponse>> CreateVerifyJobApiAlphaVerifyPostAsResponseAsync(

            global::LlamaParse.VerifyRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Verify Job<br/>
        /// Create a Verify job.<br/>
        /// Analyzes a document for signs of doctoring (splicing, copy-move,<br/>
        /// AI generation, metadata tampering, ...). Set `file_input` to a<br/>
        /// file ID (`dfl-...`). Optionally provide a `configuration` object<br/>
        /// to control the semantic agent.<br/>
        /// The job runs asynchronously. Poll `GET /verify/{job_id}`<br/>
        /// with `expand=result` to check status and retrieve results.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="webhookConfigurations">
        /// Outbound webhook endpoints to notify on job status changes
        /// </param>
        /// <param name="fileInput">
        /// File ID of the document to analyze
        /// </param>
        /// <param name="configuration">
        /// Verify configuration (defaults applied when omitted)
        /// </param>
        /// <param name="transactionId">
        /// Idempotency key scoped to the project. Reusing a key returns the original job; the new request body is ignored.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.VerifyJobResponse> CreateVerifyJobApiAlphaVerifyPostAsync(
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfiguration>? webhookConfigurations = default,
            string? fileInput = default,
            global::LlamaParse.VerifyConfiguration? configuration = default,
            string? transactionId = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}