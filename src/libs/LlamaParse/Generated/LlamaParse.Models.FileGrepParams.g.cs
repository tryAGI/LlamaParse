
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Grep within a specific file's parsed content.
    /// </summary>
    public sealed partial class FileGrepParams
    {
        /// <summary>
        /// ID of the index the file belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IndexId { get; set; }

        /// <summary>
        /// ID of the file to grep.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// Regex pattern to search for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Pattern { get; set; }

        /// <summary>
        /// Maximum number of matches to return.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Number of characters of context to include before and after the matched pattern in the content field of the response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_chars")]
        public int? ContextChars { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileGrepParams" /> class.
        /// </summary>
        /// <param name="indexId">
        /// ID of the index the file belongs to.
        /// </param>
        /// <param name="fileId">
        /// ID of the file to grep.
        /// </param>
        /// <param name="pattern">
        /// Regex pattern to search for.
        /// </param>
        /// <param name="limit">
        /// Maximum number of matches to return.
        /// </param>
        /// <param name="contextChars">
        /// Number of characters of context to include before and after the matched pattern in the content field of the response
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileGrepParams(
            string indexId,
            string fileId,
            string pattern,
            int? limit,
            int? contextChars)
        {
            this.IndexId = indexId ?? throw new global::System.ArgumentNullException(nameof(indexId));
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.Pattern = pattern ?? throw new global::System.ArgumentNullException(nameof(pattern));
            this.Limit = limit;
            this.ContextChars = contextChars;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileGrepParams" /> class.
        /// </summary>
        public FileGrepParams()
        {
        }

    }
}