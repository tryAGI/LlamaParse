#nullable enable

namespace LlamaParse
{
    public partial interface ILlamaExtractClient
    {
        /// <summary>
        /// Get Latest Run From Ui
        /// </summary>
        /// <param name="extractionAgentId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.ExtractRun> GetLatestRunFromUiApiV1ExtractionRunsLatestFromUiGetAsync(
            global::System.Guid extractionAgentId,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}