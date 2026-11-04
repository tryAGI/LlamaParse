
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// A field the review asks a person to check.
    /// </summary>
    public sealed partial class ExtractReviewFlag
    {
        /// <summary>
        /// JSON Pointer of the field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// below_threshold, or required_empty for a required field left empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LlamaParse.JsonConverters.ExtractReviewFlagReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.ExtractReviewFlagReason Reason { get; set; }

        /// <summary>
        /// The field's confidence; for a list, its least confident value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// Where in a list the least confident value is; null for a single value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cell")]
        public global::LlamaParse.ExtractReviewFlagCell? Cell { get; set; }

        /// <summary>
        /// Whether someone confirmed, corrected or cleared it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("handled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Handled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractReviewFlag" /> class.
        /// </summary>
        /// <param name="path">
        /// JSON Pointer of the field.
        /// </param>
        /// <param name="reason">
        /// below_threshold, or required_empty for a required field left empty.
        /// </param>
        /// <param name="handled">
        /// Whether someone confirmed, corrected or cleared it.
        /// </param>
        /// <param name="confidence">
        /// The field's confidence; for a list, its least confident value.
        /// </param>
        /// <param name="cell">
        /// Where in a list the least confident value is; null for a single value.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractReviewFlag(
            string path,
            global::LlamaParse.ExtractReviewFlagReason reason,
            bool handled,
            double? confidence,
            global::LlamaParse.ExtractReviewFlagCell? cell)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Reason = reason;
            this.Confidence = confidence;
            this.Cell = cell;
            this.Handled = handled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractReviewFlag" /> class.
        /// </summary>
        public ExtractReviewFlag()
        {
        }

    }
}