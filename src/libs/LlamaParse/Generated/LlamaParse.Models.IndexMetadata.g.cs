
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Build state and diagnostic info about an index. Schema is open; only `status` of `ready` or `failed` is stable.
    /// </summary>
    public sealed partial class IndexMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}