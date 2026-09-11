
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Supported text with half-open UTF-8 byte spans into the complete property string.
    /// </summary>
    public sealed partial class FormTextGrounding
    {
        /// <summary>
        /// Supported lines. Word requests include supported words; gaps are valid. Boxes use final page coordinates and optional local rotation r.
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
        /// Initializes a new instance of the <see cref="FormTextGrounding" /> class.
        /// </summary>
        /// <param name="lines">
        /// Supported lines. Word requests include supported words; gaps are valid. Boxes use final page coordinates and optional local rotation r.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FormTextGrounding(
            global::System.Collections.Generic.IList<global::LlamaParse.GroundedLine> lines)
        {
            this.Lines = lines ?? throw new global::System.ArgumentNullException(nameof(lines));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormTextGrounding" /> class.
        /// </summary>
        public FormTextGrounding()
        {
        }

    }
}