
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Directory type. Use 'ephemeral' for batch processing with automatic cleanup.<br/>
    /// Default Value: user
    /// </summary>
    public enum DirectoryCreateRequestType
    {
        /// <summary>
        /// 
        /// </summary>
        Ephemeral,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DirectoryCreateRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DirectoryCreateRequestType value)
        {
            return value switch
            {
                DirectoryCreateRequestType.Ephemeral => "ephemeral",
                DirectoryCreateRequestType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DirectoryCreateRequestType? ToEnum(string value)
        {
            return value switch
            {
                "ephemeral" => DirectoryCreateRequestType.Ephemeral,
                "user" => DirectoryCreateRequestType.User,
                _ => null,
            };
        }
    }
}