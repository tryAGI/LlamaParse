
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Optional worksheet names to extract when spreadsheet_mode is on. Overrides target_pages for spreadsheets; omit to extract every sheet. Names are matched exactly (case-sensitive) — pass them as a list, e.g. ["Sheet 1", "My Sheet"].
    /// </summary>
    public sealed partial class ExtractV2ParametersSheetNames
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}