#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MetadataScalarValue : global::System.IEquatable<MetadataScalarValue>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? MetadataScalarValueVariant1 { get; init; }
#else
        public string? MetadataScalarValueVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MetadataScalarValueVariant1))]
#endif
        public bool IsMetadataScalarValueVariant1 => MetadataScalarValueVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMetadataScalarValueVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = MetadataScalarValueVariant1;
            return IsMetadataScalarValueVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickMetadataScalarValueVariant1() => IsMetadataScalarValueVariant1
            ? MetadataScalarValueVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MetadataScalarValueVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public int? MetadataScalarValueVariant2 { get; init; }
#else
        public int? MetadataScalarValueVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MetadataScalarValueVariant2))]
#endif
        public bool IsMetadataScalarValueVariant2 => MetadataScalarValueVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMetadataScalarValueVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out int? value)
        {
            value = MetadataScalarValueVariant2;
            return IsMetadataScalarValueVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public int PickMetadataScalarValueVariant2() => IsMetadataScalarValueVariant2
            ? MetadataScalarValueVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MetadataScalarValueVariant2' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public double? MetadataScalarValueVariant3 { get; init; }
#else
        public double? MetadataScalarValueVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MetadataScalarValueVariant3))]
#endif
        public bool IsMetadataScalarValueVariant3 => MetadataScalarValueVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMetadataScalarValueVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out double? value)
        {
            value = MetadataScalarValueVariant3;
            return IsMetadataScalarValueVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public double PickMetadataScalarValueVariant3() => IsMetadataScalarValueVariant3
            ? MetadataScalarValueVariant3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MetadataScalarValueVariant3' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? MetadataScalarValueVariant4 { get; init; }
#else
        public bool? MetadataScalarValueVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MetadataScalarValueVariant4))]
#endif
        public bool IsMetadataScalarValueVariant4 => MetadataScalarValueVariant4 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMetadataScalarValueVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out bool? value)
        {
            value = MetadataScalarValueVariant4;
            return IsMetadataScalarValueVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool PickMetadataScalarValueVariant4() => IsMetadataScalarValueVariant4
            ? MetadataScalarValueVariant4!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MetadataScalarValueVariant4' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? MetadataScalarValueVariant5 { get; init; }
#else
        public object? MetadataScalarValueVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MetadataScalarValueVariant5))]
