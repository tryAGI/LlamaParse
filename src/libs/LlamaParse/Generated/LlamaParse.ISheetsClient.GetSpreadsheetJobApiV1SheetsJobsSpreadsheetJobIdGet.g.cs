#nullable enable

namespace LlamaParse
{
    public partial interface ISheetsClient
    {
        /// <summary>
        /// Get Spreadsheet Job<br/>
        /// Get a spreadsheet parsing job. When `include_results=True` (default), embeds extracted regions and results if complete, skipping the separate `/results` call.
        /// </summary>
        /// <param name="spreadsheetJobId"></param>
        /// <param name="includeResults">
        /// Default Value: true
        /// </param>
        /// <param name="expand">
        /// Optional fields to populate on the response. Valid values: metadata_state_transitions.
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.SpreadsheetJob> GetSpreadsheetJobApiV1SheetsJobsSpreadsheetJobIdGetAsync(
            string spreadsheetJobId,
            bool? includeResults = default,
            global::System.Collections.Generic.IList<string>? expand = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Spreadsheet Job<br/>
        /// Get a spreadsheet parsing job. When `include_results=True` (default), embeds extracted regions and results if complete, skipping the separate `/results` call.
        /// </summary>
        /// <param name="spreadsheetJobId"></param>
        /// <param name="includeResults">
        /// Default Value: true
        /// </param>
        /// <param name="expand">
        /// Optional fields to populate on the response. Valid values: metadata_state_transitions.
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.SpreadsheetJob>> GetSpreadsheetJobApiV1SheetsJobsSpreadsheetJobIdGetAsResponseAsync(
            string spreadsheetJobId,
            bool? includeResults = default,
            global::System.Collections.Generic.IList<string>? expand = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}