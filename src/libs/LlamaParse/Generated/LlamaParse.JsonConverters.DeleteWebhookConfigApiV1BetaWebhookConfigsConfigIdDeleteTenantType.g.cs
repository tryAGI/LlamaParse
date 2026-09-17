#nullable enable

namespace LlamaParse.JsonConverters
{
    /// <inheritdoc />
    public sealed class DeleteWebhookConfigApiV1BetaWebhookConfigsConfigIdDeleteTenantTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LlamaParse.DeleteWebhookConfigApiV1BetaWebhookConfigsConfigIdDeleteTenantType>
    {
        /// <inheritdoc />
        public override global::LlamaParse.DeleteWebhookConfigApiV1BetaWebhookConfigsConfigIdDeleteTenantType Read(
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
                        return global::LlamaParse.DeleteWebhookConfigApiV1BetaWebhookConfigsConfigIdDeleteTenantTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LlamaParse.DeleteWebhookConfigApiV1BetaWebhookConfigsConfigIdDeleteTenantType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LlamaParse.DeleteWebhookConfigApiV1BetaWebhookConfigsConfigIdDeleteTenantType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LlamaParse.DeleteWebhookConfigApiV1BetaWebhookConfigsConfigIdDeleteTenantType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::LlamaParse.DeleteWebhookConfigApiV1BetaWebhookConfigsConfigIdDeleteTenantTypeExtensions.ToValueString(value));
        }
    }
}
