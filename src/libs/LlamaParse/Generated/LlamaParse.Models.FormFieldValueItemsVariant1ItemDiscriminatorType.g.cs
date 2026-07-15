
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public enum FormFieldValueItemsVariant1ItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Field,
        /// <summary>
        /// 
        /// </summary>
        Section,
        /// <summary>
        /// 
        /// </summary>
        Table,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FormFieldValueItemsVariant1ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FormFieldValueItemsVariant1ItemDiscriminatorType value)
        {
            return value switch
            {
                FormFieldValueItemsVariant1ItemDiscriminatorType.Field => "field",
                FormFieldValueItemsVariant1ItemDiscriminatorType.Section => "section",
                FormFieldValueItemsVariant1ItemDiscriminatorType.Table => "table",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FormFieldValueItemsVariant1ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "field" => FormFieldValueItemsVariant1ItemDiscriminatorType.Field,
                "section" => FormFieldValueItemsVariant1ItemDiscriminatorType.Section,
                "table" => FormFieldValueItemsVariant1ItemDiscriminatorType.Table,
                _ => null,
            };
        }
    }
}