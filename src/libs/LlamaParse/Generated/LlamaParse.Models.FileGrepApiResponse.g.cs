
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Grep results for a file.
    /// </summary>
    public sealed partial class FileGrepApiResponse
    {
        /// <summary>
        /// Regex matches found in the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matches")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LlamaParse.GrepMatchResponse> Matches { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileGrepApiResponse" /> class.
        /// </summary>
        /// <param name="matches">
        /// Regex matches found in the file.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileGrepApiResponse(
            global::System.Collections.Generic.IList<global::LlamaParse.GrepMatchResponse> matches)
        {
            this.Matches = matches ?? throw new global::System.ArgumentNullException(nameof(matches));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileGrepApiResponse" /> class.
        /// </summary>
        public FileGrepApiResponse()
        {
        }

    }
}