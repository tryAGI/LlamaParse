#nullable enable

namespace LlamaParse
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Update Parse Configuration<br/>
        /// Update a parse configuration.<br/>
        /// Args:<br/>
        ///     config_id: The ID of the parse configuration to update<br/>
        ///     config_update: Update data<br/>
        ///     project: Validated project from dependency<br/>
        ///     user: Current user<br/>
        /// Returns:<br/>
        ///     The updated parse configuration
        /// </summary>
        /// <param name="configId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.ParseConfiguration> UpdateParseConfigurationApiV1BetaParseConfigurationsConfigIdPutAsync(
            string configId,

            global::LlamaParse.ParseConfigurationUpdate request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Parse Configuration<br/>
        /// Update a parse configuration.<br/>
        /// Args:<br/>
        ///     config_id: The ID of the parse configuration to update<br/>
        ///     config_update: Update data<br/>
        ///     project: Validated project from dependency<br/>
        ///     user: Current user<br/>
        /// Returns:<br/>
        ///     The updated parse configuration
        /// </summary>
        /// <param name="configId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="parameters">
        /// Updated LlamaParseParameters configuration
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.ParseConfiguration> UpdateParseConfigurationApiV1BetaParseConfigurationsConfigIdPutAsync(
            string configId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.LlamaParseParameters? parameters = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}