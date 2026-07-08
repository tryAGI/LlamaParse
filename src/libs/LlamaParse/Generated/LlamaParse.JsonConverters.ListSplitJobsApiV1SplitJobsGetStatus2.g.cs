#nullable enable

namespace LlamaParse.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListSplitJobsApiV1SplitJobsGetStatus2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LlamaParse.ListSplitJobsApiV1SplitJobsGetStatus2>
    {
        /// <inheritdoc />
        public override global::LlamaParse.ListSplitJobsApiV1SplitJobsGetStatus2 Read(
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
                        return global::LlamaParse.ListSplitJobsApiV1SplitJobsGetStatus2Extensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LlamaParse.ListSplitJobsApiV1SplitJobsGetStatus2)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LlamaParse.ListSplitJobsApiV1SplitJobsGetStatus2);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LlamaParse.ListSplitJobsApiV1SplitJobsGetStatus2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::LlamaParse.ListSplitJobsApiV1SplitJobsGetStatus2Extensions.ToValueString(value));
        }
    }
}
