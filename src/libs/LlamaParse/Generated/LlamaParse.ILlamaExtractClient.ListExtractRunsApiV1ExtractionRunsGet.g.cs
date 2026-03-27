#nullable enable

namespace LlamaParse
{
    public partial interface ILlamaExtractClient
    {
        /// <summary>
        /// List Extract Runs
        /// </summary>
        /// <param name="extractionAgentId"></param>
        /// <param name="skip">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 25
        /// </param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.PaginatedExtractRunsResponse> ListExtractRunsApiV1ExtractionRunsGetAsync(
            global::System.Guid extractionAgentId,
            int? skip = default,
            int? limit = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}