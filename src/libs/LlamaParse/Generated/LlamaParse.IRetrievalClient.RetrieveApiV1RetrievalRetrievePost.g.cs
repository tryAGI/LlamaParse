#nullable enable

namespace LlamaParse
{
    public partial interface IRetrievalClient
    {
        /// <summary>
        /// Retrieve<br/>
        /// Retrieve relevant chunks via hybrid search (vector + full-text), with filtering on built-in or user-defined metadata.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.RetrieveApiResponse> RetrieveApiV1RetrievalRetrievePostAsync(

            global::LlamaParse.RetrieveParams request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve<br/>
        /// Retrieve relevant chunks via hybrid search (vector + full-text), with filtering on built-in or user-defined metadata.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.RetrieveApiResponse>> RetrieveApiV1RetrievalRetrievePostAsResponseAsync(

            global::LlamaParse.RetrieveParams request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve<br/>
        /// Retrieve relevant chunks via hybrid search (vector + full-text), with filtering on built-in or user-defined metadata.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="indexId">
        /// ID of the index to retrieve against.
        /// </param>
        /// <param name="query">
        /// Natural-language query to retrieve relevant chunks.
        /// </param>
        /// <param name="topK">
        /// Maximum number of results to return.
        /// </param>
        /// <param name="numCandidates">
        /// Number of candidates for approximate nearest neighbor search.
        /// </param>
        /// <param name="vectorPipelineWeight">
        /// Weight of the vector search pipeline (0-1).
        /// </param>
        /// <param name="fullTextPipelineWeight">
        /// Weight of the full-text search pipeline (0-1).
        /// </param>
        /// <param name="scoreThreshold">
        /// Minimum score threshold for returned results.
        /// </param>
        /// <param name="staticFilters">
        /// Filters on built-in document fields (page range, chunk index, etc.).
        /// </param>
        /// <param name="customFilters">
        /// Filters on user-defined metadata fields.
        /// </param>
        /// <param name="rerank">
        /// Reranking configuration applied after hybrid search. Enabled by default.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.RetrieveApiResponse> RetrieveApiV1RetrievalRetrievePostAsync(
            string indexId,
            string query,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            int? topK = default,
            int? numCandidates = default,
            double? vectorPipelineWeight = default,
            double? fullTextPipelineWeight = default,
            double? scoreThreshold = default,
            global::LlamaParse.MongoStaticFilters? staticFilters = default,
            object? customFilters = default,
            global::LlamaParse.RerankApiConfig? rerank = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}