#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace LlamaParse.JsonConverters
{
    /// <inheritdoc />
    public class ParametersJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LlamaParse.Parameters>
    {
        /// <inheritdoc />
        public override global::LlamaParse.Parameters Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.ConfigurationCreateRequestParametersDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.ConfigurationCreateRequestParametersDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LlamaParse.ConfigurationCreateRequestParametersDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::LlamaParse.SplitV1Parameters? splitV1 = default;
            if (discriminator?.ProductType == global::LlamaParse.ConfigurationCreateRequestParametersDiscriminatorProductType.SplitV1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.SplitV1Parameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.SplitV1Parameters> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LlamaParse.SplitV1Parameters)}");
                splitV1 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LlamaParse.ExtractV2Parameters? extractV2 = default;
            if (discriminator?.ProductType == global::LlamaParse.ConfigurationCreateRequestParametersDiscriminatorProductType.ExtractV2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.ExtractV2Parameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.ExtractV2Parameters> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LlamaParse.ExtractV2Parameters)}");
                extractV2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LlamaParse.ClassifyV2Parameters? classifyV2 = default;
            if (discriminator?.ProductType == global::LlamaParse.ConfigurationCreateRequestParametersDiscriminatorProductType.ClassifyV2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.ClassifyV2Parameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.ClassifyV2Parameters> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LlamaParse.ClassifyV2Parameters)}");
                classifyV2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LlamaParse.ParseV2Parameters? parseV2 = default;
            if (discriminator?.ProductType == global::LlamaParse.ConfigurationCreateRequestParametersDiscriminatorProductType.ParseV2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.ParseV2Parameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.ParseV2Parameters> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LlamaParse.ParseV2Parameters)}");
                parseV2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LlamaParse.UntypedParameters? unknown = default;
            if (discriminator?.ProductType == global::LlamaParse.ConfigurationCreateRequestParametersDiscriminatorProductType.Unknown)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.UntypedParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.UntypedParameters> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LlamaParse.UntypedParameters)}");
                unknown = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::LlamaParse.Parameters(
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
            global::LlamaParse.Parameters value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSplitV1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.SplitV1Parameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.SplitV1Parameters?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LlamaParse.SplitV1Parameters).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SplitV1, typeInfo);
            }
            else if (value.IsExtractV2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.ExtractV2Parameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.ExtractV2Parameters?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LlamaParse.ExtractV2Parameters).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ExtractV2, typeInfo);
            }
            else if (value.IsClassifyV2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.ClassifyV2Parameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.ClassifyV2Parameters?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LlamaParse.ClassifyV2Parameters).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ClassifyV2, typeInfo);
            }
            else if (value.IsParseV2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.ParseV2Parameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.ParseV2Parameters?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LlamaParse.ParseV2Parameters).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ParseV2, typeInfo);
            }
            else if (value.IsUnknown)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.UntypedParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.UntypedParameters?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LlamaParse.UntypedParameters).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Unknown, typeInfo);
            }
        }
    }
}