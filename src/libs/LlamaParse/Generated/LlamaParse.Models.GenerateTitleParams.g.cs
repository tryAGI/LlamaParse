
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Request body for generating a session title.
    /// </summary>
    public sealed partial class GenerateTitleParams
    {
        /// <summary>
        /// First user message of the session, used to infer a short title.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FirstMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateTitleParams" /> class.
        /// </summary>
        /// <param name="firstMessage">
        /// First user message of the session, used to infer a short title.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateTitleParams(
            string firstMessage)
        {
            this.FirstMessage = firstMessage ?? throw new global::System.ArgumentNullException(nameof(firstMessage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateTitleParams" /> class.
        /// </summary>
        public GenerateTitleParams()
        {
        }

    }
}