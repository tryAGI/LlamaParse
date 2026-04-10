#nullable enable

namespace LlamaParse
{
    public partial interface IEmbeddingModelConfigsClient
    {
        /// <summary>
        /// Update Embedding Model Config<br/>
        /// Update an embedding model config by ID.
        /// </summary>
        /// <param name="embeddingModelConfigId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.EmbeddingModelConfig> UpdateEmbeddingModelConfigApiV1EmbeddingModelConfigsEmbeddingModelConfigIdPutAsync(
            global::System.Guid embeddingModelConfigId,

            global::LlamaParse.EmbeddingModelConfigUpdate request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Embedding Model Config<br/>
        /// Update an embedding model config by ID.
        /// </summary>
        /// <param name="embeddingModelConfigId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="name">
        /// The name of the embedding model config.
        /// </param>
        /// <param name="embeddingConfig">
        /// The embedding configuration for the embedding model config.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.EmbeddingModelConfig> UpdateEmbeddingModelConfigApiV1EmbeddingModelConfigsEmbeddingModelConfigIdPutAsync(
            global::System.Guid embeddingModelConfigId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            string? name = default,
            global::LlamaParse.EmbeddingConfigVariant1? embeddingConfig = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}