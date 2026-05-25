
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Grounding for a single table cell.
    /// </summary>
    public sealed partial class GroundedTableCell
    {
        /// <summary>
        /// `[start, end)` byte span in the cell text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span")]
        public global::System.Collections.Generic.IList<long>? Span { get; set; }

        /// <summary>
        /// Per-line grounding inside the cell
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lines")]
        public global::System.Collections.Generic.IList<global::LlamaParse.GroundedLine>? Lines { get; set; }

        /// <summary>
        /// One or more bounding boxes covering the cell
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bbox")]
        public global::System.Collections.Generic.IList<global::LlamaParse.BBox>? Bbox { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundedTableCell" /> class.
        /// </summary>
        /// <param name="span">
        /// `[start, end)` byte span in the cell text
        /// </param>
        /// <param name="lines">
        /// Per-line grounding inside the cell
        /// </param>
        /// <param name="bbox">
        /// One or more bounding boxes covering the cell
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GroundedTableCell(
            global::System.Collections.Generic.IList<long>? span,
            global::System.Collections.Generic.IList<global::LlamaParse.GroundedLine>? lines,
            global::System.Collections.Generic.IList<global::LlamaParse.BBox>? bbox)
        {
            this.Span = span;
            this.Lines = lines;
            this.Bbox = bbox;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundedTableCell" /> class.
        /// </summary>
        public GroundedTableCell()
        {
        }

    }
}