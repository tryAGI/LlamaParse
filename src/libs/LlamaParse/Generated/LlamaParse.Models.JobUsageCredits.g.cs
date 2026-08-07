
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Total credits billed against this job. Null until billing has recorded it.
    /// </summary>
    public sealed partial class JobUsageCredits
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}