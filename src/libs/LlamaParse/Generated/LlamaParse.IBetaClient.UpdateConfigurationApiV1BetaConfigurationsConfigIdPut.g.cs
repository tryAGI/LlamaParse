#nullable enable

namespace LlamaParse
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Update Configuration<br/>
        /// Update an existing product configuration.
        /// </summary>
        /// <param name="configId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.ConfigurationResponse> UpdateConfigurationApiV1BetaConfigurationsConfigIdPutAsync(
            string configId,

            global::LlamaParse.ConfigurationUpdateRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Configuration<br/>
        /// Update an existing product configuration.
        /// </summary>
        /// <param name="configId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.ConfigurationResponse>> UpdateConfigurationApiV1BetaConfigurationsConfigIdPutAsResponseAsync(
            string configId,

            global::LlamaParse.ConfigurationUpdateRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Configuration<br/>
        /// Update an existing product configuration.
        /// </summary>
        /// <param name="configId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="name">
        /// Updated name (omit to leave unchanged).
        /// </param>
        /// <param name="parameters">
        /// Updated parameters (omit to leave unchanged).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.ConfigurationResponse> UpdateConfigurationApiV1BetaConfigurationsConfigIdPutAsync(
            string configId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            string? name = default,
            global::LlamaParse.ParametersVariant1? parameters = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}