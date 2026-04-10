#nullable enable

namespace LlamaParse
{
    public partial interface IRetrieversClient
    {
        /// <summary>
        /// Get Retriever<br/>
        /// Get a Retriever by ID.
        /// </summary>
        /// <param name="retrieverId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.Retriever> GetRetrieverApiV1RetrieversRetrieverIdGetAsync(
            global::System.Guid retrieverId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}