#nullable enable

namespace LlamaParse.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListWebhookConfigsApiV1BetaWebhookConfigsGetTenantTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LlamaParse.ListWebhookConfigsApiV1BetaWebhookConfigsGetTenantType>
    {
        /// <inheritdoc />
        public override global::LlamaParse.ListWebhookConfigsApiV1BetaWebhookConfigsGetTenantType Read(
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
                        return global::LlamaParse.ListWebhookConfigsApiV1BetaWebhookConfigsGetTenantTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LlamaParse.ListWebhookConfigsApiV1BetaWebhookConfigsGetTenantType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LlamaParse.ListWebhookConfigsApiV1BetaWebhookConfigsGetTenantType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LlamaParse.ListWebhookConfigsApiV1BetaWebhookConfigsGetTenantType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::LlamaParse.ListWebhookConfigsApiV1BetaWebhookConfigsGetTenantTypeExtensions.ToValueString(value));
        }
    }
}
