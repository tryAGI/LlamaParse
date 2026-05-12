
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// API response schema for a project.
    /// </summary>
    public sealed partial class ProjectResponse
    {
        /// <summary>
        /// The project's unique identifier.
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
        /// The project's display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The organization the project belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// Whether this project is the default project for its organization.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_default")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The project's unique identifier.
        /// </param>
        /// <param name="name">
        /// The project's display name.
        /// </param>
        /// <param name="organizationId">
        /// The organization the project belongs to.
        /// </param>
        /// <param name="createdAt">
        /// Creation datetime
        /// </param>
        /// <param name="updatedAt">
        /// Update datetime
        /// </param>
        /// <param name="isDefault">
        /// Whether this project is the default project for its organization.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectResponse(
            string id,
            string name,
            string organizationId,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            bool? isDefault)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.IsDefault = isDefault;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectResponse" /> class.
        /// </summary>
        public ProjectResponse()
        {
        }

    }
}