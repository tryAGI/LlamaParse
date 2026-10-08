
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Printed text that is not part of a field, section heading or table: a title, an<br/>
    /// instruction, a note. With it the form JSON holds every printed word of its region.
    /// </summary>
    public sealed partial class FormText
    {
        /// <summary>
        /// Optional source-backed grounding for the printed text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grounding")]
        public global::LlamaParse.FormFieldGrounding? Grounding { get; set; }

        /// <summary>
        /// Form text node<br/>
        /// Default Value: text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The printed text, verbatim
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Bounding boxes of the text on the page, if attributed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bbox")]
        public global::System.Collections.Generic.IList<global::LlamaParse.BBox>? Bbox { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FormText" /> class.
        /// </summary>
        /// <param name="value">
        /// The printed text, verbatim
        /// </param>
        /// <param name="grounding">
        /// Optional source-backed grounding for the printed text
        /// </param>
        /// <param name="type">
        /// Form text node<br/>
        /// Default Value: text
        /// </param>
        /// <param name="bbox">
        /// Bounding boxes of the text on the page, if attributed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FormText(
            string value,
            global::LlamaParse.FormFieldGrounding? grounding,
            string? type,
            global::System.Collections.Generic.IList<global::LlamaParse.BBox>? bbox)
        {
            this.Grounding = grounding;
            this.Type = type;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Bbox = bbox;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormText" /> class.
        /// </summary>
        public FormText()
        {
        }

    }
}