
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Relevance score from the reranker, if reranking was applied.
    /// </summary>
    public sealed partial class RetrievalResultResponseRerankScore
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}