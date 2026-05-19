
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
        /// Product configurations for syncing. Omit to use a default parse configuration. Include an explicit entry per product type (e.g. parse, extract) to override the default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("products")]
        public global::System.Collections.Generic.IList<global::LlamaParse.SyncProductEntryRequest>? Products { get; set; }

        /// <summary>
        /// Optional description of the index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

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
        /// <param name="products">
        /// Product configurations for syncing. Omit to use a default parse configuration. Include an explicit entry per product type (e.g. parse, extract) to override the default.
        /// </param>
        /// <param name="description">
        /// Optional description of the index.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IndexCreateRequest(
            string sourceDirectoryId,
            global::System.Collections.Generic.IList<global::LlamaParse.SyncProductEntryRequest>? products,
            string? description)
        {
            this.SourceDirectoryId = sourceDirectoryId ?? throw new global::System.ArgumentNullException(nameof(sourceDirectoryId));
            this.Products = products;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexCreateRequest" /> class.
        /// </summary>
        public IndexCreateRequest()
        {
        }

    }
}