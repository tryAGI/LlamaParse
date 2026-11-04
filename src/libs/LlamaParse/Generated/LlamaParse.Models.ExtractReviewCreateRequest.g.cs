
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Turn review on for an extract job.
    /// </summary>
    public sealed partial class ExtractReviewCreateRequest
    {
        /// <summary>
        /// Fields read below this confidence are flagged.<br/>
        /// Default Value: 0.7F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence_threshold")]
        public double? ConfidenceThreshold { get; set; }

        /// <summary>
        /// JSON Pointers of the fields the threshold applies to; empty means all.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields_in_scope")]
        public global::System.Collections.Generic.IList<string>? FieldsInScope { get; set; }

        /// <summary>
        /// JSON Pointers of fields flagged when empty; defaults to the schema's required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_fields")]
        public global::System.Collections.Generic.IList<string>? RequiredFields { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractReviewCreateRequest" /> class.
        /// </summary>
        /// <param name="confidenceThreshold">
        /// Fields read below this confidence are flagged.<br/>
        /// Default Value: 0.7F
        /// </param>
        /// <param name="fieldsInScope">
        /// JSON Pointers of the fields the threshold applies to; empty means all.
        /// </param>
        /// <param name="requiredFields">
        /// JSON Pointers of fields flagged when empty; defaults to the schema's required.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractReviewCreateRequest(
            double? confidenceThreshold,
            global::System.Collections.Generic.IList<string>? fieldsInScope,
            global::System.Collections.Generic.IList<string>? requiredFields)
        {
            this.ConfidenceThreshold = confidenceThreshold;
            this.FieldsInScope = fieldsInScope;
            this.RequiredFields = requiredFields;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractReviewCreateRequest" /> class.
        /// </summary>
        public ExtractReviewCreateRequest()
        {
        }

    }
}