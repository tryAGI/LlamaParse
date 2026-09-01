
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Parse tier to use before extraction. Defaults to the extract tier if not specified. Turbo extract does not support parse configuration or produce a parse output; use another tier if your workflow requires parsed text.
    /// </summary>
    public sealed partial class ExtractV2ParametersParseTier
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}