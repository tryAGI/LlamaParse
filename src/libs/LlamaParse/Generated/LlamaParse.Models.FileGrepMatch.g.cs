
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// A single grep match within a file.
    /// </summary>
    public sealed partial class FileGrepMatch
    {
        /// <summary>
        /// Start character offset of the match.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_char")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartChar { get; set; }

        /// <summary>
        /// End character offset of the match.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_char")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndChar { get; set; }

        /// <summary>
        /// Matched text content.
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
        /// Initializes a new instance of the <see cref="FileGrepMatch" /> class.
        /// </summary>
        /// <param name="startChar">
        /// Start character offset of the match.
        /// </param>
        /// <param name="endChar">
        /// End character offset of the match.
        /// </param>
        /// <param name="content">
        /// Matched text content.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileGrepMatch(
            int startChar,
            int endChar,
            string content)
        {
            this.StartChar = startChar;
            this.EndChar = endChar;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileGrepMatch" /> class.
        /// </summary>
        public FileGrepMatch()
        {
        }

    }
}