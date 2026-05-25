
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Grounding for a table-shaped item.
    /// </summary>
    public sealed partial class GroundedTableSupport
    {
        /// <summary>
        /// Per-cell grounding by `[row][col]`; `null` entries mark missing cells
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rows")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::LlamaParse.GroundedTableCell>>? Rows { get; set; }

        /// <summary>
        /// Bounding boxes for each row (a row may have multiple boxes)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("row_bboxes")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::LlamaParse.BBox>>? RowBboxes { get; set; }

        /// <summary>
        /// Bounding boxes for each column (a column may have multiple boxes)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column_bboxes")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::LlamaParse.BBox>>? ColumnBboxes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundedTableSupport" /> class.
        /// </summary>
        /// <param name="rows">
        /// Per-cell grounding by `[row][col]`; `null` entries mark missing cells
        /// </param>
        /// <param name="rowBboxes">
        /// Bounding boxes for each row (a row may have multiple boxes)
        /// </param>
        /// <param name="columnBboxes">
        /// Bounding boxes for each column (a column may have multiple boxes)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GroundedTableSupport(
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::LlamaParse.GroundedTableCell>>? rows,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::LlamaParse.BBox>>? rowBboxes,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::LlamaParse.BBox>>? columnBboxes)
        {
            this.Rows = rows;
            this.RowBboxes = rowBboxes;
            this.ColumnBboxes = columnBboxes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundedTableSupport" /> class.
        /// </summary>
        public GroundedTableSupport()
        {
        }

    }
}