
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// File search results.
    /// </summary>
    public sealed partial class FileSearchApiResponse
    {
        /// <summary>
        /// Matching files with names.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LlamaParse.FileSearchApiFileEntry> Files { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSearchApiResponse" /> class.
        /// </summary>
        /// <param name="files">
        /// Matching files with names.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileSearchApiResponse(
            global::System.Collections.Generic.IList<global::LlamaParse.FileSearchApiFileEntry> files)
        {
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSearchApiResponse" /> class.
        /// </summary>
        public FileSearchApiResponse()
        {
        }

    }
}