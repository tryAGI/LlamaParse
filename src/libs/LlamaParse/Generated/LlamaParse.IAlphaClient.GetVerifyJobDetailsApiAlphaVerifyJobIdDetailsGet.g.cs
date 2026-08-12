#nullable enable

namespace LlamaParse
{
    public partial interface IAlphaClient
    {
        /// <summary>
        /// Get Verify Job Details<br/>
        /// Get the raw per-signal detail for a completed Verify job.<br/>
        /// Forensic drill-down behind the simplified result: the full evidence<br/>
        /// list, per-family sub-scores, raw localized regions, and per-page<br/>
        /// forensic heatmap overlays (presigned image URLs).
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.VerifyJobDetailsResponse> GetVerifyJobDetailsApiAlphaVerifyJobIdDetailsGetAsync(
            string jobId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Verify Job Details<br/>
        /// Get the raw per-signal detail for a completed Verify job.<br/>
        /// Forensic drill-down behind the simplified result: the full evidence<br/>
        /// list, per-family sub-scores, raw localized regions, and per-page<br/>
        /// forensic heatmap overlays (presigned image URLs).
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.VerifyJobDetailsResponse>> GetVerifyJobDetailsApiAlphaVerifyJobIdDetailsGetAsResponseAsync(
            string jobId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}