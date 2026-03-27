
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LinkItem
    {
        /// <summary>
        /// Link item type<br/>
        /// Default Value: link
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
        /// URL of the link
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Display text of the link
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkItem" /> class.
        /// </summary>
        /// <param name="type">
        /// Link item type<br/>
        /// Default Value: link
        /// </param>
        /// <param name="md">
        /// Markdown representation preserving formatting
        /// </param>
        /// <param name="bbox">
        /// List of bounding boxes
        /// </param>
        /// <param name="url">
        /// URL of the link
        /// </param>
        /// <param name="text">
        /// Display text of the link
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LinkItem(
            string md,
            string url,
            string text,
            string? type,
            global::System.Collections.Generic.IList<global::LlamaParse.BBox>? bbox)
        {
            this.Md = md ?? throw new global::System.ArgumentNullException(nameof(md));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
            this.Bbox = bbox;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkItem" /> class.
        /// </summary>
        public LinkItem()
        {
        }
    }
}