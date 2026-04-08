
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Merged metadata from all sources. Higher-priority sources override lower.
    /// </summary>
    public sealed partial class DirectoryFileResponseMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}