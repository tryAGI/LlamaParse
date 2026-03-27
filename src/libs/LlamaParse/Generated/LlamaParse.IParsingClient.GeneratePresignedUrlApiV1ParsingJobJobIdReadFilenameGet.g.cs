#nullable enable

namespace LlamaParse
{
    public partial interface IParsingClient
    {
        /// <summary>
        /// Generate Presigned Url<br/>
        /// Generate a presigned URL for a job
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="filename"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.PresignedUrl> GeneratePresignedUrlApiV1ParsingJobJobIdReadFilenameGetAsync(
            string jobId,
            string filename,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}