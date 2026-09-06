
#nullable enable

namespace LlamaParse
{
    /// <summary>
    ///
    /// </summary>
    public enum ListPipelinesApiV2PipelinesGetPipelineType
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
    public static class ListPipelinesApiV2PipelinesGetPipelineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListPipelinesApiV2PipelinesGetPipelineType value)
        {
            return value switch
            {
                ListPipelinesApiV2PipelinesGetPipelineType.Managed => "MANAGED",
                ListPipelinesApiV2PipelinesGetPipelineType.Playground => "PLAYGROUND",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListPipelinesApiV2PipelinesGetPipelineType? ToEnum(string value)
        {
            return value switch
            {
                "MANAGED" => ListPipelinesApiV2PipelinesGetPipelineType.Managed,
                "PLAYGROUND" => ListPipelinesApiV2PipelinesGetPipelineType.Playground,
                _ => null,
            };
        }
    }
}