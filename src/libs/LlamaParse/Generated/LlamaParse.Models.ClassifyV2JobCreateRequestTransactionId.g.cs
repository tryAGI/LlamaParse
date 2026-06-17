
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Idempotency key scoped to the project. Reusing a key returns the original job; the new request body is ignored.
    /// </summary>
    public sealed partial class ClassifyV2JobCreateRequestTransactionId
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}