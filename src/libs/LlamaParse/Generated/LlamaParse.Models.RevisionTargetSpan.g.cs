
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// One contiguous target span linked to a document revision.
    /// </summary>
    public sealed partial class RevisionTargetSpan
    {
        /// <summary>
        /// Text covered by this target span
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Target { get; set; }

        /// <summary>
        /// Bounding box of this target span
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_bbox")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.RevisionBBox TargetBbox { get; set; }

        /// <summary>
        /// Inclusive start offset in final page markdown
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_index")]
        public int? StartIndex { get; set; }

        /// <summary>
        /// Exclusive end offset in final page markdown
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_index")]
        public int? EndIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RevisionTargetSpan" /> class.
        /// </summary>
        /// <param name="target">
        /// Text covered by this target span
        /// </param>
        /// <param name="targetBbox">
        /// Bounding box of this target span
        /// </param>
        /// <param name="startIndex">
        /// Inclusive start offset in final page markdown
        /// </param>
        /// <param name="endIndex">
        /// Exclusive end offset in final page markdown
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RevisionTargetSpan(
            string target,
            global::LlamaParse.RevisionBBox targetBbox,
            int? startIndex,
            int? endIndex)
        {
            this.Target = target ?? throw new global::System.ArgumentNullException(nameof(target));
            this.TargetBbox = targetBbox ?? throw new global::System.ArgumentNullException(nameof(targetBbox));
            this.StartIndex = startIndex;
            this.EndIndex = endIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RevisionTargetSpan" /> class.
        /// </summary>
        public RevisionTargetSpan()
        {
        }

    }
}