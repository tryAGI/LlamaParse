
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Form analysis result (if requested; jobs with forms=enrich only)
    /// </summary>
    public sealed partial class ParseResultResponseForms
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}