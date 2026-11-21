
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Why a parse job could not be deleted, and what to do about it.
    /// </summary>
    public sealed partial class ParseJobDeleteConflictDetail
    {
        /// <summary>
        /// `job_running`: cancel the job, then delete it.
        /// </summary>
        /// <default>"job_running"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string Reason { get; set; } = "job_running";

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
        /// <param name="message">
        /// The same, in words, naming the job's status where it helps.
        /// </param>
        /// <param name="reason">
        /// `job_running`: cancel the job, then delete it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParseJobDeleteConflictDetail(
            string message,
            string reason = "job_running")
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

        /// <summary>
        /// Creates a new <see cref="ParseJobDeleteConflictDetail"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ParseJobDeleteConflictDetail FromMessage(string message)
        {
            return new ParseJobDeleteConflictDetail
            {
                Message = message,
            };
        }

    }
}