
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Configuration for how to split the document.
    /// </summary>
    public sealed partial class SplitStrategy
    {
        /// <summary>
        /// Controls handling of pages that don't match any category. 'include': pages can be grouped as 'uncategorized' and included in results. 'forbid': all pages must be assigned to a defined category. 'omit': pages can be classified as 'uncategorized' but are excluded from results.<br/>
        /// Default Value: include
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_uncategorized")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LlamaParse.JsonConverters.SplitStrategyAllowUncategorizedJsonConverter))]
        public global::LlamaParse.SplitStrategyAllowUncategorized? AllowUncategorized { get; set; }

        /// <summary>
        /// Minimum pages per segment. Shorter segments are merged into an adjacent segment; 1 disables merging.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_pages_per_split")]
        public int? MinPagesPerSplit { get; set; }

        /// <summary>
        /// Free-form guidance for where segment boundaries are placed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_instructions")]
        public string? CustomInstructions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitStrategy" /> class.
        /// </summary>
        /// <param name="allowUncategorized">
        /// Controls handling of pages that don't match any category. 'include': pages can be grouped as 'uncategorized' and included in results. 'forbid': all pages must be assigned to a defined category. 'omit': pages can be classified as 'uncategorized' but are excluded from results.<br/>
        /// Default Value: include
        /// </param>
        /// <param name="minPagesPerSplit">
        /// Minimum pages per segment. Shorter segments are merged into an adjacent segment; 1 disables merging.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="customInstructions">
        /// Free-form guidance for where segment boundaries are placed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SplitStrategy(
            global::LlamaParse.SplitStrategyAllowUncategorized? allowUncategorized,
            int? minPagesPerSplit,
            string? customInstructions)
        {
            this.AllowUncategorized = allowUncategorized;
            this.MinPagesPerSplit = minPagesPerSplit;
            this.CustomInstructions = customInstructions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitStrategy" /> class.
        /// </summary>
        public SplitStrategy()
        {
        }

    }
}