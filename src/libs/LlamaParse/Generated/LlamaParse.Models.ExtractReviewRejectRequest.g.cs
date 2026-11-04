
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Reject the result.
    /// </summary>
    public sealed partial class ExtractReviewRejectRequest
    {
        /// <summary>
        /// The review's revision as the caller last read it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revision")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Revision { get; set; }

        /// <summary>
        /// Why the result was rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractReviewRejectRequest" /> class.
        /// </summary>
        /// <param name="revision">
        /// The review's revision as the caller last read it.
        /// </param>
        /// <param name="reason">
        /// Why the result was rejected.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractReviewRejectRequest(
            int revision,
            string reason)
        {
            this.Revision = revision;
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractReviewRejectRequest" /> class.
        /// </summary>
        public ExtractReviewRejectRequest()
        {
        }

    }
}