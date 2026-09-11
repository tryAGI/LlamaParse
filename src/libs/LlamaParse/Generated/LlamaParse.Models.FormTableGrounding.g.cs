
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Scalar text grounding aligned with the table's columns and ragged rows.
    /// </summary>
    public sealed partial class FormTableGrounding
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
        /// Column text grounding in source order; blank slots have empty lines
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columns")]
        public global::System.Collections.Generic.IList<global::LlamaParse.FormTextGrounding>? Columns { get; set; }

        /// <summary>
        /// Scalar cell text grounding aligned with rows; blank and structured slots have empty lines. Structured children carry their own grounding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rows")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::LlamaParse.FormTextGrounding>>? Rows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FormTableGrounding" /> class.
        /// </summary>
        /// <param name="id">
        /// Printed identifier grounding
        /// </param>
        /// <param name="label">
        /// Printed label grounding
        /// </param>
        /// <param name="columns">
        /// Column text grounding in source order; blank slots have empty lines
        /// </param>
        /// <param name="rows">
        /// Scalar cell text grounding aligned with rows; blank and structured slots have empty lines. Structured children carry their own grounding.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FormTableGrounding(
            global::LlamaParse.FormTextGrounding? id,
            global::LlamaParse.FormTextGrounding? label,
            global::System.Collections.Generic.IList<global::LlamaParse.FormTextGrounding>? columns,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::LlamaParse.FormTextGrounding>>? rows)
        {
            this.Id = id;
            this.Label = label;
            this.Columns = columns;
            this.Rows = rows;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormTableGrounding" /> class.
        /// </summary>
        public FormTableGrounding()
        {
        }

    }
}