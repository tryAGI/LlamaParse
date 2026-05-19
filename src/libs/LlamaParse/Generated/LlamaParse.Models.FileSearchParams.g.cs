
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Search for files by name.
    /// </summary>
    public sealed partial class FileSearchParams
    {
        /// <summary>
        /// ID of the index to search within.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IndexId { get; set; }

        /// <summary>
        /// Exact file name to match.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_name")]
        public string? FileName { get; set; }

        /// <summary>
        /// Substring match on file name (case-insensitive).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_name_contains")]
        public string? FileNameContains { get; set; }

        /// <summary>
        /// Maximum number of files to return.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSearchParams" /> class.
        /// </summary>
        /// <param name="indexId">
        /// ID of the index to search within.
        /// </param>
        /// <param name="fileName">
        /// Exact file name to match.
        /// </param>
        /// <param name="fileNameContains">
        /// Substring match on file name (case-insensitive).
        /// </param>
        /// <param name="limit">
        /// Maximum number of files to return.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileSearchParams(
            string indexId,
            string? fileName,
            string? fileNameContains,
            int? limit)
        {
            this.IndexId = indexId ?? throw new global::System.ArgumentNullException(nameof(indexId));
            this.FileName = fileName;
            this.FileNameContains = fileNameContains;
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSearchParams" /> class.
        /// </summary>
        public FileSearchParams()
        {
        }

    }
}