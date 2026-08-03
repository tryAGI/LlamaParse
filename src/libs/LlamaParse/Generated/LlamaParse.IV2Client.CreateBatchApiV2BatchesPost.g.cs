#nullable enable

namespace LlamaParse
{
    public partial interface IV2Client
    {
        /// <summary>
        /// Create Batch<br/>
        /// Create a batch over a source directory and start processing asynchronously.<br/>
        /// To be notified as the batch progresses, pass `webhook_configurations` with<br/>
        /// inline endpoints and/or `webhook_configuration_ids` referencing saved<br/>
        /// configurations. Batches emit `batch.pending` on create, `batch.running`<br/>
        /// once processing starts, and a terminal `batch.success` or `batch.error`.<br/>
        /// `batch.success` means the batch finished mapping every source file to a<br/>
        /// job — individual files may still have failed, so read `results` (with<br/>
        /// `expand=results`) for per-file outcomes.<br/>
        /// Delivery order across events is not guaranteed; key on the `status` field<br/>
        /// in the payload rather than arrival order.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.BatchResponse> CreateBatchApiV2BatchesPostAsync(

            global::LlamaParse.BatchCreateRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Batch<br/>
        /// Create a batch over a source directory and start processing asynchronously.<br/>
        /// To be notified as the batch progresses, pass `webhook_configurations` with<br/>
        /// inline endpoints and/or `webhook_configuration_ids` referencing saved<br/>
        /// configurations. Batches emit `batch.pending` on create, `batch.running`<br/>
        /// once processing starts, and a terminal `batch.success` or `batch.error`.<br/>
        /// `batch.success` means the batch finished mapping every source file to a<br/>
        /// job — individual files may still have failed, so read `results` (with<br/>
        /// `expand=results`) for per-file outcomes.<br/>
        /// Delivery order across events is not guaranteed; key on the `status` field<br/>
        /// in the payload rather than arrival order.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<global::LlamaParse.BatchResponse>> CreateBatchApiV2BatchesPostAsResponseAsync(

            global::LlamaParse.BatchCreateRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Batch<br/>
        /// Create a batch over a source directory and start processing asynchronously.<br/>
        /// To be notified as the batch progresses, pass `webhook_configurations` with<br/>
        /// inline endpoints and/or `webhook_configuration_ids` referencing saved<br/>
        /// configurations. Batches emit `batch.pending` on create, `batch.running`<br/>
        /// once processing starts, and a terminal `batch.success` or `batch.error`.<br/>
        /// `batch.success` means the batch finished mapping every source file to a<br/>
        /// job — individual files may still have failed, so read `results` (with<br/>
        /// `expand=results`) for per-file outcomes.<br/>
        /// Delivery order across events is not guaranteed; key on the `status` field<br/>
        /// in the payload rather than arrival order.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="webhookConfigurationIds">
        /// IDs of saved webhook configurations to notify for this job.
        /// </param>
        /// <param name="webhookConfigurations">
        /// Outbound webhook endpoints to notify on job status changes
        /// </param>
        /// <param name="sourceDirectoryId">
        /// Directory whose files should be processed.
        /// </param>
        /// <param name="config">
        /// Batch configuration snapshot to apply to this source directory.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.BatchResponse> CreateBatchApiV2BatchesPostAsync(
            string sourceDirectoryId,
            global::LlamaParse.BatchConfiguration config,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Collections.Generic.IList<string>? webhookConfigurationIds = default,
            global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfiguration>? webhookConfigurations = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}