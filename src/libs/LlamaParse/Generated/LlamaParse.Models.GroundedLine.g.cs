
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// One grounded line of text with an optional per-word breakdown.
    /// </summary>
    public sealed partial class GroundedLine
    {
        /// <summary>
        /// `[start, end)` byte span in the item's source text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<long> Span { get; set; }

        /// <summary>
        /// Line bounding box
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bbox")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.BBox Bbox { get; set; }

        /// <summary>
        /// Per-word grounding within the line, when available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        public global::System.Collections.Generic.IList<global::LlamaParse.GroundedWord>? Words { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundedLine" /> class.
        /// </summary>
        /// <param name="span">
        /// `[start, end)` byte span in the item's source text
        /// </param>
        /// <param name="bbox">
        /// Line bounding box
        /// </param>
        /// <param name="words">
        /// Per-word grounding within the line, when available
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GroundedLine(
            global::System.Collections.Generic.IList<long> span,
            global::LlamaParse.BBox bbox,
            global::System.Collections.Generic.IList<global::LlamaParse.GroundedWord>? words)
        {
            this.Span = span ?? throw new global::System.ArgumentNullException(nameof(span));
            this.Bbox = bbox ?? throw new global::System.ArgumentNullException(nameof(bbox));
            this.Words = words;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundedLine" /> class.
        /// </summary>
        public GroundedLine()
        {
        }

    }
}