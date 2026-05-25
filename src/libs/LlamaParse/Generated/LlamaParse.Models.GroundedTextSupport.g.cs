
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Grounding for a text-shaped item (paragraph, heading, caption, etc.).
    /// </summary>
    public sealed partial class GroundedTextSupport
    {
        /// <summary>
        /// Which textual surface of the item the spans index into
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LlamaParse.JsonConverters.GroundedTextSupportSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.GroundedTextSupportSource Source { get; set; }

        /// <summary>
        /// Per-line grounding for the item text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lines")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LlamaParse.GroundedLine> Lines { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundedTextSupport" /> class.
        /// </summary>
        /// <param name="source">
        /// Which textual surface of the item the spans index into
        /// </param>
        /// <param name="lines">
        /// Per-line grounding for the item text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GroundedTextSupport(
            global::LlamaParse.GroundedTextSupportSource source,
            global::System.Collections.Generic.IList<global::LlamaParse.GroundedLine> lines)
        {
            this.Source = source;
            this.Lines = lines ?? throw new global::System.ArgumentNullException(nameof(lines));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundedTextSupport" /> class.
        /// </summary>
        public GroundedTextSupport()
        {
        }

    }
}