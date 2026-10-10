
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Rendered pixel size of a page — the coordinate space region bboxes use,<br/>
    /// so the UI can scale the suspect-region overlay onto the displayed page.
    /// </summary>
    public sealed partial class VerifyPageDimension
    {
        /// <summary>
        /// 0-based page index (0 for standalone images)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Page { get; set; }

        /// <summary>
        /// Rendered page width in pixels
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Width { get; set; }

        /// <summary>
        /// Rendered page height in pixels
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Height { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyPageDimension" /> class.
        /// </summary>
        /// <param name="page">
        /// 0-based page index (0 for standalone images)
        /// </param>
        /// <param name="width">
        /// Rendered page width in pixels
        /// </param>
        /// <param name="height">
        /// Rendered page height in pixels
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VerifyPageDimension(
            int page,
            int width,
            int height)
        {
            this.Page = page;
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyPageDimension" /> class.
        /// </summary>
        public VerifyPageDimension()
        {
        }

    }
}