
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Metadata for a single file attachment.
    /// </summary>
    public sealed partial class FileAttachmentMetadata
    {
        /// <summary>
        /// Name of the attachment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Size of the attachment in bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Size { get; set; }

        /// <summary>
        /// When the attachment was last modified
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_modified")]
        public global::System.DateTime? LastModified { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileAttachmentMetadata" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the attachment
        /// </param>
        /// <param name="size">
        /// Size of the attachment in bytes
        /// </param>
        /// <param name="lastModified">
        /// When the attachment was last modified
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileAttachmentMetadata(
            string name,
            long size,
            global::System.DateTime? lastModified)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Size = size;
            this.LastModified = lastModified;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileAttachmentMetadata" /> class.
        /// </summary>
        public FileAttachmentMetadata()
        {
        }

    }
}