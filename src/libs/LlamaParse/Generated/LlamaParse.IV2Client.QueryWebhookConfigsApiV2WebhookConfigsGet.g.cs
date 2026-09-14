#nullable enable

namespace LlamaParse
{
    public partial interface IV2Client
    {
        /// <summary>
        /// Query Webhook Configs<br/>
        /// List the webhook configurations for the current project, newest first.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="pageSize">
        /// Number of items per page<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="pageToken">
        /// Cursor from the previous page's `next_page_token`.
        /// </param>
        /// <param name="includeTotal">
        /// Return `total_size`, a count of every row matching the filter. It is a second query on every page, so it is off unless asked for.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.WebhookConfigQueryResponse> QueryWebhookConfigsApiV2WebhookConfigsGetAsync(
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            int? pageSize = default,
            string? pageToken = default,
            bool? includeTotal = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query Webhook Configs<br/>
        /// List the webhook configurations for the current project, newest first.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="pageSize">
        /// Number of items per page<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="pageToken">
        /// Cursor from the previous page's `next_page_token`.
        /// </param>
        /// <param name="includeTotal">
        /// Return `total_size`, a count of every row matching the filter. It is a second query on every page, so it is off unless asked for.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.WebhookConfigQueryResponse>> QueryWebhookConfigsApiV2WebhookConfigsGetAsResponseAsync(
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            int? pageSize = default,
            string? pageToken = default,
            bool? includeTotal = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}