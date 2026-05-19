
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Indexes this session will retrieve from. Once set and the first message has been sent, the source set is locked for the session's lifetime. Leave null to create an unbound session.
    /// </summary>
    public sealed partial class SessionCreateIndexIds
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}