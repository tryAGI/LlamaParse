
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Per-family scores (metadata, ai_generation, splicing, copy_move, compression, noise, coherence, pdf_structure)
    /// </summary>
    public sealed partial class VerifyJobDetailsResponseSubScores
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}