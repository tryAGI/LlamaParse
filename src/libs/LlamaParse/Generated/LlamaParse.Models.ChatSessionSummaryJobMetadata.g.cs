
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Token usage and status from the most recent run. Null if the session has not been run yet.
    /// </summary>
    public sealed partial class ChatSessionSummaryJobMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}