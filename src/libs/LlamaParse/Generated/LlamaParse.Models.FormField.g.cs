
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// One labeled form entry: a text input, checkbox, select group, or signature line.
    /// </summary>
    public sealed partial class FormField
    {
        /// <summary>
        /// Form field node<br/>
        /// Default Value: field
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Kind of entry: text (any free-text input), checkbox, single_select, multi_select, or signature
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LlamaParse.JsonConverters.FormFieldFieldJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.FormFieldField Field { get; set; }

        /// <summary>
        /// Field number/letter printed on the form (e.g. '1a'), if any
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Printed field caption, if any
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Entered content: verbatim text for text fields, or a boolean for checkbox (checked) and signature (signed). Absent on blank text fields and on select groups
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, bool?, object>))]
        public global::LlamaParse.AnyOf<string, bool?, object>? Value { get; set; }

        /// <summary>
        /// True for a printed-but-blank text field (mutually exclusive with value)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isEmpty")]
        public bool? IsEmpty { get; set; }

        /// <summary>
        /// Options of a single_select/multi_select group (only on select fields)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valueItems")]
        public global::System.Collections.Generic.IList<global::LlamaParse.ValueItemsVariant1Item>? ValueItems { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FormField" /> class.
        /// </summary>
        /// <param name="field">
        /// Kind of entry: text (any free-text input), checkbox, single_select, multi_select, or signature
        /// </param>
        /// <param name="type">
        /// Form field node<br/>
        /// Default Value: field
        /// </param>
        /// <param name="id">
        /// Field number/letter printed on the form (e.g. '1a'), if any
        /// </param>
        /// <param name="label">
        /// Printed field caption, if any
        /// </param>
        /// <param name="value">
        /// Entered content: verbatim text for text fields, or a boolean for checkbox (checked) and signature (signed). Absent on blank text fields and on select groups
        /// </param>
        /// <param name="isEmpty">
        /// True for a printed-but-blank text field (mutually exclusive with value)
        /// </param>
        /// <param name="valueItems">
        /// Options of a single_select/multi_select group (only on select fields)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FormField(
            global::LlamaParse.FormFieldField field,
            string? type,
            string? id,
            string? label,
            global::LlamaParse.AnyOf<string, bool?, object>? value,
            bool? isEmpty,
            global::System.Collections.Generic.IList<global::LlamaParse.ValueItemsVariant1Item>? valueItems)
        {
            this.Type = type;
            this.Field = field;
            this.Id = id;
            this.Label = label;
            this.Value = value;
            this.IsEmpty = isEmpty;
            this.ValueItems = valueItems;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormField" /> class.
        /// </summary>
        public FormField()
        {
        }

    }
}