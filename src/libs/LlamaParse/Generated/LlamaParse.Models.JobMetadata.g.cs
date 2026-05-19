
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JobMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_input_tokens")]
        public int? TotalInputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_output_tokens")]
        public int? TotalOutputTokens { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turns")]
        public int? Turns { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        public double? DurationMs { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_error")]
        public bool? IsError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("export_config_ids")]
        public global::System.Collections.Generic.IList<string>? ExportConfigIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobMetadata" /> class.
        /// </summary>
        /// <param name="totalInputTokens"></param>
        /// <param name="totalOutputTokens"></param>
        /// <param name="turns">
        /// Default Value: 1
        /// </param>
        /// <param name="durationMs">
        /// Default Value: 0F
        /// </param>
        /// <param name="isError">
        /// Default Value: false
        /// </param>
        /// <param name="error"></param>
        /// <param name="exportConfigIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JobMetadata(
            int? totalInputTokens,
            int? totalOutputTokens,
            int? turns,
            double? durationMs,
            bool? isError,
            string? error,
            global::System.Collections.Generic.IList<string>? exportConfigIds)
        {
            this.TotalInputTokens = totalInputTokens;
            this.TotalOutputTokens = totalOutputTokens;
            this.Turns = turns;
            this.DurationMs = durationMs;
            this.IsError = isError;
            this.Error = error;
            this.ExportConfigIds = exportConfigIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobMetadata" /> class.
        /// </summary>
        public JobMetadata()
        {
        }

    }
}