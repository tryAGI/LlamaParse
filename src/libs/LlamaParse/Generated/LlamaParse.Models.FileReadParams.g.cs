
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Read parsed content of a specific file.
    /// </summary>
    public sealed partial class FileReadParams
    {
        /// <summary>
        /// ID of the index the file belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IndexId { get; set; }

        /// <summary>
        /// ID of the file to read.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// Starting character offset.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Maximum number of characters to read from the offset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_length")]
        public int? MaxLength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileReadParams" /> class.
        /// </summary>
        /// <param name="indexId">
        /// ID of the index the file belongs to.
        /// </param>
        /// <param name="fileId">
        /// ID of the file to read.
        /// </param>
        /// <param name="offset">
        /// Starting character offset.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="maxLength">
        /// Maximum number of characters to read from the offset.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileReadParams(
            string indexId,
            string fileId,
            int? offset,
            int? maxLength)
        {
            this.IndexId = indexId ?? throw new global::System.ArgumentNullException(nameof(indexId));
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.Offset = offset;
            this.MaxLength = maxLength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileReadParams" /> class.
        /// </summary>
        public FileReadParams()
        {
        }

    }
}