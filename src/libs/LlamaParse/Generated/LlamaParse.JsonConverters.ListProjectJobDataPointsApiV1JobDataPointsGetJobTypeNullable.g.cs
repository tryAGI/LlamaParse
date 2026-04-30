#nullable enable

namespace LlamaParse.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListProjectJobDataPointsApiV1JobDataPointsGetJobTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LlamaParse.ListProjectJobDataPointsApiV1JobDataPointsGetJobType?>
    {
        /// <inheritdoc />
        public override global::LlamaParse.ListProjectJobDataPointsApiV1JobDataPointsGetJobType? Read(
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
                        return global::LlamaParse.ListProjectJobDataPointsApiV1JobDataPointsGetJobTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LlamaParse.ListProjectJobDataPointsApiV1JobDataPointsGetJobType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LlamaParse.ListProjectJobDataPointsApiV1JobDataPointsGetJobType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LlamaParse.ListProjectJobDataPointsApiV1JobDataPointsGetJobType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::LlamaParse.ListProjectJobDataPointsApiV1JobDataPointsGetJobTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
