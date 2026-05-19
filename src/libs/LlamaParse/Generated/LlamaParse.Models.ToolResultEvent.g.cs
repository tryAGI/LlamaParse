
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolResultEvent
    {
        /// <summary>
        /// Default Value: tool_result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_attachment")]
        public global::LlamaParse.ImageAttachmentRef? ImageAttachment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolResultEvent" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="callId"></param>
        /// <param name="result"></param>
        /// <param name="type">
        /// Default Value: tool_result
        /// </param>
        /// <param name="imageAttachment"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolResultEvent(
            string name,
            string callId,
            object result,
            string? type,
            global::LlamaParse.ImageAttachmentRef? imageAttachment)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
            this.ImageAttachment = imageAttachment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolResultEvent" /> class.
        /// </summary>
        public ToolResultEvent()
        {
        }

    }
}