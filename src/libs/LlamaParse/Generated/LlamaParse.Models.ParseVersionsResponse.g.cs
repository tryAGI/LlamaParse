
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Versions accepted by the parse API, grouped by tier.
    /// </summary>
    public sealed partial class ParseVersionsResponse
    {
        /// <summary>
        /// Versions for the fast tier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fast")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LlamaParse.ParseVersionsResponseFastItem> Fast { get; set; }

        /// <summary>
        /// Versions for the cost_effective tier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_effective")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LlamaParse.ParseVersionsResponseCostEffectiveItem> CostEffective { get; set; }

        /// <summary>
        /// Versions for the agentic tier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentic")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LlamaParse.ParseVersionsResponseAgenticItem> Agentic { get; set; }

        /// <summary>
        /// Versions for the agentic_plus tier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentic_plus")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LlamaParse.ParseVersionsResponseAgenticPlu> AgenticPlus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseVersionsResponse" /> class.
        /// </summary>
        /// <param name="fast">
        /// Versions for the fast tier
        /// </param>
        /// <param name="costEffective">
        /// Versions for the cost_effective tier
        /// </param>
        /// <param name="agentic">
        /// Versions for the agentic tier
        /// </param>
        /// <param name="agenticPlus">
        /// Versions for the agentic_plus tier
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParseVersionsResponse(
            global::System.Collections.Generic.IList<global::LlamaParse.ParseVersionsResponseFastItem> fast,
            global::System.Collections.Generic.IList<global::LlamaParse.ParseVersionsResponseCostEffectiveItem> costEffective,
            global::System.Collections.Generic.IList<global::LlamaParse.ParseVersionsResponseAgenticItem> agentic,
            global::System.Collections.Generic.IList<global::LlamaParse.ParseVersionsResponseAgenticPlu> agenticPlus)
        {
            this.Fast = fast ?? throw new global::System.ArgumentNullException(nameof(fast));
            this.CostEffective = costEffective ?? throw new global::System.ArgumentNullException(nameof(costEffective));
            this.Agentic = agentic ?? throw new global::System.ArgumentNullException(nameof(agentic));
            this.AgenticPlus = agenticPlus ?? throw new global::System.ArgumentNullException(nameof(agenticPlus));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseVersionsResponse" /> class.
        /// </summary>
        public ParseVersionsResponse()
        {
        }
    }
}