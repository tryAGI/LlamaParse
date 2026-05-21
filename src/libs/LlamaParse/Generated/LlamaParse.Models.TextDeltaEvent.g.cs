
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextDeltaEvent
    {
        /// <summary>
        /// Default Value: text_delta
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextDeltaEvent" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="type">
        /// Default Value: text_delta
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextDeltaEvent(
            string content,
            string? type)
        {
            this.Type = type;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextDeltaEvent" /> class.
        /// </summary>
        public TextDeltaEvent()
        {
        }

    }
}