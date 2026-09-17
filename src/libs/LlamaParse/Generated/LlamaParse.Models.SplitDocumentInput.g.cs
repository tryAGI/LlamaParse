
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Document input specification for beta API.
    /// </summary>
    public sealed partial class SplitDocumentInput
    {
        /// <summary>
        /// The beta `POST /api/v1/beta/split/jobs` endpoint accepts only `file_id`. To use a Parse job as input, call `POST /api/v1/split/jobs` instead, where you can pass the Parse job ID as `file_input`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Document identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitDocumentInput" /> class.
        /// </summary>
        /// <param name="type">
        /// The beta `POST /api/v1/beta/split/jobs` endpoint accepts only `file_id`. To use a Parse job as input, call `POST /api/v1/split/jobs` instead, where you can pass the Parse job ID as `file_input`.
        /// </param>
        /// <param name="value">
        /// Document identifier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SplitDocumentInput(
            string type,
            string value)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitDocumentInput" /> class.
        /// </summary>
        public SplitDocumentInput()
        {
        }

    }
}