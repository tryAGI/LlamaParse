#nullable enable

namespace LlamaParse.JsonConverters
{
    /// <inheritdoc />
    public sealed class LlamaParseProcessingOptionsSpecializedChartParsingJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LlamaParse.LlamaParseProcessingOptionsSpecializedChartParsing>
    {
        /// <inheritdoc />
        public override global::LlamaParse.LlamaParseProcessingOptionsSpecializedChartParsing Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::LlamaParse.LlamaParseProcessingOptionsSpecializedChartParsingExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LlamaParse.LlamaParseProcessingOptionsSpecializedChartParsing)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LlamaParse.LlamaParseProcessingOptionsSpecializedChartParsing);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LlamaParse.LlamaParseProcessingOptionsSpecializedChartParsing value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::LlamaParse.LlamaParseProcessingOptionsSpecializedChartParsingExtensions.ToValueString(value));
        }
    }
}
