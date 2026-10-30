#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LlamaParse
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct EmbeddingConfigVariant13 : global::System.IEquatable<EmbeddingConfigVariant13>
    {
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineListItemEmbeddingConfigVariant1DiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LlamaParse.ManagedOpenAIEmbeddingConfig? ManagedOpenaiEmbedding { get; init; }
#else
        public global::LlamaParse.ManagedOpenAIEmbeddingConfig? ManagedOpenaiEmbedding { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ManagedOpenaiEmbedding))]
#endif
        public bool IsManagedOpenaiEmbedding => ManagedOpenaiEmbedding != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickManagedOpenaiEmbedding(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LlamaParse.ManagedOpenAIEmbeddingConfig? value)
        {
            value = ManagedOpenaiEmbedding;
            return IsManagedOpenaiEmbedding;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ManagedOpenAIEmbeddingConfig PickManagedOpenaiEmbedding() => ManagedOpenaiEmbedding is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ManagedOpenaiEmbedding' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LlamaParse.AzureOpenAIEmbeddingConfig? AzureEmbedding { get; init; }
#else
        public global::LlamaParse.AzureOpenAIEmbeddingConfig? AzureEmbedding { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AzureEmbedding))]
#endif
        public bool IsAzureEmbedding => AzureEmbedding != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAzureEmbedding(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LlamaParse.AzureOpenAIEmbeddingConfig? value)
        {
            value = AzureEmbedding;
            return IsAzureEmbedding;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AzureOpenAIEmbeddingConfig PickAzureEmbedding() => AzureEmbedding is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AzureEmbedding' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LlamaParse.CohereEmbeddingConfig? CohereEmbedding { get; init; }
#else
        public global::LlamaParse.CohereEmbeddingConfig? CohereEmbedding { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CohereEmbedding))]
#endif
        public bool IsCohereEmbedding => CohereEmbedding != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCohereEmbedding(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LlamaParse.CohereEmbeddingConfig? value)
        {
            value = CohereEmbedding;
            return IsCohereEmbedding;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CohereEmbeddingConfig PickCohereEmbedding() => CohereEmbedding is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CohereEmbedding' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LlamaParse.GeminiEmbeddingConfig? GeminiEmbedding { get; init; }
#else
        public global::LlamaParse.GeminiEmbeddingConfig? GeminiEmbedding { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GeminiEmbedding))]
#endif
        public bool IsGeminiEmbedding => GeminiEmbedding != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGeminiEmbedding(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LlamaParse.GeminiEmbeddingConfig? value)
        {
            value = GeminiEmbedding;
            return IsGeminiEmbedding;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.GeminiEmbeddingConfig PickGeminiEmbedding() => GeminiEmbedding is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GeminiEmbedding' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LlamaParse.HuggingFaceInferenceAPIEmbeddingConfig? HuggingfaceApiEmbedding { get; init; }
#else
        public global::LlamaParse.HuggingFaceInferenceAPIEmbeddingConfig? HuggingfaceApiEmbedding { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(HuggingfaceApiEmbedding))]
#endif
        public bool IsHuggingfaceApiEmbedding => HuggingfaceApiEmbedding != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickHuggingfaceApiEmbedding(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LlamaParse.HuggingFaceInferenceAPIEmbeddingConfig? value)
        {
            value = HuggingfaceApiEmbedding;
            return IsHuggingfaceApiEmbedding;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.HuggingFaceInferenceAPIEmbeddingConfig PickHuggingfaceApiEmbedding() => HuggingfaceApiEmbedding is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'HuggingfaceApiEmbedding' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LlamaParse.OpenAIEmbeddingConfig? OpenaiEmbedding { get; init; }
#else
        public global::LlamaParse.OpenAIEmbeddingConfig? OpenaiEmbedding { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenaiEmbedding))]
