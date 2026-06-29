#nullable enable

namespace LlamaParse
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Update Webhook Config<br/>
        /// Update a webhook configuration. Only fields present in the request change.
        /// </summary>
        /// <param name="configId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.WebhookConfigResponse> UpdateWebhookConfigApiV1BetaWebhookConfigsConfigIdPutAsync(
            string configId,

            global::LlamaParse.WebhookConfigUpdateRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Webhook Config<br/>
        /// Update a webhook configuration. Only fields present in the request change.
        /// </summary>
        /// <param name="configId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.WebhookConfigResponse>> UpdateWebhookConfigApiV1BetaWebhookConfigsConfigIdPutAsResponseAsync(
            string configId,

            global::LlamaParse.WebhookConfigUpdateRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Webhook Config<br/>
        /// Update a webhook configuration. Only fields present in the request change.
        /// </summary>
        /// <param name="configId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="webhookUrl">
        /// Updated webhook URL.
        /// </param>
        /// <param name="webhookSigningSecret">
        /// Updated signing secret (write-only). Send to rotate the secret.
        /// </param>
        /// <param name="webhookHeaders">
        /// Updated headers.
        /// </param>
        /// <param name="webhookEvents">
        /// Updated event subscriptions.
        /// </param>
        /// <param name="webhookOutputFormat">
        /// Updated output format.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.WebhookConfigResponse> UpdateWebhookConfigApiV1BetaWebhookConfigsConfigIdPutAsync(
            string configId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            string? webhookUrl = default,
            string? webhookSigningSecret = default,
            global::System.Collections.Generic.Dictionary<string, string>? webhookHeaders = default,
            global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigUpdateRequestWebhookEventsVariant1Item>? webhookEvents = default,
            global::LlamaParse.WebhookConfigUpdateRequestWebhookOutputFormat2? webhookOutputFormat = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}