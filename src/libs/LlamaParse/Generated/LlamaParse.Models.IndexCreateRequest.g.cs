
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Create a searchable index over a source directory.<br/>
    /// Sets up the full pipeline — parsing, chunking, embedding, and vector<br/>
    /// store indexing — in a single call. An initial sync is triggered<br/>
    /// automatically.<br/>
    /// Omit ``products`` to use a default parse configuration (cost-effective<br/>
    /// tier). Pass it explicitly to control parsing or to include extraction.
    /// </summary>
    public sealed partial class IndexCreateRequest
    {
        /// <summary>
        /// ID of the source directory containing your documents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_directory_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceDirectoryId { get; set; }

        /// <summary>
        /// Optional display name for the index. If omitted, the index is named after the source directory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Product configurations for syncing. Omit to use a default parse configuration. Include an explicit entry per product type (e.g. parse, extract) to override the default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("products")]
        public global::System.Collections.Generic.IList<global::LlamaParse.IndexProductEntry>? Products { get; set; }

        /// <summary>
        /// Optional description of the index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// How often to re-run the sync. One of: manual, daily, on_source_change. Defaults to manual.<br/>
        /// Default Value: manual
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sync_frequency")]
        public string? SyncFrequency { get; set; }

        /// <summary>
        /// Attachment kinds to store alongside parsed output. Each entry must be one of: screenshots, items. For example, ['screenshots'] renders and stores per-page screenshots; ['items'] stores structured items with bounding boxes. Omit or pass an empty list to skip attachments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store_attachments")]
        public global::System.Collections.Generic.IList<string>? StoreAttachments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexCreateRequest" /> class.
        /// </summary>
        /// <param name="sourceDirectoryId">
        /// ID of the source directory containing your documents.
        /// </param>
        /// <param name="name">
        /// Optional display name for the index. If omitted, the index is named after the source directory.
        /// </param>
        /// <param name="products">
        /// Product configurations for syncing. Omit to use a default parse configuration. Include an explicit entry per product type (e.g. parse, extract) to override the default.
        /// </param>
        /// <param name="description">
        /// Optional description of the index.
        /// </param>
        /// <param name="syncFrequency">
        /// How often to re-run the sync. One of: manual, daily, on_source_change. Defaults to manual.<br/>
        /// Default Value: manual
        /// </param>
        /// <param name="storeAttachments">
        /// Attachment kinds to store alongside parsed output. Each entry must be one of: screenshots, items. For example, ['screenshots'] renders and stores per-page screenshots; ['items'] stores structured items with bounding boxes. Omit or pass an empty list to skip attachments.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IndexCreateRequest(
            string sourceDirectoryId,
            string? name,
            global::System.Collections.Generic.IList<global::LlamaParse.IndexProductEntry>? products,
            string? description,
            string? syncFrequency,
            global::System.Collections.Generic.IList<string>? storeAttachments)
        {
            this.SourceDirectoryId = sourceDirectoryId ?? throw new global::System.ArgumentNullException(nameof(sourceDirectoryId));
            this.Name = name;
            this.Products = products;
            this.Description = description;
            this.SyncFrequency = syncFrequency;
            this.StoreAttachments = storeAttachments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexCreateRequest" /> class.
        /// </summary>
        public IndexCreateRequest()
        {
        }

    }
}