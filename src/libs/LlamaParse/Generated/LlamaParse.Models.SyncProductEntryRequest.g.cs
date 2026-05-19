
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// A product configuration to include in a sync.
    /// </summary>
    public sealed partial class SyncProductEntryRequest
    {
        /// <summary>
        /// Product type: parse or extract.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LlamaParse.JsonConverters.SyncProductEntryRequestProductTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.SyncProductEntryRequestProductType ProductType { get; set; }

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
        /// Initializes a new instance of the <see cref="SyncProductEntryRequest" /> class.
        /// </summary>
        /// <param name="productType">
        /// Product type: parse or extract.
        /// </param>
        /// <param name="productConfigId">
        /// ID of the product configuration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SyncProductEntryRequest(
            global::LlamaParse.SyncProductEntryRequestProductType productType,
            string productConfigId)
        {
            this.ProductType = productType;
            this.ProductConfigId = productConfigId ?? throw new global::System.ArgumentNullException(nameof(productConfigId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SyncProductEntryRequest" /> class.
        /// </summary>
        public SyncProductEntryRequest()
        {
        }

    }
}