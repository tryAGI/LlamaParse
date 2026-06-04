
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Per-status entry timestamps. Returned only when requested via `?expand=metadata_state_transitions`.
    /// </summary>
    public sealed partial class SpreadsheetJobMetadataStateTransitions
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}