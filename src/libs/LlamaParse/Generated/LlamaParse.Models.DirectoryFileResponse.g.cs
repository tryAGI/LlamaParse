
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// API response schema for a directory file.
    /// </summary>
    public sealed partial class DirectoryFileResponse
    {
        /// <summary>
        /// Unique identifier for the directory file.
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
        /// Project the directory file belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Directory the file belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directory_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DirectoryId { get; set; }

        /// <summary>
        /// Unique identifier for the file in the directory
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unique_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UniqueId { get; set; }

        /// <summary>
        /// Display name for the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// File ID for the storage location.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// Merged metadata from all sources. Higher-priority sources override lower.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::LlamaParse.MetadataDict? Metadata { get; set; }

        /// <summary>
        /// Soft delete marker when the file is removed upstream or by user action.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_at")]
        public global::System.DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Presigned URL to download the underlying file content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("download_url")]
        public global::LlamaParse.PresignedUrl? DownloadUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryFileResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the directory file.
        /// </param>
        /// <param name="projectId">
        /// Project the directory file belongs to.
        /// </param>
        /// <param name="directoryId">
        /// Directory the file belongs to.
        /// </param>
        /// <param name="uniqueId">
        /// Unique identifier for the file in the directory
        /// </param>
        /// <param name="displayName">
        /// Display name for the file.
        /// </param>
        /// <param name="createdAt">
        /// Creation datetime
        /// </param>
        /// <param name="updatedAt">
        /// Update datetime
        /// </param>
        /// <param name="fileId">
        /// File ID for the storage location.
        /// </param>
        /// <param name="metadata">
        /// Merged metadata from all sources. Higher-priority sources override lower.
        /// </param>
        /// <param name="deletedAt">
        /// Soft delete marker when the file is removed upstream or by user action.
        /// </param>
        /// <param name="downloadUrl">
        /// Presigned URL to download the underlying file content.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DirectoryFileResponse(
            string id,
            string projectId,
            string directoryId,
            string uniqueId,
            string displayName,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            string? fileId,
            global::LlamaParse.MetadataDict? metadata,
            global::System.DateTime? deletedAt,
            global::LlamaParse.PresignedUrl? downloadUrl)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.DirectoryId = directoryId ?? throw new global::System.ArgumentNullException(nameof(directoryId));
            this.UniqueId = uniqueId ?? throw new global::System.ArgumentNullException(nameof(uniqueId));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.FileId = fileId;
            this.Metadata = metadata;
            this.DeletedAt = deletedAt;
            this.DownloadUrl = downloadUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryFileResponse" /> class.
        /// </summary>
        public DirectoryFileResponse()
        {
        }

    }
}