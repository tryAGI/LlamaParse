
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Reference to a file attachment, retrievable via ``GET /api/v1/beta/attachments/{attachment_name}?source_id=...``.
    /// </summary>
    public sealed partial class AttachmentRef
    {
        /// <summary>
        /// Attachment kind, e.g. 'screenshot', 'items'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Attachment-relative path, e.g. 'screenshots/page_7.jpg'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachment_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AttachmentName { get; set; }

        /// <summary>
        /// File ID to pass as source_id when fetching the attachment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentRef" /> class.
        /// </summary>
        /// <param name="type">
        /// Attachment kind, e.g. 'screenshot', 'items'.
        /// </param>
        /// <param name="attachmentName">
        /// Attachment-relative path, e.g. 'screenshots/page_7.jpg'.
        /// </param>
        /// <param name="sourceId">
        /// File ID to pass as source_id when fetching the attachment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AttachmentRef(
            string type,
            string attachmentName,
            string sourceId)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.AttachmentName = attachmentName ?? throw new global::System.ArgumentNullException(nameof(attachmentName));
            this.SourceId = sourceId ?? throw new global::System.ArgumentNullException(nameof(sourceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentRef" /> class.
        /// </summary>
        public AttachmentRef()
        {
        }

    }
}