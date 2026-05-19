
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// A file returned by search.
    /// </summary>
    public sealed partial class FileSearchApiFileEntry
    {
        /// <summary>
        /// ID of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// Display name of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSearchApiFileEntry" /> class.
        /// </summary>
        /// <param name="fileId">
        /// ID of the file.
        /// </param>
        /// <param name="fileName">
        /// Display name of the file.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileSearchApiFileEntry(
            string fileId,
            string fileName)
        {
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.FileName = fileName ?? throw new global::System.ArgumentNullException(nameof(fileName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSearchApiFileEntry" /> class.
        /// </summary>
        public FileSearchApiFileEntry()
        {
        }

    }
}