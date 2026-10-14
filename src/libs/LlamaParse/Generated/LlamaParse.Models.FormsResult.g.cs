
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Beta: per-page form analysis results; node types the calling SDK predates are left out.
    /// </summary>
    public sealed partial class FormsResult
    {
        /// <summary>
        /// List of form pages or failed page entries
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.FormsResultPage, global::LlamaParse.FailedFormsPage>> Pages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FormsResult" /> class.
        /// </summary>
        /// <param name="pages">
        /// List of form pages or failed page entries
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FormsResult(
            global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.FormsResultPage, global::LlamaParse.FailedFormsPage>> pages)
        {
            this.Pages = pages ?? throw new global::System.ArgumentNullException(nameof(pages));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormsResult" /> class.
        /// </summary>
        public FormsResult()
        {
        }

    }
}