
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Request body for running a chat turn against one or more indexes.
    /// </summary>
    public sealed partial class ChatParams
    {
        /// <summary>
        /// Indexes to retrieve data from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> IndexIds { get; set; }

        /// <summary>
        /// User message for this chat turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Fail the turn if any requested index cannot be queried.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_all_indexes")]
        public bool? RequireAllIndexes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatParams" /> class.
        /// </summary>
        /// <param name="indexIds">
        /// Indexes to retrieve data from.
        /// </param>
        /// <param name="prompt">
        /// User message for this chat turn.
        /// </param>
        /// <param name="requireAllIndexes">
        /// Fail the turn if any requested index cannot be queried.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatParams(
            global::System.Collections.Generic.IList<string> indexIds,
            string prompt,
            bool? requireAllIndexes)
        {
            this.IndexIds = indexIds ?? throw new global::System.ArgumentNullException(nameof(indexIds));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.RequireAllIndexes = requireAllIndexes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatParams" /> class.
        /// </summary>
        public ChatParams()
        {
        }

    }
}