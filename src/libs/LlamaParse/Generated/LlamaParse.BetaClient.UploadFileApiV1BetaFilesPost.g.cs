
#nullable enable

namespace LlamaParse
{
    public partial class BetaClient
    {


        private static readonly global::LlamaParse.EndPointSecurityRequirement s_UploadFileApiV1BetaFilesPostSecurityRequirement0 =
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
        private static readonly global::LlamaParse.EndPointSecurityRequirement[] s_UploadFileApiV1BetaFilesPostSecurityRequirements =
            new global::LlamaParse.EndPointSecurityRequirement[]
            {                s_UploadFileApiV1BetaFilesPostSecurityRequirement0,
            };
        partial void PrepareUploadFileApiV1BetaFilesPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Guid? projectId,
            global::System.Guid? organizationId,
            ref string? session,
            global::LlamaParse.BodyUploadFileApiV1BetaFilesPost request);
        partial void PrepareUploadFileApiV1BetaFilesPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid? projectId,
            global::System.Guid? organizationId,
            string? session,
            global::LlamaParse.BodyUploadFileApiV1BetaFilesPost request);
        partial void ProcessUploadFileApiV1BetaFilesPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUploadFileApiV1BetaFilesPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Upload File<br/>
        /// Upload a file using multipart/form-data.<br/>
        /// Set `purpose` to indicate how the file will be used:<br/>
        /// `user_data`, `parse`, `extract`, `classify`, `split`,<br/>
        /// `sheet`, or `agent_app`.<br/>
        /// Returns the created file metadata including its ID for use<br/>
        /// in subsequent parse, extract, or classify operations.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::LlamaParse.FileV2> UploadFileApiV1BetaFilesPostAsync(

            global::LlamaParse.BodyUploadFileApiV1BetaFilesPost request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUploadFileApiV1BetaFilesPostArguments(
                httpClient: HttpClient,
                projectId: projectId,
                organizationId: organizationId,
                session: ref session,
                request: request);


            var __authorizations = global::LlamaParse.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_UploadFileApiV1BetaFilesPostSecurityRequirements,
                operationName: "UploadFileApiV1BetaFilesPostAsync");

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
                                path: "/api/v1/beta/files",
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
                            var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
                            if (projectId != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(projectId.ToString() ?? string.Empty),
                                    name: "\"project_id\"");
                            } 
                            if (organizationId != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(organizationId.ToString() ?? string.Empty),
                                    name: "\"organization_id\"");
                            } 
                            if (session != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(session ?? string.Empty),
                                    name: "\"session\"");
                            }
                            __httpRequestContent.Add(
                                content: new global::System.Net.Http.StringContent(request.Purpose ?? string.Empty),
                                name: "\"purpose\"");
                            var __contentFile = new global::System.Net.Http.ByteArrayContent(request.File ?? global::System.Array.Empty<byte>());
                            __contentFile.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                request.Filename is null
                                    ? "application/octet-stream"
                                    : (global::System.IO.Path.GetExtension(request.Filename) ?? string.Empty).ToLowerInvariant() switch
                                    {
                                        ".aac" => "audio/aac",
                                        ".flac" => "audio/flac",
                                        ".gif" => "image/gif",
                                        ".jpeg" => "image/jpeg",
                                        ".jpg" => "image/jpeg",
                                        ".json" => "application/json",
                                        ".m4a" => "audio/mp4",
                                        ".mp3" => "audio/mpeg",
                                        ".mp4" => "video/mp4",
                                        ".mpeg" => "audio/mpeg",
                                        ".mpga" => "audio/mpeg",
                                        ".oga" => "audio/ogg",
                                        ".ogg" => "audio/ogg",
                                        ".opus" => "audio/ogg",
                                        ".pdf" => "application/pdf",
                                        ".png" => "image/png",
                                        ".txt" => "text/plain",
                                        ".wav" => "audio/wav",
                                        ".weba" => "audio/webm",
                                        ".webm" => "video/webm",
                                        ".webp" => "image/webp",
                                        _ => "application/octet-stream",
                                    });
                            __httpRequestContent.Add(
                                content: __contentFile,
                                name: "\"file\"",
                                fileName: request.Filename != null ? $"\"{request.Filename}\"" : string.Empty);
                            if (__contentFile.Headers.ContentDisposition != null)
                            {
                                __contentFile.Headers.ContentDisposition.FileNameStar = null;
                            }
                            if (request.ExternalFileId != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.ExternalFileId ?? string.Empty),
                                    name: "\"external_file_id\"");
                            }
                            __httpRequest.Content = __httpRequestContent;
                global::LlamaParse.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareUploadFileApiV1BetaFilesPostRequest(
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
                                operationId: "UploadFileApiV1BetaFilesPost",
                                methodName: "UploadFileApiV1BetaFilesPostAsync",
                                pathTemplate: "\"/api/v1/beta/files\"",
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
                                operationId: "UploadFileApiV1BetaFilesPost",
                                methodName: "UploadFileApiV1BetaFilesPostAsync",
                                pathTemplate: "\"/api/v1/beta/files\"",
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
                                operationId: "UploadFileApiV1BetaFilesPost",
                                methodName: "UploadFileApiV1BetaFilesPostAsync",
                                pathTemplate: "\"/api/v1/beta/files\"",
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
                ProcessUploadFileApiV1BetaFilesPostResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::LlamaParse.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::LlamaParse.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "UploadFileApiV1BetaFilesPost",
                                methodName: "UploadFileApiV1BetaFilesPostAsync",
                                pathTemplate: "\"/api/v1/beta/files\"",
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
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::LlamaParse.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::LlamaParse.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "UploadFileApiV1BetaFilesPost",
                                methodName: "UploadFileApiV1BetaFilesPostAsync",
                                pathTemplate: "\"/api/v1/beta/files\"",
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
                                ProcessUploadFileApiV1BetaFilesPostResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::LlamaParse.FileV2.FromJson(__content, JsonSerializerContext) ??
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
                                        await global::LlamaParse.FileV2.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// <summary>
        /// Upload File<br/>
        /// Upload a file using multipart/form-data.<br/>
        /// Set `purpose` to indicate how the file will be used:<br/>
        /// `user_data`, `parse`, `extract`, `classify`, `split`,<br/>
        /// `sheet`, or `agent_app`.<br/>
        /// Returns the created file metadata including its ID for use<br/>
        /// in subsequent parse, extract, or classify operations.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="purpose">
        /// The intended purpose of the file. Valid values: 'user_data', 'parse', 'extract', 'split', 'classify', 'sheet', 'agent_app'. This determines the storage and retention policy for the file.
        /// </param>
        /// <param name="file">
        /// The file to upload
        /// </param>
        /// <param name="filename">
        /// The file to upload
        /// </param>
        /// <param name="externalFileId">
        /// The ID of the file in the external system
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LlamaParse.FileV2> UploadFileApiV1BetaFilesPostAsync(
            string purpose,
            byte[] file,
            string filename,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            string? externalFileId = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::LlamaParse.BodyUploadFileApiV1BetaFilesPost
            {
                Purpose = purpose,
                File = file,
                Filename = filename,
                ExternalFileId = externalFileId,
            };

            return await UploadFileApiV1BetaFilesPostAsync(
                projectId: projectId,
                organizationId: organizationId,
                session: session,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}