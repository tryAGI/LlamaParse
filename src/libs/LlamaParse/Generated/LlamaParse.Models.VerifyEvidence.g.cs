
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// A single piece of evidence produced by a detection tool.
    /// </summary>
    public sealed partial class VerifyEvidence
    {
        /// <summary>
        /// Tool that produced this evidence
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tool { get; set; }

        /// <summary>
        /// Signal family (e.g. metadata, splicing, compression)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("family")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Family { get; set; }

        /// <summary>
        /// Machine-readable evidence code
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// Human-readable evidence detail
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Detail { get; set; }

        /// <summary>
        /// Evidence strength score
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        /// Whether this is hard (conclusive) evidence<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hard")]
        public bool? Hard { get; set; }

        /// <summary>
        /// Tool-specific structured payload
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyEvidence" /> class.
        /// </summary>
        /// <param name="tool">
        /// Tool that produced this evidence
        /// </param>
        /// <param name="family">
        /// Signal family (e.g. metadata, splicing, compression)
        /// </param>
        /// <param name="code">
        /// Machine-readable evidence code
        /// </param>
        /// <param name="detail">
        /// Human-readable evidence detail
        /// </param>
        /// <param name="score">
        /// Evidence strength score
        /// </param>
        /// <param name="hard">
        /// Whether this is hard (conclusive) evidence<br/>
        /// Default Value: false
        /// </param>
        /// <param name="data">
        /// Tool-specific structured payload
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VerifyEvidence(
            string tool,
            string family,
            string code,
            string detail,
            double score,
            bool? hard,
            object? data)
        {
            this.Tool = tool ?? throw new global::System.ArgumentNullException(nameof(tool));
            this.Family = family ?? throw new global::System.ArgumentNullException(nameof(family));
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Detail = detail ?? throw new global::System.ArgumentNullException(nameof(detail));
            this.Score = score;
            this.Hard = hard;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyEvidence" /> class.
        /// </summary>
        public VerifyEvidence()
        {
        }

    }
}