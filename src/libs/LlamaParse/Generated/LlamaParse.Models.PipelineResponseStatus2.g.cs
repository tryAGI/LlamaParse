
#nullable enable

namespace LlamaParse
{
    /// <summary>
    ///
    /// </summary>
    public enum PipelineResponseStatus2
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
    public static class PipelineResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelineResponseStatus2 value)
        {
            return value switch
            {
                PipelineResponseStatus2.Created => "CREATED",
                PipelineResponseStatus2.Deleting => "DELETING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelineResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "CREATED" => PipelineResponseStatus2.Created,
                "DELETING" => PipelineResponseStatus2.Deleting,
                _ => null,
            };
        }
    }
}