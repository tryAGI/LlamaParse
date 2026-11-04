
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// An action on the review as the caller last read it.
    /// </summary>
    public sealed partial class ExtractReviewRevisionRequest
    {
        /// <summary>
        /// The review's revision as the caller last read it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revision")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Revision { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractReviewRevisionRequest" /> class.
        /// </summary>
        /// <param name="revision">
        /// The review's revision as the caller last read it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractReviewRevisionRequest(
            int revision)
        {
            this.Revision = revision;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractReviewRevisionRequest" /> class.
        /// </summary>
        public ExtractReviewRevisionRequest()
        {
        }

    }
}