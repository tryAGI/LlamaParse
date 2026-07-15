
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// A fillable grid printed on the form: repeating records or a row-by-column matrix.
    /// </summary>
    public sealed partial class FormTable
    {
        /// <summary>
        /// Form table node<br/>
        /// Default Value: table
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Identifier printed on the form, if any
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Printed table caption, if any
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Printed column headers in order, if any
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columns")]
        public global::System.Collections.Generic.IList<string>? Columns { get; set; }

        /// <summary>
        /// Table cells: a verbatim string, null for a printed-but-blank cell, or an object holding the cell's own form nodes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rows")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, global::LlamaParse.FormTableCellItems, object>>> Rows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FormTable" /> class.
        /// </summary>
        /// <param name="rows">
        /// Table cells: a verbatim string, null for a printed-but-blank cell, or an object holding the cell's own form nodes
        /// </param>
        /// <param name="type">
        /// Form table node<br/>
        /// Default Value: table
        /// </param>
        /// <param name="id">
        /// Identifier printed on the form, if any
        /// </param>
        /// <param name="label">
        /// Printed table caption, if any
        /// </param>
        /// <param name="columns">
        /// Printed column headers in order, if any
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FormTable(
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, global::LlamaParse.FormTableCellItems, object>>> rows,
            string? type,
            string? id,
            string? label,
            global::System.Collections.Generic.IList<string>? columns)
        {
            this.Type = type;
            this.Id = id;
            this.Label = label;
            this.Columns = columns;
            this.Rows = rows ?? throw new global::System.ArgumentNullException(nameof(rows));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormTable" /> class.
        /// </summary>
        public FormTable()
        {
        }

    }
}