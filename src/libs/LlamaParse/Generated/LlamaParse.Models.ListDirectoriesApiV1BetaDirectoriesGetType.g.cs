
#nullable enable

namespace LlamaParse
{
    /// <summary>
    ///
    /// </summary>
    public enum ListDirectoriesApiV1BetaDirectoriesGetType
    {
        /// <summary>
        ///
        /// </summary>
        Ephemeral,
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
    public static class ListDirectoriesApiV1BetaDirectoriesGetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDirectoriesApiV1BetaDirectoriesGetType value)
        {
            return value switch
            {
                ListDirectoriesApiV1BetaDirectoriesGetType.Ephemeral => "ephemeral",
                ListDirectoriesApiV1BetaDirectoriesGetType.Index => "index",
                ListDirectoriesApiV1BetaDirectoriesGetType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDirectoriesApiV1BetaDirectoriesGetType? ToEnum(string value)
        {
            return value switch
            {
                "ephemeral" => ListDirectoriesApiV1BetaDirectoriesGetType.Ephemeral,
                "index" => ListDirectoriesApiV1BetaDirectoriesGetType.Index,
                "user" => ListDirectoriesApiV1BetaDirectoriesGetType.User,
                _ => null,
            };
        }
    }
}