
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Verify tier: 'fast' runs only the quick deterministic forensic checks (metadata, content integrity, container structure, pixel statistics); 'agentic' (default) runs the full pipeline including the learned detectors and the semantic review pass.<br/>
    /// Default Value: agentic
    /// </summary>
    public enum VerifyConfigurationTier
    {
        /// <summary>
        /// 'fast' runs only the quick deterministic forensic checks (metadata, content integrity, container structure, pixel statistics); 'agentic' (default) runs the full pipeline including the learned detectors and the semantic review pass.
        /// </summary>
        Agentic,
        /// <summary>
        /// 'fast' runs only the quick deterministic forensic checks (metadata, content integrity, container structure, pixel statistics); 'agentic' (default) runs the full pipeline including the learned detectors and the semantic review pass.
        /// </summary>
        Fast,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VerifyConfigurationTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VerifyConfigurationTier value)
        {
            return value switch
            {
                VerifyConfigurationTier.Agentic => "agentic",
                VerifyConfigurationTier.Fast => "fast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VerifyConfigurationTier? ToEnum(string value)
        {
            return value switch
            {
                "agentic" => VerifyConfigurationTier.Agentic,
                "fast" => VerifyConfigurationTier.Fast,
                _ => null,
            };
        }
    }
}