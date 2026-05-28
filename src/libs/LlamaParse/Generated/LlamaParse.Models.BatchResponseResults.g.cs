
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Expanded per-file result mappings. Null unless requested with expand=results, or while the batch is still running.
    /// </summary>
    public sealed partial class BatchResponseResults
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}