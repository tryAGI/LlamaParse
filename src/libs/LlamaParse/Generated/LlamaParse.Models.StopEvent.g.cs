
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StopEvent
    {
        /// <summary>
        /// Default Value: stop
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.Usage Usage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StopEvent" /> class.
        /// </summary>
        /// <param name="usage"></param>
        /// <param name="isError"></param>
        /// <param name="type">
        /// Default Value: stop
        /// </param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StopEvent(
            global::LlamaParse.Usage usage,
            bool isError,
            string? type,
            string? error)
        {
            this.Type = type;
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
            this.IsError = isError;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StopEvent" /> class.
        /// </summary>
        public StopEvent()
        {
        }

    }
}