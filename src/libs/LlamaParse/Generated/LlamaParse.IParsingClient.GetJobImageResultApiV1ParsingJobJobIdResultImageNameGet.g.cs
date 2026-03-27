#nullable enable

namespace LlamaParse
{
    public partial interface IParsingClient
    {
        /// <summary>
        /// Get Job Image Result<br/>
        /// Get a job by id
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="name"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task GetJobImageResultApiV1ParsingJobJobIdResultImageNameGetAsync(
            string jobId,
            string name,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}