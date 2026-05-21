
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Search for files by name.
    /// </summary>
    public sealed partial class FileFindParams
    {
        /// <summary>
        /// The maximum number of items to return. The service may return fewer than this value. If unspecified, a default page size will be used. The maximum value is typically 1000; values above this will be coerced to the maximum.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int? PageSize { get; set; }

        /// <summary>
        /// A page token, received from a previous list call. Provide this to retrieve the subsequent page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_token")]
        public string? PageToken { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileFindParams" /> class.
        /// </summary>
        /// <param name="indexId">
        /// ID of the index to search within.
        /// </param>
        /// <param name="pageSize">
        /// The maximum number of items to return. The service may return fewer than this value. If unspecified, a default page size will be used. The maximum value is typically 1000; values above this will be coerced to the maximum.
        /// </param>
        /// <param name="pageToken">
        /// A page token, received from a previous list call. Provide this to retrieve the subsequent page.
        /// </param>
        /// <param name="fileName">
        /// Exact file name to match.
        /// </param>
        /// <param name="fileNameContains">
        /// Substring match on file name (case-insensitive).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileFindParams(
            string indexId,
            int? pageSize,
            string? pageToken,
            string? fileName,
            string? fileNameContains)
        {
            this.PageSize = pageSize;
            this.PageToken = pageToken;
            this.IndexId = indexId ?? throw new global::System.ArgumentNullException(nameof(indexId));
            this.FileName = fileName;
            this.FileNameContains = fileNameContains;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileFindParams" /> class.
        /// </summary>
        public FileFindParams()
        {
        }

    }
}