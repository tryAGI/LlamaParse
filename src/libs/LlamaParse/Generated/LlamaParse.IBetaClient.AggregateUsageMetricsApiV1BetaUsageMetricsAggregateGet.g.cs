#nullable enable

namespace LlamaParse
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Aggregate Usage Metrics<br/>
        /// Aggregate usage metrics using the same filters as the regular list endpoint.<br/>
        /// The authenticated organization is always applied as a filter.
        /// </summary>
        /// <param name="groupBy">
        /// Dimensions to group by: day, project_id, event_type, tier.
        /// </param>
        /// <param name="organizationId"></param>
        /// <param name="projectId">
        /// Filter by project ID
        /// </param>
        /// <param name="userId">
        /// Filter by user ID
        /// </param>
        /// <param name="eventTypes">
        /// Filter by event types
        /// </param>
        /// <param name="days">
        /// Filter by specific days (YYYY-MM-DD)
        /// </param>
        /// <param name="dayOnOrBefore">
        /// Filter by days on or before this date (YYYY-MM-DD)
        /// </param>
        /// <param name="dayOnOrAfter">
        /// Filter by days on or after this date (YYYY-MM-DD)
        /// </param>
        /// <param name="eventAggregationType">
        /// Filter by event aggregation type
        /// </param>
        /// <param name="eventAggregationKey">
        /// Filter by event aggregation key
        /// </param>
        /// <param name="creditsConsumedGreaterThanOrEqual">
        /// Filter by credits consumed greater than or equal to this value
        /// </param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.UsageMetricAggregateResponse> AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetAsync(
            global::System.Collections.Generic.IList<global::LlamaParse.AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem> groupBy,
            global::System.Guid organizationId,
            global::System.Guid? projectId = default,
            string? userId = default,
            global::System.Collections.Generic.IList<string>? eventTypes = default,
            global::System.Collections.Generic.IList<string>? days = default,
            string? dayOnOrBefore = default,
            string? dayOnOrAfter = default,
            string? eventAggregationType = default,
            string? eventAggregationKey = default,
            double? creditsConsumedGreaterThanOrEqual = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Aggregate Usage Metrics<br/>
        /// Aggregate usage metrics using the same filters as the regular list endpoint.<br/>
        /// The authenticated organization is always applied as a filter.
        /// </summary>
        /// <param name="groupBy">
        /// Dimensions to group by: day, project_id, event_type, tier.
        /// </param>
        /// <param name="organizationId"></param>
        /// <param name="projectId">
        /// Filter by project ID
        /// </param>
        /// <param name="userId">
        /// Filter by user ID
        /// </param>
        /// <param name="eventTypes">
        /// Filter by event types
        /// </param>
        /// <param name="days">
        /// Filter by specific days (YYYY-MM-DD)
        /// </param>
        /// <param name="dayOnOrBefore">
        /// Filter by days on or before this date (YYYY-MM-DD)
        /// </param>
        /// <param name="dayOnOrAfter">
        /// Filter by days on or after this date (YYYY-MM-DD)
        /// </param>
        /// <param name="eventAggregationType">
        /// Filter by event aggregation type
        /// </param>
        /// <param name="eventAggregationKey">
        /// Filter by event aggregation key
        /// </param>
        /// <param name="creditsConsumedGreaterThanOrEqual">
        /// Filter by credits consumed greater than or equal to this value
        /// </param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.UsageMetricAggregateResponse>> AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetAsResponseAsync(
            global::System.Collections.Generic.IList<global::LlamaParse.AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem> groupBy,
            global::System.Guid organizationId,
            global::System.Guid? projectId = default,
            string? userId = default,
            global::System.Collections.Generic.IList<string>? eventTypes = default,
            global::System.Collections.Generic.IList<string>? days = default,
            string? dayOnOrBefore = default,
            string? dayOnOrAfter = default,
            string? eventAggregationType = default,
            string? eventAggregationKey = default,
            double? creditsConsumedGreaterThanOrEqual = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}