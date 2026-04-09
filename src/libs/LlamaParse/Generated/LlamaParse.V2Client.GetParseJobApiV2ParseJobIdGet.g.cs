
#nullable enable

namespace LlamaParse
{
    public partial class V2Client
    {


        private static readonly global::LlamaParse.EndPointSecurityRequirement s_GetParseJobApiV2ParseJobIdGetSecurityRequirement0 =
            new global::LlamaParse.EndPointSecurityRequirement
            {
                Authorizations = new global::LlamaParse.EndPointAuthorizationRequirement[]
                {                    new global::LlamaParse.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::LlamaParse.EndPointSecurityRequirement[] s_GetParseJobApiV2ParseJobIdGetSecurityRequirements =
            new global::LlamaParse.EndPointSecurityRequirement[]
            {                s_GetParseJobApiV2ParseJobIdGetSecurityRequirement0,
            };
        partial void PrepareGetParseJobApiV2ParseJobIdGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string jobId,
            global::System.Collections.Generic.IList<string>? expand,
            ref string? imageFilenames,
            global::System.Guid? projectId,
            global::System.Guid? organizationId,
            ref string? session);
        partial void PrepareGetParseJobApiV2ParseJobIdGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string jobId,
            global::System.Collections.Generic.IList<string>? expand,
            string? imageFilenames,
            global::System.Guid? projectId,
            global::System.Guid? organizationId,
            string? session);
        partial void ProcessGetParseJobApiV2ParseJobIdGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetParseJobApiV2ParseJobIdGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Parse Job<br/>
        /// Retrieve a parse job with optional expanded content.<br/>
        /// By default returns job metadata only. Use `expand` to include<br/>
        /// parsed content:<br/>
        /// - `text` — plain text output<br/>
        /// - `markdown` — markdown output<br/>
        /// - `items` — structured page-by-page output<br/>
        /// - `job_metadata` — usage and processing details<br/>
        /// Content metadata fields (e.g. `text_content_metadata`) return<br/>
        /// presigned URLs for downloading large results.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="expand">
        /// Fields to include: text, markdown, items, metadata, job_metadata, text_content_metadata, markdown_content_metadata, items_content_metadata, metadata_content_metadata, xlsx_content_metadata, output_pdf_content_metadata, images_content_metadata. Metadata fields include presigned URLs.
        /// </param>
        /// <param name="imageFilenames">
        /// Filter to specific image filenames (optional). Example: image_0.png,image_1.jpg
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::LlamaParse.ParseResultResponse> GetParseJobApiV2ParseJobIdGetAsync(
            string jobId,
            global::System.Collections.Generic.IList<string>? expand = default,
            string? imageFilenames = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetParseJobApiV2ParseJobIdGetArguments(
                httpClient: HttpClient,
                jobId: ref jobId,
                expand: expand,
                imageFilenames: ref imageFilenames,
                projectId: projectId,
                organizationId: organizationId,
                session: ref session);


            var __authorizations = global::LlamaParse.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetParseJobApiV2ParseJobIdGetSecurityRequirements,
                operationName: "GetParseJobApiV2ParseJobIdGetAsync");

            var __pathBuilder = new global::LlamaParse.PathBuilder(
                path: $"/api/v2/parse/{jobId}",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("expand", expand, delimiter: ",", explode: true)
                .AddOptionalParameter("image_filenames", imageFilenames)
                .AddOptionalParameter("project_id", projectId?.ToString())
                .AddOptionalParameter("organization_id", organizationId?.ToString()) 
                ;
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
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
            var __cookies = new global::System.Collections.Generic.List<string>();
            var __session = session;
            if (__session is not null)
            {
                __cookies.Add($"session={__session.ToString() ?? string.Empty}");
            }
            if (__cookies.Count > 0)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Cookie", string.Join("; ", __cookies));
            }


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGetParseJobApiV2ParseJobIdGetRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                jobId: jobId,
                expand: expand,
                imageFilenames: imageFilenames,
                projectId: projectId,
                organizationId: organizationId,
                session: session);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetParseJobApiV2ParseJobIdGetResponse(
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
                ProcessGetParseJobApiV2ParseJobIdGetResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::LlamaParse.ParseResultResponse.FromJson(__content, JsonSerializerContext) ??
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
                        await global::LlamaParse.ParseResultResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
    }
}