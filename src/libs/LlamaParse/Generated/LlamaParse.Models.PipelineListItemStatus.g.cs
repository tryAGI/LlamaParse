
#nullable enable

namespace LlamaParse
{
    /// <summary>
    ///
    /// </summary>
    public enum PipelineListItemStatus
    {
        /// <summary>
        ///
        /// </summary>
        Created,
        /// <summary>
        ///
        /// </summary>
        Deleting,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelineListItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelineListItemStatus value)
        {
            return value switch
            {
                PipelineListItemStatus.Created => "CREATED",
                PipelineListItemStatus.Deleting => "DELETING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelineListItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "CREATED" => PipelineListItemStatus.Created,
                "DELETING" => PipelineListItemStatus.Deleting,
                _ => null,
            };
        }
    }
}