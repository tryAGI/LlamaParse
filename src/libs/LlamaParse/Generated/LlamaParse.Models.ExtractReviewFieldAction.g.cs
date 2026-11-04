
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// The latest thing a person did to one field.
    /// </summary>
    public sealed partial class ExtractReviewFieldAction
    {
        /// <summary>
        /// confirm, correct or clear.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LlamaParse.JsonConverters.ExtractReviewFieldActionActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.ExtractReviewFieldActionAction Action { get; set; }

        /// <summary>
        /// The corrected value, for `correct`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public object? Value { get; set; }

        /// <summary>
        /// ID of the user who acted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ActorId { get; set; }

        /// <summary>
        /// When they acted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime At { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractReviewFieldAction" /> class.
        /// </summary>
        /// <param name="action">
        /// confirm, correct or clear.
        /// </param>
        /// <param name="actorId">
        /// ID of the user who acted.
        /// </param>
        /// <param name="at">
        /// When they acted.
        /// </param>
        /// <param name="value">
        /// The corrected value, for `correct`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractReviewFieldAction(
            global::LlamaParse.ExtractReviewFieldActionAction action,
            string actorId,
            global::System.DateTime at,
            object? value)
        {
            this.Action = action;
            this.Value = value;
            this.ActorId = actorId ?? throw new global::System.ArgumentNullException(nameof(actorId));
            this.At = at;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractReviewFieldAction" /> class.
        /// </summary>
        public ExtractReviewFieldAction()
        {
        }

    }
}