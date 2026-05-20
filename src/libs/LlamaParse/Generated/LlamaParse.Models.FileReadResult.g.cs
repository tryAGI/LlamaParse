
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// File read result.
    /// </summary>
    public sealed partial class FileReadResult
    {
        /// <summary>
        /// Parsed text content of the file.
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
        /// Initializes a new instance of the <see cref="FileReadResult" /> class.
        /// </summary>
        /// <param name="content">
        /// Parsed text content of the file.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileReadResult(
            string content)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileReadResult" /> class.
        /// </summary>
        public FileReadResult()
        {
        }

    }
}