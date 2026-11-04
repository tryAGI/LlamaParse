
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// One change to one field.
    /// </summary>
    public sealed partial class ExtractReviewFieldChange
    {
        /// <summary>
        /// JSON Pointer of the field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// confirm, correct to `value`, clear, restore the model's value, or undo.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("change")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LlamaParse.JsonConverters.ExtractReviewFieldChangeChangeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.ExtractReviewFieldChangeChange Change { get; set; }

        /// <summary>
        /// The corrected value, for `correct`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public object? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractReviewFieldChange" /> class.
        /// </summary>
        /// <param name="path">
        /// JSON Pointer of the field.
        /// </param>
        /// <param name="change">
        /// confirm, correct to `value`, clear, restore the model's value, or undo.
        /// </param>
        /// <param name="value">
        /// The corrected value, for `correct`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractReviewFieldChange(
            string path,
            global::LlamaParse.ExtractReviewFieldChangeChange change,
            object? value)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Change = change;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractReviewFieldChange" /> class.
        /// </summary>
        public ExtractReviewFieldChange()
        {
        }

    }
}