
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Why a parse job could not be deleted, and what to do about it.
    /// </summary>
    public sealed partial class ParseJobDeleteConflictDetail
    {
        /// <summary>
        /// `job_running`: cancel the job, then delete it. `held_by_evaluate`: a document in Evaluate reads its ground truth from the job; remove the document from Evaluate, or delete the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LlamaParse.JsonConverters.ParseJobDeleteConflictDetailReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.ParseJobDeleteConflictDetailReason Reason { get; set; }

        /// <summary>
        /// The same, in words, naming the job's status where it helps.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseJobDeleteConflictDetail" /> class.
        /// </summary>
        /// <param name="reason">
        /// `job_running`: cancel the job, then delete it. `held_by_evaluate`: a document in Evaluate reads its ground truth from the job; remove the document from Evaluate, or delete the project.
        /// </param>
        /// <param name="message">
        /// The same, in words, naming the job's status where it helps.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParseJobDeleteConflictDetail(
            global::LlamaParse.ParseJobDeleteConflictDetailReason reason,
            string message)
        {
            this.Reason = reason;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseJobDeleteConflictDetail" /> class.
        /// </summary>
        public ParseJobDeleteConflictDetail()
        {
        }

    }
}