#nullable enable

namespace LlamaParse
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Delete Pipeline Document<br/>
        /// Delete a document from a pipeline; runs async (vectors first, then MongoDB record).
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task DeletePipelineDocumentApiV1PipelinesPipelineIdDocumentsDocumentIdDeleteAsync(
            string documentId,
            global::System.Guid pipelineId,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Pipeline Document<br/>
        /// Delete a document from a pipeline; runs async (vectors first, then MongoDB record).
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse> DeletePipelineDocumentApiV1PipelinesPipelineIdDocumentsDocumentIdDeleteAsResponseAsync(
            string documentId,
            global::System.Guid pipelineId,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}