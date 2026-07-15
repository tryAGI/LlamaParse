
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// One line of a form's list representation.
    /// </summary>
    public sealed partial class FormListTextItem
    {
        /// <summary>
        /// Text line<br/>
        /// Default Value: text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Line content (e.g. '[1a] Wages: 29,513')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Markdown representation of the line
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("md")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Md { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FormListTextItem" /> class.
        /// </summary>
        /// <param name="value">
        /// Line content (e.g. '[1a] Wages: 29,513')
        /// </param>
        /// <param name="md">
        /// Markdown representation of the line
        /// </param>
        /// <param name="type">
        /// Text line<br/>
        /// Default Value: text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FormListTextItem(
            string value,
            string md,
            string? type)
        {
            this.Type = type;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Md = md ?? throw new global::System.ArgumentNullException(nameof(md));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormListTextItem" /> class.
        /// </summary>
        public FormListTextItem()
        {
        }

    }
}