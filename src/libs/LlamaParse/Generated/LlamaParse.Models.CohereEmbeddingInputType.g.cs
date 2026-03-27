
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Model Input type. If not provided, search_document and search_query are used when needed.
    /// </summary>
    public sealed partial class CohereEmbeddingInputType
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}