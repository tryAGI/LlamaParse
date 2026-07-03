
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public enum DirectoryResponseType2
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
    public static class DirectoryResponseType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DirectoryResponseType2 value)
        {
            return value switch
            {
                DirectoryResponseType2.Ephemeral => "ephemeral",
                DirectoryResponseType2.Index => "index",
                DirectoryResponseType2.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DirectoryResponseType2? ToEnum(string value)
        {
            return value switch
            {
                "ephemeral" => DirectoryResponseType2.Ephemeral,
                "index" => DirectoryResponseType2.Index,
                "user" => DirectoryResponseType2.User,
                _ => null,
            };
        }
    }
}