
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// The pipeline's type.
    /// </summary>
    public enum PipelineResponsePipelineType
    {
        /// <summary>
        ///
        /// </summary>
        Managed,
        /// <summary>
        ///
        /// </summary>
        Playground,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelineResponsePipelineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelineResponsePipelineType value)
        {
            return value switch
            {
                PipelineResponsePipelineType.Managed => "MANAGED",
                PipelineResponsePipelineType.Playground => "PLAYGROUND",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelineResponsePipelineType? ToEnum(string value)
        {
            return value switch
            {
                "MANAGED" => PipelineResponsePipelineType.Managed,
                "PLAYGROUND" => PipelineResponsePipelineType.Playground,
                _ => null,
            };
        }
    }
}