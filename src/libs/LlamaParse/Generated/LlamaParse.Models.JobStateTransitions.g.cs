
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// State transition timestamps extracted from job_metadata.<br/>
    /// Matches the shape of StateTransitionTimestamps from job_latency/base.py<br/>
    /// with the addition of pending_at. The frontend derives queue latency,<br/>
    /// processing time, etc. from these timestamps.
    /// </summary>
    public sealed partial class JobStateTransitions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_at")]
        public global::System.DateTime? PendingAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("throttled_at")]
        public global::System.DateTime? ThrottledAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("running_at")]
        public global::System.DateTime? RunningAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_at")]
        public global::System.DateTime? FailedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancelled_at")]
        public global::System.DateTime? CancelledAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobStateTransitions" /> class.
        /// </summary>
        /// <param name="pendingAt"></param>
        /// <param name="throttledAt"></param>
        /// <param name="runningAt"></param>
        /// <param name="completedAt"></param>
        /// <param name="failedAt"></param>
        /// <param name="cancelledAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JobStateTransitions(
            global::System.DateTime? pendingAt,
            global::System.DateTime? throttledAt,
            global::System.DateTime? runningAt,
            global::System.DateTime? completedAt,
            global::System.DateTime? failedAt,
            global::System.DateTime? cancelledAt)
        {
            this.PendingAt = pendingAt;
            this.ThrottledAt = throttledAt;
            this.RunningAt = runningAt;
            this.CompletedAt = completedAt;
            this.FailedAt = failedAt;
            this.CancelledAt = cancelledAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobStateTransitions" /> class.
        /// </summary>
        public JobStateTransitions()
        {
        }
    }
}