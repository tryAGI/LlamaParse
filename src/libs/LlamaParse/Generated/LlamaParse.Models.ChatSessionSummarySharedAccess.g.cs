
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// What this chat's share link grants: read_only (transcript only) or query (viewers may ask new questions).
    /// </summary>
    public enum ChatSessionSummarySharedAccess
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
    public static class ChatSessionSummarySharedAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatSessionSummarySharedAccess value)
        {
            return value switch
            {
                ChatSessionSummarySharedAccess.Query => "query",
                ChatSessionSummarySharedAccess.ReadOnly => "read_only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatSessionSummarySharedAccess? ToEnum(string value)
        {
            return value switch
            {
                "query" => ChatSessionSummarySharedAccess.Query,
                "read_only" => ChatSessionSummarySharedAccess.ReadOnly,
                _ => null,
            };
        }
    }
}