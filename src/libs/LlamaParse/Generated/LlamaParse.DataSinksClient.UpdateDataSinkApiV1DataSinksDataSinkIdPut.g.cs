
#nullable enable

namespace LlamaParse
{
    public partial class DataSinksClient
    {
        partial void PrepareUpdateDataSinkApiV1DataSinksDataSinkIdPutArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid dataSinkId,
            ref string? session,
            global::LlamaParse.DataSinkUpdate request);
        partial void PrepareUpdateDataSinkApiV1DataSinksDataSinkIdPutRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid dataSinkId,
            string? session,
            global::LlamaParse.DataSinkUpdate request);
        partial void ProcessUpdateDataSinkApiV1DataSinksDataSinkIdPutResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateDataSinkApiV1DataSinksDataSinkIdPutResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Data Sink<br/>
        /// Update a data sink by ID.
        /// </summary>
        /// <param name="dataSinkId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::LlamaParse.DataSink> UpdateDataSinkApiV1DataSinksDataSinkIdPutAsync(
            global::System.Guid dataSinkId,

            global::LlamaParse.DataSinkUpdate request,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUpdateDataSinkApiV1DataSinksDataSinkIdPutArguments(
                httpClient: HttpClient,
                dataSinkId: ref dataSinkId,
                session: ref session,
                request: request);

            var __pathBuilder = new global::LlamaParse.PathBuilder(
                path: $"/api/v1/data-sinks/{dataSinkId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareUpdateDataSinkApiV1DataSinksDataSinkIdPutRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                dataSinkId: dataSinkId,
                session: session,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUpdateDataSinkApiV1DataSinksDataSinkIdPutResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation Error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::LlamaParse.HTTPValidationError? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::LlamaParse.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::LlamaParse.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::LlamaParse.ApiException<global::LlamaParse.HTTPValidationError>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_422,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessUpdateDataSinkApiV1DataSinksDataSinkIdPutResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::LlamaParse.DataSink.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::LlamaParse.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::LlamaParse.DataSink.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::LlamaParse.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
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
        public async global::System.Threading.Tasks.Task<global::LlamaParse.DataSink> UpdateDataSinkApiV1DataSinksDataSinkIdPutAsync(
            global::System.Guid dataSinkId,
            global::LlamaParse.ConfigurableDataSinkNames sinkType,
            string? session = default,
            string? name = default,
            global::LlamaParse.AnyOf<object, global::LlamaParse.CloudPineconeVectorStore, global::LlamaParse.CloudPostgresVectorStore, global::LlamaParse.CloudQdrantVectorStore, global::LlamaParse.CloudAzureAISearchVectorStore, global::LlamaParse.CloudMongoDBAtlasVectorSearch, global::LlamaParse.CloudMilvusVectorStore, global::LlamaParse.CloudAstraDBVectorStore, object>? component = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::LlamaParse.DataSinkUpdate
            {
                Name = name,
                SinkType = sinkType,
                Component = component,
            };

            return await UpdateDataSinkApiV1DataSinksDataSinkIdPutAsync(
                dataSinkId: dataSinkId,
                session: session,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}