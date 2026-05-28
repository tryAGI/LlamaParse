
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Vector export destination for the index. 'DEFAULT' exports to the managed vector DB destination resolved from configuration. 'DISABLED' skips vector export — the export destination falls back to 'Download'.<br/>
    /// Default Value: DEFAULT
    /// </summary>
    public enum IndexCreateRequestVectorTarget
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Disabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IndexCreateRequestVectorTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IndexCreateRequestVectorTarget value)
        {
            return value switch
            {
                IndexCreateRequestVectorTarget.Default => "DEFAULT",
                IndexCreateRequestVectorTarget.Disabled => "DISABLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IndexCreateRequestVectorTarget? ToEnum(string value)
        {
            return value switch
            {
                "DEFAULT" => IndexCreateRequestVectorTarget.Default,
                "DISABLED" => IndexCreateRequestVectorTarget.Disabled,
                _ => null,
            };
        }
    }
}