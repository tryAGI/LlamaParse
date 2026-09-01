
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// A pipeline in a project.
    /// </summary>
    public sealed partial class PipelineResponse
    {
        /// <summary>
        /// The pipeline's unique identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Creation datetime
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Update datetime
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The pipeline's display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The project the pipeline belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// The pipeline's type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipeline_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LlamaParse.JsonConverters.PipelineResponsePipelineTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.PipelineResponsePipelineType PipelineType { get; set; }

        /// <summary>
        /// The pipeline's current status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public global::LlamaParse.PipelineResponseStatus2? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The pipeline's unique identifier.
        /// </param>
        /// <param name="name">
        /// The pipeline's display name.
        /// </param>
        /// <param name="projectId">
        /// The project the pipeline belongs to.
        /// </param>
        /// <param name="pipelineType">
        /// The pipeline's type.
        /// </param>
        /// <param name="createdAt">
        /// Creation datetime
        /// </param>
        /// <param name="updatedAt">
        /// Update datetime
        /// </param>
        /// <param name="status">
        /// The pipeline's current status.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PipelineResponse(
            string id,
            string name,
            string projectId,
            global::LlamaParse.PipelineResponsePipelineType pipelineType,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::LlamaParse.PipelineResponseStatus2? status)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.PipelineType = pipelineType;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineResponse" /> class.
        /// </summary>
        public PipelineResponse()
        {
        }

    }
}