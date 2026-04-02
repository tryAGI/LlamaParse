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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::LlamaParse.FooterItemItemDiscriminator>(ref readerCopy, options);

            global::LlamaParse.TextItem? text = default;
            if (discriminator?.Type == global::LlamaParse.FooterItemItemDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::LlamaParse.TextItem>(ref reader, options);
            }
            global::LlamaParse.HeadingItem? heading = default;
            if (discriminator?.Type == global::LlamaParse.FooterItemItemDiscriminatorType.Heading)
            {
                heading = global::System.Text.Json.JsonSerializer.Deserialize<global::LlamaParse.HeadingItem>(ref reader, options);
            }
            global::LlamaParse.ListItem? list = default;
            if (discriminator?.Type == global::LlamaParse.FooterItemItemDiscriminatorType.List)
            {
                list = global::System.Text.Json.JsonSerializer.Deserialize<global::LlamaParse.ListItem>(ref reader, options);
            }
            global::LlamaParse.CodeItem? code = default;
            if (discriminator?.Type == global::LlamaParse.FooterItemItemDiscriminatorType.Code)
            {
                code = global::System.Text.Json.JsonSerializer.Deserialize<global::LlamaParse.CodeItem>(ref reader, options);
            }
            global::LlamaParse.TableItem? table = default;
            if (discriminator?.Type == global::LlamaParse.FooterItemItemDiscriminatorType.Table)
            {
                table = global::System.Text.Json.JsonSerializer.Deserialize<global::LlamaParse.TableItem>(ref reader, options);
            }
            global::LlamaParse.ImageItem? image = default;
            if (discriminator?.Type == global::LlamaParse.FooterItemItemDiscriminatorType.Image)
            {
                image = global::System.Text.Json.JsonSerializer.Deserialize<global::LlamaParse.ImageItem>(ref reader, options);
            }
            global::LlamaParse.LinkItem? link = default;
            if (discriminator?.Type == global::LlamaParse.FooterItemItemDiscriminatorType.Link)
            {
                link = global::System.Text.Json.JsonSerializer.Deserialize<global::LlamaParse.LinkItem>(ref reader, options);
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

            if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::LlamaParse.TextItem), options);
            }
            else if (value.IsHeading)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Heading, typeof(global::LlamaParse.HeadingItem), options);
            }
            else if (value.IsList)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.List, typeof(global::LlamaParse.ListItem), options);
            }
            else if (value.IsCode)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Code, typeof(global::LlamaParse.CodeItem), options);
            }
            else if (value.IsTable)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Table, typeof(global::LlamaParse.TableItem), options);
            }
            else if (value.IsImage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image, typeof(global::LlamaParse.ImageItem), options);
            }
            else if (value.IsLink)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Link, typeof(global::LlamaParse.LinkItem), options);
            }
        }
    }
}