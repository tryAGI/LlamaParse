#nullable enable

namespace LlamaParse.JsonConverters
{
    /// <inheritdoc />
    public sealed class LlamaParseOutputOptionsImagesToSaveItemNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LlamaParse.LlamaParseOutputOptionsImagesToSaveItem?>
    {
        /// <inheritdoc />
        public override global::LlamaParse.LlamaParseOutputOptionsImagesToSaveItem? Read(
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
                        return global::LlamaParse.LlamaParseOutputOptionsImagesToSaveItemExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LlamaParse.LlamaParseOutputOptionsImagesToSaveItem)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LlamaParse.LlamaParseOutputOptionsImagesToSaveItem?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LlamaParse.LlamaParseOutputOptionsImagesToSaveItem? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::LlamaParse.LlamaParseOutputOptionsImagesToSaveItemExtensions.ToValueString(value.Value));
            }
        }
    }
}
