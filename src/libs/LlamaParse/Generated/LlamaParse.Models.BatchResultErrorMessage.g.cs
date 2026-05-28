
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Batch-level mapping error if the system could not create or associate a job for this source file.
    /// </summary>
    public sealed partial class BatchResultErrorMessage
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}