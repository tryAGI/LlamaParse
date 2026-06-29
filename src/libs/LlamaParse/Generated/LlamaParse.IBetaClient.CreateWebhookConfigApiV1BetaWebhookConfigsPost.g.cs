#nullable enable

namespace LlamaParse
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Create Webhook Config<br/>
        /// Create a reusable webhook configuration for the current project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.WebhookConfigResponse> CreateWebhookConfigApiV1BetaWebhookConfigsPostAsync(

            global::LlamaParse.WebhookConfigCreateRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Webhook Config<br/>
        /// Create a reusable webhook configuration for the current project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.WebhookConfigResponse>> CreateWebhookConfigApiV1BetaWebhookConfigsPostAsResponseAsync(

            global::LlamaParse.WebhookConfigCreateRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Webhook Config<br/>
        /// Create a reusable webhook configuration for the current project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="webhookUrl">
        /// URL to receive webhook POST notifications.
        /// </param>
        /// <param name="webhookSigningSecret">
        /// Shared secret used to sign deliveries to this endpoint. Write-only: it is never returned in responses.
        /// </param>
        /// <param name="webhookHeaders">
        /// Custom HTTP headers sent with each webhook request.
        /// </param>
        /// <param name="webhookEvents">
        /// Events to subscribe to. If null, all events are delivered.
        /// </param>
        /// <param name="webhookOutputFormat">
        /// Response format sent to the webhook: 'string' (default) or 'json'.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.WebhookConfigResponse> CreateWebhookConfigApiV1BetaWebhookConfigsPostAsync(
            string webhookUrl,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            string? webhookSigningSecret = default,
            global::System.Collections.Generic.Dictionary<string, string>? webhookHeaders = default,
            global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigCreateRequestWebhookEventsVariant1Item>? webhookEvents = default,
            global::LlamaParse.WebhookConfigCreateRequestWebhookOutputFormat2? webhookOutputFormat = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}