#endif
        public bool IsOpenaiEmbedding => OpenaiEmbedding != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenaiEmbedding(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LlamaParse.OpenAIEmbeddingConfig? value)
        {
            value = OpenaiEmbedding;
            return IsOpenaiEmbedding;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.OpenAIEmbeddingConfig PickOpenaiEmbedding() => OpenaiEmbedding is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenaiEmbedding' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LlamaParse.VertexAIEmbeddingConfig? VertexaiEmbedding { get; init; }
#else
        public global::LlamaParse.VertexAIEmbeddingConfig? VertexaiEmbedding { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VertexaiEmbedding))]
#endif
        public bool IsVertexaiEmbedding => VertexaiEmbedding != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickVertexaiEmbedding(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LlamaParse.VertexAIEmbeddingConfig? value)
        {
            value = VertexaiEmbedding;
            return IsVertexaiEmbedding;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VertexAIEmbeddingConfig PickVertexaiEmbedding() => VertexaiEmbedding is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'VertexaiEmbedding' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LlamaParse.BedrockEmbeddingConfig? BedrockEmbedding { get; init; }
#else
        public global::LlamaParse.BedrockEmbeddingConfig? BedrockEmbedding { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BedrockEmbedding))]
#endif
        public bool IsBedrockEmbedding => BedrockEmbedding != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBedrockEmbedding(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LlamaParse.BedrockEmbeddingConfig? value)
        {
            value = BedrockEmbedding;
            return IsBedrockEmbedding;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BedrockEmbeddingConfig PickBedrockEmbedding() => BedrockEmbedding is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BedrockEmbedding' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator EmbeddingConfigVariant13(global::LlamaParse.ManagedOpenAIEmbeddingConfig value) => new EmbeddingConfigVariant13((global::LlamaParse.ManagedOpenAIEmbeddingConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LlamaParse.ManagedOpenAIEmbeddingConfig?(EmbeddingConfigVariant13 @this) => @this.ManagedOpenaiEmbedding;

        /// <summary>
        ///
        /// </summary>
        public EmbeddingConfigVariant13(global::LlamaParse.ManagedOpenAIEmbeddingConfig? value)
        {
            ManagedOpenaiEmbedding = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EmbeddingConfigVariant13 FromManagedOpenaiEmbedding(global::LlamaParse.ManagedOpenAIEmbeddingConfig? value) => new EmbeddingConfigVariant13(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EmbeddingConfigVariant13(global::LlamaParse.AzureOpenAIEmbeddingConfig value) => new EmbeddingConfigVariant13((global::LlamaParse.AzureOpenAIEmbeddingConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LlamaParse.AzureOpenAIEmbeddingConfig?(EmbeddingConfigVariant13 @this) => @this.AzureEmbedding;

        /// <summary>
        ///
        /// </summary>
        public EmbeddingConfigVariant13(global::LlamaParse.AzureOpenAIEmbeddingConfig? value)
        {
            AzureEmbedding = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EmbeddingConfigVariant13 FromAzureEmbedding(global::LlamaParse.AzureOpenAIEmbeddingConfig? value) => new EmbeddingConfigVariant13(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EmbeddingConfigVariant13(global::LlamaParse.CohereEmbeddingConfig value) => new EmbeddingConfigVariant13((global::LlamaParse.CohereEmbeddingConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LlamaParse.CohereEmbeddingConfig?(EmbeddingConfigVariant13 @this) => @this.CohereEmbedding;

        /// <summary>
        ///
        /// </summary>
        public EmbeddingConfigVariant13(global::LlamaParse.CohereEmbeddingConfig? value)
        {
            CohereEmbedding = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EmbeddingConfigVariant13 FromCohereEmbedding(global::LlamaParse.CohereEmbeddingConfig? value) => new EmbeddingConfigVariant13(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EmbeddingConfigVariant13(global::LlamaParse.GeminiEmbeddingConfig value) => new EmbeddingConfigVariant13((global::LlamaParse.GeminiEmbeddingConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LlamaParse.GeminiEmbeddingConfig?(EmbeddingConfigVariant13 @this) => @this.GeminiEmbedding;

        /// <summary>
        ///
        /// </summary>
        public EmbeddingConfigVariant13(global::LlamaParse.GeminiEmbeddingConfig? value)
        {
            GeminiEmbedding = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EmbeddingConfigVariant13 FromGeminiEmbedding(global::LlamaParse.GeminiEmbeddingConfig? value) => new EmbeddingConfigVariant13(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EmbeddingConfigVariant13(global::LlamaParse.HuggingFaceInferenceAPIEmbeddingConfig value) => new EmbeddingConfigVariant13((global::LlamaParse.HuggingFaceInferenceAPIEmbeddingConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LlamaParse.HuggingFaceInferenceAPIEmbeddingConfig?(EmbeddingConfigVariant13 @this) => @this.HuggingfaceApiEmbedding;

        /// <summary>
        ///
        /// </summary>
        public EmbeddingConfigVariant13(global::LlamaParse.HuggingFaceInferenceAPIEmbeddingConfig? value)
        {
            HuggingfaceApiEmbedding = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EmbeddingConfigVariant13 FromHuggingfaceApiEmbedding(global::LlamaParse.HuggingFaceInferenceAPIEmbeddingConfig? value) => new EmbeddingConfigVariant13(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EmbeddingConfigVariant13(global::LlamaParse.OpenAIEmbeddingConfig value) => new EmbeddingConfigVariant13((global::LlamaParse.OpenAIEmbeddingConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LlamaParse.OpenAIEmbeddingConfig?(EmbeddingConfigVariant13 @this) => @this.OpenaiEmbedding;

        /// <summary>
        ///
        /// </summary>
        public EmbeddingConfigVariant13(global::LlamaParse.OpenAIEmbeddingConfig? value)
        {
            OpenaiEmbedding = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EmbeddingConfigVariant13 FromOpenaiEmbedding(global::LlamaParse.OpenAIEmbeddingConfig? value) => new EmbeddingConfigVariant13(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EmbeddingConfigVariant13(global::LlamaParse.VertexAIEmbeddingConfig value) => new EmbeddingConfigVariant13((global::LlamaParse.VertexAIEmbeddingConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LlamaParse.VertexAIEmbeddingConfig?(EmbeddingConfigVariant13 @this) => @this.VertexaiEmbedding;

        /// <summary>
        ///
        /// </summary>
        public EmbeddingConfigVariant13(global::LlamaParse.VertexAIEmbeddingConfig? value)
        {
            VertexaiEmbedding = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EmbeddingConfigVariant13 FromVertexaiEmbedding(global::LlamaParse.VertexAIEmbeddingConfig? value) => new EmbeddingConfigVariant13(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EmbeddingConfigVariant13(global::LlamaParse.BedrockEmbeddingConfig value) => new EmbeddingConfigVariant13((global::LlamaParse.BedrockEmbeddingConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LlamaParse.BedrockEmbeddingConfig?(EmbeddingConfigVariant13 @this) => @this.BedrockEmbedding;

        /// <summary>
        ///
        /// </summary>
        public EmbeddingConfigVariant13(global::LlamaParse.BedrockEmbeddingConfig? value)
        {
            BedrockEmbedding = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EmbeddingConfigVariant13 FromBedrockEmbedding(global::LlamaParse.BedrockEmbeddingConfig? value) => new EmbeddingConfigVariant13(value);

        /// <summary>
        ///
        /// </summary>
        public EmbeddingConfigVariant13(
            global::LlamaParse.PipelineListItemEmbeddingConfigVariant1DiscriminatorType? type,
            global::LlamaParse.ManagedOpenAIEmbeddingConfig? managedOpenaiEmbedding,
            global::LlamaParse.AzureOpenAIEmbeddingConfig? azureEmbedding,
            global::LlamaParse.CohereEmbeddingConfig? cohereEmbedding,
            global::LlamaParse.GeminiEmbeddingConfig? geminiEmbedding,
            global::LlamaParse.HuggingFaceInferenceAPIEmbeddingConfig? huggingfaceApiEmbedding,
            global::LlamaParse.OpenAIEmbeddingConfig? openaiEmbedding,
            global::LlamaParse.VertexAIEmbeddingConfig? vertexaiEmbedding,
            global::LlamaParse.BedrockEmbeddingConfig? bedrockEmbedding
            )
        {
            Type = type;

            ManagedOpenaiEmbedding = managedOpenaiEmbedding;
            AzureEmbedding = azureEmbedding;
            CohereEmbedding = cohereEmbedding;
            GeminiEmbedding = geminiEmbedding;
            HuggingfaceApiEmbedding = huggingfaceApiEmbedding;
            OpenaiEmbedding = openaiEmbedding;
            VertexaiEmbedding = vertexaiEmbedding;
            BedrockEmbedding = bedrockEmbedding;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            BedrockEmbedding as object ??
            VertexaiEmbedding as object ??
            OpenaiEmbedding as object ??
            HuggingfaceApiEmbedding as object ??
            GeminiEmbedding as object ??
            CohereEmbedding as object ??
            AzureEmbedding as object ??
            ManagedOpenaiEmbedding as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ManagedOpenaiEmbedding?.ToString() ??
            AzureEmbedding?.ToString() ??
            CohereEmbedding?.ToString() ??
            GeminiEmbedding?.ToString() ??
            HuggingfaceApiEmbedding?.ToString() ??
            OpenaiEmbedding?.ToString() ??
            VertexaiEmbedding?.ToString() ??
            BedrockEmbedding?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsManagedOpenaiEmbedding && !IsAzureEmbedding && !IsCohereEmbedding && !IsGeminiEmbedding && !IsHuggingfaceApiEmbedding && !IsOpenaiEmbedding && !IsVertexaiEmbedding && !IsBedrockEmbedding || !IsManagedOpenaiEmbedding && IsAzureEmbedding && !IsCohereEmbedding && !IsGeminiEmbedding && !IsHuggingfaceApiEmbedding && !IsOpenaiEmbedding && !IsVertexaiEmbedding && !IsBedrockEmbedding || !IsManagedOpenaiEmbedding && !IsAzureEmbedding && IsCohereEmbedding && !IsGeminiEmbedding && !IsHuggingfaceApiEmbedding && !IsOpenaiEmbedding && !IsVertexaiEmbedding && !IsBedrockEmbedding || !IsManagedOpenaiEmbedding && !IsAzureEmbedding && !IsCohereEmbedding && IsGeminiEmbedding && !IsHuggingfaceApiEmbedding && !IsOpenaiEmbedding && !IsVertexaiEmbedding && !IsBedrockEmbedding || !IsManagedOpenaiEmbedding && !IsAzureEmbedding && !IsCohereEmbedding && !IsGeminiEmbedding && IsHuggingfaceApiEmbedding && !IsOpenaiEmbedding && !IsVertexaiEmbedding && !IsBedrockEmbedding || !IsManagedOpenaiEmbedding && !IsAzureEmbedding && !IsCohereEmbedding && !IsGeminiEmbedding && !IsHuggingfaceApiEmbedding && IsOpenaiEmbedding && !IsVertexaiEmbedding && !IsBedrockEmbedding || !IsManagedOpenaiEmbedding && !IsAzureEmbedding && !IsCohereEmbedding && !IsGeminiEmbedding && !IsHuggingfaceApiEmbedding && !IsOpenaiEmbedding && IsVertexaiEmbedding && !IsBedrockEmbedding || !IsManagedOpenaiEmbedding && !IsAzureEmbedding && !IsCohereEmbedding && !IsGeminiEmbedding && !IsHuggingfaceApiEmbedding && !IsOpenaiEmbedding && !IsVertexaiEmbedding && IsBedrockEmbedding;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::LlamaParse.ManagedOpenAIEmbeddingConfig, TResult>? managedOpenaiEmbedding = null,
            global::System.Func<global::LlamaParse.AzureOpenAIEmbeddingConfig, TResult>? azureEmbedding = null,
            global::System.Func<global::LlamaParse.CohereEmbeddingConfig, TResult>? cohereEmbedding = null,
            global::System.Func<global::LlamaParse.GeminiEmbeddingConfig, TResult>? geminiEmbedding = null,
            global::System.Func<global::LlamaParse.HuggingFaceInferenceAPIEmbeddingConfig, TResult>? huggingfaceApiEmbedding = null,
            global::System.Func<global::LlamaParse.OpenAIEmbeddingConfig, TResult>? openaiEmbedding = null,
            global::System.Func<global::LlamaParse.VertexAIEmbeddingConfig, TResult>? vertexaiEmbedding = null,
            global::System.Func<global::LlamaParse.BedrockEmbeddingConfig, TResult>? bedrockEmbedding = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ManagedOpenaiEmbedding is { } __value0 && managedOpenaiEmbedding != null)
            {
                return managedOpenaiEmbedding(__value0);
            }
            else if (AzureEmbedding is { } __value1 && azureEmbedding != null)
            {
                return azureEmbedding(__value1);
            }
            else if (CohereEmbedding is { } __value2 && cohereEmbedding != null)
            {
                return cohereEmbedding(__value2);
            }
            else if (GeminiEmbedding is { } __value3 && geminiEmbedding != null)
            {
                return geminiEmbedding(__value3);
            }
            else if (HuggingfaceApiEmbedding is { } __value4 && huggingfaceApiEmbedding != null)
            {
                return huggingfaceApiEmbedding(__value4);
            }
            else if (OpenaiEmbedding is { } __value5 && openaiEmbedding != null)
            {
                return openaiEmbedding(__value5);
            }
            else if (VertexaiEmbedding is { } __value6 && vertexaiEmbedding != null)
            {
                return vertexaiEmbedding(__value6);
            }
            else if (BedrockEmbedding is { } __value7 && bedrockEmbedding != null)
            {
                return bedrockEmbedding(__value7);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::LlamaParse.ManagedOpenAIEmbeddingConfig>? managedOpenaiEmbedding = null,

            global::System.Action<global::LlamaParse.AzureOpenAIEmbeddingConfig>? azureEmbedding = null,

            global::System.Action<global::LlamaParse.CohereEmbeddingConfig>? cohereEmbedding = null,

            global::System.Action<global::LlamaParse.GeminiEmbeddingConfig>? geminiEmbedding = null,

            global::System.Action<global::LlamaParse.HuggingFaceInferenceAPIEmbeddingConfig>? huggingfaceApiEmbedding = null,

            global::System.Action<global::LlamaParse.OpenAIEmbeddingConfig>? openaiEmbedding = null,

            global::System.Action<global::LlamaParse.VertexAIEmbeddingConfig>? vertexaiEmbedding = null,

            global::System.Action<global::LlamaParse.BedrockEmbeddingConfig>? bedrockEmbedding = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ManagedOpenaiEmbedding is { } __value0)
            {
                managedOpenaiEmbedding?.Invoke(__value0);
            }
            else if (AzureEmbedding is { } __value1)
            {
                azureEmbedding?.Invoke(__value1);
            }
            else if (CohereEmbedding is { } __value2)
            {
                cohereEmbedding?.Invoke(__value2);
            }
            else if (GeminiEmbedding is { } __value3)
            {
                geminiEmbedding?.Invoke(__value3);
            }
            else if (HuggingfaceApiEmbedding is { } __value4)
            {
                huggingfaceApiEmbedding?.Invoke(__value4);
            }
            else if (OpenaiEmbedding is { } __value5)
            {
                openaiEmbedding?.Invoke(__value5);
            }
            else if (VertexaiEmbedding is { } __value6)
            {
                vertexaiEmbedding?.Invoke(__value6);
            }
            else if (BedrockEmbedding is { } __value7)
            {
                bedrockEmbedding?.Invoke(__value7);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::LlamaParse.ManagedOpenAIEmbeddingConfig>? managedOpenaiEmbedding = null,
            global::System.Action<global::LlamaParse.AzureOpenAIEmbeddingConfig>? azureEmbedding = null,
            global::System.Action<global::LlamaParse.CohereEmbeddingConfig>? cohereEmbedding = null,
            global::System.Action<global::LlamaParse.GeminiEmbeddingConfig>? geminiEmbedding = null,
            global::System.Action<global::LlamaParse.HuggingFaceInferenceAPIEmbeddingConfig>? huggingfaceApiEmbedding = null,
            global::System.Action<global::LlamaParse.OpenAIEmbeddingConfig>? openaiEmbedding = null,
            global::System.Action<global::LlamaParse.VertexAIEmbeddingConfig>? vertexaiEmbedding = null,
            global::System.Action<global::LlamaParse.BedrockEmbeddingConfig>? bedrockEmbedding = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ManagedOpenaiEmbedding is { } __value0)
            {
                managedOpenaiEmbedding?.Invoke(__value0);
            }
            else if (AzureEmbedding is { } __value1)
            {
                azureEmbedding?.Invoke(__value1);
            }
            else if (CohereEmbedding is { } __value2)
            {
                cohereEmbedding?.Invoke(__value2);
            }
            else if (GeminiEmbedding is { } __value3)
            {
                geminiEmbedding?.Invoke(__value3);
            }
            else if (HuggingfaceApiEmbedding is { } __value4)
            {
                huggingfaceApiEmbedding?.Invoke(__value4);
            }
            else if (OpenaiEmbedding is { } __value5)
            {
                openaiEmbedding?.Invoke(__value5);
            }
            else if (VertexaiEmbedding is { } __value6)
            {
                vertexaiEmbedding?.Invoke(__value6);
            }
            else if (BedrockEmbedding is { } __value7)
            {
                bedrockEmbedding?.Invoke(__value7);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ManagedOpenaiEmbedding,
                typeof(global::LlamaParse.ManagedOpenAIEmbeddingConfig),
                AzureEmbedding,
                typeof(global::LlamaParse.AzureOpenAIEmbeddingConfig),
                CohereEmbedding,
                typeof(global::LlamaParse.CohereEmbeddingConfig),
                GeminiEmbedding,
                typeof(global::LlamaParse.GeminiEmbeddingConfig),
                HuggingfaceApiEmbedding,
                typeof(global::LlamaParse.HuggingFaceInferenceAPIEmbeddingConfig),
                OpenaiEmbedding,
                typeof(global::LlamaParse.OpenAIEmbeddingConfig),
                VertexaiEmbedding,
                typeof(global::LlamaParse.VertexAIEmbeddingConfig),
                BedrockEmbedding,
                typeof(global::LlamaParse.BedrockEmbeddingConfig),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(EmbeddingConfigVariant13 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::LlamaParse.ManagedOpenAIEmbeddingConfig?>.Default.Equals(ManagedOpenaiEmbedding, other.ManagedOpenaiEmbedding) &&
                global::System.Collections.Generic.EqualityComparer<global::LlamaParse.AzureOpenAIEmbeddingConfig?>.Default.Equals(AzureEmbedding, other.AzureEmbedding) &&
                global::System.Collections.Generic.EqualityComparer<global::LlamaParse.CohereEmbeddingConfig?>.Default.Equals(CohereEmbedding, other.CohereEmbedding) &&
                global::System.Collections.Generic.EqualityComparer<global::LlamaParse.GeminiEmbeddingConfig?>.Default.Equals(GeminiEmbedding, other.GeminiEmbedding) &&
                global::System.Collections.Generic.EqualityComparer<global::LlamaParse.HuggingFaceInferenceAPIEmbeddingConfig?>.Default.Equals(HuggingfaceApiEmbedding, other.HuggingfaceApiEmbedding) &&
                global::System.Collections.Generic.EqualityComparer<global::LlamaParse.OpenAIEmbeddingConfig?>.Default.Equals(OpenaiEmbedding, other.OpenaiEmbedding) &&
                global::System.Collections.Generic.EqualityComparer<global::LlamaParse.VertexAIEmbeddingConfig?>.Default.Equals(VertexaiEmbedding, other.VertexaiEmbedding) &&
                global::System.Collections.Generic.EqualityComparer<global::LlamaParse.BedrockEmbeddingConfig?>.Default.Equals(BedrockEmbedding, other.BedrockEmbedding)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(EmbeddingConfigVariant13 obj1, EmbeddingConfigVariant13 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EmbeddingConfigVariant13>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(EmbeddingConfigVariant13 obj1, EmbeddingConfigVariant13 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EmbeddingConfigVariant13 o && Equals(o);
        }
    }
}
