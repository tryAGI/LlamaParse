
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// A searchable index over a directory of documents.
    /// </summary>
    public sealed partial class IndexResponse
    {
        /// <summary>
        /// Unique identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.AnyOf<string, global::System.Guid?> Id { get; set; }

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
        /// Index name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Index description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Project this index belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// ID of the source directory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_directory_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceDirectoryId { get; set; }

        /// <summary>
        /// ID of the sync configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sync_config_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SyncConfigId { get; set; }

        /// <summary>
        /// ID of the export configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("export_config_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExportConfigId { get; set; }

        /// <summary>
        /// Last sync time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_synced_at")]
        public global::System.DateTime? LastSyncedAt { get; set; }

        /// <summary>
        /// Last export time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_exported_at")]
        public global::System.DateTime? LastExportedAt { get; set; }

        /// <summary>
        /// Build state and diagnostic info.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::LlamaParse.IndexMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier
        /// </param>
        /// <param name="name">
        /// Index name.
        /// </param>
        /// <param name="projectId">
        /// Project this index belongs to.
        /// </param>
        /// <param name="sourceDirectoryId">
        /// ID of the source directory.
        /// </param>
        /// <param name="syncConfigId">
        /// ID of the sync configuration.
        /// </param>
        /// <param name="exportConfigId">
        /// ID of the export configuration.
        /// </param>
        /// <param name="createdAt">
        /// Creation datetime
        /// </param>
        /// <param name="updatedAt">
        /// Update datetime
        /// </param>
        /// <param name="description">
        /// Index description.
        /// </param>
        /// <param name="lastSyncedAt">
        /// Last sync time.
        /// </param>
        /// <param name="lastExportedAt">
        /// Last export time.
        /// </param>
        /// <param name="metadata">
        /// Build state and diagnostic info.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IndexResponse(
            global::LlamaParse.AnyOf<string, global::System.Guid?> id,
            string name,
            string projectId,
            string sourceDirectoryId,
            string syncConfigId,
            string exportConfigId,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            string? description,
            global::System.DateTime? lastSyncedAt,
            global::System.DateTime? lastExportedAt,
            global::LlamaParse.IndexMetadata? metadata)
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.SourceDirectoryId = sourceDirectoryId ?? throw new global::System.ArgumentNullException(nameof(sourceDirectoryId));
            this.SyncConfigId = syncConfigId ?? throw new global::System.ArgumentNullException(nameof(syncConfigId));
            this.ExportConfigId = exportConfigId ?? throw new global::System.ArgumentNullException(nameof(exportConfigId));
            this.LastSyncedAt = lastSyncedAt;
            this.LastExportedAt = lastExportedAt;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexResponse" /> class.
        /// </summary>
        public IndexResponse()
        {
        }

    }
}