
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// One grounded character: a `[start, end)` span in the source text and its bbox.
    /// </summary>
    public sealed partial class GroundedChar
    {
        /// <summary>
        /// `[start, end)` UTF-8 byte span in the complete source property string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<long> Span { get; set; }

        /// <summary>
        /// Character bounding box
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bbox")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.BBox Bbox { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundedChar" /> class.
        /// </summary>
        /// <param name="span">
        /// `[start, end)` UTF-8 byte span in the complete source property string
        /// </param>
        /// <param name="bbox">
        /// Character bounding box
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GroundedChar(
            global::System.Collections.Generic.IList<long> span,
            global::LlamaParse.BBox bbox)
        {
            this.Span = span ?? throw new global::System.ArgumentNullException(nameof(span));
            this.Bbox = bbox ?? throw new global::System.ArgumentNullException(nameof(bbox));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundedChar" /> class.
        /// </summary>
        public GroundedChar()
        {
        }

    }
}