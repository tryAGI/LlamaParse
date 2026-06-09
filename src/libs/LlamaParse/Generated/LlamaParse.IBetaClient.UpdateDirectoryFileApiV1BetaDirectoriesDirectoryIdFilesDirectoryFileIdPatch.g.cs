#nullable enable

namespace LlamaParse
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Update Directory File<br/>
        /// Update directory-file metadata by `directory_file_id`; set `directory_id` to move the file to a different directory. To resolve from `unique_id`, list with a filter first.
        /// </summary>
        /// <param name="directoryId"></param>
        /// <param name="directoryFileId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.DirectoryFileResponse> UpdateDirectoryFileApiV1BetaDirectoriesDirectoryIdFilesDirectoryFileIdPatchAsync(
            string directoryId,
            string directoryFileId,

            global::LlamaParse.DirectoryFileUpdateRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Directory File<br/>
        /// Update directory-file metadata by `directory_file_id`; set `directory_id` to move the file to a different directory. To resolve from `unique_id`, list with a filter first.
        /// </summary>
        /// <param name="directoryId"></param>
        /// <param name="directoryFileId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.DirectoryFileResponse>> UpdateDirectoryFileApiV1BetaDirectoriesDirectoryIdFilesDirectoryFileIdPatchAsResponseAsync(
            string directoryId,
            string directoryFileId,

            global::LlamaParse.DirectoryFileUpdateRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Directory File<br/>
        /// Update directory-file metadata by `directory_file_id`; set `directory_id` to move the file to a different directory. To resolve from `unique_id`, list with a filter first.
        /// </summary>
        /// <param name="directoryId"></param>
        /// <param name="directoryFileId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="uniqueId">
        /// Updated unique identifier.
        /// </param>
        /// <param name="displayName">
        /// Updated display name.
        /// </param>
        /// <param name="targetDirectoryId">
        /// Move file to a different directory.
        /// </param>
        /// <param name="metadata">
        /// User-defined metadata key-value pairs. Replaces the user metadata layer.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.DirectoryFileResponse> UpdateDirectoryFileApiV1BetaDirectoriesDirectoryIdFilesDirectoryFileIdPatchAsync(
            string directoryId,
            string directoryFileId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            string? uniqueId = default,
            string? displayName = default,
            string? targetDirectoryId = default,
            global::LlamaParse.MetadataDict? metadata = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}