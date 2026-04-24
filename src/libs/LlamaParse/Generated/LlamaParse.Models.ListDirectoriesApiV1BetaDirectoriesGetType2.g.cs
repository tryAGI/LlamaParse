
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListDirectoriesApiV1BetaDirectoriesGetType2
    {
        /// <summary>
        /// 
        /// </summary>
        Index,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListDirectoriesApiV1BetaDirectoriesGetType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDirectoriesApiV1BetaDirectoriesGetType2 value)
        {
            return value switch
            {
                ListDirectoriesApiV1BetaDirectoriesGetType2.Index => "index",
                ListDirectoriesApiV1BetaDirectoriesGetType2.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDirectoriesApiV1BetaDirectoriesGetType2? ToEnum(string value)
        {
            return value switch
            {
                "index" => ListDirectoriesApiV1BetaDirectoriesGetType2.Index,
                "user" => ListDirectoriesApiV1BetaDirectoriesGetType2.User,
                _ => null,
            };
        }
    }
}