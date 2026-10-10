
#nullable enable

namespace LlamaParse
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.WebhookConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<string, global::System.Guid?>), TypeInfoPropertyName = "AnyOfStringGuid2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.VerifyCompositeScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.VerifyCompositeScores))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.VerifyConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.VerifyConfigurationTier), TypeInfoPropertyName = "VerifyConfigurationTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.VerifyDegradedTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.VerifyEvidence))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.VerifyHeatmap))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.VerifyJobDetailsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.VerifyRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.VerifyRegion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.VerifyEvidence>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.VerifyDegradedTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.VerifyHeatmap>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.VerifyPageDimension>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.VerifyPageDimension))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.VerifyJobQueryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.VerifyJobResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.VerifyJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.VerifyJobResponseStatus), TypeInfoPropertyName = "VerifyJobResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.VerifyJobResponseDocumentInputType), TypeInfoPropertyName = "VerifyJobResponseDocumentInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.VerifyResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.VerifyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.VerifyResultVerdict), TypeInfoPropertyName = "VerifyResultVerdict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.VerifySuspectRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.VerifySuspectRegion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item), TypeInfoPropertyName = "WebhookConfigurationWebhookEventsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListVerifyJobsApiAlphaVerifyGetStatus), TypeInfoPropertyName = "ListVerifyJobsApiAlphaVerifyGetStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<string, global::System.Guid?>?), TypeInfoPropertyName = "NullableAnyOfStringGuid2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.VerifyConfigurationTier?), TypeInfoPropertyName = "NullableVerifyConfigurationTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.VerifyJobResponseStatus?), TypeInfoPropertyName = "NullableVerifyJobResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.VerifyJobResponseDocumentInputType?), TypeInfoPropertyName = "NullableVerifyJobResponseDocumentInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.VerifyResultVerdict?), TypeInfoPropertyName = "NullableVerifyResultVerdict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item?), TypeInfoPropertyName = "NullableWebhookConfigurationWebhookEventsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListVerifyJobsApiAlphaVerifyGetStatus?), TypeInfoPropertyName = "NullableListVerifyJobsApiAlphaVerifyGetStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.WebhookConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.VerifyRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.VerifyEvidence>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.VerifyDegradedTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.VerifyHeatmap>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.VerifyPageDimension>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.VerifyJobResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.VerifySuspectRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item>))]
    internal sealed partial class AlphaSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AlphaSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AlphaSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AlphaSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, string>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, string>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, string>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, string>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, string>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, string>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, string>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, double?, string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<int>>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, double?, global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<int?, double?>>>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, double?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, int?, double?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, int?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, int?, bool?, double?, global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?, bool?, double?>>>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, int?, bool?, double?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
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
                    typeToConvert == typeof(global::LlamaParse.VerifyConfigurationTier)

                    || typeToConvert == typeof(global::LlamaParse.VerifyConfigurationTier?)

                    || typeToConvert == typeof(global::LlamaParse.VerifyJobResponseStatus)

                    || typeToConvert == typeof(global::LlamaParse.VerifyJobResponseStatus?)

                    || typeToConvert == typeof(global::LlamaParse.VerifyJobResponseDocumentInputType)

                    || typeToConvert == typeof(global::LlamaParse.VerifyJobResponseDocumentInputType?)

                    || typeToConvert == typeof(global::LlamaParse.VerifyResultVerdict)

                    || typeToConvert == typeof(global::LlamaParse.VerifyResultVerdict?)

                    || typeToConvert == typeof(global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item)

                    || typeToConvert == typeof(global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item?)

                    || typeToConvert == typeof(global::LlamaParse.ListVerifyJobsApiAlphaVerifyGetStatus)

                    || typeToConvert == typeof(global::LlamaParse.ListVerifyJobsApiAlphaVerifyGetStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::LlamaParse.VerifyConfigurationTier))
                {
                    return new global::LlamaParse.JsonConverters.VerifyConfigurationTierJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.VerifyConfigurationTier?))
                {
                    return new global::LlamaParse.JsonConverters.VerifyConfigurationTierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.VerifyJobResponseStatus))
                {
                    return new global::LlamaParse.JsonConverters.VerifyJobResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.VerifyJobResponseStatus?))
                {
                    return new global::LlamaParse.JsonConverters.VerifyJobResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.VerifyJobResponseDocumentInputType))
                {
                    return new global::LlamaParse.JsonConverters.VerifyJobResponseDocumentInputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.VerifyJobResponseDocumentInputType?))
                {
                    return new global::LlamaParse.JsonConverters.VerifyJobResponseDocumentInputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.VerifyResultVerdict))
                {
                    return new global::LlamaParse.JsonConverters.VerifyResultVerdictJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.VerifyResultVerdict?))
                {
                    return new global::LlamaParse.JsonConverters.VerifyResultVerdictNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item))
                {
                    return new global::LlamaParse.JsonConverters.WebhookConfigurationWebhookEventsVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item?))
                {
                    return new global::LlamaParse.JsonConverters.WebhookConfigurationWebhookEventsVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ListVerifyJobsApiAlphaVerifyGetStatus))
                {
                    return new global::LlamaParse.JsonConverters.ListVerifyJobsApiAlphaVerifyGetStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ListVerifyJobsApiAlphaVerifyGetStatus?))
                {
                    return new global::LlamaParse.JsonConverters.ListVerifyJobsApiAlphaVerifyGetStatusNullableJsonConverter();
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
                    0 => new AlphaSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}