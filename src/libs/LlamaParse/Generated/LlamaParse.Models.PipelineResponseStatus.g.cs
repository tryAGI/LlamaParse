
#nullable enable

namespace LlamaParse
{
    /// <summary>
    ///
    /// </summary>
    public enum PipelineResponseStatus
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
    public static class PipelineResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelineResponseStatus value)
        {
            return value switch
            {
                PipelineResponseStatus.Created => "CREATED",
                PipelineResponseStatus.Deleting => "DELETING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelineResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "CREATED" => PipelineResponseStatus.Created,
                "DELETING" => PipelineResponseStatus.Deleting,
                _ => null,
            };
        }
    }
}