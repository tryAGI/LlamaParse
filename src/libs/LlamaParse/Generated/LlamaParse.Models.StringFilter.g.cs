
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Filter on a string field.
    /// </summary>
    public sealed partial class StringFilter
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LlamaParse.JsonConverters.StringFilterOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.StringFilterOperator Operator { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.AnyOf<string, global::System.Collections.Generic.IList<string>> Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StringFilter" /> class.
        /// </summary>
        /// <param name="operator"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StringFilter(
            global::LlamaParse.StringFilterOperator @operator,
            global::LlamaParse.AnyOf<string, global::System.Collections.Generic.IList<string>> value)
        {
            this.Operator = @operator;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StringFilter" /> class.
        /// </summary>
        public StringFilter()
        {
        }

    }
}