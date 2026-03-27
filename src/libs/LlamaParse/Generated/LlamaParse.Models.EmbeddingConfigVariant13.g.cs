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
        public global::LlamaParse.PipelineUpdateEmbeddingConfigVariant1DiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LlamaParse.AzureOpenAIEmbeddingConfig? AzureEmbedding1 { get; init; }
#else
        public global::LlamaParse.AzureOpenAIEmbeddingConfig? AzureEmbedding1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AzureEmbedding1))]
#endif
        public bool IsAzureEmbedding1 => AzureEmbedding1 != null;

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
#if NET6_0_OR_GREATER
        public global::LlamaParse.OpenAIEmbeddingConfig? AzureEmbedding2 { get; init; }
#else
        public global::LlamaParse.OpenAIEmbeddingConfig? AzureEmbedding2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AzureEmbedding2))]
#endif
        public bool IsAzureEmbedding2 => AzureEmbedding2 != null;

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
        public static implicit operator EmbeddingConfigVariant13(global::LlamaParse.AzureOpenAIEmbeddingConfig value) => new EmbeddingConfigVariant13((global::LlamaParse.AzureOpenAIEmbeddingConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LlamaParse.AzureOpenAIEmbeddingConfig?(EmbeddingConfigVariant13 @this) => @this.AzureEmbedding1;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingConfigVariant13(global::LlamaParse.AzureOpenAIEmbeddingConfig? value)
        {
            AzureEmbedding1 = value;
        }

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
        public static implicit operator EmbeddingConfigVariant13(global::LlamaParse.OpenAIEmbeddingConfig value) => new EmbeddingConfigVariant13((global::LlamaParse.OpenAIEmbeddingConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LlamaParse.OpenAIEmbeddingConfig?(EmbeddingConfigVariant13 @this) => @this.AzureEmbedding2;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingConfigVariant13(global::LlamaParse.OpenAIEmbeddingConfig? value)
        {
            AzureEmbedding2 = value;
        }

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
        public EmbeddingConfigVariant13(
            global::LlamaParse.PipelineUpdateEmbeddingConfigVariant1DiscriminatorType? type,
            global::LlamaParse.AzureOpenAIEmbeddingConfig? azureEmbedding1,
            global::LlamaParse.CohereEmbeddingConfig? cohereEmbedding,
            global::LlamaParse.GeminiEmbeddingConfig? geminiEmbedding,
            global::LlamaParse.HuggingFaceInferenceAPIEmbeddingConfig? huggingfaceApiEmbedding,
            global::LlamaParse.OpenAIEmbeddingConfig? azureEmbedding2,
            global::LlamaParse.VertexAIEmbeddingConfig? vertexaiEmbedding,
            global::LlamaParse.BedrockEmbeddingConfig? bedrockEmbedding
            )
        {
            Type = type;

            AzureEmbedding1 = azureEmbedding1;
            CohereEmbedding = cohereEmbedding;
            GeminiEmbedding = geminiEmbedding;
            HuggingfaceApiEmbedding = huggingfaceApiEmbedding;
            AzureEmbedding2 = azureEmbedding2;
            VertexaiEmbedding = vertexaiEmbedding;
            BedrockEmbedding = bedrockEmbedding;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            BedrockEmbedding as object ??
            VertexaiEmbedding as object ??
            AzureEmbedding2 as object ??
            HuggingfaceApiEmbedding as object ??
            GeminiEmbedding as object ??
            CohereEmbedding as object ??
            AzureEmbedding1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AzureEmbedding1?.ToString() ??
            CohereEmbedding?.ToString() ??
            GeminiEmbedding?.ToString() ??
            HuggingfaceApiEmbedding?.ToString() ??
            AzureEmbedding2?.ToString() ??
            VertexaiEmbedding?.ToString() ??
            BedrockEmbedding?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAzureEmbedding1 && !IsCohereEmbedding && !IsGeminiEmbedding && !IsHuggingfaceApiEmbedding && !IsAzureEmbedding2 && !IsVertexaiEmbedding && !IsBedrockEmbedding || !IsAzureEmbedding1 && IsCohereEmbedding && !IsGeminiEmbedding && !IsHuggingfaceApiEmbedding && !IsAzureEmbedding2 && !IsVertexaiEmbedding && !IsBedrockEmbedding || !IsAzureEmbedding1 && !IsCohereEmbedding && IsGeminiEmbedding && !IsHuggingfaceApiEmbedding && !IsAzureEmbedding2 && !IsVertexaiEmbedding && !IsBedrockEmbedding || !IsAzureEmbedding1 && !IsCohereEmbedding && !IsGeminiEmbedding && IsHuggingfaceApiEmbedding && !IsAzureEmbedding2 && !IsVertexaiEmbedding && !IsBedrockEmbedding || !IsAzureEmbedding1 && !IsCohereEmbedding && !IsGeminiEmbedding && !IsHuggingfaceApiEmbedding && IsAzureEmbedding2 && !IsVertexaiEmbedding && !IsBedrockEmbedding || !IsAzureEmbedding1 && !IsCohereEmbedding && !IsGeminiEmbedding && !IsHuggingfaceApiEmbedding && !IsAzureEmbedding2 && IsVertexaiEmbedding && !IsBedrockEmbedding || !IsAzureEmbedding1 && !IsCohereEmbedding && !IsGeminiEmbedding && !IsHuggingfaceApiEmbedding && !IsAzureEmbedding2 && !IsVertexaiEmbedding && IsBedrockEmbedding;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::LlamaParse.AzureOpenAIEmbeddingConfig?, TResult>? azureEmbedding1 = null,
            global::System.Func<global::LlamaParse.CohereEmbeddingConfig?, TResult>? cohereEmbedding = null,
            global::System.Func<global::LlamaParse.GeminiEmbeddingConfig?, TResult>? geminiEmbedding = null,
            global::System.Func<global::LlamaParse.HuggingFaceInferenceAPIEmbeddingConfig?, TResult>? huggingfaceApiEmbedding = null,
            global::System.Func<global::LlamaParse.OpenAIEmbeddingConfig?, TResult>? azureEmbedding2 = null,
            global::System.Func<global::LlamaParse.VertexAIEmbeddingConfig?, TResult>? vertexaiEmbedding = null,
            global::System.Func<global::LlamaParse.BedrockEmbeddingConfig?, TResult>? bedrockEmbedding = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAzureEmbedding1 && azureEmbedding1 != null)
            {
                return azureEmbedding1(AzureEmbedding1!);
            }
            else if (IsCohereEmbedding && cohereEmbedding != null)
            {
                return cohereEmbedding(CohereEmbedding!);
            }
            else if (IsGeminiEmbedding && geminiEmbedding != null)
            {
                return geminiEmbedding(GeminiEmbedding!);
            }
            else if (IsHuggingfaceApiEmbedding && huggingfaceApiEmbedding != null)
            {
                return huggingfaceApiEmbedding(HuggingfaceApiEmbedding!);
            }
            else if (IsAzureEmbedding2 && azureEmbedding2 != null)
            {
                return azureEmbedding2(AzureEmbedding2!);
            }
            else if (IsVertexaiEmbedding && vertexaiEmbedding != null)
            {
                return vertexaiEmbedding(VertexaiEmbedding!);
            }
            else if (IsBedrockEmbedding && bedrockEmbedding != null)
            {
                return bedrockEmbedding(BedrockEmbedding!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::LlamaParse.AzureOpenAIEmbeddingConfig?>? azureEmbedding1 = null,
            global::System.Action<global::LlamaParse.CohereEmbeddingConfig?>? cohereEmbedding = null,
            global::System.Action<global::LlamaParse.GeminiEmbeddingConfig?>? geminiEmbedding = null,
            global::System.Action<global::LlamaParse.HuggingFaceInferenceAPIEmbeddingConfig?>? huggingfaceApiEmbedding = null,
            global::System.Action<global::LlamaParse.OpenAIEmbeddingConfig?>? azureEmbedding2 = null,
            global::System.Action<global::LlamaParse.VertexAIEmbeddingConfig?>? vertexaiEmbedding = null,
            global::System.Action<global::LlamaParse.BedrockEmbeddingConfig?>? bedrockEmbedding = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAzureEmbedding1)
            {
                azureEmbedding1?.Invoke(AzureEmbedding1!);
            }
            else if (IsCohereEmbedding)
            {
                cohereEmbedding?.Invoke(CohereEmbedding!);
            }
            else if (IsGeminiEmbedding)
            {
                geminiEmbedding?.Invoke(GeminiEmbedding!);
            }
            else if (IsHuggingfaceApiEmbedding)
            {
                huggingfaceApiEmbedding?.Invoke(HuggingfaceApiEmbedding!);
            }
            else if (IsAzureEmbedding2)
            {
                azureEmbedding2?.Invoke(AzureEmbedding2!);
            }
            else if (IsVertexaiEmbedding)
            {
                vertexaiEmbedding?.Invoke(VertexaiEmbedding!);
            }
            else if (IsBedrockEmbedding)
            {
                bedrockEmbedding?.Invoke(BedrockEmbedding!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AzureEmbedding1,
                typeof(global::LlamaParse.AzureOpenAIEmbeddingConfig),
                CohereEmbedding,
                typeof(global::LlamaParse.CohereEmbeddingConfig),
                GeminiEmbedding,
                typeof(global::LlamaParse.GeminiEmbeddingConfig),
                HuggingfaceApiEmbedding,
                typeof(global::LlamaParse.HuggingFaceInferenceAPIEmbeddingConfig),
                AzureEmbedding2,
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
                global::System.Collections.Generic.EqualityComparer<global::LlamaParse.AzureOpenAIEmbeddingConfig?>.Default.Equals(AzureEmbedding1, other.AzureEmbedding1) &&
                global::System.Collections.Generic.EqualityComparer<global::LlamaParse.CohereEmbeddingConfig?>.Default.Equals(CohereEmbedding, other.CohereEmbedding) &&
                global::System.Collections.Generic.EqualityComparer<global::LlamaParse.GeminiEmbeddingConfig?>.Default.Equals(GeminiEmbedding, other.GeminiEmbedding) &&
                global::System.Collections.Generic.EqualityComparer<global::LlamaParse.HuggingFaceInferenceAPIEmbeddingConfig?>.Default.Equals(HuggingfaceApiEmbedding, other.HuggingfaceApiEmbedding) &&
                global::System.Collections.Generic.EqualityComparer<global::LlamaParse.OpenAIEmbeddingConfig?>.Default.Equals(AzureEmbedding2, other.AzureEmbedding2) &&
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
