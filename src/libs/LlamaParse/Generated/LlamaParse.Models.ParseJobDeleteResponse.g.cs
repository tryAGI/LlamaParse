
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Confirmation that a parse job was deleted.<br/>
    /// A deleted job can no longer be fetched, so the response echoes back what it<br/>
    /// was rather than pointing at it. Returning the identifiers instead of an<br/>
    /// empty body lets a caller assert on the delete it just made without a<br/>
    /// follow-up request.
    /// </summary>
    public sealed partial class ParseJobDeleteResponse
    {
        /// <summary>
        /// Identifier of the deleted parse job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Project the deleted job belonged to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseJobDeleteResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Identifier of the deleted parse job
        /// </param>
        /// <param name="projectId">
        /// Project the deleted job belonged to
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParseJobDeleteResponse(
            string id,
            string projectId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseJobDeleteResponse" /> class.
        /// </summary>
        public ParseJobDeleteResponse()
        {
        }

    }
}