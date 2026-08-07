
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Usage recorded against a job.
    /// </summary>
    public sealed partial class JobUsage
    {
        /// <summary>
        /// Total credits billed against this job. Null until billing has recorded it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        public double? Credits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobUsage" /> class.
        /// </summary>
        /// <param name="credits">
        /// Total credits billed against this job. Null until billing has recorded it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JobUsage(
            double? credits)
        {
            this.Credits = credits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobUsage" /> class.
        /// </summary>
        public JobUsage()
        {
        }

    }
}