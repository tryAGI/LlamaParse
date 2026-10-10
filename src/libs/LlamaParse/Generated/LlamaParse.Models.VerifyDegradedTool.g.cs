
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// A check that was attempted but could not run on this job.
    /// </summary>
    public sealed partial class VerifyDegradedTool
    {
        /// <summary>
        /// Name of the check
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tool { get; set; }

        /// <summary>
        /// Why the check could not run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyDegradedTool" /> class.
        /// </summary>
        /// <param name="tool">
        /// Name of the check
        /// </param>
        /// <param name="reason">
        /// Why the check could not run
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VerifyDegradedTool(
            string tool,
            string? reason)
        {
            this.Tool = tool ?? throw new global::System.ArgumentNullException(nameof(tool));
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyDegradedTool" /> class.
        /// </summary>
        public VerifyDegradedTool()
        {
        }

    }
}