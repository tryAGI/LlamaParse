
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Paginated list of chat sessions.
    /// </summary>
    public sealed partial class SessionListAPIResponse
    {
        /// <summary>
        /// Chat sessions for the current page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LlamaParse.SessionSummaryAPIResponse> Items { get; set; }

        /// <summary>
        /// Opaque token to retrieve the next page. Omitted when there are no further pages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page_token")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionListAPIResponse" /> class.
        /// </summary>
        /// <param name="items">
        /// Chat sessions for the current page.
        /// </param>
        /// <param name="nextPageToken">
        /// Opaque token to retrieve the next page. Omitted when there are no further pages.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionListAPIResponse(
            global::System.Collections.Generic.IList<global::LlamaParse.SessionSummaryAPIResponse> items,
            string? nextPageToken)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.NextPageToken = nextPageToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionListAPIResponse" /> class.
        /// </summary>
        public SessionListAPIResponse()
        {
        }

    }
}