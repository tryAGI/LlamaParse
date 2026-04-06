#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace LlamaParse.JsonConverters
{
    /// <inheritdoc />
    public class ItemsItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LlamaParse.ItemsItem>
    {
        /// <inheritdoc />
        public override global::LlamaParse.ItemsItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.FooterItemItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.FooterItemItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LlamaParse.FooterItemItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::LlamaParse.TextItem? text = default;
            if (discriminator?.Type == global::LlamaParse.FooterItemItemDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.TextItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.TextItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LlamaParse.TextItem)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LlamaParse.HeadingItem? heading = default;
            if (discriminator?.Type == global::LlamaParse.FooterItemItemDiscriminatorType.Heading)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.HeadingItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.HeadingItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LlamaParse.HeadingItem)}");
                heading = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LlamaParse.ListItem? list = default;
            if (discriminator?.Type == global::LlamaParse.FooterItemItemDiscriminatorType.List)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.ListItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.ListItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LlamaParse.ListItem)}");
                list = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LlamaParse.CodeItem? code = default;
            if (discriminator?.Type == global::LlamaParse.FooterItemItemDiscriminatorType.Code)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.CodeItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.CodeItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LlamaParse.CodeItem)}");
                code = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LlamaParse.TableItem? table = default;
            if (discriminator?.Type == global::LlamaParse.FooterItemItemDiscriminatorType.Table)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.TableItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.TableItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LlamaParse.TableItem)}");
                table = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LlamaParse.ImageItem? image = default;
            if (discriminator?.Type == global::LlamaParse.FooterItemItemDiscriminatorType.Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.ImageItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.ImageItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LlamaParse.ImageItem)}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LlamaParse.LinkItem? link = default;
            if (discriminator?.Type == global::LlamaParse.FooterItemItemDiscriminatorType.Link)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.LinkItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.LinkItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LlamaParse.LinkItem)}");
                link = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::LlamaParse.ItemsItem(
                discriminator?.Type,
                text,

                heading,

                list,

                code,

                table,

                image,

                link
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LlamaParse.ItemsItem value,
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
        }
    }
}