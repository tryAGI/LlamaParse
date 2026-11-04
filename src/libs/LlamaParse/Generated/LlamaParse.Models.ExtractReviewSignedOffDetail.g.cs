
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// What a `flags_signed_off` entry records.
    /// </summary>
    public sealed partial class ExtractReviewSignedOffDetail
    {
        /// <summary>
        /// JSON Pointers of the flagged fields confirmed as part of approving.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paths")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Paths { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractReviewSignedOffDetail" /> class.
        /// </summary>
        /// <param name="paths">
        /// JSON Pointers of the flagged fields confirmed as part of approving.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractReviewSignedOffDetail(
            global::System.Collections.Generic.IList<string> paths)
        {
            this.Paths = paths ?? throw new global::System.ArgumentNullException(nameof(paths));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractReviewSignedOffDetail" /> class.
        /// </summary>
        public ExtractReviewSignedOffDetail()
        {
        }

    }
}