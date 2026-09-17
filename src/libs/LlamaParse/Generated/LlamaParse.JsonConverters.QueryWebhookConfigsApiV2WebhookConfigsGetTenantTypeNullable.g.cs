#nullable enable

namespace LlamaParse.JsonConverters
{
    /// <inheritdoc />
    public sealed class QueryWebhookConfigsApiV2WebhookConfigsGetTenantTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LlamaParse.QueryWebhookConfigsApiV2WebhookConfigsGetTenantType?>
    {
        /// <inheritdoc />
        public override global::LlamaParse.QueryWebhookConfigsApiV2WebhookConfigsGetTenantType? Read(
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
                        return global::LlamaParse.QueryWebhookConfigsApiV2WebhookConfigsGetTenantTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LlamaParse.QueryWebhookConfigsApiV2WebhookConfigsGetTenantType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LlamaParse.QueryWebhookConfigsApiV2WebhookConfigsGetTenantType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LlamaParse.QueryWebhookConfigsApiV2WebhookConfigsGetTenantType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::LlamaParse.QueryWebhookConfigsApiV2WebhookConfigsGetTenantTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
