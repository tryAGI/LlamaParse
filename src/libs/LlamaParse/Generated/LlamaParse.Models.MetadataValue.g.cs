#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MetadataValue : global::System.IEquatable<MetadataValue>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LlamaParse.MetadataScalarValue? Scalar { get; init; }
#else
        public global::LlamaParse.MetadataScalarValue? Scalar { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Scalar))]
#endif
        public bool IsScalar => Scalar != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickScalar(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LlamaParse.MetadataScalarValue? value)
        {
            value = Scalar;
            return IsScalar;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.MetadataScalarValue PickScalar() => IsScalar
            ? Scalar!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Scalar' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? List { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? List { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(List))]
#endif
        public bool IsList => List != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickList(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<string>? value)
        {
            value = List;
            return IsList;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string> PickList() => IsList
            ? List!
            : throw new global::System.InvalidOperationException($"Expected union variant 'List' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MetadataValue(global::LlamaParse.MetadataScalarValue value) => new MetadataValue((global::LlamaParse.MetadataScalarValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LlamaParse.MetadataScalarValue?(MetadataValue @this) => @this.Scalar;

        /// <summary>
        /// 
        /// </summary>
        public MetadataValue(global::LlamaParse.MetadataScalarValue? value)
        {
            Scalar = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MetadataValue FromScalar(global::LlamaParse.MetadataScalarValue? value) => new MetadataValue(value);

        /// <summary>
        /// 
        /// </summary>
        public MetadataValue(
            global::LlamaParse.MetadataScalarValue? scalar,
            global::System.Collections.Generic.IList<string>? list
            )
        {
            Scalar = scalar;
            List = list;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            List as object ??
            Scalar as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Scalar?.ToString() ??
            List?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsScalar || IsList;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::LlamaParse.MetadataScalarValue?, TResult>? scalar = null,
            global::System.Func<global::System.Collections.Generic.IList<string>, TResult>? list = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsScalar && scalar != null)
            {
                return scalar(Scalar!);
            }
            else if (IsList && list != null)
            {
                return list(List!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::LlamaParse.MetadataScalarValue?>? scalar = null,

            global::System.Action<global::System.Collections.Generic.IList<string>>? list = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsScalar)
            {
                scalar?.Invoke(Scalar!);
            }
            else if (IsList)
            {
                list?.Invoke(List!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::LlamaParse.MetadataScalarValue?>? scalar = null,
            global::System.Action<global::System.Collections.Generic.IList<string>>? list = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsScalar)
            {
                scalar?.Invoke(Scalar!);
            }
            else if (IsList)
            {
                list?.Invoke(List!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Scalar,
                typeof(global::LlamaParse.MetadataScalarValue),
                List,
                typeof(global::System.Collections.Generic.IList<string>),
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
        public bool Equals(MetadataValue other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::LlamaParse.MetadataScalarValue?>.Default.Equals(Scalar, other.Scalar) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(List, other.List) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MetadataValue obj1, MetadataValue obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MetadataValue>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MetadataValue obj1, MetadataValue obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MetadataValue o && Equals(o);
        }
    }
}
