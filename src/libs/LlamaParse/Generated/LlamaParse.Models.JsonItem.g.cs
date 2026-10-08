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
        public global::LlamaParse.FormSection PickSection() => Section is { } value
            ? value
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
        public global::LlamaParse.FormField PickField() => Field is { } value
            ? value
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
        public global::LlamaParse.FormTable PickTable() => Table is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Table' but the value was {ToString()}.");

        /// <summary>
        /// Printed text that is not part of a field, section heading or table: a title, an<br/>
        /// instruction, a note. With it the form JSON holds every printed word of its region.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LlamaParse.FormText? Text { get; init; }
#else
        public global::LlamaParse.FormText? Text { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LlamaParse.FormText? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormText PickText() => Text is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");
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
        public static implicit operator JsonItem(global::LlamaParse.FormText value) => new JsonItem((global::LlamaParse.FormText?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LlamaParse.FormText?(JsonItem @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public JsonItem(global::LlamaParse.FormText? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static JsonItem FromText(global::LlamaParse.FormText? value) => new JsonItem(value);

        /// <summary>
        ///
        /// </summary>
        public JsonItem(
            global::LlamaParse.FormJsonItemDiscriminatorType? type,
            global::LlamaParse.FormSection? section,
            global::LlamaParse.FormField? field,
            global::LlamaParse.FormTable? table,
            global::LlamaParse.FormText? text
            )
        {
            Type = type;

            Section = section;
            Field = field;
            Table = table;
            Text = text;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Text as object ??
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
            Table?.ToString() ??
            Text?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSection && !IsField && !IsTable && !IsText || !IsSection && IsField && !IsTable && !IsText || !IsSection && !IsField && IsTable && !IsText || !IsSection && !IsField && !IsTable && IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::LlamaParse.FormSection, TResult>? section = null,
            global::System.Func<global::LlamaParse.FormField, TResult>? field = null,
            global::System.Func<global::LlamaParse.FormTable, TResult>? table = null,
            global::System.Func<global::LlamaParse.FormText, TResult>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Section is { } __value0 && section != null)
            {
                return section(__value0);
            }
            else if (Field is { } __value1 && field != null)
            {
                return field(__value1);
            }
            else if (Table is { } __value2 && table != null)
            {
                return table(__value2);
            }
            else if (Text is { } __value3 && text != null)
            {
                return text(__value3);
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

            global::System.Action<global::LlamaParse.FormText>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Section is { } __value0)
            {
                section?.Invoke(__value0);
            }
            else if (Field is { } __value1)
            {
                field?.Invoke(__value1);
            }
            else if (Table is { } __value2)
            {
                table?.Invoke(__value2);
            }
            else if (Text is { } __value3)
            {
                text?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::LlamaParse.FormSection>? section = null,
            global::System.Action<global::LlamaParse.FormField>? field = null,
            global::System.Action<global::LlamaParse.FormTable>? table = null,
            global::System.Action<global::LlamaParse.FormText>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Section is { } __value0)
            {
                section?.Invoke(__value0);
            }
            else if (Field is { } __value1)
            {
                field?.Invoke(__value1);
            }
            else if (Table is { } __value2)
            {
                table?.Invoke(__value2);
            }
            else if (Text is { } __value3)
            {
                text?.Invoke(__value3);
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
                Text,
                typeof(global::LlamaParse.FormText),
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
                global::System.Collections.Generic.EqualityComparer<global::LlamaParse.FormTable?>.Default.Equals(Table, other.Table) &&
                global::System.Collections.Generic.EqualityComparer<global::LlamaParse.FormText?>.Default.Equals(Text, other.Text)
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
