
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Typed parameters for an *extract v2* product configuration.
    /// </summary>
    public sealed partial class ExtractV2Parameters
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
        /// Use 'max' for additional processing effort on agentic_plus. Bills by model usage with the page charge as a minimum. Omit or set to null for the tier's default behavior.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        public string? Effort { get; set; }

        /// <summary>
        /// Extract tier: cost_effective (5 credits/page), agentic (15 credits/page), agentic_plus (50 credits/page), or turbo (35 credits/page)<br/>
        /// Default Value: cost_effective
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LlamaParse.JsonConverters.ExtractV2ParametersTierJsonConverter))]
        public global::LlamaParse.ExtractV2ParametersTier? Tier { get; set; }

        /// <summary>
        /// Extract version name, such as '2.5'. Use 'latest' for the newest compatible release for the selected tier. Dates (YYYY-MM-DD) are also supported, which will use the latest version on or before the specified date.<br/>
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
        /// Deprecated. Applies only to Agentic and Cost Effective versions 2.0 or earlier. Granularity of extraction: per_doc returns one object per document, per_page returns one object per page, per_table_row returns one object per table row. Agentic Plus supports per_doc only.<br/>
        /// Default Value: per_doc
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extraction_target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LlamaParse.JsonConverters.ExtractV2ParametersExtractionTargetJsonConverter))]
        public global::LlamaParse.ExtractV2ParametersExtractionTarget? ExtractionTarget { get; set; }

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
        /// More precise citation bounding boxes. Set to false for faster extraction with less precise boxes.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("advanced_citations")]
        public bool? AdvancedCitations { get; set; }

        /// <summary>
        /// Extract structured data directly from spreadsheet cells (.xlsx/.xls/.csv). Billed at the standard per-page Extract rate, with page count derived from workbook size.<br/>
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
        public global::LlamaParse.ExtractV2ParametersParseTier? ParseTier { get; set; }

        /// <summary>
        /// Saved parse configuration ID to control how the document is parsed before extraction. Turbo extract does not support parse configuration or produce a parse output; use another tier if your workflow requires parsed text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parse_config_id")]
        public string? ParseConfigId { get; set; }

        /// <summary>
        /// Product type.
        /// </summary>
        /// <default>"extract_v2"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("product_type")]
        public string ProductType { get; set; } = "extract_v2";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractV2Parameters" /> class.
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
        /// <param name="effort">
        /// Use 'max' for additional processing effort on agentic_plus. Bills by model usage with the page charge as a minimum. Omit or set to null for the tier's default behavior.
        /// </param>
        /// <param name="tier">
        /// Extract tier: cost_effective (5 credits/page), agentic (15 credits/page), agentic_plus (50 credits/page), or turbo (35 credits/page)<br/>
        /// Default Value: cost_effective
        /// </param>
        /// <param name="version">
        /// Extract version name, such as '2.5'. Use 'latest' for the newest compatible release for the selected tier. Dates (YYYY-MM-DD) are also supported, which will use the latest version on or before the specified date.<br/>
        /// Default Value: latest
        /// </param>
        /// <param name="disableCache">
        /// Disable reuse and storage of Extract results<br/>
        /// Default Value: false
        /// </param>
        /// <param name="extractionTarget">
        /// Deprecated. Applies only to Agentic and Cost Effective versions 2.0 or earlier. Granularity of extraction: per_doc returns one object per document, per_page returns one object per page, per_table_row returns one object per table row. Agentic Plus supports per_doc only.<br/>
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
        /// <param name="advancedCitations">
        /// More precise citation bounding boxes. Set to false for faster extraction with less precise boxes.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="spreadsheetMode">
        /// Extract structured data directly from spreadsheet cells (.xlsx/.xls/.csv). Billed at the standard per-page Extract rate, with page count derived from workbook size.<br/>
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
        /// <param name="productType">
        /// Product type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractV2Parameters(
            object dataSchema,
            string? targetPages,
            int? maxPages,
            string? effort,
            global::LlamaParse.ExtractV2ParametersTier? tier,
            string? version,
            bool? disableCache,
            global::LlamaParse.ExtractV2ParametersExtractionTarget? extractionTarget,
            string? systemPrompt,
            bool? citeSources,
            bool? confidenceScores,
            bool? advancedCitations,
            bool? spreadsheetMode,
            global::System.Collections.Generic.IList<string>? sheetNames,
            global::LlamaParse.ExtractV2ParametersParseTier? parseTier,
            string? parseConfigId,
            string productType = "extract_v2")
        {
            this.TargetPages = targetPages;
            this.MaxPages = maxPages;
            this.Effort = effort;
            this.Tier = tier;
            this.Version = version;
            this.DisableCache = disableCache;
            this.DataSchema = dataSchema ?? throw new global::System.ArgumentNullException(nameof(dataSchema));
            this.ExtractionTarget = extractionTarget;
            this.SystemPrompt = systemPrompt;
            this.CiteSources = citeSources;
            this.ConfidenceScores = confidenceScores;
            this.AdvancedCitations = advancedCitations;
            this.SpreadsheetMode = spreadsheetMode;
            this.SheetNames = sheetNames;
            this.ParseTier = parseTier;
            this.ParseConfigId = parseConfigId;
            this.ProductType = productType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractV2Parameters" /> class.
        /// </summary>
        public ExtractV2Parameters()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ExtractV2Parameters"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ExtractV2Parameters FromDataSchema(object dataSchema)
        {
            return new ExtractV2Parameters
            {
                DataSchema = dataSchema,
            };
        }

    }
}