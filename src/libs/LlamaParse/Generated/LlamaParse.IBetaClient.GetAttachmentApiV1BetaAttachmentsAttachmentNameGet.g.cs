#nullable enable

namespace LlamaParse
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Get Attachment<br/>
        /// Return a presigned download URL for a specific attachment.
        /// </summary>
        /// <param name="attachmentName"></param>
        /// <param name="sourceId">
        /// File UUID or directory file ID (dfl-...).
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.PresignedUrl> GetAttachmentApiV1BetaAttachmentsAttachmentNameGetAsync(
            string attachmentName,
            string sourceId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Attachment<br/>
        /// Return a presigned download URL for a specific attachment.
        /// </summary>
        /// <param name="attachmentName"></param>
        /// <param name="sourceId">
        /// File UUID or directory file ID (dfl-...).
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.PresignedUrl>> GetAttachmentApiV1BetaAttachmentsAttachmentNameGetAsResponseAsync(
            string attachmentName,
            string sourceId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}