#nullable enable

namespace LlamaParse
{
    public partial interface IRetrieversClient
    {
        /// <summary>
        /// Direct Retrieve<br/>
        /// Retrieve data using specified pipelines without creating a persistent retriever.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.CompositeRetrievalResult> DirectRetrieveApiV1RetrieversRetrievePostAsync(

            global::LlamaParse.DirectRetrievalParams request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Direct Retrieve<br/>
        /// Retrieve data using specified pipelines without creating a persistent retriever.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="mode">
        /// The mode of composite retrieval.<br/>
        /// Default Value: full
        /// </param>
        /// <param name="rerankConfig">
        /// The rerank configuration for composite retrieval.
        /// </param>
        /// <param name="query">
        /// The query to retrieve against.
        /// </param>
        /// <param name="pipelines">
        /// The pipelines to use for retrieval.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.CompositeRetrievalResult> DirectRetrieveApiV1RetrieversRetrievePostAsync(
            string query,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.CompositeRetrievalMode? mode = default,
            global::LlamaParse.ReRankConfig? rerankConfig = default,
            global::System.Collections.Generic.IList<global::LlamaParse.RetrieverPipeline>? pipelines = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}