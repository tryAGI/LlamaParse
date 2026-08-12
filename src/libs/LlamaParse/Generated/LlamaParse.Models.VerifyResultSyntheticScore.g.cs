
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Likelihood (0 to 1) that the document is wholly generated or fabricated rather than a capture of a real document. Null for jobs completed before this score was introduced
    /// </summary>
    public sealed partial class VerifyResultSyntheticScore
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}