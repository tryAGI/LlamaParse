#nullable enable

namespace LlamaParse
{
    public partial interface IIndexesClient
    {
        /// <summary>
        /// Create Index<br/>
        /// Create a searchable index over a source directory.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.IndexResponse> CreateIndexApiV1IndexesPostAsync(

            global::LlamaParse.IndexCreateRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Index<br/>
        /// Create a searchable index over a source directory.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.IndexResponse>> CreateIndexApiV1IndexesPostAsResponseAsync(

            global::LlamaParse.IndexCreateRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Index<br/>
        /// Create a searchable index over a source directory.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="sourceDirectoryId">
        /// ID of the source directory containing your documents.
        /// </param>
        /// <param name="name">
        /// Optional display name for the index. If omitted, the index is named after the source directory.
        /// </param>
        /// <param name="products">
        /// Product configurations for syncing. Omit to use a default parse configuration. Include an explicit entry per product type (e.g. parse, extract) to override the default.
        /// </param>
        /// <param name="description">
        /// Optional description of the index.
        /// </param>
        /// <param name="syncFrequency">
        /// How often to re-run the sync. One of: manual, daily, on_source_change. Defaults to manual.<br/>
        /// Default Value: manual
        /// </param>
        /// <param name="storeAttachments">
        /// Attachment kinds to store alongside parsed output. Each entry must be one of: screenshots, items. For example, ['screenshots'] renders and stores per-page screenshots; ['items'] stores structured items with bounding boxes. Omit or pass an empty list to skip attachments.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.IndexResponse> CreateIndexApiV1IndexesPostAsync(
            string sourceDirectoryId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            string? name = default,
            global::System.Collections.Generic.IList<global::LlamaParse.IndexProductEntry>? products = default,
            string? description = default,
            string? syncFrequency = default,
            global::System.Collections.Generic.IList<string>? storeAttachments = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}