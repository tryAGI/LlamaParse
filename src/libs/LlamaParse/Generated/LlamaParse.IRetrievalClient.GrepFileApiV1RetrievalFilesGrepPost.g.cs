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
        global::System.Threading.Tasks.Task<global::LlamaParse.FileGrepResult> GrepFileApiV1RetrievalFilesGrepPostAsync(

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
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.FileGrepResult>> GrepFileApiV1RetrievalFilesGrepPostAsResponseAsync(

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
        /// <param name="pageSize">
        /// The maximum number of items to return. The service may return fewer than this value. If unspecified, a default page size will be used. The maximum value is typically 1000; values above this will be coerced to the maximum.
        /// </param>
        /// <param name="pageToken">
        /// A page token, received from a previous list call. Provide this to retrieve the subsequent page.
        /// </param>
        /// <param name="indexId">
        /// ID of the index the file belongs to.
        /// </param>
        /// <param name="fileId">
        /// ID of the file to grep.
        /// </param>
        /// <param name="pattern">
        /// Regex pattern to search for.
        /// </param>
        /// <param name="contextChars">
        /// Number of characters of context to include before and after the matched pattern in the content field of the response
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.FileGrepResult> GrepFileApiV1RetrievalFilesGrepPostAsync(
            string indexId,
            string fileId,
            string pattern,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            int? pageSize = default,
            string? pageToken = default,
            int? contextChars = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}