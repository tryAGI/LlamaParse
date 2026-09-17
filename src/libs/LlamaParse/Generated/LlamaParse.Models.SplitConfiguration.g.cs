
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Split configuration with categories and splitting strategy.
    /// </summary>
    public sealed partial class SplitConfiguration
    {
        /// <summary>
        /// Categories to split documents into.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LlamaParse.SplitCategory> Categories { get; set; }

        /// <summary>
        /// Strategy for splitting documents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("splitting_strategy")]
        public global::LlamaParse.SplitStrategy? SplittingStrategy { get; set; }

        /// <summary>
        /// Parse tier used to read the document before splitting. Defaults to fast. Ignored when a completed parse job is supplied as file_input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parse_tier")]
        public global::LlamaParse.SplitConfigurationParseTier? ParseTier { get; set; }

        /// <summary>
        /// Saved parse configuration ID controlling how the document is read before splitting. Takes precedence over parse_tier. Configurations restricted to a page subset (target_pages or max_pages) are rejected, since split results always number pages relative to the full document. Ignored when a completed parse job is supplied as file_input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parse_config_id")]
        public string? ParseConfigId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitConfiguration" /> class.
        /// </summary>
        /// <param name="categories">
        /// Categories to split documents into.
        /// </param>
        /// <param name="splittingStrategy">
        /// Strategy for splitting documents.
        /// </param>
        /// <param name="parseTier">
        /// Parse tier used to read the document before splitting. Defaults to fast. Ignored when a completed parse job is supplied as file_input.
        /// </param>
        /// <param name="parseConfigId">
        /// Saved parse configuration ID controlling how the document is read before splitting. Takes precedence over parse_tier. Configurations restricted to a page subset (target_pages or max_pages) are rejected, since split results always number pages relative to the full document. Ignored when a completed parse job is supplied as file_input.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SplitConfiguration(
            global::System.Collections.Generic.IList<global::LlamaParse.SplitCategory> categories,
            global::LlamaParse.SplitStrategy? splittingStrategy,
            global::LlamaParse.SplitConfigurationParseTier? parseTier,
            string? parseConfigId)
        {
            this.Categories = categories ?? throw new global::System.ArgumentNullException(nameof(categories));
            this.SplittingStrategy = splittingStrategy;
            this.ParseTier = parseTier;
            this.ParseConfigId = parseConfigId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitConfiguration" /> class.
        /// </summary>
        public SplitConfiguration()
        {
        }

    }
}