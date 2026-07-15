#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ItemsItem7 : global::System.IEquatable<ItemsItem7>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.StructuredResultPageItemDiscriminatorType? Type { get; }

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
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LlamaParse.TextItem? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.TextItem PickText() => IsText
            ? Text!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

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
        public bool TryPickHeading(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LlamaParse.HeadingItem? value)
        {
            value = Heading;
            return IsHeading;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.HeadingItem PickHeading() => IsHeading
            ? Heading!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Heading' but the value was {ToString()}.");

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
        public bool TryPickList(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LlamaParse.ListItem? value)
        {
            value = List;
            return IsList;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ListItem PickList() => IsList
            ? List!
            : throw new global::System.InvalidOperationException($"Expected union variant 'List' but the value was {ToString()}.");

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
        public bool TryPickCode(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LlamaParse.CodeItem? value)
        {
            value = Code;
            return IsCode;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.CodeItem PickCode() => IsCode
            ? Code!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Code' but the value was {ToString()}.");

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
        public bool TryPickTable(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LlamaParse.TableItem? value)
        {
            value = Table;
            return IsTable;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.TableItem PickTable() => IsTable
            ? Table!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Table' but the value was {ToString()}.");

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
        public bool TryPickImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LlamaParse.ImageItem? value)
        {
            value = Image;
            return IsImage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ImageItem PickImage() => IsImage
            ? Image!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Image' but the value was {ToString()}.");

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
        public bool TryPickLink(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LlamaParse.LinkItem? value)
        {
            value = Link;
            return IsLink;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.LinkItem PickLink() => IsLink
            ? Link!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Link' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LlamaParse.HeaderItem? Header { get; init; }
#else
        public global::LlamaParse.HeaderItem? Header { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Header))]
#endif
        public bool IsHeader => Header != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickHeader(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LlamaParse.HeaderItem? value)
        {
            value = Header;
            return IsHeader;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.HeaderItem PickHeader() => IsHeader
            ? Header!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Header' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LlamaParse.FooterItem? Footer { get; init; }
#else
        public global::LlamaParse.FooterItem? Footer { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Footer))]
#endif
        public bool IsFooter => Footer != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFooter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LlamaParse.FooterItem? value)
        {
            value = Footer;
            return IsFooter;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.FooterItem PickFooter() => IsFooter
            ? Footer!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Footer' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemsItem7(global::LlamaParse.TextItem value) => new ItemsItem7((global::LlamaParse.TextItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LlamaParse.TextItem?(ItemsItem7 @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ItemsItem7(global::LlamaParse.TextItem? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ItemsItem7 FromText(global::LlamaParse.TextItem? value) => new ItemsItem7(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemsItem7(global::LlamaParse.HeadingItem value) => new ItemsItem7((global::LlamaParse.HeadingItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LlamaParse.HeadingItem?(ItemsItem7 @this) => @this.Heading;

        /// <summary>
        /// 
        /// </summary>
        public ItemsItem7(global::LlamaParse.HeadingItem? value)
        {
            Heading = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ItemsItem7 FromHeading(global::LlamaParse.HeadingItem? value) => new ItemsItem7(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemsItem7(global::LlamaParse.ListItem value) => new ItemsItem7((global::LlamaParse.ListItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LlamaParse.ListItem?(ItemsItem7 @this) => @this.List;

        /// <summary>
        /// 
        /// </summary>
        public ItemsItem7(global::LlamaParse.ListItem? value)
        {
            List = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ItemsItem7 FromList(global::LlamaParse.ListItem? value) => new ItemsItem7(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemsItem7(global::LlamaParse.CodeItem value) => new ItemsItem7((global::LlamaParse.CodeItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LlamaParse.CodeItem?(ItemsItem7 @this) => @this.Code;

        /// <summary>
        /// 
        /// </summary>
        public ItemsItem7(global::LlamaParse.CodeItem? value)
        {
            Code = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ItemsItem7 FromCode(global::LlamaParse.CodeItem? value) => new ItemsItem7(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemsItem7(global::LlamaParse.TableItem value) => new ItemsItem7((global::LlamaParse.TableItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LlamaParse.TableItem?(ItemsItem7 @this) => @this.Table;

        /// <summary>
        /// 
        /// </summary>
        public ItemsItem7(global::LlamaParse.TableItem? value)
        {
            Table = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ItemsItem7 FromTable(global::LlamaParse.TableItem? value) => new ItemsItem7(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemsItem7(global::LlamaParse.ImageItem value) => new ItemsItem7((global::LlamaParse.ImageItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LlamaParse.ImageItem?(ItemsItem7 @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public ItemsItem7(global::LlamaParse.ImageItem? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ItemsItem7 FromImage(global::LlamaParse.ImageItem? value) => new ItemsItem7(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemsItem7(global::LlamaParse.LinkItem value) => new ItemsItem7((global::LlamaParse.LinkItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LlamaParse.LinkItem?(ItemsItem7 @this) => @this.Link;

        /// <summary>
        /// 
        /// </summary>
        public ItemsItem7(global::LlamaParse.LinkItem? value)
        {
            Link = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ItemsItem7 FromLink(global::LlamaParse.LinkItem? value) => new ItemsItem7(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemsItem7(global::LlamaParse.HeaderItem value) => new ItemsItem7((global::LlamaParse.HeaderItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LlamaParse.HeaderItem?(ItemsItem7 @this) => @this.Header;

        /// <summary>
        /// 
        /// </summary>
        public ItemsItem7(global::LlamaParse.HeaderItem? value)
        {
            Header = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ItemsItem7 FromHeader(global::LlamaParse.HeaderItem? value) => new ItemsItem7(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemsItem7(global::LlamaParse.FooterItem value) => new ItemsItem7((global::LlamaParse.FooterItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LlamaParse.FooterItem?(ItemsItem7 @this) => @this.Footer;

        /// <summary>
        /// 
        /// </summary>
        public ItemsItem7(global::LlamaParse.FooterItem? value)
        {
            Footer = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ItemsItem7 FromFooter(global::LlamaParse.FooterItem? value) => new ItemsItem7(value);

        /// <summary>
        /// 
        /// </summary>
        public ItemsItem7(
            global::LlamaParse.StructuredResultPageItemDiscriminatorType? type,
            global::LlamaParse.TextItem? text,
            global::LlamaParse.HeadingItem? heading,
            global::LlamaParse.ListItem? list,
            global::LlamaParse.CodeItem? code,
            global::LlamaParse.TableItem? table,
            global::LlamaParse.ImageItem? image,
            global::LlamaParse.LinkItem? link,
            global::LlamaParse.HeaderItem? header,
            global::LlamaParse.FooterItem? footer
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
            Header = header;
            Footer = footer;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Footer as object ??
            Header as object ??
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
            Link?.ToString() ??
            Header?.ToString() ??
            Footer?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsHeading && !IsList && !IsCode && !IsTable && !IsImage && !IsLink && !IsHeader && !IsFooter || !IsText && IsHeading && !IsList && !IsCode && !IsTable && !IsImage && !IsLink && !IsHeader && !IsFooter || !IsText && !IsHeading && IsList && !IsCode && !IsTable && !IsImage && !IsLink && !IsHeader && !IsFooter || !IsText && !IsHeading && !IsList && IsCode && !IsTable && !IsImage && !IsLink && !IsHeader && !IsFooter || !IsText && !IsHeading && !IsList && !IsCode && IsTable && !IsImage && !IsLink && !IsHeader && !IsFooter || !IsText && !IsHeading && !IsList && !IsCode && !IsTable && IsImage && !IsLink && !IsHeader && !IsFooter || !IsText && !IsHeading && !IsList && !IsCode && !IsTable && !IsImage && IsLink && !IsHeader && !IsFooter || !IsText && !IsHeading && !IsList && !IsCode && !IsTable && !IsImage && !IsLink && IsHeader && !IsFooter || !IsText && !IsHeading && !IsList && !IsCode && !IsTable && !IsImage && !IsLink && !IsHeader && IsFooter;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::LlamaParse.TextItem, TResult>? text = null,
            global::System.Func<global::LlamaParse.HeadingItem, TResult>? heading = null,
            global::System.Func<global::LlamaParse.ListItem, TResult>? list = null,
            global::System.Func<global::LlamaParse.CodeItem, TResult>? code = null,
            global::System.Func<global::LlamaParse.TableItem, TResult>? table = null,
            global::System.Func<global::LlamaParse.ImageItem, TResult>? image = null,
            global::System.Func<global::LlamaParse.LinkItem, TResult>? link = null,
            global::System.Func<global::LlamaParse.HeaderItem, TResult>? header = null,
            global::System.Func<global::LlamaParse.FooterItem, TResult>? footer = null,
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
            else if (IsHeader && header != null)
            {
                return header(Header!);
            }
            else if (IsFooter && footer != null)
            {
                return footer(Footer!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::LlamaParse.TextItem>? text = null,

            global::System.Action<global::LlamaParse.HeadingItem>? heading = null,

            global::System.Action<global::LlamaParse.ListItem>? list = null,

            global::System.Action<global::LlamaParse.CodeItem>? code = null,

            global::System.Action<global::LlamaParse.TableItem>? table = null,

            global::System.Action<global::LlamaParse.ImageItem>? image = null,

            global::System.Action<global::LlamaParse.LinkItem>? link = null,

            global::System.Action<global::LlamaParse.HeaderItem>? header = null,

            global::System.Action<global::LlamaParse.FooterItem>? footer = null,
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
            else if (IsHeader)
            {
                header?.Invoke(Header!);
            }
            else if (IsFooter)
            {
                footer?.Invoke(Footer!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::LlamaParse.TextItem>? text = null,
            global::System.Action<global::LlamaParse.HeadingItem>? heading = null,
            global::System.Action<global::LlamaParse.ListItem>? list = null,
            global::System.Action<global::LlamaParse.CodeItem>? code = null,
            global::System.Action<global::LlamaParse.TableItem>? table = null,
            global::System.Action<global::LlamaParse.ImageItem>? image = null,
            global::System.Action<global::LlamaParse.LinkItem>? link = null,
            global::System.Action<global::LlamaParse.HeaderItem>? header = null,
            global::System.Action<global::LlamaParse.FooterItem>? footer = null,
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
            else if (IsHeader)
            {
                header?.Invoke(Header!);
            }
            else if (IsFooter)
            {
                footer?.Invoke(Footer!);
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
                Header,
                typeof(global::LlamaParse.HeaderItem),
                Footer,
                typeof(global::LlamaParse.FooterItem),
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
        public bool Equals(ItemsItem7 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::LlamaParse.TextItem?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::LlamaParse.HeadingItem?>.Default.Equals(Heading, other.Heading) &&
                global::System.Collections.Generic.EqualityComparer<global::LlamaParse.ListItem?>.Default.Equals(List, other.List) &&
                global::System.Collections.Generic.EqualityComparer<global::LlamaParse.CodeItem?>.Default.Equals(Code, other.Code) &&
                global::System.Collections.Generic.EqualityComparer<global::LlamaParse.TableItem?>.Default.Equals(Table, other.Table) &&
                global::System.Collections.Generic.EqualityComparer<global::LlamaParse.ImageItem?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::LlamaParse.LinkItem?>.Default.Equals(Link, other.Link) &&
                global::System.Collections.Generic.EqualityComparer<global::LlamaParse.HeaderItem?>.Default.Equals(Header, other.Header) &&
                global::System.Collections.Generic.EqualityComparer<global::LlamaParse.FooterItem?>.Default.Equals(Footer, other.Footer) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ItemsItem7 obj1, ItemsItem7 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ItemsItem7>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ItemsItem7 obj1, ItemsItem7 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ItemsItem7 o && Equals(o);
        }
    }
}
