
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Usage recorded against an extract job.<br/>
    /// A parse job can back several extract jobs, so each of them reports that<br/>
    /// same parse cost in its total.
    /// </summary>
    public sealed partial class ExtractUsage
    {
        /// <summary>
        /// Total credits billed against this job. Null until billing has recorded it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        public double? Credits { get; set; }

        /// <summary>
        /// Credits billed for the extraction itself
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extract_credits")]
        public double? ExtractCredits { get; set; }

        /// <summary>
        /// Credits billed against the parse job backing this extract job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parse_credits")]
        public double? ParseCredits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractUsage" /> class.
        /// </summary>
        /// <param name="credits">
        /// Total credits billed against this job. Null until billing has recorded it.
        /// </param>
        /// <param name="extractCredits">
        /// Credits billed for the extraction itself
        /// </param>
        /// <param name="parseCredits">
        /// Credits billed against the parse job backing this extract job
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractUsage(
            double? credits,
            double? extractCredits,
            double? parseCredits)
        {
            this.Credits = credits;
            this.ExtractCredits = extractCredits;
            this.ParseCredits = parseCredits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractUsage" /> class.
        /// </summary>
        public ExtractUsage()
        {
        }

    }
}