#nullable enable

namespace LlamaParse.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListSplitJobsApiV1BetaSplitJobsGetStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LlamaParse.ListSplitJobsApiV1BetaSplitJobsGetStatus?>
    {
        /// <inheritdoc />
        public override global::LlamaParse.ListSplitJobsApiV1BetaSplitJobsGetStatus? Read(
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
                        return global::LlamaParse.ListSplitJobsApiV1BetaSplitJobsGetStatusExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LlamaParse.ListSplitJobsApiV1BetaSplitJobsGetStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LlamaParse.ListSplitJobsApiV1BetaSplitJobsGetStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LlamaParse.ListSplitJobsApiV1BetaSplitJobsGetStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::LlamaParse.ListSplitJobsApiV1BetaSplitJobsGetStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
