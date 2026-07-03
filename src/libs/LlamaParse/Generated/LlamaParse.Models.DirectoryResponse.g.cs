
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// API response schema for a directory.
    /// </summary>
    public sealed partial class DirectoryResponse
    {
        /// <summary>
        /// Unique identifier for the directory.
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
        /// Project the directory belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Human-readable name for the directory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional description shown to users.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Directory type: 'user', 'index', or 'ephemeral'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public global::LlamaParse.DirectoryResponseType2? Type { get; set; }

        /// <summary>
        /// When this directory expires and is eligible for cleanup.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Reserved system-managed metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_metadata")]
        public object? SystemMetadata { get; set; }

        /// <summary>
        /// Optional timestamp of when the directory was deleted. Null if not deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_at")]
        public global::System.DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the directory.
        /// </param>
        /// <param name="projectId">
        /// Project the directory belongs to.
        /// </param>
        /// <param name="name">
        /// Human-readable name for the directory.
        /// </param>
        /// <param name="createdAt">
        /// Creation datetime
        /// </param>
        /// <param name="updatedAt">
        /// Update datetime
        /// </param>
        /// <param name="description">
        /// Optional description shown to users.
        /// </param>
        /// <param name="type">
        /// Directory type: 'user', 'index', or 'ephemeral'.
        /// </param>
        /// <param name="expiresAt">
        /// When this directory expires and is eligible for cleanup.
        /// </param>
        /// <param name="systemMetadata">
        /// Reserved system-managed metadata.
        /// </param>
        /// <param name="deletedAt">
        /// Optional timestamp of when the directory was deleted. Null if not deleted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DirectoryResponse(
            string id,
            string projectId,
            string name,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            string? description,
            global::LlamaParse.DirectoryResponseType2? type,
            global::System.DateTime? expiresAt,
            object? systemMetadata,
            global::System.DateTime? deletedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Type = type;
            this.ExpiresAt = expiresAt;
            this.SystemMetadata = systemMetadata;
            this.DeletedAt = deletedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryResponse" /> class.
        /// </summary>
        public DirectoryResponse()
        {
        }

    }
}