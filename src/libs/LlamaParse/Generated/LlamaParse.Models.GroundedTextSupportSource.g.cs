
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Which textual surface of the item the spans index into
    /// </summary>
    public enum GroundedTextSupportSource
    {
        /// <summary>
        /// 
        /// </summary>
        Caption,
        /// <summary>
        /// 
        /// </summary>
        Md,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GroundedTextSupportSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GroundedTextSupportSource value)
        {
            return value switch
            {
                GroundedTextSupportSource.Caption => "caption",
                GroundedTextSupportSource.Md => "md",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GroundedTextSupportSource? ToEnum(string value)
        {
            return value switch
            {
                "caption" => GroundedTextSupportSource.Caption,
                "md" => GroundedTextSupportSource.Md,
                _ => null,
            };
        }
    }
}