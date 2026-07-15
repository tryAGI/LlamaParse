
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public enum FormTableCellItemsItemDiscriminatorType
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
    public static class FormTableCellItemsItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FormTableCellItemsItemDiscriminatorType value)
        {
            return value switch
            {
                FormTableCellItemsItemDiscriminatorType.Field => "field",
                FormTableCellItemsItemDiscriminatorType.Section => "section",
                FormTableCellItemsItemDiscriminatorType.Table => "table",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FormTableCellItemsItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "field" => FormTableCellItemsItemDiscriminatorType.Field,
                "section" => FormTableCellItemsItemDiscriminatorType.Section,
                "table" => FormTableCellItemsItemDiscriminatorType.Table,
                _ => null,
            };
        }
    }
}