
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Per-row metadata when extraction_target is per_table_row
    /// </summary>
    public sealed partial class ExtractedFieldMetadataRowMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}