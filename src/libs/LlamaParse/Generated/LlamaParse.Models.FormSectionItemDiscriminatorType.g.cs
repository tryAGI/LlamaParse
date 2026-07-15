
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public enum FormSectionItemDiscriminatorType
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
    public static class FormSectionItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FormSectionItemDiscriminatorType value)
        {
            return value switch
            {
                FormSectionItemDiscriminatorType.Field => "field",
                FormSectionItemDiscriminatorType.Section => "section",
                FormSectionItemDiscriminatorType.Table => "table",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FormSectionItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "field" => FormSectionItemDiscriminatorType.Field,
                "section" => FormSectionItemDiscriminatorType.Section,
                "table" => FormSectionItemDiscriminatorType.Table,
                _ => null,
            };
        }
    }
}