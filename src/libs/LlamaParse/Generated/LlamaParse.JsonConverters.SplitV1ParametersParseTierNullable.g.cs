#nullable enable

namespace LlamaParse.JsonConverters
{
    /// <inheritdoc />
    public sealed class SplitV1ParametersParseTierNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LlamaParse.SplitV1ParametersParseTier?>
    {
        /// <inheritdoc />
        public override global::LlamaParse.SplitV1ParametersParseTier? Read(
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
                        return global::LlamaParse.SplitV1ParametersParseTierExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LlamaParse.SplitV1ParametersParseTier)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LlamaParse.SplitV1ParametersParseTier?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LlamaParse.SplitV1ParametersParseTier? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::LlamaParse.SplitV1ParametersParseTierExtensions.ToValueString(value.Value));
            }
        }
    }
}
