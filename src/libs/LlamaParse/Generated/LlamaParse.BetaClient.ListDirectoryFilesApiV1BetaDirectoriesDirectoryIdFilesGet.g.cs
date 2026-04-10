
#nullable enable

namespace LlamaParse
{
    public partial class BetaClient
    {


        private static readonly global::LlamaParse.EndPointSecurityRequirement s_ListDirectoryFilesApiV1BetaDirectoriesDirectoryIdFilesGetSecurityRequirement0 =
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
        private static readonly global::LlamaParse.EndPointSecurityRequirement[] s_ListDirectoryFilesApiV1BetaDirectoriesDirectoryIdFilesGetSecurityRequirements =
            new global::LlamaParse.EndPointSecurityRequirement[]
            {                s_ListDirectoryFilesApiV1BetaDirectoriesDirectoryIdFilesGetSecurityRequirement0,
            };
        partial void PrepareListDirectoryFilesApiV1BetaDirectoriesDirectoryIdFilesGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string directoryId,
            global::System.Guid? projectId,
            global::System.Guid? organizationId,
            ref string? displayName,
            ref string? displayNameContains,
            ref string? uniqueId,
            ref string? fileId,
            ref bool? includeDeleted,
            int? pageSize,
            ref string? pageToken,
            ref string? session);
        partial void PrepareListDirectoryFilesApiV1BetaDirectoriesDirectoryIdFilesGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string directoryId,
            global::System.Guid? projectId,
            global::System.Guid? organizationId,
            string? displayName,
            string? displayNameContains,
            string? uniqueId,
            string? fileId,
            bool? includeDeleted,
            int? pageSize,
            string? pageToken,
            string? session);
        partial void ProcessListDirectoryFilesApiV1BetaDirectoriesDirectoryIdFilesGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListDirectoryFilesApiV1BetaDirectoriesDirectoryIdFilesGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Directory Files<br/>
        /// List all files within the specified directory with optional filtering and pagination.
        /// </summary>
        /// <param name="directoryId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="displayName"></param>
        /// <param name="displayNameContains"></param>
        /// <param name="uniqueId"></param>
        /// <param name="fileId"></param>
        /// <param name="includeDeleted">
        /// Default Value: false
        /// </param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::LlamaParse.DirectoryFileQueryResponse> ListDirectoryFilesApiV1BetaDirectoriesDirectoryIdFilesGetAsync(
            string directoryId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? displayName = default,
            string? displayNameContains = default,
            string? uniqueId = default,
            string? fileId = default,
            bool? includeDeleted = default,
            int? pageSize = default,
            string? pageToken = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListDirectoryFilesApiV1BetaDirectoriesDirectoryIdFilesGetArguments(
                httpClient: HttpClient,
                directoryId: ref directoryId,
                projectId: projectId,
                organizationId: organizationId,
                displayName: ref displayName,
                displayNameContains: ref displayNameContains,
                uniqueId: ref uniqueId,
                fileId: ref fileId,
                includeDeleted: ref includeDeleted,
                pageSize: pageSize,
                pageToken: ref pageToken,
                session: ref session);


            var __authorizations = global::LlamaParse.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ListDirectoryFilesApiV1BetaDirectoriesDirectoryIdFilesGetSecurityRequirements,
                operationName: "ListDirectoryFilesApiV1BetaDirectoriesDirectoryIdFilesGetAsync");

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
                                path: $"/api/v1/beta/directories/{directoryId}/files",
                                baseUri: HttpClient.BaseAddress); 
                            __pathBuilder
                                .AddOptionalParameter("project_id", projectId?.ToString())
                                .AddOptionalParameter("organization_id", organizationId?.ToString())
                                .AddOptionalParameter("display_name", displayName)
                                .AddOptionalParameter("display_name_contains", displayNameContains)
                                .AddOptionalParameter("unique_id", uniqueId)
                                .AddOptionalParameter("file_id", fileId)
                                .AddOptionalParameter("include_deleted", includeDeleted?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("page_size", pageSize?.ToString())
                                .AddOptionalParameter("page_token", pageToken) 
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::LlamaParse.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
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
                                __cookies.Add($"session={__session.ToString() ?? string.Empty}");
                            }

                if (__cookies.Count > 0)
                            {
                                __httpRequest.Headers.TryAddWithoutValidation("Cookie", string.Join("; ", __cookies));
                            }
                global::LlamaParse.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareListDirectoryFilesApiV1BetaDirectoriesDirectoryIdFilesGetRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    directoryId: directoryId,
                    projectId: projectId,
                    organizationId: organizationId,
                    displayName: displayName,
                    displayNameContains: displayNameContains,
                    uniqueId: uniqueId,
                    fileId: fileId,
                    includeDeleted: includeDeleted,
                    pageSize: pageSize,
                    pageToken: pageToken,
                    session: session);

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
                                operationId: "ListDirectoryFilesApiV1BetaDirectoriesDirectoryIdFilesGet",
                                methodName: "ListDirectoryFilesApiV1BetaDirectoriesDirectoryIdFilesGetAsync",
                                pathTemplate: "$\"/api/v1/beta/directories/{directoryId}/files\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
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
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::LlamaParse.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::LlamaParse.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListDirectoryFilesApiV1BetaDirectoriesDirectoryIdFilesGet",
                                methodName: "ListDirectoryFilesApiV1BetaDirectoriesDirectoryIdFilesGetAsync",
                                pathTemplate: "$\"/api/v1/beta/directories/{directoryId}/files\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::LlamaParse.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::LlamaParse.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::LlamaParse.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::LlamaParse.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListDirectoryFilesApiV1BetaDirectoriesDirectoryIdFilesGet",
                                methodName: "ListDirectoryFilesApiV1BetaDirectoriesDirectoryIdFilesGetAsync",
                                pathTemplate: "$\"/api/v1/beta/directories/{directoryId}/files\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::LlamaParse.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
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
                ProcessListDirectoryFilesApiV1BetaDirectoriesDirectoryIdFilesGetResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::LlamaParse.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::LlamaParse.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListDirectoryFilesApiV1BetaDirectoriesDirectoryIdFilesGet",
                                methodName: "ListDirectoryFilesApiV1BetaDirectoriesDirectoryIdFilesGetAsync",
                                pathTemplate: "$\"/api/v1/beta/directories/{directoryId}/files\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::LlamaParse.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::LlamaParse.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListDirectoryFilesApiV1BetaDirectoriesDirectoryIdFilesGet",
                                methodName: "ListDirectoryFilesApiV1BetaDirectoriesDirectoryIdFilesGetAsync",
                                pathTemplate: "$\"/api/v1/beta/directories/{directoryId}/files\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
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
                                ProcessListDirectoryFilesApiV1BetaDirectoriesDirectoryIdFilesGetResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::LlamaParse.DirectoryFileQueryResponse.FromJson(__content, JsonSerializerContext) ??
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
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return
                                        await global::LlamaParse.DirectoryFileQueryResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
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
    }
}