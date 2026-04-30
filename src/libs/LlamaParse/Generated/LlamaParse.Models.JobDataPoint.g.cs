
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// A job data point.
    /// </summary>
    public sealed partial class JobDataPoint
    {
        /// <summary>
        /// Job ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Project ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Created timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Updated timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Job status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Custom tag.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_tag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CustomTag { get; set; }

        /// <summary>
        /// Error message, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Job state transition timestamps.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state_transitions")]
        public global::LlamaParse.JobStateTransitions? StateTransitions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobDataPoint" /> class.
        /// </summary>
        /// <param name="id">
        /// Job ID.
        /// </param>
        /// <param name="projectId">
        /// Project ID.
        /// </param>
        /// <param name="createdAt">
        /// Created timestamp.
        /// </param>
        /// <param name="updatedAt">
        /// Updated timestamp.
        /// </param>
        /// <param name="status">
        /// Job status.
        /// </param>
        /// <param name="customTag">
        /// Custom tag.
        /// </param>
        /// <param name="errorMessage">
        /// Error message, if any.
        /// </param>
        /// <param name="stateTransitions">
        /// Job state transition timestamps.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JobDataPoint(
            string id,
            string projectId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string status,
            string customTag,
            string? errorMessage,
            global::LlamaParse.JobStateTransitions? stateTransitions)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.CustomTag = customTag ?? throw new global::System.ArgumentNullException(nameof(customTag));
            this.ErrorMessage = errorMessage;
            this.StateTransitions = stateTransitions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobDataPoint" /> class.
        /// </summary>
        public JobDataPoint()
        {
        }
    }
}