
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Changes to a job's fields, applied in order. A job without a review gets<br/>
    /// one, at revision 0.
    /// </summary>
    public sealed partial class ExtractReviewFieldsRequest
    {
        /// <summary>
        /// The review's revision as the caller last read it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revision")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Revision { get; set; }

        /// <summary>
        /// Changes to apply, in order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LlamaParse.ExtractReviewFieldChange> Changes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractReviewFieldsRequest" /> class.
        /// </summary>
        /// <param name="revision">
        /// The review's revision as the caller last read it.
        /// </param>
        /// <param name="changes">
        /// Changes to apply, in order.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractReviewFieldsRequest(
            int revision,
            global::System.Collections.Generic.IList<global::LlamaParse.ExtractReviewFieldChange> changes)
        {
            this.Revision = revision;
            this.Changes = changes ?? throw new global::System.ArgumentNullException(nameof(changes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractReviewFieldsRequest" /> class.
        /// </summary>
        public ExtractReviewFieldsRequest()
        {
        }

    }
}