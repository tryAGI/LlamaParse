#nullable enable

namespace LlamaParse
{
    public partial interface IPipelineDataSourcesClient
    {
        /// <summary>
        /// Add Data Sources To Pipeline<br/>
        /// Add data sources to a pipeline.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LlamaParse.PipelineDataSource>> AddDataSourcesToPipelineApiV1PipelinesPipelineIdDataSourcesPutAsync(
            global::System.Guid pipelineId,

            global::System.Collections.Generic.IList<global::LlamaParse.PipelineDataSourceCreate> request,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Data Sources To Pipeline<br/>
        /// Add data sources to a pipeline.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::LlamaParse.PipelineDataSource>>> AddDataSourcesToPipelineApiV1PipelinesPipelineIdDataSourcesPutAsResponseAsync(
            global::System.Guid pipelineId,

            global::System.Collections.Generic.IList<global::LlamaParse.PipelineDataSourceCreate> request,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}