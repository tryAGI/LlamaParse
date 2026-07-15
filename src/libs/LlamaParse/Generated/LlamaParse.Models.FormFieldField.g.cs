
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Kind of entry: text (any free-text input), checkbox, single_select, multi_select, or signature
    /// </summary>
    public enum FormFieldField
    {
        /// <summary>
        /// text (any free-text input), checkbox, single_select, multi_select, or signature
        /// </summary>
        Checkbox,
        /// <summary>
        /// text (any free-text input), checkbox, single_select, multi_select, or signature
        /// </summary>
        MultiSelect,
        /// <summary>
        /// text (any free-text input), checkbox, single_select, multi_select, or signature
        /// </summary>
        Signature,
        /// <summary>
        /// text (any free-text input), checkbox, single_select, multi_select, or signature
        /// </summary>
        SingleSelect,
        /// <summary>
        /// text (any free-text input), checkbox, single_select, multi_select, or signature
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FormFieldFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FormFieldField value)
        {
            return value switch
            {
                FormFieldField.Checkbox => "checkbox",
                FormFieldField.MultiSelect => "multi_select",
                FormFieldField.Signature => "signature",
                FormFieldField.SingleSelect => "single_select",
                FormFieldField.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FormFieldField? ToEnum(string value)
        {
            return value switch
            {
                "checkbox" => FormFieldField.Checkbox,
                "multi_select" => FormFieldField.MultiSelect,
                "signature" => FormFieldField.Signature,
                "single_select" => FormFieldField.SingleSelect,
                "text" => FormFieldField.Text,
                _ => null,
            };
        }
    }
}