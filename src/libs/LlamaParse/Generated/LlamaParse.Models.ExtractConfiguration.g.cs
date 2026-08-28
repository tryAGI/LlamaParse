
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Extract configuration combining parse and extract settings.
    /// </summary>
    public sealed partial class ExtractConfiguration
    {
        /// <summary>
        /// Comma-separated page numbers or ranges to process (1-based). Omit to process all pages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_pages")]
        public string? TargetPages { get; set; }

        /// <summary>
        /// Maximum number of pages to process. Omit for no limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_pages")]
        public int? MaxPages { get; set; }

        /// <summary>
        /// Extract tier: cost_effective (5 credits/page), agentic (15 credits/page), agentic_plus (50 credits/page), or turbo (35 credits/page, experimental)<br/>
        /// Default Value: cost_effective
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LlamaParse.JsonConverters.ExtractConfigurationTierJsonConverter))]
        public global::LlamaParse.ExtractConfigurationTier? Tier { get; set; }

        /// <summary>
        /// Use 'latest' for the latest release for the selected tier or a date string (YYYY-MM-DD format) to pin to the nearest release at or before that date. Job responses always report the concrete resolved version the job runs, fixed at job creation; saved configurations keep the value as provided.<br/>
        /// Default Value: latest
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Disable reuse and storage of Extract results<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_cache")]
        public bool? DisableCache { get; set; }

        /// <summary>
        /// JSON Schema defining the fields to extract. Validate with the /schema/validate endpoint first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object DataSchema { get; set; }

        /// <summary>
        /// Granularity of extraction: per_doc returns one object per document, per_page returns one object per page, per_table_row returns one object per table row<br/>
        /// Default Value: per_doc
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extraction_target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LlamaParse.JsonConverters.ExtractConfigurationExtractionTargetJsonConverter))]
        public global::LlamaParse.ExtractConfigurationExtractionTarget? ExtractionTarget { get; set; }

        /// <summary>
        /// Custom system prompt to guide extraction behavior
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_prompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// Include citations in results. Returned under `extract_metadata` (auto-included when set). Text-level on `turbo` (no bounding boxes).<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cite_sources")]
        public bool? CiteSources { get; set; }

        /// <summary>
        /// Include confidence scores in results. Returned under `extract_metadata` (auto-included when set).<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence_scores")]
        public bool? ConfidenceScores { get; set; }

        /// <summary>
        /// Beta. When true, extract structured data directly from a spreadsheet workbook (.xlsx/.xls/.csv) — the agent reads cells straight from the workbook instead of the standard document path. Off by default (spreadsheets keep the standard path). Requires the agentic_plus tier. Billed on the standard per-page extract rate, against a page count derived from workbook size. Citations and confidence scores are not available in this mode.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spreadsheet_mode")]
        public bool? SpreadsheetMode { get; set; }

        /// <summary>
        /// Optional worksheet names to extract when spreadsheet_mode is on. Overrides target_pages for spreadsheets; omit to extract every sheet. Names are matched exactly (case-sensitive) — pass them as a list, e.g. ["Sheet 1", "My Sheet"].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sheet_names")]
        public global::System.Collections.Generic.IList<string>? SheetNames { get; set; }

        /// <summary>
        /// Parse tier to use before extraction. Defaults to the extract tier if not specified. Turbo extract does not support parse configuration or produce a parse output; use another tier if your workflow requires parsed text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parse_tier")]
        public string? ParseTier { get; set; }

        /// <summary>
        /// Saved parse configuration ID to control how the document is parsed before extraction. Turbo extract does not support parse configuration or produce a parse output; use another tier if your workflow requires parsed text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parse_config_id")]
        public string? ParseConfigId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractConfiguration" /> class.
        /// </summary>
        /// <param name="dataSchema">
        /// JSON Schema defining the fields to extract. Validate with the /schema/validate endpoint first.
        /// </param>
        /// <param name="targetPages">
        /// Comma-separated page numbers or ranges to process (1-based). Omit to process all pages.
        /// </param>
        /// <param name="maxPages">
        /// Maximum number of pages to process. Omit for no limit.
        /// </param>
        /// <param name="tier">
        /// Extract tier: cost_effective (5 credits/page), agentic (15 credits/page), agentic_plus (50 credits/page), or turbo (35 credits/page, experimental)<br/>
        /// Default Value: cost_effective
        /// </param>
        /// <param name="version">
        /// Use 'latest' for the latest release for the selected tier or a date string (YYYY-MM-DD format) to pin to the nearest release at or before that date. Job responses always report the concrete resolved version the job runs, fixed at job creation; saved configurations keep the value as provided.<br/>
        /// Default Value: latest
        /// </param>
        /// <param name="disableCache">
        /// Disable reuse and storage of Extract results<br/>
        /// Default Value: false
        /// </param>
        /// <param name="extractionTarget">
        /// Granularity of extraction: per_doc returns one object per document, per_page returns one object per page, per_table_row returns one object per table row<br/>
        /// Default Value: per_doc
        /// </param>
        /// <param name="systemPrompt">
        /// Custom system prompt to guide extraction behavior
        /// </param>
        /// <param name="citeSources">
        /// Include citations in results. Returned under `extract_metadata` (auto-included when set). Text-level on `turbo` (no bounding boxes).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="confidenceScores">
        /// Include confidence scores in results. Returned under `extract_metadata` (auto-included when set).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="spreadsheetMode">
        /// Beta. When true, extract structured data directly from a spreadsheet workbook (.xlsx/.xls/.csv) — the agent reads cells straight from the workbook instead of the standard document path. Off by default (spreadsheets keep the standard path). Requires the agentic_plus tier. Billed on the standard per-page extract rate, against a page count derived from workbook size. Citations and confidence scores are not available in this mode.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="sheetNames">
        /// Optional worksheet names to extract when spreadsheet_mode is on. Overrides target_pages for spreadsheets; omit to extract every sheet. Names are matched exactly (case-sensitive) — pass them as a list, e.g. ["Sheet 1", "My Sheet"].
        /// </param>
        /// <param name="parseTier">
        /// Parse tier to use before extraction. Defaults to the extract tier if not specified. Turbo extract does not support parse configuration or produce a parse output; use another tier if your workflow requires parsed text.
        /// </param>
        /// <param name="parseConfigId">
        /// Saved parse configuration ID to control how the document is parsed before extraction. Turbo extract does not support parse configuration or produce a parse output; use another tier if your workflow requires parsed text.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractConfiguration(
            object dataSchema,
            string? targetPages,
            int? maxPages,
            global::LlamaParse.ExtractConfigurationTier? tier,
            string? version,
            bool? disableCache,
            global::LlamaParse.ExtractConfigurationExtractionTarget? extractionTarget,
            string? systemPrompt,
            bool? citeSources,
            bool? confidenceScores,
            bool? spreadsheetMode,
            global::System.Collections.Generic.IList<string>? sheetNames,
            string? parseTier,
            string? parseConfigId)
        {
            this.TargetPages = targetPages;
            this.MaxPages = maxPages;
            this.Tier = tier;
            this.Version = version;
            this.DisableCache = disableCache;
            this.DataSchema = dataSchema ?? throw new global::System.ArgumentNullException(nameof(dataSchema));
            this.ExtractionTarget = extractionTarget;
            this.SystemPrompt = systemPrompt;
            this.CiteSources = citeSources;
            this.ConfidenceScores = confidenceScores;
            this.SpreadsheetMode = spreadsheetMode;
            this.SheetNames = sheetNames;
            this.ParseTier = parseTier;
            this.ParseConfigId = parseConfigId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractConfiguration" /> class.
        /// </summary>
        public ExtractConfiguration()
        {
        }

    }
}