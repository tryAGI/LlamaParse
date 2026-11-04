
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// One entry in a review's history.
    /// </summary>
    public sealed partial class ExtractReviewEvent
    {
        /// <summary>
        /// Unique identifier of the entry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// What happened.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LlamaParse.JsonConverters.ExtractReviewEventKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.ExtractReviewEventKind Kind { get; set; }

        /// <summary>
        /// JSON Pointer of the field it changed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// The field's value before the change.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_before")]
        public object? ValueBefore { get; set; }

        /// <summary>
        /// The field's value after the change.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_after")]
        public object? ValueAfter { get; set; }

        /// <summary>
        /// The settings for `created`, the reason for `rejected`, and the fields for `flags_signed_off`; null for the rest.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.ExtractReviewCreatedDetail, global::LlamaParse.ExtractReviewRejectedDetail, global::LlamaParse.ExtractReviewSignedOffDetail>))]
        public global::LlamaParse.AnyOf<global::LlamaParse.ExtractReviewCreatedDetail, global::LlamaParse.ExtractReviewRejectedDetail, global::LlamaParse.ExtractReviewSignedOffDetail>? Detail { get; set; }

        /// <summary>
        /// ID of the user who acted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ActorId { get; set; }

        /// <summary>
        /// When it happened.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractReviewEvent" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the entry.
        /// </param>
        /// <param name="kind">
        /// What happened.
        /// </param>
        /// <param name="actorId">
        /// ID of the user who acted.
        /// </param>
        /// <param name="createdAt">
        /// When it happened.
        /// </param>
        /// <param name="path">
        /// JSON Pointer of the field it changed.
        /// </param>
        /// <param name="valueBefore">
        /// The field's value before the change.
        /// </param>
        /// <param name="valueAfter">
        /// The field's value after the change.
        /// </param>
        /// <param name="detail">
        /// The settings for `created`, the reason for `rejected`, and the fields for `flags_signed_off`; null for the rest.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractReviewEvent(
            string id,
            global::LlamaParse.ExtractReviewEventKind kind,
            string actorId,
            global::System.DateTime createdAt,
            string? path,
            object? valueBefore,
            object? valueAfter,
            global::LlamaParse.AnyOf<global::LlamaParse.ExtractReviewCreatedDetail, global::LlamaParse.ExtractReviewRejectedDetail, global::LlamaParse.ExtractReviewSignedOffDetail>? detail)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Kind = kind;
            this.Path = path;
            this.ValueBefore = valueBefore;
            this.ValueAfter = valueAfter;
            this.Detail = detail;
            this.ActorId = actorId ?? throw new global::System.ArgumentNullException(nameof(actorId));
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractReviewEvent" /> class.
        /// </summary>
        public ExtractReviewEvent()
        {
        }

    }
}