#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace LlamaParse.JsonConverters
{
    /// <inheritdoc />
    public class EmbeddingConfigVariant12JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LlamaParse.EmbeddingConfigVariant12>
    {
        /// <inheritdoc />
        public override global::LlamaParse.EmbeddingConfigVariant12 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::LlamaParse.PipelineCreateEmbeddingConfigVariant1Discriminator>(ref readerCopy, options);

            global::LlamaParse.AzureOpenAIEmbeddingConfig? azureEmbedding1 = default;
            if (discriminator?.Type == global::LlamaParse.PipelineCreateEmbeddingConfigVariant1DiscriminatorType.AzureEmbedding)
            {
                azureEmbedding1 = global::System.Text.Json.JsonSerializer.Deserialize<global::LlamaParse.AzureOpenAIEmbeddingConfig>(ref reader, options);
            }
            global::LlamaParse.CohereEmbeddingConfig? cohereEmbedding = default;
            if (discriminator?.Type == global::LlamaParse.PipelineCreateEmbeddingConfigVariant1DiscriminatorType.CohereEmbedding)
            {
                cohereEmbedding = global::System.Text.Json.JsonSerializer.Deserialize<global::LlamaParse.CohereEmbeddingConfig>(ref reader, options);
            }
            global::LlamaParse.GeminiEmbeddingConfig? geminiEmbedding = default;
            if (discriminator?.Type == global::LlamaParse.PipelineCreateEmbeddingConfigVariant1DiscriminatorType.GeminiEmbedding)
            {
                geminiEmbedding = global::System.Text.Json.JsonSerializer.Deserialize<global::LlamaParse.GeminiEmbeddingConfig>(ref reader, options);
            }
            global::LlamaParse.HuggingFaceInferenceAPIEmbeddingConfig? huggingfaceApiEmbedding = default;
            if (discriminator?.Type == global::LlamaParse.PipelineCreateEmbeddingConfigVariant1DiscriminatorType.HuggingfaceApiEmbedding)
            {
                huggingfaceApiEmbedding = global::System.Text.Json.JsonSerializer.Deserialize<global::LlamaParse.HuggingFaceInferenceAPIEmbeddingConfig>(ref reader, options);
            }
            global::LlamaParse.OpenAIEmbeddingConfig? azureEmbedding2 = default;
            if (discriminator?.Type == global::LlamaParse.PipelineCreateEmbeddingConfigVariant1DiscriminatorType.AzureEmbedding)
            {
                azureEmbedding2 = global::System.Text.Json.JsonSerializer.Deserialize<global::LlamaParse.OpenAIEmbeddingConfig>(ref reader, options);
            }
            global::LlamaParse.VertexAIEmbeddingConfig? vertexaiEmbedding = default;
            if (discriminator?.Type == global::LlamaParse.PipelineCreateEmbeddingConfigVariant1DiscriminatorType.VertexaiEmbedding)
            {
                vertexaiEmbedding = global::System.Text.Json.JsonSerializer.Deserialize<global::LlamaParse.VertexAIEmbeddingConfig>(ref reader, options);
            }
            global::LlamaParse.BedrockEmbeddingConfig? bedrockEmbedding = default;
            if (discriminator?.Type == global::LlamaParse.PipelineCreateEmbeddingConfigVariant1DiscriminatorType.BedrockEmbedding)
            {
                bedrockEmbedding = global::System.Text.Json.JsonSerializer.Deserialize<global::LlamaParse.BedrockEmbeddingConfig>(ref reader, options);
            }

            var __value = new global::LlamaParse.EmbeddingConfigVariant12(
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
            global::LlamaParse.EmbeddingConfigVariant12 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsAzureEmbedding1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AzureEmbedding1, typeof(global::LlamaParse.AzureOpenAIEmbeddingConfig), options);
            }
            else if (value.IsCohereEmbedding)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CohereEmbedding, typeof(global::LlamaParse.CohereEmbeddingConfig), options);
            }
            else if (value.IsGeminiEmbedding)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GeminiEmbedding, typeof(global::LlamaParse.GeminiEmbeddingConfig), options);
            }
            else if (value.IsHuggingfaceApiEmbedding)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HuggingfaceApiEmbedding, typeof(global::LlamaParse.HuggingFaceInferenceAPIEmbeddingConfig), options);
            }
            else if (value.IsAzureEmbedding2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AzureEmbedding2, typeof(global::LlamaParse.OpenAIEmbeddingConfig), options);
            }
            else if (value.IsVertexaiEmbedding)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VertexaiEmbedding, typeof(global::LlamaParse.VertexAIEmbeddingConfig), options);
            }
            else if (value.IsBedrockEmbedding)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BedrockEmbedding, typeof(global::LlamaParse.BedrockEmbeddingConfig), options);
            }
        }
    }
}