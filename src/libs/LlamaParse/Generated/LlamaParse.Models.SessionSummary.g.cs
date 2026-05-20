
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Summary of a chat session, including its title and last run metadata.
    /// </summary>
    public sealed partial class SessionSummary
    {
        /// <summary>
        /// Unique session identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// Auto-generated title derived from the first user message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_title")]
        public string? GeneratedTitle { get; set; }

        /// <summary>
        /// ISO-format timestamp showing when the session was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LastUpdatedAt { get; set; }

        /// <summary>
        /// Token usage and status from the most recent run. Null if the session has not been run yet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_metadata")]
        public global::LlamaParse.JobMetadata? JobMetadata { get; set; }

        /// <summary>
        /// Indexes this session is bound to. Null on unbound sessions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index_ids")]
        public global::System.Collections.Generic.IList<string>? IndexIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionSummary" /> class.
        /// </summary>
        /// <param name="sessionId">
        /// Unique session identifier.
        /// </param>
        /// <param name="lastUpdatedAt">
        /// ISO-format timestamp showing when the session was last updated.
        /// </param>
        /// <param name="generatedTitle">
        /// Auto-generated title derived from the first user message.
        /// </param>
        /// <param name="jobMetadata">
        /// Token usage and status from the most recent run. Null if the session has not been run yet.
        /// </param>
        /// <param name="indexIds">
        /// Indexes this session is bound to. Null on unbound sessions.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionSummary(
            string sessionId,
            string lastUpdatedAt,
            string? generatedTitle,
            global::LlamaParse.JobMetadata? jobMetadata,
            global::System.Collections.Generic.IList<string>? indexIds)
        {
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.GeneratedTitle = generatedTitle;
            this.LastUpdatedAt = lastUpdatedAt ?? throw new global::System.ArgumentNullException(nameof(lastUpdatedAt));
            this.JobMetadata = jobMetadata;
            this.IndexIds = indexIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionSummary" /> class.
        /// </summary>
        public SessionSummary()
        {
        }

    }
}