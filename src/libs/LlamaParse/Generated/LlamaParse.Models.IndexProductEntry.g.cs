
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// A product configuration to include in an index's sync.<br/>
    /// Structurally mirrors ``directory_sync.SyncProductEntryRequest`` but is a<br/>
    /// distinct class so the Index API surface stays SDK-gen-isolated from<br/>
    /// directory-sync internals. Translation between the two happens in<br/>
    /// ``index/api_utils.py``.
    /// </summary>
    public sealed partial class IndexProductEntry
    {
        /// <summary>
        /// Product type. One of: parse, extract.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProductType { get; set; }

        /// <summary>
        /// ID of the product configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product_config_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProductConfigId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexProductEntry" /> class.
        /// </summary>
        /// <param name="productType">
        /// Product type. One of: parse, extract.
        /// </param>
        /// <param name="productConfigId">
        /// ID of the product configuration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IndexProductEntry(
            string productType,
            string productConfigId)
        {
            this.ProductType = productType ?? throw new global::System.ArgumentNullException(nameof(productType));
            this.ProductConfigId = productConfigId ?? throw new global::System.ArgumentNullException(nameof(productConfigId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexProductEntry" /> class.
        /// </summary>
        public IndexProductEntry()
        {
        }

    }
}