
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HeaderItem
    {
        /// <summary>
        /// Page header container<br/>
        /// Default Value: header
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Markdown representation preserving formatting
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("md")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Md { get; set; }

        /// <summary>
        /// List of bounding boxes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bbox")]
        public global::System.Collections.Generic.IList<global::LlamaParse.BBox>? Bbox { get; set; }

        /// <summary>
        /// List of items within the header
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LlamaParse.ItemsItem2> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HeaderItem" /> class.
        /// </summary>
        /// <param name="type">
        /// Page header container<br/>
        /// Default Value: header
        /// </param>
        /// <param name="md">
        /// Markdown representation preserving formatting
        /// </param>
        /// <param name="bbox">
        /// List of bounding boxes
        /// </param>
        /// <param name="items">
        /// List of items within the header
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HeaderItem(
            string md,
            global::System.Collections.Generic.IList<global::LlamaParse.ItemsItem2> items,
            string? type,
            global::System.Collections.Generic.IList<global::LlamaParse.BBox>? bbox)
        {
            this.Md = md ?? throw new global::System.ArgumentNullException(nameof(md));
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.Type = type;
            this.Bbox = bbox;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeaderItem" /> class.
        /// </summary>
        public HeaderItem()
        {
        }
    }
}