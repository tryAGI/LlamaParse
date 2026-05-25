
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Extraction usage metrics.
    /// </summary>
    public sealed partial class ExtractJobUsage
    {
        /// <summary>
        /// Number of pages extracted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_pages_extracted")]
        public int? NumPagesExtracted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractJobUsage" /> class.
        /// </summary>
        /// <param name="numPagesExtracted">
        /// Number of pages extracted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractJobUsage(
            int? numPagesExtracted)
        {
            this.NumPagesExtracted = numPagesExtracted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractJobUsage" /> class.
        /// </summary>
        public ExtractJobUsage()
        {
        }

    }
}