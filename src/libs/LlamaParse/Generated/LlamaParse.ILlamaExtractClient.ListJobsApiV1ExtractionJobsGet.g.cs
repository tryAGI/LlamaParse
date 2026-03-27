#nullable enable

namespace LlamaParse
{
    public partial interface ILlamaExtractClient
    {
        /// <summary>
        /// List Jobs
        /// </summary>
        /// <param name="extractionAgentId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LlamaParse.ExtractJob>> ListJobsApiV1ExtractionJobsGetAsync(
            global::System.Guid extractionAgentId,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}