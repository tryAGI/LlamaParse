
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Where in a list the least confident value is.
    /// </summary>
    public sealed partial class ExtractReviewFlagCell
    {
        /// <summary>
        /// Index of the row, from 0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("row")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Row { get; set; }

        /// <summary>
        /// Property of the row, when rows are objects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column")]
        public string? Column { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractReviewFlagCell" /> class.
        /// </summary>
        /// <param name="row">
        /// Index of the row, from 0.
        /// </param>
        /// <param name="column">
        /// Property of the row, when rows are objects.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractReviewFlagCell(
            int row,
            string? column)
        {
            this.Row = row;
            this.Column = column;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractReviewFlagCell" /> class.
        /// </summary>
        public ExtractReviewFlagCell()
        {
        }

    }
}