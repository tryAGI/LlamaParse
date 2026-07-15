
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Forms found on one page. Pages without form content have an empty forms list.
    /// </summary>
    public sealed partial class FormsResultPage
    {
        /// <summary>
        /// Page number of the document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PageNumber { get; set; }

        /// <summary>
        /// Forms detected on the page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LlamaParse.Form> Forms { get; set; }

        /// <summary>
        /// Success indicator
        /// </summary>
        /// <default>true</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool Success { get; set; } = true;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FormsResultPage" /> class.
        /// </summary>
        /// <param name="pageNumber">
        /// Page number of the document
        /// </param>
        /// <param name="forms">
        /// Forms detected on the page
        /// </param>
        /// <param name="success">
        /// Success indicator
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FormsResultPage(
            int pageNumber,
            global::System.Collections.Generic.IList<global::LlamaParse.Form> forms,
            bool success = true)
        {
            this.PageNumber = pageNumber;
            this.Forms = forms ?? throw new global::System.ArgumentNullException(nameof(forms));
            this.Success = success;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormsResultPage" /> class.
        /// </summary>
        public FormsResultPage()
        {
        }

    }
}