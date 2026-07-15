
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// A grouping of form content, in the form's reading order.
    /// </summary>
    public sealed partial class FormSection
    {
        /// <summary>
        /// Form section node<br/>
        /// Default Value: section
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Identifier printed on the form (e.g. 'Part III'), if any
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Printed section heading, if any
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Child form nodes in reading order
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LlamaParse.ItemsItem3> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FormSection" /> class.
        /// </summary>
        /// <param name="items">
        /// Child form nodes in reading order
        /// </param>
        /// <param name="type">
        /// Form section node<br/>
        /// Default Value: section
        /// </param>
        /// <param name="id">
        /// Identifier printed on the form (e.g. 'Part III'), if any
        /// </param>
        /// <param name="label">
        /// Printed section heading, if any
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FormSection(
            global::System.Collections.Generic.IList<global::LlamaParse.ItemsItem3> items,
            string? type,
            string? id,
            string? label)
        {
            this.Type = type;
            this.Id = id;
            this.Label = label;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormSection" /> class.
        /// </summary>
        public FormSection()
        {
        }

    }
}