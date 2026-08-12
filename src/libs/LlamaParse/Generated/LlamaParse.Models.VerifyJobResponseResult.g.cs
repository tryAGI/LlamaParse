
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Verify result — populated when status is COMPLETED and the result was requested via expand=result
    /// </summary>
    public sealed partial class VerifyJobResponseResult
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}