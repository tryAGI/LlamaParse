#nullable enable

namespace LlamaParse
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Upload File To Directory<br/>
        /// Upload a file and create its directory entry in one call; `unique_id` / `display_name` default to values derived from file metadata.
        /// </summary>
        /// <param name="directoryId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.DirectoryFileResponse> UploadFileToDirectoryApiV1BetaDirectoriesDirectoryIdFilesUploadPostAsync(
            string directoryId,

            global::LlamaParse.BodyUploadFileToDirectoryApiV1BetaDirectoriesDirectoryIdFilesUploadPost request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload File To Directory<br/>
        /// Upload a file and create its directory entry in one call; `unique_id` / `display_name` default to values derived from file metadata.
        /// </summary>
        /// <param name="directoryId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.DirectoryFileResponse>> UploadFileToDirectoryApiV1BetaDirectoriesDirectoryIdFilesUploadPostAsResponseAsync(
            string directoryId,

            global::LlamaParse.BodyUploadFileToDirectoryApiV1BetaDirectoriesDirectoryIdFilesUploadPost request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload File To Directory<br/>
        /// Upload a file and create its directory entry in one call; `unique_id` / `display_name` default to values derived from file metadata.
        /// </summary>
        /// <param name="directoryId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="uploadFile"></param>
        /// <param name="uploadFilename"></param>
        /// <param name="uniqueId"></param>
        /// <param name="displayName"></param>
        /// <param name="externalFileId"></param>
        /// <param name="metadata">
        /// User metadata as a JSON object string.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.DirectoryFileResponse> UploadFileToDirectoryApiV1BetaDirectoriesDirectoryIdFilesUploadPostAsync(
            string directoryId,
            byte[] uploadFile,
            string uploadFilename,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            string? uniqueId = default,
            string? displayName = default,
            string? externalFileId = default,
            string? metadata = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload File To Directory<br/>
        /// Upload a file and create its directory entry in one call; `unique_id` / `display_name` default to values derived from file metadata.
        /// </summary>
        /// <param name="directoryId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="uploadFile">
        /// The stream to send as the multipart 'upload_file' file part.
        /// </param>
        /// <param name="uploadFilename"></param>
        /// <param name="uniqueId"></param>
        /// <param name="displayName"></param>
        /// <param name="externalFileId"></param>
        /// <param name="metadata">
        /// User metadata as a JSON object string.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.DirectoryFileResponse> UploadFileToDirectoryApiV1BetaDirectoriesDirectoryIdFilesUploadPostAsync(
            string directoryId,
            global::System.IO.Stream uploadFile,
            string uploadFilename,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            string? uniqueId = default,
            string? displayName = default,
            string? externalFileId = default,
            string? metadata = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload File To Directory<br/>
        /// Upload a file and create its directory entry in one call; `unique_id` / `display_name` default to values derived from file metadata.
        /// </summary>
        /// <param name="directoryId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="uploadFile">
        /// The stream to send as the multipart 'upload_file' file part.
        /// </param>
        /// <param name="uploadFilename"></param>
        /// <param name="uniqueId"></param>
        /// <param name="displayName"></param>
        /// <param name="externalFileId"></param>
        /// <param name="metadata">
        /// User metadata as a JSON object string.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.DirectoryFileResponse>> UploadFileToDirectoryApiV1BetaDirectoriesDirectoryIdFilesUploadPostAsResponseAsync(
            string directoryId,
            global::System.IO.Stream uploadFile,
            string uploadFilename,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            string? uniqueId = default,
            string? displayName = default,
            string? externalFileId = default,
            string? metadata = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}