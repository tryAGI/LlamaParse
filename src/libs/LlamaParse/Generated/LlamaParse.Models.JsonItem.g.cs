#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct JsonItem : global::System.IEquatable<JsonItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.FormJsonItemDiscriminatorType? Type { get; }

        /// <summary>
        /// A grouping of form content, in the form's reading order.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LlamaParse.FormSection? Section { get; init; }
#else
        public global::LlamaParse.FormSection? Section { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Section))]
#endif
        public bool IsSection => Section != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSection(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LlamaParse.FormSection? value)
        {
            value = Section;
            return IsSection;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.FormSection PickSection() => IsSection
            ? Section!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Section' but the value was {ToString()}.");

        /// <summary>
        /// One labeled form entry: a text input, checkbox, select group, or signature line.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LlamaParse.FormField? Field { get; init; }
#else
        public global::LlamaParse.FormField? Field { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Field))]
#endif
        public bool IsField => Field != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickField(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LlamaParse.FormField? value)
        {
            value = Field;
            return IsField;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.FormField PickField() => IsField
            ? Field!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Field' but the value was {ToString()}.");

        /// <summary>
        /// A fillable grid printed on the form: repeating records or a row-by-column matrix.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LlamaParse.FormTable? Table { get; init; }
#else
        public global::LlamaParse.FormTable? Table { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Table))]
#endif
        public bool IsTable => Table != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTable(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LlamaParse.FormTable? value)
        {
            value = Table;
            return IsTable;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.FormTable PickTable() => IsTable
            ? Table!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Table' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator JsonItem(global::LlamaParse.FormSection value) => new JsonItem((global::LlamaParse.FormSection?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LlamaParse.FormSection?(JsonItem @this) => @this.Section;

        /// <summary>
        /// 
        /// </summary>
        public JsonItem(global::LlamaParse.FormSection? value)
        {
            Section = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static JsonItem FromSection(global::LlamaParse.FormSection? value) => new JsonItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator JsonItem(global::LlamaParse.FormField value) => new JsonItem((global::LlamaParse.FormField?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LlamaParse.FormField?(JsonItem @this) => @this.Field;

        /// <summary>
        /// 
        /// </summary>
        public JsonItem(global::LlamaParse.FormField? value)
        {
            Field = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static JsonItem FromField(global::LlamaParse.FormField? value) => new JsonItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator JsonItem(global::LlamaParse.FormTable value) => new JsonItem((global::LlamaParse.FormTable?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LlamaParse.FormTable?(JsonItem @this) => @this.Table;

        /// <summary>
        /// 
        /// </summary>
        public JsonItem(global::LlamaParse.FormTable? value)
        {
            Table = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static JsonItem FromTable(global::LlamaParse.FormTable? value) => new JsonItem(value);

        /// <summary>
        /// 
        /// </summary>
        public JsonItem(
            global::LlamaParse.FormJsonItemDiscriminatorType? type,
            global::LlamaParse.FormSection? section,
            global::LlamaParse.FormField? field,
            global::LlamaParse.FormTable? table
            )
        {
            Type = type;

            Section = section;
            Field = field;
            Table = table;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Table as object ??
            Field as object ??
            Section as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Section?.ToString() ??
            Field?.ToString() ??
            Table?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSection && !IsField && !IsTable || !IsSection && IsField && !IsTable || !IsSection && !IsField && IsTable;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::LlamaParse.FormSection, TResult>? section = null,
            global::System.Func<global::LlamaParse.FormField, TResult>? field = null,
            global::System.Func<global::LlamaParse.FormTable, TResult>? table = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSection && section != null)
            {
                return section(Section!);
            }
            else if (IsField && field != null)
            {
                return field(Field!);
            }
            else if (IsTable && table != null)
            {
                return table(Table!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::LlamaParse.FormSection>? section = null,

            global::System.Action<global::LlamaParse.FormField>? field = null,

            global::System.Action<global::LlamaParse.FormTable>? table = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSection)
            {
                section?.Invoke(Section!);
            }
            else if (IsField)
            {
                field?.Invoke(Field!);
            }
            else if (IsTable)
            {
                table?.Invoke(Table!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::LlamaParse.FormSection>? section = null,
            global::System.Action<global::LlamaParse.FormField>? field = null,
            global::System.Action<global::LlamaParse.FormTable>? table = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSection)
            {
                section?.Invoke(Section!);
            }
            else if (IsField)
            {
                field?.Invoke(Field!);
            }
            else if (IsTable)
            {
                table?.Invoke(Table!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Section,
                typeof(global::LlamaParse.FormSection),
                Field,
                typeof(global::LlamaParse.FormField),
                Table,
                typeof(global::LlamaParse.FormTable),
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
        public bool Equals(JsonItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::LlamaParse.FormSection?>.Default.Equals(Section, other.Section) &&
                global::System.Collections.Generic.EqualityComparer<global::LlamaParse.FormField?>.Default.Equals(Field, other.Field) &&
                global::System.Collections.Generic.EqualityComparer<global::LlamaParse.FormTable?>.Default.Equals(Table, other.Table) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(JsonItem obj1, JsonItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<JsonItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(JsonItem obj1, JsonItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is JsonItem o && Equals(o);
        }
    }
}
