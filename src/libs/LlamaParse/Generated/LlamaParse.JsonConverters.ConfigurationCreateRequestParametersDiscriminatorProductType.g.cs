#nullable enable

namespace LlamaParse.JsonConverters
{
    /// <inheritdoc />
    public sealed class ConfigurationCreateRequestParametersDiscriminatorProductTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LlamaParse.ConfigurationCreateRequestParametersDiscriminatorProductType>
    {
        /// <inheritdoc />
        public override global::LlamaParse.ConfigurationCreateRequestParametersDiscriminatorProductType Read(
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
                        return global::LlamaParse.ConfigurationCreateRequestParametersDiscriminatorProductTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LlamaParse.ConfigurationCreateRequestParametersDiscriminatorProductType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LlamaParse.ConfigurationCreateRequestParametersDiscriminatorProductType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LlamaParse.ConfigurationCreateRequestParametersDiscriminatorProductType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::LlamaParse.ConfigurationCreateRequestParametersDiscriminatorProductTypeExtensions.ToValueString(value));
        }
    }
}
