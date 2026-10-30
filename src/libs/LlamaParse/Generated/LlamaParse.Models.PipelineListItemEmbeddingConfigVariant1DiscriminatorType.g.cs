
#nullable enable

namespace LlamaParse
{
    /// <summary>
    ///
    /// </summary>
    public enum PipelineListItemEmbeddingConfigVariant1DiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        AzureEmbedding,
        /// <summary>
        ///
        /// </summary>
        BedrockEmbedding,
        /// <summary>
        ///
        /// </summary>
        CohereEmbedding,
        /// <summary>
        ///
        /// </summary>
        GeminiEmbedding,
        /// <summary>
        ///
        /// </summary>
        HuggingfaceApiEmbedding,
        /// <summary>
        ///
        /// </summary>
        ManagedOpenaiEmbedding,
        /// <summary>
        ///
        /// </summary>
        OpenaiEmbedding,
        /// <summary>
        ///
        /// </summary>
        VertexaiEmbedding,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelineListItemEmbeddingConfigVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelineListItemEmbeddingConfigVariant1DiscriminatorType value)
        {
            return value switch
            {
                PipelineListItemEmbeddingConfigVariant1DiscriminatorType.AzureEmbedding => "AZURE_EMBEDDING",
                PipelineListItemEmbeddingConfigVariant1DiscriminatorType.BedrockEmbedding => "BEDROCK_EMBEDDING",
                PipelineListItemEmbeddingConfigVariant1DiscriminatorType.CohereEmbedding => "COHERE_EMBEDDING",
                PipelineListItemEmbeddingConfigVariant1DiscriminatorType.GeminiEmbedding => "GEMINI_EMBEDDING",
                PipelineListItemEmbeddingConfigVariant1DiscriminatorType.HuggingfaceApiEmbedding => "HUGGINGFACE_API_EMBEDDING",
                PipelineListItemEmbeddingConfigVariant1DiscriminatorType.ManagedOpenaiEmbedding => "MANAGED_OPENAI_EMBEDDING",
                PipelineListItemEmbeddingConfigVariant1DiscriminatorType.OpenaiEmbedding => "OPENAI_EMBEDDING",
                PipelineListItemEmbeddingConfigVariant1DiscriminatorType.VertexaiEmbedding => "VERTEXAI_EMBEDDING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelineListItemEmbeddingConfigVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "AZURE_EMBEDDING" => PipelineListItemEmbeddingConfigVariant1DiscriminatorType.AzureEmbedding,
                "BEDROCK_EMBEDDING" => PipelineListItemEmbeddingConfigVariant1DiscriminatorType.BedrockEmbedding,
                "COHERE_EMBEDDING" => PipelineListItemEmbeddingConfigVariant1DiscriminatorType.CohereEmbedding,
                "GEMINI_EMBEDDING" => PipelineListItemEmbeddingConfigVariant1DiscriminatorType.GeminiEmbedding,
                "HUGGINGFACE_API_EMBEDDING" => PipelineListItemEmbeddingConfigVariant1DiscriminatorType.HuggingfaceApiEmbedding,
                "MANAGED_OPENAI_EMBEDDING" => PipelineListItemEmbeddingConfigVariant1DiscriminatorType.ManagedOpenaiEmbedding,
                "OPENAI_EMBEDDING" => PipelineListItemEmbeddingConfigVariant1DiscriminatorType.OpenaiEmbedding,
                "VERTEXAI_EMBEDDING" => PipelineListItemEmbeddingConfigVariant1DiscriminatorType.VertexaiEmbedding,
                _ => null,
            };
        }
    }
}