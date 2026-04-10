#nullable enable

namespace LlamaParse
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Delete Agent Data By Query<br/>
        /// Bulk delete agent data by query (deployment_name, collection, optional filters).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.DeleteResponse> DeleteAgentDataByQueryApiV1BetaAgentDataDeletePostAsync(

            global::LlamaParse.DeleteRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Agent Data By Query<br/>
        /// Bulk delete agent data by query (deployment_name, collection, optional filters).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="deploymentName">
        /// The agent deployment's name to delete data for
        /// </param>
        /// <param name="collection">
        /// The logical agent data collection to delete from<br/>
        /// Default Value: default
        /// </param>
        /// <param name="filter">
        /// Optional filters to select which items to delete
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.DeleteResponse> DeleteAgentDataByQueryApiV1BetaAgentDataDeletePostAsync(
            string deploymentName,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            string? collection = default,
            global::System.Collections.Generic.Dictionary<string, global::LlamaParse.FilterOperation>? filter = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}