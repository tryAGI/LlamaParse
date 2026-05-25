#nullable enable

namespace LlamaParse
{
    public partial interface IPageFiguresClient
    {
        /// <summary>
        /// Generate File Page Figure Presigned Url<br/>
        /// Returns a short-lived presigned URL to read a page figure; treat the URL as sensitive while it is valid.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pageIndex"></param>
        /// <param name="figureName"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.PresignedUrl> GenerateFilePageFigurePresignedUrlApiV1FilesIdPageFiguresPageIndexFigureNamePresignedUrlPostAsync(
            global::System.Guid id,
            int pageIndex,
            string figureName,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate File Page Figure Presigned Url<br/>
        /// Returns a short-lived presigned URL to read a page figure; treat the URL as sensitive while it is valid.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pageIndex"></param>
        /// <param name="figureName"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.PresignedUrl>> GenerateFilePageFigurePresignedUrlApiV1FilesIdPageFiguresPageIndexFigureNamePresignedUrlPostAsResponseAsync(
            global::System.Guid id,
            int pageIndex,
            string figureName,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}