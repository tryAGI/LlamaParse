
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Product type: parse or extract.
    /// </summary>
    public enum SyncProductEntryRequestProductType
    {
        /// <summary>
        /// parse or extract.
        /// </summary>
        Extract,
        /// <summary>
        /// parse or extract.
        /// </summary>
        Parse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SyncProductEntryRequestProductTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SyncProductEntryRequestProductType value)
        {
            return value switch
            {
                SyncProductEntryRequestProductType.Extract => "extract",
                SyncProductEntryRequestProductType.Parse => "parse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SyncProductEntryRequestProductType? ToEnum(string value)
        {
            return value switch
            {
                "extract" => SyncProductEntryRequestProductType.Extract,
                "parse" => SyncProductEntryRequestProductType.Parse,
                _ => null,
            };
        }
    }
}