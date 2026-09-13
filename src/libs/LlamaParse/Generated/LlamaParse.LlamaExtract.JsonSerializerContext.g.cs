
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.WebhookConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BodyRunJobOnFileApiV1ExtractionJobsFilePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>), TypeInfoPropertyName = "AnyOfObjectIListObjectStringInt32DoubleBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DocumentChunkMode), TypeInfoPropertyName = "DocumentChunkMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractAgentCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, string>), TypeInfoPropertyName = "AnyOfObjectString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractAgentQueryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ExtractAgent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractAgentUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractConfigPriority), TypeInfoPropertyName = "ExtractConfigPriority2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractTarget), TypeInfoPropertyName = "ExtractTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractMode), TypeInfoPropertyName = "ExtractMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PublicModelName), TypeInfoPropertyName = "PublicModelName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.ExtractModels?, string, object>), TypeInfoPropertyName = "AnyOfExtractModelsStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractModels), TypeInfoPropertyName = "ExtractModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractJobStatus), TypeInfoPropertyName = "ExtractJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.File))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractJobCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractJobCreatePriority), TypeInfoPropertyName = "ExtractJobCreatePriority2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, string, object>), TypeInfoPropertyName = "AnyOfObjectStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractJobCreateBatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractResultset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::System.Collections.Generic.IList<object>, object>), TypeInfoPropertyName = "AnyOfObjectIListObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractState), TypeInfoPropertyName = "ExtractState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractSchemaGenerateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractSchemaGenerateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractSchemaValidateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractSchemaValidateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractStatelessRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FileData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PaginatedExtractRunsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ExtractRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item), TypeInfoPropertyName = "WebhookConfigurationWebhookEventsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ExtractJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>?), TypeInfoPropertyName = "NullableAnyOfObjectIListObjectStringInt32DoubleBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DocumentChunkMode?), TypeInfoPropertyName = "NullableDocumentChunkMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, string>?), TypeInfoPropertyName = "NullableAnyOfObjectString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractConfigPriority?), TypeInfoPropertyName = "NullableExtractConfigPriority2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractTarget?), TypeInfoPropertyName = "NullableExtractTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractMode?), TypeInfoPropertyName = "NullableExtractMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PublicModelName?), TypeInfoPropertyName = "NullablePublicModelName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.ExtractModels?, string, object>?), TypeInfoPropertyName = "NullableAnyOfExtractModelsStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractModels?), TypeInfoPropertyName = "NullableExtractModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractJobStatus?), TypeInfoPropertyName = "NullableExtractJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractJobCreatePriority?), TypeInfoPropertyName = "NullableExtractJobCreatePriority2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, string, object>?), TypeInfoPropertyName = "NullableAnyOfObjectStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::System.Collections.Generic.IList<object>, object>?), TypeInfoPropertyName = "NullableAnyOfObjectIListObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractState?), TypeInfoPropertyName = "NullableExtractState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item?), TypeInfoPropertyName = "NullableWebhookConfigurationWebhookEventsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.WebhookConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::System.Collections.Generic.List<object>, string, int?, double?, bool?, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ExtractAgent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::System.Collections.Generic.List<object>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ExtractRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ExtractJob>))]
    internal sealed partial class LlamaExtractSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LlamaExtractSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static LlamaExtractSourceGenerationContext Default { get; } = new(DefaultOptions);

        private LlamaExtractSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.ExtractModels?, string, object>());
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
                    typeToConvert == typeof(global::LlamaParse.DocumentChunkMode)

                    || typeToConvert == typeof(global::LlamaParse.DocumentChunkMode?)

                    || typeToConvert == typeof(global::LlamaParse.ExtractConfigPriority)

                    || typeToConvert == typeof(global::LlamaParse.ExtractConfigPriority?)

                    || typeToConvert == typeof(global::LlamaParse.ExtractJobStatus)

                    || typeToConvert == typeof(global::LlamaParse.ExtractJobStatus?)

                    || typeToConvert == typeof(global::LlamaParse.ExtractJobCreatePriority)

                    || typeToConvert == typeof(global::LlamaParse.ExtractJobCreatePriority?)

                    || typeToConvert == typeof(global::LlamaParse.ExtractMode)

                    || typeToConvert == typeof(global::LlamaParse.ExtractMode?)

                    || typeToConvert == typeof(global::LlamaParse.ExtractModels)

                    || typeToConvert == typeof(global::LlamaParse.ExtractModels?)

                    || typeToConvert == typeof(global::LlamaParse.ExtractState)

                    || typeToConvert == typeof(global::LlamaParse.ExtractState?)

                    || typeToConvert == typeof(global::LlamaParse.ExtractTarget)

                    || typeToConvert == typeof(global::LlamaParse.ExtractTarget?)

                    || typeToConvert == typeof(global::LlamaParse.PublicModelName)

                    || typeToConvert == typeof(global::LlamaParse.PublicModelName?)

                    || typeToConvert == typeof(global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item)

                    || typeToConvert == typeof(global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::LlamaParse.DocumentChunkMode))
                {
                    return new global::LlamaParse.JsonConverters.DocumentChunkModeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.DocumentChunkMode?))
                {
                    return new global::LlamaParse.JsonConverters.DocumentChunkModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ExtractConfigPriority))
                {
                    return new global::LlamaParse.JsonConverters.ExtractConfigPriorityJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ExtractConfigPriority?))
                {
                    return new global::LlamaParse.JsonConverters.ExtractConfigPriorityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ExtractJobStatus))
                {
                    return new global::LlamaParse.JsonConverters.ExtractJobStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ExtractJobStatus?))
                {
                    return new global::LlamaParse.JsonConverters.ExtractJobStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ExtractJobCreatePriority))
                {
                    return new global::LlamaParse.JsonConverters.ExtractJobCreatePriorityJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ExtractJobCreatePriority?))
                {
                    return new global::LlamaParse.JsonConverters.ExtractJobCreatePriorityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ExtractMode))
                {
                    return new global::LlamaParse.JsonConverters.ExtractModeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ExtractMode?))
                {
                    return new global::LlamaParse.JsonConverters.ExtractModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ExtractModels))
                {
                    return new global::LlamaParse.JsonConverters.ExtractModelsJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ExtractModels?))
                {
                    return new global::LlamaParse.JsonConverters.ExtractModelsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ExtractState))
                {
                    return new global::LlamaParse.JsonConverters.ExtractStateJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ExtractState?))
                {
                    return new global::LlamaParse.JsonConverters.ExtractStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ExtractTarget))
                {
                    return new global::LlamaParse.JsonConverters.ExtractTargetJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ExtractTarget?))
                {
                    return new global::LlamaParse.JsonConverters.ExtractTargetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.PublicModelName))
                {
                    return new global::LlamaParse.JsonConverters.PublicModelNameJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.PublicModelName?))
                {
                    return new global::LlamaParse.JsonConverters.PublicModelNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item))
                {
                    return new global::LlamaParse.JsonConverters.WebhookConfigurationWebhookEventsVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item?))
                {
                    return new global::LlamaParse.JsonConverters.WebhookConfigurationWebhookEventsVariant1ItemNullableJsonConverter();
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
                    0 => new LlamaExtractSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}