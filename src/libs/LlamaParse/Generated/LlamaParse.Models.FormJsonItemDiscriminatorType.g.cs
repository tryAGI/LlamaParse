
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public enum FormJsonItemDiscriminatorType
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
    public static class FormJsonItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FormJsonItemDiscriminatorType value)
        {
            return value switch
            {
                FormJsonItemDiscriminatorType.Field => "field",
                FormJsonItemDiscriminatorType.Section => "section",
                FormJsonItemDiscriminatorType.Table => "table",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FormJsonItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "field" => FormJsonItemDiscriminatorType.Field,
                "section" => FormJsonItemDiscriminatorType.Section,
                "table" => FormJsonItemDiscriminatorType.Table,
                _ => null,
            };
        }
    }
}