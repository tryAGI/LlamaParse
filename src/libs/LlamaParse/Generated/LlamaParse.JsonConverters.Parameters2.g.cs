#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace LlamaParse.JsonConverters
{
    /// <inheritdoc />
    public class Parameters2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LlamaParse.Parameters2>
    {
        /// <inheritdoc />
        public override global::LlamaParse.Parameters2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::LlamaParse.ConfigurationResponseParametersDiscriminator>(ref readerCopy, options);

            global::LlamaParse.SplitV1Parameters? splitV1 = default;
            if (discriminator?.ProductType == global::LlamaParse.ConfigurationResponseParametersDiscriminatorProductType.SplitV1)
            {
                splitV1 = global::System.Text.Json.JsonSerializer.Deserialize<global::LlamaParse.SplitV1Parameters>(ref reader, options);
            }
            global::LlamaParse.ExtractV2Parameters? extractV2 = default;
            if (discriminator?.ProductType == global::LlamaParse.ConfigurationResponseParametersDiscriminatorProductType.ExtractV2)
            {
                extractV2 = global::System.Text.Json.JsonSerializer.Deserialize<global::LlamaParse.ExtractV2Parameters>(ref reader, options);
            }
            global::LlamaParse.ClassifyV2Parameters? classifyV2 = default;
            if (discriminator?.ProductType == global::LlamaParse.ConfigurationResponseParametersDiscriminatorProductType.ClassifyV2)
            {
                classifyV2 = global::System.Text.Json.JsonSerializer.Deserialize<global::LlamaParse.ClassifyV2Parameters>(ref reader, options);
            }
            global::LlamaParse.ParseV2Parameters? parseV2 = default;
            if (discriminator?.ProductType == global::LlamaParse.ConfigurationResponseParametersDiscriminatorProductType.ParseV2)
            {
                parseV2 = global::System.Text.Json.JsonSerializer.Deserialize<global::LlamaParse.ParseV2Parameters>(ref reader, options);
            }
            global::LlamaParse.UntypedParameters? unknown = default;
            if (discriminator?.ProductType == global::LlamaParse.ConfigurationResponseParametersDiscriminatorProductType.Unknown)
            {
                unknown = global::System.Text.Json.JsonSerializer.Deserialize<global::LlamaParse.UntypedParameters>(ref reader, options);
            }

            var __value = new global::LlamaParse.Parameters2(
                discriminator?.ProductType,
                splitV1,

                extractV2,

                classifyV2,

                parseV2,

                unknown
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LlamaParse.Parameters2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsSplitV1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SplitV1, typeof(global::LlamaParse.SplitV1Parameters), options);
            }
            else if (value.IsExtractV2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ExtractV2, typeof(global::LlamaParse.ExtractV2Parameters), options);
            }
            else if (value.IsClassifyV2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ClassifyV2, typeof(global::LlamaParse.ClassifyV2Parameters), options);
            }
            else if (value.IsParseV2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ParseV2, typeof(global::LlamaParse.ParseV2Parameters), options);
            }
            else if (value.IsUnknown)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Unknown, typeof(global::LlamaParse.UntypedParameters), options);
            }
        }
    }
}