
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolCallEvent
    {
        /// <summary>
        /// Default Value: tool_call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Arguments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallEvent" /> class.
        /// </summary>
        /// <param name="arguments"></param>
        /// <param name="name"></param>
        /// <param name="callId"></param>
        /// <param name="type">
        /// Default Value: tool_call
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolCallEvent(
            object arguments,
            string name,
            string callId,
            string? type)
        {
            this.Type = type;
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallEvent" /> class.
        /// </summary>
        public ToolCallEvent()
        {
        }

    }
}