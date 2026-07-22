
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Configuration for spreadsheet parsing and region extraction
    /// </summary>
    public sealed partial class SpreadsheetParsingConfig
    {
        /// <summary>
        /// Spreadsheet extraction tier. `cost_effective` uses the rule-based/ML-only pipeline; `agentic` uses the full pipeline.<br/>
        /// Default Value: agentic
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LlamaParse.JsonConverters.SpreadsheetParsingConfigTierJsonConverter))]
        public global::LlamaParse.SpreadsheetParsingConfigTier? Tier { get; set; }

        /// <summary>
        /// The names of the sheets to extract regions from. If empty, all sheets will be processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sheet_names")]
        public global::System.Collections.Generic.IList<string>? SheetNames { get; set; }

        /// <summary>
        /// Whether to include hidden cells when extracting regions from the spreadsheet.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_hidden_cells")]
        public bool? IncludeHiddenCells { get; set; }

        /// <summary>
        /// A1 notation of the range to extract a single region from. If None, the entire sheet is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extraction_range")]
        public string? ExtractionRange { get; set; }

        /// <summary>
        /// Deprecated: controlled by `tier`. Whether to generate additional metadata (title, description) for each extracted region. Honored only on `agentic`.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generate_additional_metadata")]
        public bool? GenerateAdditionalMetadata { get; set; }

        /// <summary>
        /// Deprecated: controlled by `tier`. Enables experimental processing. Honored only on `agentic`.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_experimental_processing")]
        public bool? UseExperimentalProcessing { get; set; }

        /// <summary>
        /// Return a flattened dataframe when a detected table is recognized as hierarchical.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flatten_hierarchical_tables")]
        public bool? FlattenHierarchicalTables { get; set; }

        /// <summary>
        /// Deprecated: controlled by `tier`. Influences how likely similar-looking regions are merged into a single table. Honored only on `agentic`.<br/>
        /// Default Value: strong
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table_merge_sensitivity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LlamaParse.JsonConverters.SpreadsheetParsingConfigTableMergeSensitivityJsonConverter))]
        public global::LlamaParse.SpreadsheetParsingConfigTableMergeSensitivity? TableMergeSensitivity { get; set; }

        /// <summary>
        /// Deprecated: controlled by `tier`. Optional specialization mode for domain-specific extraction. Supported values: 'financial-standard', 'financial-enhanced', 'financial-precise'. Default None uses the general-purpose pipeline. Honored only on `agentic`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("specialization")]
        public string? Specialization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpreadsheetParsingConfig" /> class.
        /// </summary>
        /// <param name="tier">
        /// Spreadsheet extraction tier. `cost_effective` uses the rule-based/ML-only pipeline; `agentic` uses the full pipeline.<br/>
        /// Default Value: agentic
        /// </param>
        /// <param name="sheetNames">
        /// The names of the sheets to extract regions from. If empty, all sheets will be processed.
        /// </param>
        /// <param name="includeHiddenCells">
        /// Whether to include hidden cells when extracting regions from the spreadsheet.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="extractionRange">
        /// A1 notation of the range to extract a single region from. If None, the entire sheet is used.
        /// </param>
        /// <param name="generateAdditionalMetadata">
        /// Deprecated: controlled by `tier`. Whether to generate additional metadata (title, description) for each extracted region. Honored only on `agentic`.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="useExperimentalProcessing">
        /// Deprecated: controlled by `tier`. Enables experimental processing. Honored only on `agentic`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="flattenHierarchicalTables">
        /// Return a flattened dataframe when a detected table is recognized as hierarchical.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="tableMergeSensitivity">
        /// Deprecated: controlled by `tier`. Influences how likely similar-looking regions are merged into a single table. Honored only on `agentic`.<br/>
        /// Default Value: strong
        /// </param>
        /// <param name="specialization">
        /// Deprecated: controlled by `tier`. Optional specialization mode for domain-specific extraction. Supported values: 'financial-standard', 'financial-enhanced', 'financial-precise'. Default None uses the general-purpose pipeline. Honored only on `agentic`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpreadsheetParsingConfig(
            global::LlamaParse.SpreadsheetParsingConfigTier? tier,
            global::System.Collections.Generic.IList<string>? sheetNames,
            bool? includeHiddenCells,
            string? extractionRange,
            bool? generateAdditionalMetadata,
            bool? useExperimentalProcessing,
            bool? flattenHierarchicalTables,
            global::LlamaParse.SpreadsheetParsingConfigTableMergeSensitivity? tableMergeSensitivity,
            string? specialization)
        {
            this.Tier = tier;
            this.SheetNames = sheetNames;
            this.IncludeHiddenCells = includeHiddenCells;
            this.ExtractionRange = extractionRange;
            this.GenerateAdditionalMetadata = generateAdditionalMetadata;
            this.UseExperimentalProcessing = useExperimentalProcessing;
            this.FlattenHierarchicalTables = flattenHierarchicalTables;
            this.TableMergeSensitivity = tableMergeSensitivity;
            this.Specialization = specialization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpreadsheetParsingConfig" /> class.
        /// </summary>
        public SpreadsheetParsingConfig()
        {
        }

    }
}