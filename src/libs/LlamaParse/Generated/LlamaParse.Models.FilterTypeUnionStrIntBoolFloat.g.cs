
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FilterTypeUnionStrIntBoolFloat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LlamaParse.JsonConverters.FilterTypeUnionStrIntBoolFloatOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.FilterTypeUnionStrIntBoolFloatOperator Operator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, int?, bool?, double?, global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?, bool?, double?>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.AnyOf<string, int?, bool?, double?, global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?, bool?, double?>>> Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterTypeUnionStrIntBoolFloat" /> class.
        /// </summary>
        /// <param name="operator"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FilterTypeUnionStrIntBoolFloat(
            global::LlamaParse.FilterTypeUnionStrIntBoolFloatOperator @operator,
            global::LlamaParse.AnyOf<string, int?, bool?, double?, global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?, bool?, double?>>> value)
        {
            this.Operator = @operator;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterTypeUnionStrIntBoolFloat" /> class.
        /// </summary>
        public FilterTypeUnionStrIntBoolFloat()
        {
        }

    }
}