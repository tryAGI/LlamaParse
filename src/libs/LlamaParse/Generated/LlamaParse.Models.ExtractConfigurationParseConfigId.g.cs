
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Saved parse configuration ID to control how the document is parsed before extraction. Turbo extract does not support parse configuration or produce a parse output; use another tier if your workflow requires parsed text.
    /// </summary>
    public sealed partial class ExtractConfigurationParseConfigId
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}