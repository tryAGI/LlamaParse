#nullable enable

namespace LlamaParse
{
    public partial interface ILlamaExtractClient
    {
        /// <summary>
        /// Get Job
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.ExtractJob> GetJobApiV1ExtractionJobsJobIdGetAsync(
            global::System.Guid jobId,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}