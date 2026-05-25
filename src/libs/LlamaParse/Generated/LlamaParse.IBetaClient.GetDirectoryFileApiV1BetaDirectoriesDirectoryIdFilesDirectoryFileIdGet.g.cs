#nullable enable

namespace LlamaParse
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Get Directory File<br/>
        /// Get a directory file by `directory_file_id`; to look up by `unique_id`, use the list endpoint with a filter.
        /// </summary>
        /// <param name="directoryId"></param>
        /// <param name="directoryFileId"></param>
        /// <param name="expand">
        /// Fields to expand.
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.DirectoryFileResponse> GetDirectoryFileApiV1BetaDirectoriesDirectoryIdFilesDirectoryFileIdGetAsync(
            string directoryId,
            string directoryFileId,
            global::System.Collections.Generic.IList<string>? expand = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Directory File<br/>
        /// Get a directory file by `directory_file_id`; to look up by `unique_id`, use the list endpoint with a filter.
        /// </summary>
        /// <param name="directoryId"></param>
        /// <param name="directoryFileId"></param>
        /// <param name="expand">
        /// Fields to expand.
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.DirectoryFileResponse>> GetDirectoryFileApiV1BetaDirectoriesDirectoryIdFilesDirectoryFileIdGetAsResponseAsync(
            string directoryId,
            string directoryFileId,
            global::System.Collections.Generic.IList<string>? expand = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}