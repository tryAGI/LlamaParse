
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// One form detected on a page, in two representations of the same content.
    /// </summary>
    public sealed partial class Form
    {
        /// <summary>
        /// Structured representation: an ordered tree of sections, fields, and tables
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LlamaParse.JsonItem> Json { get; set; }

        /// <summary>
        /// Flattened list representation of the same content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("list")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.FormListItem List { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Form" /> class.
        /// </summary>
        /// <param name="json">
        /// Structured representation: an ordered tree of sections, fields, and tables
        /// </param>
        /// <param name="list">
        /// Flattened list representation of the same content
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Form(
            global::System.Collections.Generic.IList<global::LlamaParse.JsonItem> json,
            global::LlamaParse.FormListItem list)
        {
            this.Json = json ?? throw new global::System.ArgumentNullException(nameof(json));
            this.List = list ?? throw new global::System.ArgumentNullException(nameof(list));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Form" /> class.
        /// </summary>
        public Form()
        {
        }

    }
}