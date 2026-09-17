#nullable enable

namespace LlamaParse
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Delete Webhook Config<br/>
        /// Delete a webhook configuration.
        /// </summary>
        /// <param name="configId"></param>
        /// <param name="tenantType">
        /// Which configurations to address: `project` for ones a job references by ID, or `project_default` for ones every job in the project notifies.<br/>
        /// Default Value: project
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteWebhookConfigApiV1BetaWebhookConfigsConfigIdDeleteAsync(
            string configId,
            global::LlamaParse.DeleteWebhookConfigApiV1BetaWebhookConfigsConfigIdDeleteTenantType? tenantType = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Webhook Config<br/>
        /// Delete a webhook configuration.
        /// </summary>
        /// <param name="configId"></param>
        /// <param name="tenantType">
        /// Which configurations to address: `project` for ones a job references by ID, or `project_default` for ones every job in the project notifies.<br/>
        /// Default Value: project
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse> DeleteWebhookConfigApiV1BetaWebhookConfigsConfigIdDeleteAsResponseAsync(
            string configId,
            global::LlamaParse.DeleteWebhookConfigApiV1BetaWebhookConfigsConfigIdDeleteTenantType? tenantType = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}