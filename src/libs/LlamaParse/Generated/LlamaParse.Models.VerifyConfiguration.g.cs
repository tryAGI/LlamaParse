
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Configuration for a Verify job.
    /// </summary>
    public sealed partial class VerifyConfiguration
    {
        /// <summary>
        /// Verify tier: 'fast' runs only the quick deterministic forensic checks (metadata, content integrity, container structure, pixel statistics); 'agentic' (default) runs the full pipeline including the learned detectors and the semantic review pass.<br/>
        /// Default Value: agentic
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LlamaParse.JsonConverters.VerifyConfigurationTierJsonConverter))]
        public global::LlamaParse.VerifyConfigurationTier? Tier { get; set; }

        /// <summary>
        /// Comma-separated page numbers or ranges to analyze (1-based). Omit to analyze all pages. Ignored for non-PDF inputs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_pages")]
        public string? TargetPages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyConfiguration" /> class.
        /// </summary>
        /// <param name="tier">
        /// Verify tier: 'fast' runs only the quick deterministic forensic checks (metadata, content integrity, container structure, pixel statistics); 'agentic' (default) runs the full pipeline including the learned detectors and the semantic review pass.<br/>
        /// Default Value: agentic
        /// </param>
        /// <param name="targetPages">
        /// Comma-separated page numbers or ranges to analyze (1-based). Omit to analyze all pages. Ignored for non-PDF inputs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VerifyConfiguration(
            global::LlamaParse.VerifyConfigurationTier? tier,
            string? targetPages)
        {
            this.Tier = tier;
            this.TargetPages = targetPages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyConfiguration" /> class.
        /// </summary>
        public VerifyConfiguration()
        {
        }

    }
}