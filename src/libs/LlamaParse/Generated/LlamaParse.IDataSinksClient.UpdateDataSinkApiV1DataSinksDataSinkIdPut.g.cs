#nullable enable

namespace LlamaParse
{
    public partial interface IDataSinksClient
    {
        /// <summary>
        /// Update Data Sink<br/>
        /// Update a data sink by ID.
        /// </summary>
        /// <param name="dataSinkId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.DataSink> UpdateDataSinkApiV1DataSinksDataSinkIdPutAsync(
            global::System.Guid dataSinkId,

            global::LlamaParse.DataSinkUpdate request,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Data Sink<br/>
        /// Update a data sink by ID.
        /// </summary>
        /// <param name="dataSinkId"></param>
        /// <param name="session"></param>
        /// <param name="name">
        /// The name of the data sink.
        /// </param>
        /// <param name="sinkType"></param>
        /// <param name="component">
        /// Component that implements the data sink
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.DataSink> UpdateDataSinkApiV1DataSinksDataSinkIdPutAsync(
            global::System.Guid dataSinkId,
            global::LlamaParse.ConfigurableDataSinkNames sinkType,
            string? session = default,
            string? name = default,
            global::LlamaParse.AnyOf<object, global::LlamaParse.CloudPineconeVectorStore, global::LlamaParse.CloudPostgresVectorStore, global::LlamaParse.CloudQdrantVectorStore, global::LlamaParse.CloudAzureAISearchVectorStore, global::LlamaParse.CloudMongoDBAtlasVectorSearch, global::LlamaParse.CloudMilvusVectorStore, global::LlamaParse.CloudAstraDBVectorStore, object>? component = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}