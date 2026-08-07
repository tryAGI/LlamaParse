
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Image categories to save: 'screenshot' (full page renders), 'embedded' (images found within the document), 'layout' (cropped figures and diagrams). Defaults to saving 'layout' when the output links to cropped images; pass [] to save none
    /// </summary>
    public sealed partial class LlamaParseOutputOptionsImagesToSave
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}