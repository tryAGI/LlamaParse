#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ItemsItem : global::System.IEquatable<ItemsItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.FooterItemItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LlamaParse.TextItem? Text { get; init; }
#else
        public global::LlamaParse.TextItem? Text { get; }
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
#if NET6_0_OR_GREATER
        public global::LlamaParse.HeadingItem? Heading { get; init; }
#else
        public global::LlamaParse.HeadingItem? Heading { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Heading))]
#endif
        public bool IsHeading => Heading != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LlamaParse.ListItem? List { get; init; }
#else
        public global::LlamaParse.ListItem? List { get; }
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
#if NET6_0_OR_GREATER
        public global::LlamaParse.CodeItem? Code { get; init; }
#else
        public global::LlamaParse.CodeItem? Code { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Code))]
#endif
        public bool IsCode => Code != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LlamaParse.TableItem? Table { get; init; }
#else
        public global::LlamaParse.TableItem? Table { get; }
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
#if NET6_0_OR_GREATER
        public global::LlamaParse.ImageItem? Image { get; init; }
#else
        public global::LlamaParse.ImageItem? Image { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Image))]
#endif
        public bool IsImage => Image != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LlamaParse.LinkItem? Link { get; init; }
#else
        public global::LlamaParse.LinkItem? Link { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Link))]
