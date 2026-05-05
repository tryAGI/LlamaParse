#nullable enable

namespace LlamaParse
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Delete Spreadsheet Job<br/>
        /// Delete a spreadsheet parsing job and its associated data.<br/>
        /// Experimental: This endpoint is not yet ready for production use and is subject to change at any time.
        /// </summary>
        /// <param name="spreadsheetJobId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteSpreadsheetJobApiV1BetaSheetsJobsSpreadsheetJobIdDeleteAsync(
            string spreadsheetJobId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Spreadsheet Job<br/>
        /// Delete a spreadsheet parsing job and its associated data.<br/>
        /// Experimental: This endpoint is not yet ready for production use and is subject to change at any time.
        /// </summary>
        /// <param name="spreadsheetJobId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<string>> DeleteSpreadsheetJobApiV1BetaSheetsJobsSpreadsheetJobIdDeleteAsResponseAsync(
            string spreadsheetJobId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}