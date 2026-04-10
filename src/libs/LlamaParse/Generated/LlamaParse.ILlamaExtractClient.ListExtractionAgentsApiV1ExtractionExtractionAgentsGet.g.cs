#nullable enable

namespace LlamaParse
{
    public partial interface ILlamaExtractClient
    {
        /// <summary>
        /// List Extraction Agents
        /// </summary>
        /// <param name="includeDefault">
        /// Whether to include default agents in the results<br/>
        /// Default Value: false
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LlamaParse.ExtractAgent>> ListExtractionAgentsApiV1ExtractionExtractionAgentsGetAsync(
            bool? includeDefault = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}