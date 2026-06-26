
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// API request schema for creating a directory.
    /// </summary>
    public sealed partial class DirectoryCreateRequest
    {
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
        /// Directory type. Use 'ephemeral' for batch processing with automatic cleanup.<br/>
        /// Default Value: user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LlamaParse.JsonConverters.DirectoryCreateRequestTypeJsonConverter))]
        public global::LlamaParse.DirectoryCreateRequestType? Type { get; set; }

        /// <summary>
        /// Reserved system-managed metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_metadata")]
        public object? SystemMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryCreateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Human-readable name for the directory.
        /// </param>
        /// <param name="description">
        /// Optional description shown to users.
        /// </param>
        /// <param name="type">
        /// Directory type. Use 'ephemeral' for batch processing with automatic cleanup.<br/>
        /// Default Value: user
        /// </param>
        /// <param name="systemMetadata">
        /// Reserved system-managed metadata.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DirectoryCreateRequest(
            string name,
            string? description,
            global::LlamaParse.DirectoryCreateRequestType? type,
            object? systemMetadata)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Type = type;
            this.SystemMetadata = systemMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryCreateRequest" /> class.
        /// </summary>
        public DirectoryCreateRequest()
        {
        }

    }
}