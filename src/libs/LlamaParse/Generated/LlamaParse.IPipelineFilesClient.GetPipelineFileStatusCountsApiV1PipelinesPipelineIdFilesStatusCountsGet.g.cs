#nullable enable

namespace LlamaParse
{
    public partial interface IPipelineFilesClient
    {
        /// <summary>
        /// Get Pipeline File Status Counts<br/>
        /// Get files for a pipeline.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="dataSourceId"></param>
        /// <param name="onlyManuallyUploaded">
        /// Default Value: false
        /// </param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.FileCountByStatusResponse> GetPipelineFileStatusCountsApiV1PipelinesPipelineIdFilesStatusCountsGetAsync(
            global::System.Guid pipelineId,
            global::System.Guid? dataSourceId = default,
            bool? onlyManuallyUploaded = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}