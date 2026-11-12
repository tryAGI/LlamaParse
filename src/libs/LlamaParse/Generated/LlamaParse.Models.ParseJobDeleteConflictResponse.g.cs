
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Body of the 409 returned when a parse job can't be deleted.
    /// </summary>
    public sealed partial class ParseJobDeleteConflictResponse
    {
        /// <summary>
        /// Why a parse job could not be deleted, and what to do about it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.ParseJobDeleteConflictDetail Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseJobDeleteConflictResponse" /> class.
        /// </summary>
        /// <param name="detail">
        /// Why a parse job could not be deleted, and what to do about it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParseJobDeleteConflictResponse(
            global::LlamaParse.ParseJobDeleteConflictDetail detail)
        {
            this.Detail = detail ?? throw new global::System.ArgumentNullException(nameof(detail));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseJobDeleteConflictResponse" /> class.
        /// </summary>
        public ParseJobDeleteConflictResponse()
        {
        }

    }
}