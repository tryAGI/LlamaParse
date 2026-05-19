
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MongoStaticFilters
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parsed_directory_file_id")]
        public global::LlamaParse.FilterTypeStr? ParsedDirectoryFileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MongoStaticFilters" /> class.
        /// </summary>
        /// <param name="parsedDirectoryFileId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MongoStaticFilters(
            global::LlamaParse.FilterTypeStr? parsedDirectoryFileId)
        {
            this.ParsedDirectoryFileId = parsedDirectoryFileId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MongoStaticFilters" /> class.
        /// </summary>
        public MongoStaticFilters()
        {
        }

    }
}