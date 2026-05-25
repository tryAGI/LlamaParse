
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Bounding boxes for each row (a row may have multiple boxes)
    /// </summary>
    public sealed partial class GroundedTableSupportRowBboxes
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}