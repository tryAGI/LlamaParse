
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Type of revision
    /// </summary>
    public enum RevisionType
    {
        /// <summary>
        /// 
        /// </summary>
        Comment,
        /// <summary>
        /// 
        /// </summary>
        Deleted,
        /// <summary>
        /// 
        /// </summary>
        Formatted,
        /// <summary>
        /// 
        /// </summary>
        Inserted,
        /// <summary>
        /// 
        /// </summary>
        MovedFrom,
        /// <summary>
        /// 
        /// </summary>
        MovedTo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RevisionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RevisionType value)
        {
            return value switch
            {
                RevisionType.Comment => "comment",
                RevisionType.Deleted => "deleted",
                RevisionType.Formatted => "formatted",
                RevisionType.Inserted => "inserted",
                RevisionType.MovedFrom => "moved_from",
                RevisionType.MovedTo => "moved_to",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RevisionType? ToEnum(string value)
        {
            return value switch
            {
                "comment" => RevisionType.Comment,
                "deleted" => RevisionType.Deleted,
                "formatted" => RevisionType.Formatted,
                "inserted" => RevisionType.Inserted,
                "moved_from" => RevisionType.MovedFrom,
                "moved_to" => RevisionType.MovedTo,
                _ => null,
            };
        }
    }
}