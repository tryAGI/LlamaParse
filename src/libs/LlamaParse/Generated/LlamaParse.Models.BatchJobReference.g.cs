
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Reference to a job produced by a batch.<br/>
    /// Example:<br/>
    ///     {<br/>
    ///         "type": "parse_v2",<br/>
    ///         "id": "pjb-aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeeee"<br/>
    ///     }
    /// </summary>
    public sealed partial class BatchJobReference
    {
        /// <summary>
        /// Type of job produced for the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Job ID, such as a parse job ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchJobReference" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of job produced for the file.
        /// </param>
        /// <param name="id">
        /// Job ID, such as a parse job ID.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchJobReference(
            string type,
            string id)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchJobReference" /> class.
        /// </summary>
        public BatchJobReference()
        {
        }

    }
}