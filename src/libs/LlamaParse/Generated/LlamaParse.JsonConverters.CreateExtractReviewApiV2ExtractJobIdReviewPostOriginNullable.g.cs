#nullable enable

namespace LlamaParse.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateExtractReviewApiV2ExtractJobIdReviewPostOriginNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LlamaParse.CreateExtractReviewApiV2ExtractJobIdReviewPostOrigin?>
    {
        /// <inheritdoc />
        public override global::LlamaParse.CreateExtractReviewApiV2ExtractJobIdReviewPostOrigin? Read(
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
                        return global::LlamaParse.CreateExtractReviewApiV2ExtractJobIdReviewPostOriginExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LlamaParse.CreateExtractReviewApiV2ExtractJobIdReviewPostOrigin)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LlamaParse.CreateExtractReviewApiV2ExtractJobIdReviewPostOrigin?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LlamaParse.CreateExtractReviewApiV2ExtractJobIdReviewPostOrigin? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::LlamaParse.CreateExtractReviewApiV2ExtractJobIdReviewPostOriginExtensions.ToValueString(value.Value));
            }
        }
    }
}
