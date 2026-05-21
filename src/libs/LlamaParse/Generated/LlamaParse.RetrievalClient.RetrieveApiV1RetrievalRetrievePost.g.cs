
#nullable enable

namespace LlamaParse
{
    public partial class RetrievalClient
    {


        private static readonly global::LlamaParse.EndPointSecurityRequirement s_RetrieveApiV1RetrievalRetrievePostSecurityRequirement0 =
            new global::LlamaParse.EndPointSecurityRequirement
            {
                Authorizations = new global::LlamaParse.EndPointAuthorizationRequirement[]
                {                    new global::LlamaParse.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::LlamaParse.EndPointSecurityRequirement[] s_RetrieveApiV1RetrievalRetrievePostSecurityRequirements =
            new global::LlamaParse.EndPointSecurityRequirement[]
            {                s_RetrieveApiV1RetrievalRetrievePostSecurityRequirement0,
            };
        partial void PrepareRetrieveApiV1RetrievalRetrievePostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Guid? projectId,
            global::System.Guid? organizationId,
            ref string? session,
            global::LlamaParse.RetrieveParams request);
        partial void PrepareRetrieveApiV1RetrievalRetrievePostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid? projectId,
            global::System.Guid? organizationId,
            string? session,
            global::LlamaParse.RetrieveParams request);
        partial void ProcessRetrieveApiV1RetrievalRetrievePostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessRetrieveApiV1RetrievalRetrievePostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        public async global::System.Threading.Tasks.Task<global::LlamaParse.RetrieveResult> RetrieveApiV1RetrievalRetrievePostAsync(

            global::LlamaParse.RetrieveParams request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await RetrieveApiV1RetrievalRetrievePostAsResponseAsync(

                request: request,
                projectId: projectId,
                organizationId: organizationId,
                session: session,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
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
        public async global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.RetrieveResult>> RetrieveApiV1RetrievalRetrievePostAsResponseAsync(

            global::LlamaParse.RetrieveParams request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareRetrieveApiV1RetrievalRetrievePostArguments(
                httpClient: HttpClient,
                projectId: projectId,
                organizationId: organizationId,
                session: ref session,
                request: request);


            var __authorizations = global::LlamaParse.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_RetrieveApiV1RetrievalRetrievePostSecurityRequirements,
                operationName: "RetrieveApiV1RetrievalRetrievePostAsync");

            using var __timeoutCancellationTokenSource = global::LlamaParse.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::LlamaParse.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::LlamaParse.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::LlamaParse.PathBuilder(
                                path: "/api/v1/retrieval/retrieve",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("project_id", projectId?.ToString())
                                .AddOptionalParameter("organization_id", organizationId?.ToString())
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::LlamaParse.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

                var __cookies = new global::System.Collections.Generic.List<string>();

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                            var __session = session;
                            if (__session is not null)
                            {
                                __cookies.Add("session=" + (__session ?? string.Empty));
                            }

                if (__cookies.Count > 0)
                            {
                                __httpRequest.Headers.TryAddWithoutValidation("Cookie", string.Join("; ", __cookies));
                            }
                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::LlamaParse.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareRetrieveApiV1RetrievalRetrievePostRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    projectId: projectId,
                    organizationId: organizationId,
                    session: session,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::LlamaParse.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::LlamaParse.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "RetrieveApiV1RetrievalRetrievePost",
                                methodName: "RetrieveApiV1RetrievalRetrievePostAsync",
                                pathTemplate: "\"/api/v1/retrieval/retrieve\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::LlamaParse.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::LlamaParse.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::LlamaParse.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "RetrieveApiV1RetrievalRetrievePost",
                                methodName: "RetrieveApiV1RetrievalRetrievePostAsync",
                                pathTemplate: "\"/api/v1/retrieval/retrieve\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::LlamaParse.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::LlamaParse.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::LlamaParse.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::LlamaParse.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::LlamaParse.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "RetrieveApiV1RetrievalRetrievePost",
                                methodName: "RetrieveApiV1RetrievalRetrievePostAsync",
                                pathTemplate: "\"/api/v1/retrieval/retrieve\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::LlamaParse.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessRetrieveApiV1RetrievalRetrievePostResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::LlamaParse.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::LlamaParse.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "RetrieveApiV1RetrievalRetrievePost",
                                methodName: "RetrieveApiV1RetrievalRetrievePostAsync",
                                pathTemplate: "\"/api/v1/retrieval/retrieve\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::LlamaParse.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::LlamaParse.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "RetrieveApiV1RetrievalRetrievePost",
                                methodName: "RetrieveApiV1RetrievalRetrievePostAsync",
                                pathTemplate: "\"/api/v1/retrieval/retrieve\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Validation Error
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                global::LlamaParse.HTTPValidationError? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = global::LlamaParse.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

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

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessRetrieveApiV1RetrievalRetrievePostResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::LlamaParse.RetrieveResult.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.RetrieveResult>(
                                        statusCode: __response.StatusCode,
                                        headers: global::LlamaParse.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
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
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::LlamaParse.RetrieveResult.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.RetrieveResult>(
                                        statusCode: __response.StatusCode,
                                        headers: global::LlamaParse.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
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
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
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
        public async global::System.Threading.Tasks.Task<global::LlamaParse.RetrieveResult> RetrieveApiV1RetrievalRetrievePostAsync(
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
            global::LlamaParse.RerankConfig2? rerank = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::LlamaParse.RetrieveParams
            {
                IndexId = indexId,
                Query = query,
                TopK = topK,
                NumCandidates = numCandidates,
                VectorPipelineWeight = vectorPipelineWeight,
                FullTextPipelineWeight = fullTextPipelineWeight,
                ScoreThreshold = scoreThreshold,
                StaticFilters = staticFilters,
                CustomFilters = customFilters,
                Rerank = rerank,
            };

            return await RetrieveApiV1RetrievalRetrievePostAsync(
                projectId: projectId,
                organizationId: organizationId,
                session: session,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}