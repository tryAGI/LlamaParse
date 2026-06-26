
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1Item
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
    public static class ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1Item value)
        {
            return value switch
            {
                ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1Item.Ephemeral => "ephemeral",
                ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1Item.Index => "index",
                ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1Item.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "ephemeral" => ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1Item.Ephemeral,
                "index" => ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1Item.Index,
                "user" => ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1Item.User,
                _ => null,
            };
        }
    }
}