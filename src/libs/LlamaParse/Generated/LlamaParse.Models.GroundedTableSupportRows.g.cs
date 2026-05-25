
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Per-cell grounding by `[row][col]`; `null` entries mark missing cells
    /// </summary>
    public sealed partial class GroundedTableSupportRows
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}