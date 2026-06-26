#nullable enable

namespace LlamaParse
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// List Directories
        /// </summary>
        /// <param name="name">
        /// Directory name to match.
        /// </param>
        /// <param name="type">
        /// Directory type to include.
        /// </param>
        /// <param name="types">
        /// Filter by one or more directory types. Repeat the parameter for multiple values.
        /// </param>
        /// <param name="includeDeleted">
        /// Include deleted directories.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.DirectoryQueryResponse> ListDirectoriesApiV1BetaDirectoriesGetAsync(
            string? name = default,
            global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetType2? type = default,
            global::System.Collections.Generic.IList<global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1Item>? types = default,
            bool? includeDeleted = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            int? pageSize = default,
            string? pageToken = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Directories
        /// </summary>
        /// <param name="name">
        /// Directory name to match.
        /// </param>
        /// <param name="type">
        /// Directory type to include.
        /// </param>
        /// <param name="types">
        /// Filter by one or more directory types. Repeat the parameter for multiple values.
        /// </param>
        /// <param name="includeDeleted">
        /// Include deleted directories.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.DirectoryQueryResponse>> ListDirectoriesApiV1BetaDirectoriesGetAsResponseAsync(
            string? name = default,
            global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetType2? type = default,
            global::System.Collections.Generic.IList<global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1Item>? types = default,
            bool? includeDeleted = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            int? pageSize = default,
            string? pageToken = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}