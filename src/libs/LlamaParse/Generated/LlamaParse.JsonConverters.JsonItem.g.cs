#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace LlamaParse.JsonConverters
{
    /// <inheritdoc />
    public class JsonItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LlamaParse.JsonItem>
    {
        /// <inheritdoc />
        public override global::LlamaParse.JsonItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.FormJsonItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.FormJsonItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LlamaParse.FormJsonItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::LlamaParse.FormSection? section = default;
            if (discriminator?.Type == global::LlamaParse.FormJsonItemDiscriminatorType.Section)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.FormSection), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.FormSection> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LlamaParse.FormSection)}");
                section = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LlamaParse.FormField? field = default;
            if (discriminator?.Type == global::LlamaParse.FormJsonItemDiscriminatorType.Field)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.FormField), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.FormField> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LlamaParse.FormField)}");
                field = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LlamaParse.FormTable? table = default;
            if (discriminator?.Type == global::LlamaParse.FormJsonItemDiscriminatorType.Table)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.FormTable), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.FormTable> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LlamaParse.FormTable)}");
                table = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::LlamaParse.JsonItem(
                discriminator?.Type,
                section,

                field,

                table
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LlamaParse.JsonItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSection)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.FormSection), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.FormSection?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LlamaParse.FormSection).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Section!, typeInfo);
            }
            else if (value.IsField)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.FormField), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.FormField?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LlamaParse.FormField).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Field!, typeInfo);
            }
            else if (value.IsTable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.FormTable), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.FormTable?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LlamaParse.FormTable).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Table!, typeInfo);
            }
        }
    }
}