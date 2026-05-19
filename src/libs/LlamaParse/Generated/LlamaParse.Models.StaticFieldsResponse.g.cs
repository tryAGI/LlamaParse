
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Built-in fields stored for every exported chunk.
    /// </summary>
    public sealed partial class StaticFieldsResponse
    {
        /// <summary>
        /// ID of the parsed file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parsed_directory_file_id")]
        public string? ParsedDirectoryFileId { get; set; }

        /// <summary>
        /// First page number covered by this chunk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_range_start")]
        public int? PageRangeStart { get; set; }

        /// <summary>
        /// Last page number covered by this chunk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_range_end")]
        public int? PageRangeEnd { get; set; }

        /// <summary>
        /// Start character offset of the chunk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_start_char")]
        public int? ChunkStartChar { get; set; }

        /// <summary>
        /// End character offset of the chunk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_end_char")]
        public int? ChunkEndChar { get; set; }

        /// <summary>
        /// Index of the chunk within the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_index")]
        public int? ChunkIndex { get; set; }

        /// <summary>
        /// Token count of the chunk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_token_count")]
        public int? ChunkTokenCount { get; set; }

        /// <summary>
        /// Attachments associated with the chunk
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachments")]
        public global::System.Collections.Generic.IList<global::LlamaParse.AttachmentRef>? Attachments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StaticFieldsResponse" /> class.
        /// </summary>
        /// <param name="parsedDirectoryFileId">
        /// ID of the parsed file.
        /// </param>
        /// <param name="pageRangeStart">
        /// First page number covered by this chunk.
        /// </param>
        /// <param name="pageRangeEnd">
        /// Last page number covered by this chunk.
        /// </param>
        /// <param name="chunkStartChar">
        /// Start character offset of the chunk.
        /// </param>
        /// <param name="chunkEndChar">
        /// End character offset of the chunk.
        /// </param>
        /// <param name="chunkIndex">
        /// Index of the chunk within the file.
        /// </param>
        /// <param name="chunkTokenCount">
        /// Token count of the chunk.
        /// </param>
        /// <param name="attachments">
        /// Attachments associated with the chunk
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StaticFieldsResponse(
            string? parsedDirectoryFileId,
            int? pageRangeStart,
            int? pageRangeEnd,
            int? chunkStartChar,
            int? chunkEndChar,
            int? chunkIndex,
            int? chunkTokenCount,
            global::System.Collections.Generic.IList<global::LlamaParse.AttachmentRef>? attachments)
        {
            this.ParsedDirectoryFileId = parsedDirectoryFileId;
            this.PageRangeStart = pageRangeStart;
            this.PageRangeEnd = pageRangeEnd;
            this.ChunkStartChar = chunkStartChar;
            this.ChunkEndChar = chunkEndChar;
            this.ChunkIndex = chunkIndex;
            this.ChunkTokenCount = chunkTokenCount;
            this.Attachments = attachments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StaticFieldsResponse" /> class.
        /// </summary>
        public StaticFieldsResponse()
        {
        }

    }
}