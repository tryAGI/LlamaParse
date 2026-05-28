
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Job to run for each file in the source directory.<br/>
    /// Example:<br/>
    ///     {<br/>
    ///         "type": "parse_v2",<br/>
    ///         "configuration_id": "cfg-aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeeee"<br/>
    ///     }<br/>
    /// Batch V2 references saved product configurations so the underlying<br/>
    /// directory-sync flow can resolve a stable config ID for every file-level job.
    /// </summary>
    public sealed partial class BatchJobConfig
    {
        /// <summary>
        /// Product job type to run for each source directory file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Saved product configuration ID matching the job type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConfigurationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchJobConfig" /> class.
        /// </summary>
        /// <param name="type">
        /// Product job type to run for each source directory file.
        /// </param>
        /// <param name="configurationId">
        /// Saved product configuration ID matching the job type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchJobConfig(
            string type,
            string configurationId)
        {
            this.Type = type;
            this.ConfigurationId = configurationId ?? throw new global::System.ArgumentNullException(nameof(configurationId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchJobConfig" /> class.
        /// </summary>
        public BatchJobConfig()
        {
        }

    }
}