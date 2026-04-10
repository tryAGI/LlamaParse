#nullable enable

namespace LlamaParse
{
    public partial interface ILlamaExtractClient
    {
        /// <summary>
        /// Extract Stateless<br/>
        /// Stateless extraction endpoint that uses a default extraction agent in the user's default project.<br/>
        /// Requires data_schema, config, and either file_id, text, or base64 encoded file data.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.ExtractJob> ExtractStatelessApiV1ExtractionRunPostAsync(

            global::LlamaParse.ExtractStatelessRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Extract Stateless<br/>
        /// Stateless extraction endpoint that uses a default extraction agent in the user's default project.<br/>
        /// Requires data_schema, config, and either file_id, text, or base64 encoded file data.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="webhookConfigurations">
        /// Outbound webhook endpoints to notify on job status changes
        /// </param>
        /// <param name="dataSchema">
        /// The schema of the data to extract
        /// </param>
        /// <param name="config">
        /// The configuration parameters for the extraction
        /// </param>
        /// <param name="fileId">
        /// The ID of the file to extract from
        /// </param>
        /// <param name="text">
        /// The text content to extract from
        /// </param>
        /// <param name="file">
        /// The file data with base64 content and MIME type
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.ExtractJob> ExtractStatelessApiV1ExtractionRunPostAsync(
            global::LlamaParse.AnyOf<object, string> dataSchema,
            global::LlamaParse.ExtractConfig config,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfiguration>? webhookConfigurations = default,
            global::System.Guid? fileId = default,
            string? text = default,
            global::LlamaParse.FileData? file = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}