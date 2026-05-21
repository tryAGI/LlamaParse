
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Response containing retrieval results.
    /// </summary>
    public sealed partial class RetrieveResult
    {
        /// <summary>
        /// Ordered list of retrieved chunks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LlamaParse.RetrievalResult> Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveResult" /> class.
        /// </summary>
        /// <param name="results">
        /// Ordered list of retrieved chunks.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetrieveResult(
            global::System.Collections.Generic.IList<global::LlamaParse.RetrievalResult> results)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveResult" /> class.
        /// </summary>
        public RetrieveResult()
        {
        }

    }
}