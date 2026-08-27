
#nullable enable

namespace LlamaParse
{
    /// <summary>
    ///
    /// </summary>
    public enum LlamaParseOutputOptionsImagesToSaveVariant1Item
    {
        /// <summary>
        ///
        /// </summary>
        Embedded,
        /// <summary>
        ///
        /// </summary>
        Layout,
        /// <summary>
        ///
        /// </summary>
        Screenshot,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LlamaParseOutputOptionsImagesToSaveVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LlamaParseOutputOptionsImagesToSaveVariant1Item value)
        {
            return value switch
            {
                LlamaParseOutputOptionsImagesToSaveVariant1Item.Embedded => "embedded",
                LlamaParseOutputOptionsImagesToSaveVariant1Item.Layout => "layout",
                LlamaParseOutputOptionsImagesToSaveVariant1Item.Screenshot => "screenshot",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LlamaParseOutputOptionsImagesToSaveVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "embedded" => LlamaParseOutputOptionsImagesToSaveVariant1Item.Embedded,
                "layout" => LlamaParseOutputOptionsImagesToSaveVariant1Item.Layout,
                "screenshot" => LlamaParseOutputOptionsImagesToSaveVariant1Item.Screenshot,
                _ => null,
            };
        }
    }
}