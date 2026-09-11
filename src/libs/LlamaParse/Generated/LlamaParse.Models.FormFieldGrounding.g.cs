
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Optional grounding for a field's printed text; boolean states have no text spans.
    /// </summary>
    public sealed partial class FormFieldGrounding
    {
        /// <summary>
        /// Printed identifier grounding
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::LlamaParse.FormTextGrounding? Id { get; set; }

        /// <summary>
        /// Printed label grounding
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public global::LlamaParse.FormTextGrounding? Label { get; set; }

        /// <summary>
        /// String value grounding
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public global::LlamaParse.FormTextGrounding? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FormFieldGrounding" /> class.
        /// </summary>
        /// <param name="id">
        /// Printed identifier grounding
        /// </param>
        /// <param name="label">
        /// Printed label grounding
        /// </param>
        /// <param name="value">
        /// String value grounding
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FormFieldGrounding(
            global::LlamaParse.FormTextGrounding? id,
            global::LlamaParse.FormTextGrounding? label,
            global::LlamaParse.FormTextGrounding? value)
        {
            this.Id = id;
            this.Label = label;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormFieldGrounding" /> class.
        /// </summary>
        public FormFieldGrounding()
        {
        }

    }
}