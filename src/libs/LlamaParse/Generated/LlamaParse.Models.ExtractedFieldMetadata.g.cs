
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Metadata for extracted fields including document, page, and row level info.
    /// </summary>
    public sealed partial class ExtractedFieldMetadata
    {
        /// <summary>
        /// Per-field metadata keyed by field name from your schema. Scalar fields (e.g. `vendor`) map to a FieldMetadataEntry with citation and confidence. Array fields (e.g. `items`) map to a list where each element contains per-sub-field FieldMetadataEntry objects, indexed by array position. Nested objects contain sub-field entries recursively.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_metadata")]
        public object? DocumentMetadata { get; set; }

        /// <summary>
        /// Per-page metadata when extraction_target is per_page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_metadata")]
        public global::System.Collections.Generic.IList<object>? PageMetadata { get; set; }

        /// <summary>
        /// Per-row metadata when extraction_target is per_table_row
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("row_metadata")]
        public global::System.Collections.Generic.IList<object>? RowMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractedFieldMetadata" /> class.
        /// </summary>
        /// <param name="documentMetadata">
        /// Per-field metadata keyed by field name from your schema. Scalar fields (e.g. `vendor`) map to a FieldMetadataEntry with citation and confidence. Array fields (e.g. `items`) map to a list where each element contains per-sub-field FieldMetadataEntry objects, indexed by array position. Nested objects contain sub-field entries recursively.
        /// </param>
        /// <param name="pageMetadata">
        /// Per-page metadata when extraction_target is per_page
        /// </param>
        /// <param name="rowMetadata">
        /// Per-row metadata when extraction_target is per_table_row
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractedFieldMetadata(
            object? documentMetadata,
            global::System.Collections.Generic.IList<object>? pageMetadata,
            global::System.Collections.Generic.IList<object>? rowMetadata)
        {
            this.DocumentMetadata = documentMetadata;
            this.PageMetadata = pageMetadata;
            this.RowMetadata = rowMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractedFieldMetadata" /> class.
        /// </summary>
        public ExtractedFieldMetadata()
        {
        }
    }
}