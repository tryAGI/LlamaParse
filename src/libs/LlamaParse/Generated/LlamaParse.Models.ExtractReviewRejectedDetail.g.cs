
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// What a `rejected` entry records.
    /// </summary>
    public sealed partial class ExtractReviewRejectedDetail
    {
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
        /// Initializes a new instance of the <see cref="ExtractReviewRejectedDetail" /> class.
        /// </summary>
        /// <param name="reason">
        /// Why the result was rejected.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractReviewRejectedDetail(
            string reason)
        {
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractReviewRejectedDetail" /> class.
        /// </summary>
        public ExtractReviewRejectedDetail()
        {
        }

    }
}