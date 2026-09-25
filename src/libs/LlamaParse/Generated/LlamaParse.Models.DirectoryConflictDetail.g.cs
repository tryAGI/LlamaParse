
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Why a directory create conflicted.
    /// </summary>
    public sealed partial class DirectoryConflictDetail
    {
        /// <summary>
        /// What conflicted and how to resolve it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The directory the connector subscription already syncs into. Null for a name conflict.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directory_id")]
        public string? DirectoryId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryConflictDetail" /> class.
        /// </summary>
        /// <param name="message">
        /// What conflicted and how to resolve it.
        /// </param>
        /// <param name="directoryId">
        /// The directory the connector subscription already syncs into. Null for a name conflict.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DirectoryConflictDetail(
            string message,
            string? directoryId)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.DirectoryId = directoryId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryConflictDetail" /> class.
        /// </summary>
        public DirectoryConflictDetail()
        {
        }

    }
}