#nullable enable

namespace LlamaParse
{
    public partial interface ILlamaExtractClient
    {
        /// <summary>
        /// Delete Extraction Agent
        /// </summary>
        /// <param name="extractionAgentId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteExtractionAgentApiV1ExtractionExtractionAgentsExtractionAgentIdDeleteAsync(
            global::System.Guid extractionAgentId,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}