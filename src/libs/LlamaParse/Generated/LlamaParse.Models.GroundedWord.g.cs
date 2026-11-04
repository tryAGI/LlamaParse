
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// One grounded word: a `[start, end)` span in the source text and its bbox.
    /// </summary>
    public sealed partial class GroundedWord
    {
        /// <summary>
        /// `[start, end)` UTF-8 byte span in the complete source property string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<long> Span { get; set; }

        /// <summary>
        /// Word bounding box
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bbox")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.BBox Bbox { get; set; }

        /// <summary>
        /// Per-character grounding within the word, present when `granular_bboxes` includes 'char' (Agentic Plus only). Each box is an even split of the word box across the word's characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chars")]
        public global::System.Collections.Generic.IList<global::LlamaParse.GroundedChar>? Chars { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundedWord" /> class.
        /// </summary>
        /// <param name="span">
        /// `[start, end)` UTF-8 byte span in the complete source property string
        /// </param>
        /// <param name="bbox">
        /// Word bounding box
        /// </param>
        /// <param name="chars">
        /// Per-character grounding within the word, present when `granular_bboxes` includes 'char' (Agentic Plus only). Each box is an even split of the word box across the word's characters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GroundedWord(
            global::System.Collections.Generic.IList<long> span,
            global::LlamaParse.BBox bbox,
            global::System.Collections.Generic.IList<global::LlamaParse.GroundedChar>? chars)
        {
            this.Span = span ?? throw new global::System.ArgumentNullException(nameof(span));
            this.Bbox = bbox ?? throw new global::System.ArgumentNullException(nameof(bbox));
            this.Chars = chars;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundedWord" /> class.
        /// </summary>
        public GroundedWord()
        {
        }

    }
}