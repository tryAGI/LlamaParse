
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// One extracted document revision linked to page content.
    /// </summary>
    public sealed partial class Revision
    {
        /// <summary>
        /// Type of revision
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LlamaParse.JsonConverters.RevisionTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.RevisionType Type { get; set; }

        /// <summary>
        /// Best available target text in the page content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Target { get; set; }

        /// <summary>
        /// Revision or comment content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Revision author, when available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        public string? Author { get; set; }

        /// <summary>
        /// Union bounding box of the target spans
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_bbox")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.RevisionBBox TargetBbox { get; set; }

        /// <summary>
        /// Bounding box of the printed revision balloon
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revision_bbox")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.RevisionBBox RevisionBbox { get; set; }

        /// <summary>
        /// Disconnected target spans, when present
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_spans")]
        public global::System.Collections.Generic.IList<global::LlamaParse.RevisionTargetSpan>? TargetSpans { get; set; }

        /// <summary>
        /// Inclusive start offset in final page markdown
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_index")]
        public int? StartIndex { get; set; }

        /// <summary>
        /// Exclusive end offset in final page markdown
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_index")]
        public int? EndIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Revision" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of revision
        /// </param>
        /// <param name="target">
        /// Best available target text in the page content
        /// </param>
        /// <param name="content">
        /// Revision or comment content
        /// </param>
        /// <param name="targetBbox">
        /// Union bounding box of the target spans
        /// </param>
        /// <param name="revisionBbox">
        /// Bounding box of the printed revision balloon
        /// </param>
        /// <param name="author">
        /// Revision author, when available
        /// </param>
        /// <param name="targetSpans">
        /// Disconnected target spans, when present
        /// </param>
        /// <param name="startIndex">
        /// Inclusive start offset in final page markdown
        /// </param>
        /// <param name="endIndex">
        /// Exclusive end offset in final page markdown
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Revision(
            global::LlamaParse.RevisionType type,
            string target,
            string content,
            global::LlamaParse.RevisionBBox targetBbox,
            global::LlamaParse.RevisionBBox revisionBbox,
            string? author,
            global::System.Collections.Generic.IList<global::LlamaParse.RevisionTargetSpan>? targetSpans,
            int? startIndex,
            int? endIndex)
        {
            this.Type = type;
            this.Target = target ?? throw new global::System.ArgumentNullException(nameof(target));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Author = author;
            this.TargetBbox = targetBbox ?? throw new global::System.ArgumentNullException(nameof(targetBbox));
            this.RevisionBbox = revisionBbox ?? throw new global::System.ArgumentNullException(nameof(revisionBbox));
            this.TargetSpans = targetSpans;
            this.StartIndex = startIndex;
            this.EndIndex = endIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Revision" /> class.
        /// </summary>
        public Revision()
        {
        }

    }
}