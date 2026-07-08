
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Arbitrary key/value tags to attach to this job. Returned when retrieving the job. Not searchable. Limits apply to the number of entries and the length of keys and values; oversized metadata is rejected.
    /// </summary>
    public sealed partial class ParseRequestConfigurationUserMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}