#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace LlamaParse.JsonConverters
{
    /// <inheritdoc />
    public class EmbeddingConfigVariant13JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LlamaParse.EmbeddingConfigVariant13>
    {
        /// <inheritdoc />
        public override global::LlamaParse.EmbeddingConfigVariant13 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.PipelineUpdateEmbeddingConfigVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.PipelineUpdateEmbeddingConfigVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LlamaParse.PipelineUpdateEmbeddingConfigVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::LlamaParse.AzureOpenAIEmbeddingConfig? azureEmbedding1 = default;
            if (discriminator?.Type == global::LlamaParse.PipelineUpdateEmbeddingConfigVariant1DiscriminatorType.AzureEmbedding)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.AzureOpenAIEmbeddingConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.AzureOpenAIEmbeddingConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LlamaParse.AzureOpenAIEmbeddingConfig)}");
                azureEmbedding1 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LlamaParse.CohereEmbeddingConfig? cohereEmbedding = default;
            if (discriminator?.Type == global::LlamaParse.PipelineUpdateEmbeddingConfigVariant1DiscriminatorType.CohereEmbedding)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.CohereEmbeddingConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.CohereEmbeddingConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LlamaParse.CohereEmbeddingConfig)}");
                cohereEmbedding = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LlamaParse.GeminiEmbeddingConfig? geminiEmbedding = default;
            if (discriminator?.Type == global::LlamaParse.PipelineUpdateEmbeddingConfigVariant1DiscriminatorType.GeminiEmbedding)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.GeminiEmbeddingConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.GeminiEmbeddingConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LlamaParse.GeminiEmbeddingConfig)}");
                geminiEmbedding = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LlamaParse.HuggingFaceInferenceAPIEmbeddingConfig? huggingfaceApiEmbedding = default;
            if (discriminator?.Type == global::LlamaParse.PipelineUpdateEmbeddingConfigVariant1DiscriminatorType.HuggingfaceApiEmbedding)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.HuggingFaceInferenceAPIEmbeddingConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.HuggingFaceInferenceAPIEmbeddingConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LlamaParse.HuggingFaceInferenceAPIEmbeddingConfig)}");
                huggingfaceApiEmbedding = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LlamaParse.OpenAIEmbeddingConfig? azureEmbedding2 = default;
            if (discriminator?.Type == global::LlamaParse.PipelineUpdateEmbeddingConfigVariant1DiscriminatorType.AzureEmbedding)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.OpenAIEmbeddingConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.OpenAIEmbeddingConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LlamaParse.OpenAIEmbeddingConfig)}");
                azureEmbedding2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LlamaParse.VertexAIEmbeddingConfig? vertexaiEmbedding = default;
            if (discriminator?.Type == global::LlamaParse.PipelineUpdateEmbeddingConfigVariant1DiscriminatorType.VertexaiEmbedding)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.VertexAIEmbeddingConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.VertexAIEmbeddingConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LlamaParse.VertexAIEmbeddingConfig)}");
                vertexaiEmbedding = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LlamaParse.BedrockEmbeddingConfig? bedrockEmbedding = default;
            if (discriminator?.Type == global::LlamaParse.PipelineUpdateEmbeddingConfigVariant1DiscriminatorType.BedrockEmbedding)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.BedrockEmbeddingConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.BedrockEmbeddingConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LlamaParse.BedrockEmbeddingConfig)}");
                bedrockEmbedding = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::LlamaParse.EmbeddingConfigVariant13(
                discriminator?.Type,
                azureEmbedding1,

                cohereEmbedding,

                geminiEmbedding,

                huggingfaceApiEmbedding,

                azureEmbedding2,

                vertexaiEmbedding,

                bedrockEmbedding
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LlamaParse.EmbeddingConfigVariant13 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAzureEmbedding1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.AzureOpenAIEmbeddingConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.AzureOpenAIEmbeddingConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LlamaParse.AzureOpenAIEmbeddingConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AzureEmbedding1!, typeInfo);
            }
            else if (value.IsCohereEmbedding)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.CohereEmbeddingConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.CohereEmbeddingConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LlamaParse.CohereEmbeddingConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CohereEmbedding!, typeInfo);
            }
            else if (value.IsGeminiEmbedding)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.GeminiEmbeddingConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.GeminiEmbeddingConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LlamaParse.GeminiEmbeddingConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GeminiEmbedding!, typeInfo);
            }
            else if (value.IsHuggingfaceApiEmbedding)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.HuggingFaceInferenceAPIEmbeddingConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.HuggingFaceInferenceAPIEmbeddingConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LlamaParse.HuggingFaceInferenceAPIEmbeddingConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HuggingfaceApiEmbedding!, typeInfo);
            }
            else if (value.IsAzureEmbedding2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.OpenAIEmbeddingConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.OpenAIEmbeddingConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LlamaParse.OpenAIEmbeddingConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AzureEmbedding2!, typeInfo);
            }
            else if (value.IsVertexaiEmbedding)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.VertexAIEmbeddingConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.VertexAIEmbeddingConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LlamaParse.VertexAIEmbeddingConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VertexaiEmbedding!, typeInfo);
            }
            else if (value.IsBedrockEmbedding)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.BedrockEmbeddingConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.BedrockEmbeddingConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LlamaParse.BedrockEmbeddingConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BedrockEmbedding!, typeInfo);
            }
        }
    }
}