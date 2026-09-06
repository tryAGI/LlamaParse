#nullable enable

namespace LlamaParse.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListClassifyJobsApiV2ClassifyGetStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LlamaParse.ListClassifyJobsApiV2ClassifyGetStatus?>
    {
        /// <inheritdoc />
        public override global::LlamaParse.ListClassifyJobsApiV2ClassifyGetStatus? Read(
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
                        return global::LlamaParse.ListClassifyJobsApiV2ClassifyGetStatusExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LlamaParse.ListClassifyJobsApiV2ClassifyGetStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LlamaParse.ListClassifyJobsApiV2ClassifyGetStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LlamaParse.ListClassifyJobsApiV2ClassifyGetStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::LlamaParse.ListClassifyJobsApiV2ClassifyGetStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
