
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Create a batch over a directory.<br/>
    /// Example:<br/>
    ///     {<br/>
    ///         "source_directory_id": "dir-aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeeee",<br/>
    ///         "config": {<br/>
    ///             "job": {<br/>
    ///                 "type": "parse_v2",<br/>
    ///                 "configuration_id": "cfg-PARSE_AGENTIC"<br/>
    ///             }<br/>
    ///         },<br/>
    ///     }<br/>
    /// The source is always a directory. Callers upload or attach files to the<br/>
    /// directory first, then this API maps each source directory file to an<br/>
    /// output job such as a parse job ID.
    /// </summary>
    public sealed partial class BatchCreateRequest
    {
        /// <summary>
        /// Directory whose files should be processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_directory_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceDirectoryId { get; set; }

        /// <summary>
        /// Batch configuration snapshot to apply to this source directory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.BatchConfiguration Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchCreateRequest" /> class.
        /// </summary>
        /// <param name="sourceDirectoryId">
        /// Directory whose files should be processed.
        /// </param>
        /// <param name="config">
        /// Batch configuration snapshot to apply to this source directory.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchCreateRequest(
            string sourceDirectoryId,
            global::LlamaParse.BatchConfiguration config)
        {
            this.SourceDirectoryId = sourceDirectoryId ?? throw new global::System.ArgumentNullException(nameof(sourceDirectoryId));
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchCreateRequest" /> class.
        /// </summary>
        public BatchCreateRequest()
        {
        }

    }
}