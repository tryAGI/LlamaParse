#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace LlamaParse.JsonConverters
{
    /// <inheritdoc />
    public class ItemsItem4JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LlamaParse.ItemsItem4>
    {
        /// <inheritdoc />
        public override global::LlamaParse.ItemsItem4 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.StructuredResultPageItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.StructuredResultPageItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LlamaParse.StructuredResultPageItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::LlamaParse.TextItem? text = default;
            if (discriminator?.Type == global::LlamaParse.StructuredResultPageItemDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.TextItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.TextItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LlamaParse.TextItem)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LlamaParse.HeadingItem? heading = default;
            if (discriminator?.Type == global::LlamaParse.StructuredResultPageItemDiscriminatorType.Heading)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.HeadingItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.HeadingItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LlamaParse.HeadingItem)}");
                heading = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LlamaParse.ListItem? list = default;
            if (discriminator?.Type == global::LlamaParse.StructuredResultPageItemDiscriminatorType.List)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.ListItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.ListItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LlamaParse.ListItem)}");
                list = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LlamaParse.CodeItem? code = default;
            if (discriminator?.Type == global::LlamaParse.StructuredResultPageItemDiscriminatorType.Code)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.CodeItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.CodeItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LlamaParse.CodeItem)}");
                code = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LlamaParse.TableItem? table = default;
            if (discriminator?.Type == global::LlamaParse.StructuredResultPageItemDiscriminatorType.Table)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.TableItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.TableItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LlamaParse.TableItem)}");
                table = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LlamaParse.ImageItem? image = default;
            if (discriminator?.Type == global::LlamaParse.StructuredResultPageItemDiscriminatorType.Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.ImageItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.ImageItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LlamaParse.ImageItem)}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LlamaParse.LinkItem? link = default;
            if (discriminator?.Type == global::LlamaParse.StructuredResultPageItemDiscriminatorType.Link)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.LinkItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.LinkItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LlamaParse.LinkItem)}");
                link = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LlamaParse.HeaderItem? header = default;
            if (discriminator?.Type == global::LlamaParse.StructuredResultPageItemDiscriminatorType.Header)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.HeaderItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.HeaderItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LlamaParse.HeaderItem)}");
                header = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LlamaParse.FooterItem? footer = default;
            if (discriminator?.Type == global::LlamaParse.StructuredResultPageItemDiscriminatorType.Footer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.FooterItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.FooterItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LlamaParse.FooterItem)}");
                footer = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::LlamaParse.ItemsItem4(
                discriminator?.Type,
                text,

                heading,

                list,

                code,

                table,

                image,

                link,

                header,

                footer
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LlamaParse.ItemsItem4 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.TextItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.TextItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LlamaParse.TextItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!, typeInfo);
            }
            else if (value.IsHeading)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.HeadingItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.HeadingItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LlamaParse.HeadingItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Heading!, typeInfo);
            }
            else if (value.IsList)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.ListItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.ListItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LlamaParse.ListItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.List!, typeInfo);
            }
            else if (value.IsCode)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.CodeItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.CodeItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LlamaParse.CodeItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Code!, typeInfo);
            }
            else if (value.IsTable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.TableItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.TableItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LlamaParse.TableItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Table!, typeInfo);
            }
            else if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.ImageItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.ImageItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LlamaParse.ImageItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image!, typeInfo);
            }
            else if (value.IsLink)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.LinkItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.LinkItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LlamaParse.LinkItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Link!, typeInfo);
            }
            else if (value.IsHeader)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.HeaderItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.HeaderItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LlamaParse.HeaderItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Header!, typeInfo);
            }
            else if (value.IsFooter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.FooterItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.FooterItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LlamaParse.FooterItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Footer!, typeInfo);
            }
        }
    }
}