#nullable enable

namespace LlamaParse
{
    public partial interface IRetrievalClient
    {
        /// <summary>
        /// Grep File<br/>
        /// Grep within a file's parsed content using a regex pattern.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.FileGrepApiResponse> GrepFileApiV1RetrievalFilesGrepPostAsync(

            global::LlamaParse.FileGrepParams request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Grep File<br/>
        /// Grep within a file's parsed content using a regex pattern.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.FileGrepApiResponse>> GrepFileApiV1RetrievalFilesGrepPostAsResponseAsync(

            global::LlamaParse.FileGrepParams request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Grep File<br/>
        /// Grep within a file's parsed content using a regex pattern.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="indexId">
        /// ID of the index the file belongs to.
        /// </param>
        /// <param name="fileId">
        /// ID of the file to grep.
        /// </param>
        /// <param name="pattern">
        /// Regex pattern to search for.
        /// </param>
        /// <param name="limit">
        /// Maximum number of matches to return.
        /// </param>
        /// <param name="contextChars">
        /// Number of characters of context to include before and after the matched pattern in the content field of the response
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.FileGrepApiResponse> GrepFileApiV1RetrievalFilesGrepPostAsync(
            string indexId,
            string fileId,
            string pattern,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            int? limit = default,
            int? contextChars = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}