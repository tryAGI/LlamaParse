
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Source line number linked to final page markdown.
    /// </summary>
    public sealed partial class MarkdownLineNumberAnnotation
    {
        /// <summary>
        /// Printed source line number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("line_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LineNumber { get; set; }

        /// <summary>
        /// Zero-based inclusive UTF-16 code-unit offset in final page markdown
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartIndex { get; set; }

        /// <summary>
        /// Zero-based exclusive UTF-16 code-unit offset in final page markdown
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownLineNumberAnnotation" /> class.
        /// </summary>
        /// <param name="lineNumber">
        /// Printed source line number
        /// </param>
        /// <param name="startIndex">
        /// Zero-based inclusive UTF-16 code-unit offset in final page markdown
        /// </param>
        /// <param name="endIndex">
        /// Zero-based exclusive UTF-16 code-unit offset in final page markdown
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MarkdownLineNumberAnnotation(
            string lineNumber,
            int startIndex,
            int endIndex)
        {
            this.LineNumber = lineNumber ?? throw new global::System.ArgumentNullException(nameof(lineNumber));
            this.StartIndex = startIndex;
            this.EndIndex = endIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownLineNumberAnnotation" /> class.
        /// </summary>
        public MarkdownLineNumberAnnotation()
        {
        }

    }
}