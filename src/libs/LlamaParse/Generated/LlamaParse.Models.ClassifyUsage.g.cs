
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Usage recorded against a classify job.<br/>
    /// Classify bills through the parse job it runs on a file input, so that parse<br/>
    /// job's credits are the whole total. A job run on a parse job you created bills<br/>
    /// nothing of its own: ``parse_credits`` is null and ``credits`` is 0.
    /// </summary>
    public sealed partial class ClassifyUsage
    {
        /// <summary>
        /// Total credits billed against this job. Null until billing has recorded it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        public double? Credits { get; set; }

        /// <summary>
        /// Credits billed against the parse job Classify ran on the input file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parse_credits")]
        public double? ParseCredits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyUsage" /> class.
        /// </summary>
        /// <param name="credits">
        /// Total credits billed against this job. Null until billing has recorded it.
        /// </param>
        /// <param name="parseCredits">
        /// Credits billed against the parse job Classify ran on the input file
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClassifyUsage(
            double? credits,
            double? parseCredits)
        {
            this.Credits = credits;
            this.ParseCredits = parseCredits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyUsage" /> class.
        /// </summary>
        public ClassifyUsage()
        {
        }

    }
}