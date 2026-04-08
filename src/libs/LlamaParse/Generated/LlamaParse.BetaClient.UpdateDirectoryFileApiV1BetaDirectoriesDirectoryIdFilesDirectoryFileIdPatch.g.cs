
#nullable enable

namespace LlamaParse
{
    public partial class BetaClient
    {
        partial void PrepareUpdateDirectoryFileApiV1BetaDirectoriesDirectoryIdFilesDirectoryFileIdPatchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string directoryId,
            ref string directoryFileId,
            global::System.Guid? projectId,
            global::System.Guid? organizationId,
            ref string? session,
            global::LlamaParse.DirectoryFileUpdateRequest request);
        partial void PrepareUpdateDirectoryFileApiV1BetaDirectoriesDirectoryIdFilesDirectoryFileIdPatchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string directoryId,
            string directoryFileId,
            global::System.Guid? projectId,
            global::System.Guid? organizationId,
            string? session,
            global::LlamaParse.DirectoryFileUpdateRequest request);
        partial void ProcessUpdateDirectoryFileApiV1BetaDirectoriesDirectoryIdFilesDirectoryFileIdPatchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateDirectoryFileApiV1BetaDirectoriesDirectoryIdFilesDirectoryFileIdPatchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Directory File<br/>
        /// Update file metadata within the specified directory.<br/>
        /// Supports moving files to a different directory by setting directory_id.<br/>
        /// Note: This endpoint uses directory_file_id (the internal ID). If you're trying to update a file by its unique_id, use the list endpoint with a filter to find the directory_file_id first.
        /// </summary>
        /// <param name="directoryId"></param>
        /// <param name="directoryFileId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::LlamaParse.DirectoryFileResponse> UpdateDirectoryFileApiV1BetaDirectoriesDirectoryIdFilesDirectoryFileIdPatchAsync(
            string directoryId,
            string directoryFileId,

            global::LlamaParse.DirectoryFileUpdateRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUpdateDirectoryFileApiV1BetaDirectoriesDirectoryIdFilesDirectoryFileIdPatchArguments(
                httpClient: HttpClient,
                directoryId: ref directoryId,
                directoryFileId: ref directoryFileId,
                projectId: projectId,
                organizationId: organizationId,
                session: ref session,
                request: request);

            var __pathBuilder = new global::LlamaParse.PathBuilder(
                path: $"/api/v1/beta/directories/{directoryId}/files/{directoryFileId}",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("project_id", projectId?.ToString())
                .AddOptionalParameter("organization_id", organizationId?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
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
            PrepareUpdateDirectoryFileApiV1BetaDirectoriesDirectoryIdFilesDirectoryFileIdPatchRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                directoryId: directoryId,
                directoryFileId: directoryFileId,
                projectId: projectId,
                organizationId: organizationId,
                session: session,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUpdateDirectoryFileApiV1BetaDirectoriesDirectoryIdFilesDirectoryFileIdPatchResponse(
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
                ProcessUpdateDirectoryFileApiV1BetaDirectoriesDirectoryIdFilesDirectoryFileIdPatchResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::LlamaParse.DirectoryFileResponse.FromJson(__content, JsonSerializerContext) ??
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
                        await global::LlamaParse.DirectoryFileResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Update Directory File<br/>
        /// Update file metadata within the specified directory.<br/>
        /// Supports moving files to a different directory by setting directory_id.<br/>
        /// Note: This endpoint uses directory_file_id (the internal ID). If you're trying to update a file by its unique_id, use the list endpoint with a filter to find the directory_file_id first.
        /// </summary>
        /// <param name="directoryId"></param>
        /// <param name="directoryFileId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="uniqueId">
        /// Updated unique identifier.
        /// </param>
        /// <param name="displayName">
        /// Updated display name.
        /// </param>
        /// <param name="requestDirectoryId">
        /// Move file to a different directory.
        /// </param>
        /// <param name="metadata">
        /// User-defined metadata key-value pairs. Replaces the user metadata layer.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LlamaParse.DirectoryFileResponse> UpdateDirectoryFileApiV1BetaDirectoriesDirectoryIdFilesDirectoryFileIdPatchAsync(
            string directoryId,
            string directoryFileId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            string? uniqueId = default,
            string? displayName = default,
            string? requestDirectoryId = default,
            object? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::LlamaParse.DirectoryFileUpdateRequest
            {
                UniqueId = uniqueId,
                DisplayName = displayName,
                DirectoryId = requestDirectoryId,
                Metadata = metadata,
            };

            return await UpdateDirectoryFileApiV1BetaDirectoriesDirectoryIdFilesDirectoryFileIdPatchAsync(
                directoryId: directoryId,
                directoryFileId: directoryFileId,
                projectId: projectId,
                organizationId: organizationId,
                session: session,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}