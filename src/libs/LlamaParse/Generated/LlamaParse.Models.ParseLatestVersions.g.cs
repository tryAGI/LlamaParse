
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Dated version each tier runs when a request pins `latest`.
    /// </summary>
    public sealed partial class ParseLatestVersions
    {
        /// <summary>
        /// Version `latest` resolves to for the fast tier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fast")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Fast { get; set; }

        /// <summary>
        /// Version `latest` resolves to for the cost_effective tier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_effective")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CostEffective { get; set; }

        /// <summary>
        /// Version `latest` resolves to for the agentic tier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentic")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Agentic { get; set; }

        /// <summary>
        /// Version `latest` resolves to for the agentic_plus tier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentic_plus")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgenticPlus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseLatestVersions" /> class.
        /// </summary>
        /// <param name="fast">
        /// Version `latest` resolves to for the fast tier
        /// </param>
        /// <param name="costEffective">
        /// Version `latest` resolves to for the cost_effective tier
        /// </param>
        /// <param name="agentic">
        /// Version `latest` resolves to for the agentic tier
        /// </param>
        /// <param name="agenticPlus">
        /// Version `latest` resolves to for the agentic_plus tier
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParseLatestVersions(
            string fast,
            string costEffective,
            string agentic,
            string agenticPlus)
        {
            this.Fast = fast ?? throw new global::System.ArgumentNullException(nameof(fast));
            this.CostEffective = costEffective ?? throw new global::System.ArgumentNullException(nameof(costEffective));
            this.Agentic = agentic ?? throw new global::System.ArgumentNullException(nameof(agentic));
            this.AgenticPlus = agenticPlus ?? throw new global::System.ArgumentNullException(nameof(agenticPlus));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseLatestVersions" /> class.
        /// </summary>
        public ParseLatestVersions()
        {
        }

    }
}