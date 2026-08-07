
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Save a PDF copy of the parsed document, retrievable via `expand=output_pdf_content_metadata`. Not produced for spreadsheet, plain-text, or audio inputs
    /// </summary>
    public sealed partial class LlamaParseOutputOptionsSaveOutputPdf
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}