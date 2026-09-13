
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace LlamaParse
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AzureOpenAIEmbedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AzureOpenAIEmbeddingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BedrockEmbedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BedrockEmbeddingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.CohereEmbedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.CohereEmbeddingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EmbeddingModelConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EmbeddingConfig), TypeInfoPropertyName = "EmbeddingConfig2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.GeminiEmbeddingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.HuggingFaceInferenceAPIEmbeddingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.OpenAIEmbeddingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.VertexAIEmbeddingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EmbeddingModelConfigEmbeddingConfigDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EmbeddingModelConfigEmbeddingConfigDiscriminatorType), TypeInfoPropertyName = "EmbeddingModelConfigEmbeddingConfigDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EmbeddingModelConfigCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EmbeddingConfig2), TypeInfoPropertyName = "EmbeddingConfig22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EmbeddingModelConfigCreateEmbeddingConfigDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType), TypeInfoPropertyName = "EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EmbeddingModelConfigUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EmbeddingConfigVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EmbeddingModelConfigUpdateEmbeddingConfigVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorType), TypeInfoPropertyName = "EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<string, bool?, object>), TypeInfoPropertyName = "AnyOfStringBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.GeminiEmbedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.HuggingFaceInferenceAPIEmbedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.Pooling), TypeInfoPropertyName = "Pooling2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ManagedOpenAIEmbeddingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.OpenAIEmbedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EmbeddingConfig3), TypeInfoPropertyName = "EmbeddingConfig32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EmbeddingConfigVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EmbeddingConfigVariant13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.VertexTextEmbedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.VertexEmbeddingMode), TypeInfoPropertyName = "VertexEmbeddingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.EmbeddingModelConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EmbeddingConfig?), TypeInfoPropertyName = "NullableEmbeddingConfig2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EmbeddingModelConfigEmbeddingConfigDiscriminatorType?), TypeInfoPropertyName = "NullableEmbeddingModelConfigEmbeddingConfigDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EmbeddingConfig2?), TypeInfoPropertyName = "NullableEmbeddingConfig22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType?), TypeInfoPropertyName = "NullableEmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableEmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<string, bool?, object>?), TypeInfoPropertyName = "NullableAnyOfStringBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.Pooling?), TypeInfoPropertyName = "NullablePooling2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EmbeddingConfig3?), TypeInfoPropertyName = "NullableEmbeddingConfig32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.VertexEmbeddingMode?), TypeInfoPropertyName = "NullableVertexEmbeddingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.EmbeddingModelConfig>))]
    internal sealed partial class EmbeddingModelConfigsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EmbeddingModelConfigsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static EmbeddingModelConfigsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private EmbeddingModelConfigsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::LlamaParse.JsonConverters.EmbeddingConfigJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.EmbeddingConfig2JsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.EmbeddingConfigVariant1JsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.EmbeddingConfig3JsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.EmbeddingConfigVariant12JsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.EmbeddingConfigVariant13JsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, string>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, string>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, string>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, string>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, double?, string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<int>, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, double?, global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<int?, double?>>>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, double?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, int?, double?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, int?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, int?, bool?, double?, global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?, bool?, double?>>>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, int?, bool?, double?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::LlamaParse.EmbeddingModelConfigEmbeddingConfigDiscriminatorType)

                    || typeToConvert == typeof(global::LlamaParse.EmbeddingModelConfigEmbeddingConfigDiscriminatorType?)

                    || typeToConvert == typeof(global::LlamaParse.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType)

                    || typeToConvert == typeof(global::LlamaParse.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType?)

                    || typeToConvert == typeof(global::LlamaParse.EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::LlamaParse.EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::LlamaParse.Pooling)

                    || typeToConvert == typeof(global::LlamaParse.Pooling?)

                    || typeToConvert == typeof(global::LlamaParse.VertexEmbeddingMode)

                    || typeToConvert == typeof(global::LlamaParse.VertexEmbeddingMode?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::LlamaParse.EmbeddingModelConfigEmbeddingConfigDiscriminatorType))
                {
                    return new global::LlamaParse.JsonConverters.EmbeddingModelConfigEmbeddingConfigDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.EmbeddingModelConfigEmbeddingConfigDiscriminatorType?))
                {
                    return new global::LlamaParse.JsonConverters.EmbeddingModelConfigEmbeddingConfigDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType))
                {
                    return new global::LlamaParse.JsonConverters.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType?))
                {
                    return new global::LlamaParse.JsonConverters.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorType))
                {
                    return new global::LlamaParse.JsonConverters.EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorType?))
                {
                    return new global::LlamaParse.JsonConverters.EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.Pooling))
                {
                    return new global::LlamaParse.JsonConverters.PoolingJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.Pooling?))
                {
                    return new global::LlamaParse.JsonConverters.PoolingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.VertexEmbeddingMode))
                {
                    return new global::LlamaParse.JsonConverters.VertexEmbeddingModeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.VertexEmbeddingMode?))
                {
                    return new global::LlamaParse.JsonConverters.VertexEmbeddingModeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new EmbeddingModelConfigsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}