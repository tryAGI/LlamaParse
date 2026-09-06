
#nullable enable

namespace LlamaParse
{
    /// <summary>
    ///
    /// </summary>
    public enum DirectoryResponseType
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
    public static class DirectoryResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DirectoryResponseType value)
        {
            return value switch
            {
                DirectoryResponseType.Ephemeral => "ephemeral",
                DirectoryResponseType.Index => "index",
                DirectoryResponseType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DirectoryResponseType? ToEnum(string value)
        {
            return value switch
            {
                "ephemeral" => DirectoryResponseType.Ephemeral,
                "index" => DirectoryResponseType.Index,
                "user" => DirectoryResponseType.User,
                _ => null,
            };
        }
    }
}