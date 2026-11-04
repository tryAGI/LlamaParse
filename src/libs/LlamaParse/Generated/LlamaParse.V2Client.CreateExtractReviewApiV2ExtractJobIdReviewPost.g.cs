
#nullable enable

namespace LlamaParse
{
    public partial class V2Client
    {


        private static readonly global::LlamaParse.EndPointSecurityRequirement s_CreateExtractReviewApiV2ExtractJobIdReviewPostSecurityRequirement0 =
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
        private static readonly global::LlamaParse.EndPointSecurityRequirement[] s_CreateExtractReviewApiV2ExtractJobIdReviewPostSecurityRequirements =
            new global::LlamaParse.EndPointSecurityRequirement[]
            {                s_CreateExtractReviewApiV2ExtractJobIdReviewPostSecurityRequirement0,
            };
        partial void PrepareCreateExtractReviewApiV2ExtractJobIdReviewPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string jobId,
            ref global::LlamaParse.CreateExtractReviewApiV2ExtractJobIdReviewPostOrigin? origin,
            global::System.Guid? projectId,
            global::System.Guid? organizationId,
            ref string? session,
            global::LlamaParse.ExtractReviewCreateRequest request);
        partial void PrepareCreateExtractReviewApiV2ExtractJobIdReviewPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string jobId,
            global::LlamaParse.CreateExtractReviewApiV2ExtractJobIdReviewPostOrigin? origin,
            global::System.Guid? projectId,
            global::System.Guid? organizationId,
            string? session,
            global::LlamaParse.ExtractReviewCreateRequest request);
        partial void ProcessCreateExtractReviewApiV2ExtractJobIdReviewPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateExtractReviewApiV2ExtractJobIdReviewPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Extract Review<br/>
        /// Beta: answers 403 until extract review is enabled for the caller and their organization.<br/>
        /// Turn review on for an extract job.<br/>
        /// Fields read below `confidence_threshold`, and required fields left empty, are<br/>
        /// flagged for a person to check. Every setting has a default, so the body can be<br/>
        /// left out. A job still running can be named: it waits for review once it<br/>
        /// completes. A job that failed, was cancelled, or cannot be reviewed answers 409<br/>
        /// with `code: job_not_reviewable`; a field in `fields_in_scope` the job's schema<br/>
        /// does not have answers 400.<br/>
        /// Answers 201 with the new review, or 200 with the job's existing review, whose<br/>
        /// settings stay as they are.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="origin">
        /// Where in the app review was turned on.
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::LlamaParse.ExtractReviewResponse> CreateExtractReviewApiV2ExtractJobIdReviewPostAsync(
            string jobId,

            global::LlamaParse.ExtractReviewCreateRequest request,
            global::LlamaParse.CreateExtractReviewApiV2ExtractJobIdReviewPostOrigin? origin = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await CreateExtractReviewApiV2ExtractJobIdReviewPostAsResponseAsync(
                jobId: jobId,

                request: request,
                origin: origin,
                projectId: projectId,
                organizationId: organizationId,
                session: session,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Create Extract Review<br/>
        /// Beta: answers 403 until extract review is enabled for the caller and their organization.<br/>
        /// Turn review on for an extract job.<br/>
        /// Fields read below `confidence_threshold`, and required fields left empty, are<br/>
        /// flagged for a person to check. Every setting has a default, so the body can be<br/>
        /// left out. A job still running can be named: it waits for review once it<br/>
        /// completes. A job that failed, was cancelled, or cannot be reviewed answers 409<br/>
        /// with `code: job_not_reviewable`; a field in `fields_in_scope` the job's schema<br/>
        /// does not have answers 400.<br/>
        /// Answers 201 with the new review, or 200 with the job's existing review, whose<br/>
        /// settings stay as they are.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="origin">
        /// Where in the app review was turned on.
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.ExtractReviewResponse>> CreateExtractReviewApiV2ExtractJobIdReviewPostAsResponseAsync(
            string jobId,

            global::LlamaParse.ExtractReviewCreateRequest request,
            global::LlamaParse.CreateExtractReviewApiV2ExtractJobIdReviewPostOrigin? origin = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateExtractReviewApiV2ExtractJobIdReviewPostArguments(
                httpClient: HttpClient,
                jobId: ref jobId,
                origin: ref origin,
                projectId: projectId,
                organizationId: organizationId,
                session: ref session,
                request: request);


            var __authorizations = global::LlamaParse.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateExtractReviewApiV2ExtractJobIdReviewPostSecurityRequirements,
                operationName: "CreateExtractReviewApiV2ExtractJobIdReviewPostAsync");

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
                                path: $"/api/v2/extract/{jobId}/review",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("origin", origin?.ToValueString())
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
                PrepareCreateExtractReviewApiV2ExtractJobIdReviewPostRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    jobId: jobId,
                    origin: origin,
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
                                operationId: "CreateExtractReviewApiV2ExtractJobIdReviewPost",
                                methodName: "CreateExtractReviewApiV2ExtractJobIdReviewPostAsync",
                                pathTemplate: "$\"/api/v2/extract/{jobId}/review\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                                operationId: "CreateExtractReviewApiV2ExtractJobIdReviewPost",
                                methodName: "CreateExtractReviewApiV2ExtractJobIdReviewPostAsync",
                                pathTemplate: "$\"/api/v2/extract/{jobId}/review\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                                operationId: "CreateExtractReviewApiV2ExtractJobIdReviewPost",
                                methodName: "CreateExtractReviewApiV2ExtractJobIdReviewPostAsync",
                                pathTemplate: "$\"/api/v2/extract/{jobId}/review\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                ProcessCreateExtractReviewApiV2ExtractJobIdReviewPostResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::LlamaParse.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::LlamaParse.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateExtractReviewApiV2ExtractJobIdReviewPost",
                                methodName: "CreateExtractReviewApiV2ExtractJobIdReviewPostAsync",
                                pathTemplate: "$\"/api/v2/extract/{jobId}/review\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                                operationId: "CreateExtractReviewApiV2ExtractJobIdReviewPost",
                                methodName: "CreateExtractReviewApiV2ExtractJobIdReviewPostAsync",
                                pathTemplate: "$\"/api/v2/extract/{jobId}/review\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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


                                throw global::LlamaParse.ApiException<global::LlamaParse.HTTPValidationError>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_422,
                                    responseBody: __content_422,
                                    responseObject: __value_422,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
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
                                ProcessCreateExtractReviewApiV2ExtractJobIdReviewPostResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::LlamaParse.ExtractReviewResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.ExtractReviewResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::LlamaParse.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::LlamaParse.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
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

                                    var __value = await global::LlamaParse.ExtractReviewResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.ExtractReviewResponse>(
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

                                    throw global::LlamaParse.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
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
        /// Create Extract Review<br/>
        /// Beta: answers 403 until extract review is enabled for the caller and their organization.<br/>
        /// Turn review on for an extract job.<br/>
        /// Fields read below `confidence_threshold`, and required fields left empty, are<br/>
        /// flagged for a person to check. Every setting has a default, so the body can be<br/>
        /// left out. A job still running can be named: it waits for review once it<br/>
        /// completes. A job that failed, was cancelled, or cannot be reviewed answers 409<br/>
        /// with `code: job_not_reviewable`; a field in `fields_in_scope` the job's schema<br/>
        /// does not have answers 400.<br/>
        /// Answers 201 with the new review, or 200 with the job's existing review, whose<br/>
        /// settings stay as they are.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="origin">
        /// Where in the app review was turned on.
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="confidenceThreshold">
        /// Fields read below this confidence are flagged.<br/>
        /// Default Value: 0.7F
        /// </param>
        /// <param name="fieldsInScope">
        /// JSON Pointers of the fields the threshold applies to; empty means all.
        /// </param>
        /// <param name="requiredFields">
        /// JSON Pointers of fields flagged when empty; defaults to the schema's required.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LlamaParse.ExtractReviewResponse> CreateExtractReviewApiV2ExtractJobIdReviewPostAsync(
            string jobId,
            global::LlamaParse.CreateExtractReviewApiV2ExtractJobIdReviewPostOrigin? origin = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            double? confidenceThreshold = default,
            global::System.Collections.Generic.IList<string>? fieldsInScope = default,
            global::System.Collections.Generic.IList<string>? requiredFields = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::LlamaParse.ExtractReviewCreateRequest
            {
                ConfidenceThreshold = confidenceThreshold,
                FieldsInScope = fieldsInScope,
                RequiredFields = requiredFields,
            };

            return await CreateExtractReviewApiV2ExtractJobIdReviewPostAsync(
                jobId: jobId,
                origin: origin,
                projectId: projectId,
                organizationId: organizationId,
                session: session,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}