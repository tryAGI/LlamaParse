
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Request body for creating a chat session.
    /// </summary>
    public sealed partial class SessionCreate
    {
        /// <summary>
        /// Indexes this session will retrieve from. Once set and the first message has been sent, the source set is locked for the session's lifetime. Leave null to create an unbound session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index_ids")]
        public global::System.Collections.Generic.IList<string>? IndexIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionCreate" /> class.
        /// </summary>
        /// <param name="indexIds">
        /// Indexes this session will retrieve from. Once set and the first message has been sent, the source set is locked for the session's lifetime. Leave null to create an unbound session.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionCreate(
            global::System.Collections.Generic.IList<string>? indexIds)
        {
            this.IndexIds = indexIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionCreate" /> class.
        /// </summary>
        public SessionCreate()
        {
        }

    }
}