#endif
        public bool IsLink => Link != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemsItem(global::LlamaParse.TextItem value) => new ItemsItem((global::LlamaParse.TextItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LlamaParse.TextItem?(ItemsItem @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ItemsItem(global::LlamaParse.TextItem? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemsItem(global::LlamaParse.HeadingItem value) => new ItemsItem((global::LlamaParse.HeadingItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LlamaParse.HeadingItem?(ItemsItem @this) => @this.Heading;

        /// <summary>
        /// 
        /// </summary>
        public ItemsItem(global::LlamaParse.HeadingItem? value)
        {
            Heading = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemsItem(global::LlamaParse.ListItem value) => new ItemsItem((global::LlamaParse.ListItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LlamaParse.ListItem?(ItemsItem @this) => @this.List;

        /// <summary>
        /// 
        /// </summary>
        public ItemsItem(global::LlamaParse.ListItem? value)
        {
            List = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemsItem(global::LlamaParse.CodeItem value) => new ItemsItem((global::LlamaParse.CodeItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LlamaParse.CodeItem?(ItemsItem @this) => @this.Code;

        /// <summary>
        /// 
        /// </summary>
        public ItemsItem(global::LlamaParse.CodeItem? value)
        {
            Code = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemsItem(global::LlamaParse.TableItem value) => new ItemsItem((global::LlamaParse.TableItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LlamaParse.TableItem?(ItemsItem @this) => @this.Table;

        /// <summary>
        /// 
        /// </summary>
        public ItemsItem(global::LlamaParse.TableItem? value)
        {
            Table = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemsItem(global::LlamaParse.ImageItem value) => new ItemsItem((global::LlamaParse.ImageItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LlamaParse.ImageItem?(ItemsItem @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public ItemsItem(global::LlamaParse.ImageItem? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemsItem(global::LlamaParse.LinkItem value) => new ItemsItem((global::LlamaParse.LinkItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LlamaParse.LinkItem?(ItemsItem @this) => @this.Link;

        /// <summary>
        /// 
        /// </summary>
        public ItemsItem(global::LlamaParse.LinkItem? value)
        {
            Link = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ItemsItem(
            global::LlamaParse.FooterItemItemDiscriminatorType? type,
            global::LlamaParse.TextItem? text,
            global::LlamaParse.HeadingItem? heading,
            global::LlamaParse.ListItem? list,
            global::LlamaParse.CodeItem? code,
            global::LlamaParse.TableItem? table,
            global::LlamaParse.ImageItem? image,
            global::LlamaParse.LinkItem? link
            )
        {
            Type = type;

            Text = text;
            Heading = heading;
            List = list;
            Code = code;
            Table = table;
            Image = image;
            Link = link;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Link as object ??
            Image as object ??
            Table as object ??
            Code as object ??
            List as object ??
            Heading as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            Heading?.ToString() ??
            List?.ToString() ??
            Code?.ToString() ??
            Table?.ToString() ??
            Image?.ToString() ??
            Link?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsHeading && !IsList && !IsCode && !IsTable && !IsImage && !IsLink || !IsText && IsHeading && !IsList && !IsCode && !IsTable && !IsImage && !IsLink || !IsText && !IsHeading && IsList && !IsCode && !IsTable && !IsImage && !IsLink || !IsText && !IsHeading && !IsList && IsCode && !IsTable && !IsImage && !IsLink || !IsText && !IsHeading && !IsList && !IsCode && IsTable && !IsImage && !IsLink || !IsText && !IsHeading && !IsList && !IsCode && !IsTable && IsImage && !IsLink || !IsText && !IsHeading && !IsList && !IsCode && !IsTable && !IsImage && IsLink;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::LlamaParse.TextItem?, TResult>? text = null,
            global::System.Func<global::LlamaParse.HeadingItem?, TResult>? heading = null,
            global::System.Func<global::LlamaParse.ListItem?, TResult>? list = null,
            global::System.Func<global::LlamaParse.CodeItem?, TResult>? code = null,
            global::System.Func<global::LlamaParse.TableItem?, TResult>? table = null,
            global::System.Func<global::LlamaParse.ImageItem?, TResult>? image = null,
            global::System.Func<global::LlamaParse.LinkItem?, TResult>? link = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsHeading && heading != null)
            {
                return heading(Heading!);
            }
            else if (IsList && list != null)
            {
                return list(List!);
            }
            else if (IsCode && code != null)
            {
                return code(Code!);
            }
            else if (IsTable && table != null)
            {
                return table(Table!);
            }
            else if (IsImage && image != null)
            {
                return image(Image!);
            }
            else if (IsLink && link != null)
            {
                return link(Link!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::LlamaParse.TextItem?>? text = null,
            global::System.Action<global::LlamaParse.HeadingItem?>? heading = null,
            global::System.Action<global::LlamaParse.ListItem?>? list = null,
            global::System.Action<global::LlamaParse.CodeItem?>? code = null,
            global::System.Action<global::LlamaParse.TableItem?>? table = null,
            global::System.Action<global::LlamaParse.ImageItem?>? image = null,
            global::System.Action<global::LlamaParse.LinkItem?>? link = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsHeading)
            {
                heading?.Invoke(Heading!);
            }
            else if (IsList)
            {
                list?.Invoke(List!);
            }
            else if (IsCode)
            {
                code?.Invoke(Code!);
            }
            else if (IsTable)
            {
                table?.Invoke(Table!);
            }
            else if (IsImage)
            {
                image?.Invoke(Image!);
            }
            else if (IsLink)
            {
                link?.Invoke(Link!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::LlamaParse.TextItem),
                Heading,
                typeof(global::LlamaParse.HeadingItem),
                List,
                typeof(global::LlamaParse.ListItem),
                Code,
                typeof(global::LlamaParse.CodeItem),
                Table,
                typeof(global::LlamaParse.TableItem),
                Image,
                typeof(global::LlamaParse.ImageItem),
                Link,
                typeof(global::LlamaParse.LinkItem),
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
        public bool Equals(ItemsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::LlamaParse.TextItem?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::LlamaParse.HeadingItem?>.Default.Equals(Heading, other.Heading) &&
                global::System.Collections.Generic.EqualityComparer<global::LlamaParse.ListItem?>.Default.Equals(List, other.List) &&
                global::System.Collections.Generic.EqualityComparer<global::LlamaParse.CodeItem?>.Default.Equals(Code, other.Code) &&
                global::System.Collections.Generic.EqualityComparer<global::LlamaParse.TableItem?>.Default.Equals(Table, other.Table) &&
                global::System.Collections.Generic.EqualityComparer<global::LlamaParse.ImageItem?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::LlamaParse.LinkItem?>.Default.Equals(Link, other.Link) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ItemsItem obj1, ItemsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ItemsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ItemsItem obj1, ItemsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ItemsItem o && Equals(o);
        }
    }
}
