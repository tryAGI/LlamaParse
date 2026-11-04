
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Approve the reviewed result.
    /// </summary>
    public sealed partial class ExtractReviewApproveRequest
    {
        /// <summary>
        /// The review's revision as the caller last read it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revision")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Revision { get; set; }

        /// <summary>
        /// Confirm the flagged fields nobody checked as part of approving.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sign_off")]
        public bool? SignOff { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractReviewApproveRequest" /> class.
        /// </summary>
        /// <param name="revision">
        /// The review's revision as the caller last read it.
        /// </param>
        /// <param name="signOff">
        /// Confirm the flagged fields nobody checked as part of approving.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractReviewApproveRequest(
            int revision,
            bool? signOff)
        {
            this.Revision = revision;
            this.SignOff = signOff;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractReviewApproveRequest" /> class.
        /// </summary>
        public ExtractReviewApproveRequest()
        {
        }

    }
}