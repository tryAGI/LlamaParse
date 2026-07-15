
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// The list representation of form content: nested lists of rendered field lines.
    /// </summary>
    public sealed partial class FormListItem
    {
        /// <summary>
        /// List node<br/>
        /// Default Value: list
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Nested lines and sub-lists, in the form's reading order
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.FormListTextItem, global::LlamaParse.FormListItem>> Items { get; set; }

        /// <summary>
        /// Whether the list is ordered
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ordered")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Ordered { get; set; }

        /// <summary>
        /// Markdown representation of this list
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("md")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Md { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FormListItem" /> class.
        /// </summary>
        /// <param name="items">
        /// Nested lines and sub-lists, in the form's reading order
        /// </param>
        /// <param name="ordered">
        /// Whether the list is ordered
        /// </param>
        /// <param name="md">
        /// Markdown representation of this list
        /// </param>
        /// <param name="type">
        /// List node<br/>
        /// Default Value: list
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FormListItem(
            global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.FormListTextItem, global::LlamaParse.FormListItem>> items,
            bool ordered,
            string md,
            string? type)
        {
            this.Type = type;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.Ordered = ordered;
            this.Md = md ?? throw new global::System.ArgumentNullException(nameof(md));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormListItem" /> class.
        /// </summary>
        public FormListItem()
        {
        }

    }
}