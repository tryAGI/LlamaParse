
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
        /// Split version to run. Omit for the current release. Preview versions are selectable by name and never resolved automatically.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Parse tier used to read the document before splitting. Defaults to fast. Ignored when a completed parse job is supplied as file_input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parse_tier")]
        public global::LlamaParse.SplitConfigurationParseTier? ParseTier { get; set; }

        /// <summary>
        /// Saved parse configuration ID to control how the document is parsed before splitting. Takes precedence over parse_tier. Configurations that restrict pages (`target_pages` or `max_pages` on the parse configuration) are rejected: split results number pages relative to the full document. Ignored when a completed parse job is supplied as file_input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parse_config_id")]
        public string? ParseConfigId { get; set; }

        /// <summary>
        /// Comma-separated page numbers or ranges to split (1-based). Omit to split all pages. Requires a completed parse job as file_input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_pages")]
        public string? TargetPages { get; set; }

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
        /// <param name="version">
        /// Split version to run. Omit for the current release. Preview versions are selectable by name and never resolved automatically.
        /// </param>
        /// <param name="parseTier">
        /// Parse tier used to read the document before splitting. Defaults to fast. Ignored when a completed parse job is supplied as file_input.
        /// </param>
        /// <param name="parseConfigId">
        /// Saved parse configuration ID to control how the document is parsed before splitting. Takes precedence over parse_tier. Configurations that restrict pages (`target_pages` or `max_pages` on the parse configuration) are rejected: split results number pages relative to the full document. Ignored when a completed parse job is supplied as file_input.
        /// </param>
        /// <param name="targetPages">
        /// Comma-separated page numbers or ranges to split (1-based). Omit to split all pages. Requires a completed parse job as file_input.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SplitConfiguration(
            global::System.Collections.Generic.IList<global::LlamaParse.SplitCategory> categories,
            global::LlamaParse.SplitStrategy? splittingStrategy,
            string? version,
            global::LlamaParse.SplitConfigurationParseTier? parseTier,
            string? parseConfigId,
            string? targetPages)
        {
            this.Categories = categories ?? throw new global::System.ArgumentNullException(nameof(categories));
            this.SplittingStrategy = splittingStrategy;
            this.Version = version;
            this.ParseTier = parseTier;
            this.ParseConfigId = parseConfigId;
            this.TargetPages = targetPages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitConfiguration" /> class.
        /// </summary>
        public SplitConfiguration()
        {
        }

    }
}