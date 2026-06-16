
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Configuration for a batch.<br/>
    /// Example:<br/>
    ///     {<br/>
    ///         "job": {<br/>
    ///             "type": "parse_v2",<br/>
    ///             "configuration_id": "cfg-PARSE_AGENTIC"<br/>
    ///         }<br/>
    ///     }<br/>
    /// This wraps the product configuration ID to run over the source directory.<br/>
    /// Use a built-in preset ID when available, or create/reuse a product<br/>
    /// configuration through the generic configurations API before creating the<br/>
    /// batch.
    /// </summary>
    public sealed partial class BatchConfiguration
    {
        /// <summary>
        /// Job to create for each file in the source directory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.BatchJobConfig Job { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchConfiguration" /> class.
        /// </summary>
        /// <param name="job">
        /// Job to create for each file in the source directory.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchConfiguration(
            global::LlamaParse.BatchJobConfig job)
        {
            this.Job = job ?? throw new global::System.ArgumentNullException(nameof(job));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchConfiguration" /> class.
        /// </summary>
        public BatchConfiguration()
        {
        }

    }
}