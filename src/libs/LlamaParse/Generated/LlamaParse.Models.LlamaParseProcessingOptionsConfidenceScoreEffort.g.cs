
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Confidence scoring effort. Omit for standard scoring. 'high': more accurate assessment of the parsing quality of every page, plus a document-level score in the result metadata; costs an additional 5 credits per page
    /// </summary>
    public sealed partial class LlamaParseProcessingOptionsConfidenceScoreEffort
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}