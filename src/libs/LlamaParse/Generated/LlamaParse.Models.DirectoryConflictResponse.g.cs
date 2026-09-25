
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Body of the 409 returned when a directory create conflicts.
    /// </summary>
    public sealed partial class DirectoryConflictResponse
    {
        /// <summary>
        /// Why a directory create conflicted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.DirectoryConflictDetail Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryConflictResponse" /> class.
        /// </summary>
        /// <param name="detail">
        /// Why a directory create conflicted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DirectoryConflictResponse(
            global::LlamaParse.DirectoryConflictDetail detail)
        {
            this.Detail = detail ?? throw new global::System.ArgumentNullException(nameof(detail));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryConflictResponse" /> class.
        /// </summary>
        public DirectoryConflictResponse()
        {
        }

    }
}