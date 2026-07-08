#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace LlamaParse
{
    public partial interface ISheetsClient
    {
        /// <summary>
        /// Create Spreadsheet Job<br/>
        /// Create a spreadsheet parsing job.<br/>
        /// Provide at most one of `configuration` (an inline parsing configuration) or<br/>
        /// `configuration_id` (a saved configuration preset). If neither is provided, a<br/>
        /// default configuration is used. Optionally include `webhook_configurations`<br/>
        /// to receive `sheets.*` status notifications.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.SpreadsheetJob> CreateSpreadsheetJobApiV1SheetsJobsPostAsync(

            global::LlamaParse.SpreadsheetJobCreate request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Spreadsheet Job<br/>
        /// Create a spreadsheet parsing job.<br/>
        /// Provide at most one of `configuration` (an inline parsing configuration) or<br/>
        /// `configuration_id` (a saved configuration preset). If neither is provided, a<br/>
        /// default configuration is used. Optionally include `webhook_configurations`<br/>
        /// to receive `sheets.*` status notifications.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.SpreadsheetJob>> CreateSpreadsheetJobApiV1SheetsJobsPostAsResponseAsync(

            global::LlamaParse.SpreadsheetJobCreate request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Spreadsheet Job<br/>
        /// Create a spreadsheet parsing job.<br/>
        /// Provide at most one of `configuration` (an inline parsing configuration) or<br/>
        /// `configuration_id` (a saved configuration preset). If neither is provided, a<br/>
        /// default configuration is used. Optionally include `webhook_configurations`<br/>
        /// to receive `sheets.*` status notifications.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="configurationId">
        /// Saved configuration ID
        /// </param>
        /// <param name="configuration">
        /// Inline configuration
        /// </param>
        /// <param name="webhookConfigurations">
        /// Outbound webhook endpoints to notify on job status changes
        /// </param>
        /// <param name="fileId">
        /// The ID of the file to parse
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.SpreadsheetJob> CreateSpreadsheetJobApiV1SheetsJobsPostAsync(
            global::System.Guid fileId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            string? configurationId = default,
            global::LlamaParse.SpreadsheetParsingConfig? configuration = default,
            global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfiguration>? webhookConfigurations = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}