#endif
        public bool IsMetadataScalarValueVariant5 => MetadataScalarValueVariant5 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMetadataScalarValueVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = MetadataScalarValueVariant5;
            return IsMetadataScalarValueVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public object PickMetadataScalarValueVariant5() => IsMetadataScalarValueVariant5
            ? MetadataScalarValueVariant5!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MetadataScalarValueVariant5' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MetadataScalarValue(string value) => new MetadataScalarValue((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(MetadataScalarValue @this) => @this.MetadataScalarValueVariant1;

        /// <summary>
        /// 
        /// </summary>
        public MetadataScalarValue(string? value)
        {
            MetadataScalarValueVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MetadataScalarValue FromMetadataScalarValueVariant1(string? value) => new MetadataScalarValue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MetadataScalarValue(int value) => new MetadataScalarValue((int?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator int?(MetadataScalarValue @this) => @this.MetadataScalarValueVariant2;

        /// <summary>
        /// 
        /// </summary>
        public MetadataScalarValue(int? value)
        {
            MetadataScalarValueVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MetadataScalarValue FromMetadataScalarValueVariant2(int? value) => new MetadataScalarValue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MetadataScalarValue(double value) => new MetadataScalarValue((double?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator double?(MetadataScalarValue @this) => @this.MetadataScalarValueVariant3;

        /// <summary>
        /// 
        /// </summary>
        public MetadataScalarValue(double? value)
        {
            MetadataScalarValueVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MetadataScalarValue FromMetadataScalarValueVariant3(double? value) => new MetadataScalarValue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MetadataScalarValue(bool value) => new MetadataScalarValue((bool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator bool?(MetadataScalarValue @this) => @this.MetadataScalarValueVariant4;

        /// <summary>
        /// 
        /// </summary>
        public MetadataScalarValue(bool? value)
        {
            MetadataScalarValueVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MetadataScalarValue FromMetadataScalarValueVariant4(bool? value) => new MetadataScalarValue(value);

        /// <summary>
        /// 
        /// </summary>
        public MetadataScalarValue(
            string? metadataScalarValueVariant1,
            int? metadataScalarValueVariant2,
            double? metadataScalarValueVariant3,
            bool? metadataScalarValueVariant4,
            object? metadataScalarValueVariant5
            )
        {
            MetadataScalarValueVariant1 = metadataScalarValueVariant1;
            MetadataScalarValueVariant2 = metadataScalarValueVariant2;
            MetadataScalarValueVariant3 = metadataScalarValueVariant3;
            MetadataScalarValueVariant4 = metadataScalarValueVariant4;
            MetadataScalarValueVariant5 = metadataScalarValueVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MetadataScalarValueVariant5 as object ??
            MetadataScalarValueVariant4 as object ??
            MetadataScalarValueVariant3 as object ??
            MetadataScalarValueVariant2 as object ??
            MetadataScalarValueVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            MetadataScalarValueVariant1?.ToString() ??
            MetadataScalarValueVariant2?.ToString() ??
            MetadataScalarValueVariant3?.ToString() ??
            MetadataScalarValueVariant4?.ToString().ToLowerInvariant() ??
            MetadataScalarValueVariant5?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMetadataScalarValueVariant1 || IsMetadataScalarValueVariant2 || IsMetadataScalarValueVariant3 || IsMetadataScalarValueVariant4 || IsMetadataScalarValueVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? metadataScalarValueVariant1 = null,
            global::System.Func<int?, TResult>? metadataScalarValueVariant2 = null,
            global::System.Func<double?, TResult>? metadataScalarValueVariant3 = null,
            global::System.Func<bool?, TResult>? metadataScalarValueVariant4 = null,
            global::System.Func<object, TResult>? metadataScalarValueVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMetadataScalarValueVariant1 && metadataScalarValueVariant1 != null)
            {
                return metadataScalarValueVariant1(MetadataScalarValueVariant1!);
            }
            else if (IsMetadataScalarValueVariant2 && metadataScalarValueVariant2 != null)
            {
                return metadataScalarValueVariant2(MetadataScalarValueVariant2!);
            }
            else if (IsMetadataScalarValueVariant3 && metadataScalarValueVariant3 != null)
            {
                return metadataScalarValueVariant3(MetadataScalarValueVariant3!);
            }
            else if (IsMetadataScalarValueVariant4 && metadataScalarValueVariant4 != null)
            {
                return metadataScalarValueVariant4(MetadataScalarValueVariant4!);
            }
            else if (IsMetadataScalarValueVariant5 && metadataScalarValueVariant5 != null)
            {
                return metadataScalarValueVariant5(MetadataScalarValueVariant5!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? metadataScalarValueVariant1 = null,

            global::System.Action<int?>? metadataScalarValueVariant2 = null,

            global::System.Action<double?>? metadataScalarValueVariant3 = null,

            global::System.Action<bool?>? metadataScalarValueVariant4 = null,

            global::System.Action<object>? metadataScalarValueVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMetadataScalarValueVariant1)
            {
                metadataScalarValueVariant1?.Invoke(MetadataScalarValueVariant1!);
            }
            else if (IsMetadataScalarValueVariant2)
            {
                metadataScalarValueVariant2?.Invoke(MetadataScalarValueVariant2!);
            }
            else if (IsMetadataScalarValueVariant3)
            {
                metadataScalarValueVariant3?.Invoke(MetadataScalarValueVariant3!);
            }
            else if (IsMetadataScalarValueVariant4)
            {
                metadataScalarValueVariant4?.Invoke(MetadataScalarValueVariant4!);
            }
            else if (IsMetadataScalarValueVariant5)
            {
                metadataScalarValueVariant5?.Invoke(MetadataScalarValueVariant5!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? metadataScalarValueVariant1 = null,
            global::System.Action<int?>? metadataScalarValueVariant2 = null,
            global::System.Action<double?>? metadataScalarValueVariant3 = null,
            global::System.Action<bool?>? metadataScalarValueVariant4 = null,
            global::System.Action<object>? metadataScalarValueVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMetadataScalarValueVariant1)
            {
                metadataScalarValueVariant1?.Invoke(MetadataScalarValueVariant1!);
            }
            else if (IsMetadataScalarValueVariant2)
            {
                metadataScalarValueVariant2?.Invoke(MetadataScalarValueVariant2!);
            }
            else if (IsMetadataScalarValueVariant3)
            {
                metadataScalarValueVariant3?.Invoke(MetadataScalarValueVariant3!);
            }
            else if (IsMetadataScalarValueVariant4)
            {
                metadataScalarValueVariant4?.Invoke(MetadataScalarValueVariant4!);
            }
            else if (IsMetadataScalarValueVariant5)
            {
                metadataScalarValueVariant5?.Invoke(MetadataScalarValueVariant5!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MetadataScalarValueVariant1,
                typeof(string),
                MetadataScalarValueVariant2,
                typeof(int),
                MetadataScalarValueVariant3,
                typeof(double),
                MetadataScalarValueVariant4,
                typeof(bool),
                MetadataScalarValueVariant5,
                typeof(object),
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
        public bool Equals(MetadataScalarValue other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(MetadataScalarValueVariant1, other.MetadataScalarValueVariant1) &&
                global::System.Collections.Generic.EqualityComparer<int?>.Default.Equals(MetadataScalarValueVariant2, other.MetadataScalarValueVariant2) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(MetadataScalarValueVariant3, other.MetadataScalarValueVariant3) &&
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(MetadataScalarValueVariant4, other.MetadataScalarValueVariant4) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(MetadataScalarValueVariant5, other.MetadataScalarValueVariant5) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MetadataScalarValue obj1, MetadataScalarValue obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MetadataScalarValue>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MetadataScalarValue obj1, MetadataScalarValue obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MetadataScalarValue o && Equals(o);
        }
    }
}
