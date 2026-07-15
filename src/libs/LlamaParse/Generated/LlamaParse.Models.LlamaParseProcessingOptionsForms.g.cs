
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Beta: set to 'enrich' to run an additional AI form-analysis pass on pages detected as forms, producing a structured tree of the form's sections, fields, and fillable grids. Retrieve the result with expand=forms. 'default' (the default) applies standard parsing with no extra pass. Not available on the fast tier
    /// </summary>
    public sealed partial class LlamaParseProcessingOptionsForms
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}