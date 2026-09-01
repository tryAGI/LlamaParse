
#nullable enable

namespace LlamaParse
{
    /// <summary>
    ///
    /// </summary>
    public enum ListPipelinesApiV2PipelinesGetPipelineType2
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
    public static class ListPipelinesApiV2PipelinesGetPipelineType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListPipelinesApiV2PipelinesGetPipelineType2 value)
        {
            return value switch
            {
                ListPipelinesApiV2PipelinesGetPipelineType2.Managed => "MANAGED",
                ListPipelinesApiV2PipelinesGetPipelineType2.Playground => "PLAYGROUND",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListPipelinesApiV2PipelinesGetPipelineType2? ToEnum(string value)
        {
            return value switch
            {
                "MANAGED" => ListPipelinesApiV2PipelinesGetPipelineType2.Managed,
                "PLAYGROUND" => ListPipelinesApiV2PipelinesGetPipelineType2.Playground,
                _ => null,
            };
        }
    }
}