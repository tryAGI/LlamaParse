
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Coordinates for lazily resolving a page screenshot presigned URL.
    /// </summary>
    public sealed partial class ImageAttachmentRef
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachment_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AttachmentName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageAttachmentRef" /> class.
        /// </summary>
        /// <param name="sourceId"></param>
        /// <param name="attachmentName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageAttachmentRef(
            string sourceId,
            string attachmentName)
        {
            this.SourceId = sourceId ?? throw new global::System.ArgumentNullException(nameof(sourceId));
            this.AttachmentName = attachmentName ?? throw new global::System.ArgumentNullException(nameof(attachmentName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageAttachmentRef" /> class.
        /// </summary>
        public ImageAttachmentRef()
        {
        }

    }
}