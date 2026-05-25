
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Attachment kinds to store alongside parsed output. Each entry must be one of: screenshots, items. For example, ['screenshots'] renders and stores per-page screenshots; ['items'] stores structured items with bounding boxes. Omit or pass an empty list to skip attachments.
    /// </summary>
    public sealed partial class IndexCreateRequestStoreAttachments
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}