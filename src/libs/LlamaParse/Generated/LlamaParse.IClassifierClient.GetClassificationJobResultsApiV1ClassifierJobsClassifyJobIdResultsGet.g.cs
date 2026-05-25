#nullable enable

namespace LlamaParse
{
    public partial interface IClassifierClient
    {
        /// <summary>
        /// Get Classification Job Results<br/>
        /// Get the results of a classify job. Experimental: not production-ready and subject to change.
        /// </summary>
        /// <param name="classifyJobId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.ClassifyJobResults> GetClassificationJobResultsApiV1ClassifierJobsClassifyJobIdResultsGetAsync(
            global::System.Guid classifyJobId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Classification Job Results<br/>
        /// Get the results of a classify job. Experimental: not production-ready and subject to change.
        /// </summary>
        /// <param name="classifyJobId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.ClassifyJobResults>> GetClassificationJobResultsApiV1ClassifierJobsClassifyJobIdResultsGetAsResponseAsync(
            global::System.Guid classifyJobId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}