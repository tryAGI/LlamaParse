
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// A table cell holding its own form nodes (e.g. a checkbox column).
    /// </summary>
    public sealed partial class FormTableCellItems
    {
        /// <summary>
        /// Form nodes inside the cell
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LlamaParse.ItemsItem4> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FormTableCellItems" /> class.
        /// </summary>
        /// <param name="items">
        /// Form nodes inside the cell
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FormTableCellItems(
            global::System.Collections.Generic.IList<global::LlamaParse.ItemsItem4> items)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormTableCellItems" /> class.
        /// </summary>
        public FormTableCellItems()
        {
        }

    }
}