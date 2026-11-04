
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// What a `created` entry records: where review was turned on, and its settings.
    /// </summary>
    public sealed partial class ExtractReviewCreatedDetail
    {
        /// <summary>
        /// Turned on as the job ran, from History, by a first edit, or by the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LlamaParse.JsonConverters.ExtractReviewCreatedDetailOriginJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.ExtractReviewCreatedDetailOrigin Origin { get; set; }

        /// <summary>
        /// Fields read below this confidence are flagged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence_threshold")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ConfidenceThreshold { get; set; }

        /// <summary>
        /// JSON Pointers of the fields the threshold applies to; empty means all.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields_in_scope")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> FieldsInScope { get; set; }

        /// <summary>
        /// JSON Pointers of fields flagged when empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_fields")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> RequiredFields { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractReviewCreatedDetail" /> class.
        /// </summary>
        /// <param name="origin">
        /// Turned on as the job ran, from History, by a first edit, or by the API.
        /// </param>
        /// <param name="confidenceThreshold">
        /// Fields read below this confidence are flagged.
        /// </param>
        /// <param name="fieldsInScope">
        /// JSON Pointers of the fields the threshold applies to; empty means all.
        /// </param>
        /// <param name="requiredFields">
        /// JSON Pointers of fields flagged when empty.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractReviewCreatedDetail(
            global::LlamaParse.ExtractReviewCreatedDetailOrigin origin,
            double confidenceThreshold,
            global::System.Collections.Generic.IList<string> fieldsInScope,
            global::System.Collections.Generic.IList<string> requiredFields)
        {
            this.Origin = origin;
            this.ConfidenceThreshold = confidenceThreshold;
            this.FieldsInScope = fieldsInScope ?? throw new global::System.ArgumentNullException(nameof(fieldsInScope));
            this.RequiredFields = requiredFields ?? throw new global::System.ArgumentNullException(nameof(requiredFields));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractReviewCreatedDetail" /> class.
        /// </summary>
        public ExtractReviewCreatedDetail()
        {
        }

    }
}