
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// What this chat's share link grants: read_only (transcript only) or query (viewers may ask new questions).
    /// </summary>
    public enum SessionDetailSharedAccess
    {
        /// <summary>
        /// read_only (transcript only) or query (viewers may ask new questions).
        /// </summary>
        Query,
        /// <summary>
        /// read_only (transcript only) or query (viewers may ask new questions).
        /// </summary>
        ReadOnly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionDetailSharedAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionDetailSharedAccess value)
        {
            return value switch
            {
                SessionDetailSharedAccess.Query => "query",
                SessionDetailSharedAccess.ReadOnly => "read_only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionDetailSharedAccess? ToEnum(string value)
        {
            return value switch
            {
                "query" => SessionDetailSharedAccess.Query,
                "read_only" => SessionDetailSharedAccess.ReadOnly,
                _ => null,
            };
        }
    }
}