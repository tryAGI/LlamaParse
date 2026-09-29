
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Presentation (PowerPoint, Keynote, ODP) parsing options.
    /// </summary>
    public sealed partial class LlamaParsePresentationOptions
    {
        /// <summary>
        /// Include hidden PPTX slides in the output. Omitted or false skips hidden slides.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_hidden_slides")]
        public bool? IncludeHiddenSlides { get; set; }

        /// <summary>
        /// Extract content positioned outside the visible slide area. Some presentations have hidden notes or content that extends beyond slide boundaries
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("out_of_bounds_content")]
        public bool? OutOfBoundsContent { get; set; }

        /// <summary>
        /// Skip extraction of embedded chart data tables. When true, only the visual representation of charts is captured, not the underlying data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip_embedded_data")]
        public bool? SkipEmbeddedData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlamaParsePresentationOptions" /> class.
        /// </summary>
        /// <param name="includeHiddenSlides">
        /// Include hidden PPTX slides in the output. Omitted or false skips hidden slides.
        /// </param>
        /// <param name="outOfBoundsContent">
        /// Extract content positioned outside the visible slide area. Some presentations have hidden notes or content that extends beyond slide boundaries
        /// </param>
        /// <param name="skipEmbeddedData">
        /// Skip extraction of embedded chart data tables. When true, only the visual representation of charts is captured, not the underlying data
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LlamaParsePresentationOptions(
            bool? includeHiddenSlides,
            bool? outOfBoundsContent,
            bool? skipEmbeddedData)
        {
            this.IncludeHiddenSlides = includeHiddenSlides;
            this.OutOfBoundsContent = outOfBoundsContent;
            this.SkipEmbeddedData = skipEmbeddedData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlamaParsePresentationOptions" /> class.
        /// </summary>
        public LlamaParsePresentationOptions()
        {
        }

    }
}