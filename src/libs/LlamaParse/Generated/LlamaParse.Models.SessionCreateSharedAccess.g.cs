
#nullable enable

namespace LlamaParse
{
    /// <summary>
    ///
    /// </summary>
    public enum SessionCreateSharedAccess
    {
        /// <summary>
        ///
        /// </summary>
        Query,
        /// <summary>
        ///
        /// </summary>
        ReadOnly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionCreateSharedAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionCreateSharedAccess value)
        {
            return value switch
            {
                SessionCreateSharedAccess.Query => "query",
                SessionCreateSharedAccess.ReadOnly => "read_only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionCreateSharedAccess? ToEnum(string value)
        {
            return value switch
            {
                "query" => SessionCreateSharedAccess.Query,
                "read_only" => SessionCreateSharedAccess.ReadOnly,
                _ => null,
            };
        }
    }
}