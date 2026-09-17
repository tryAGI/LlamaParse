
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Identifiers for a deleted classify job.
    /// </summary>
    public sealed partial class ClassifyV2JobDeleteResponse
    {
        /// <summary>
        /// Identifier of the deleted classify job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Project the deleted job belonged to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyV2JobDeleteResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Identifier of the deleted classify job
        /// </param>
        /// <param name="projectId">
        /// Project the deleted job belonged to
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClassifyV2JobDeleteResponse(
            string id,
            string? projectId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyV2JobDeleteResponse" /> class.
        /// </summary>
        public ClassifyV2JobDeleteResponse()
        {
        }

    }
}