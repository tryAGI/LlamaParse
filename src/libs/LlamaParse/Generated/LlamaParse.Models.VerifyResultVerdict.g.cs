
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Overall verdict for the document
    /// </summary>
    public enum VerifyResultVerdict
    {
        /// <summary>
        /// 
        /// </summary>
        Authentic,
        /// <summary>
        /// 
        /// </summary>
        Doctored,
        /// <summary>
        /// 
        /// </summary>
        LikelyDoctored,
        /// <summary>
        /// 
        /// </summary>
        NoStrongSignal,
        /// <summary>
        /// 
        /// </summary>
        Suspicious,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VerifyResultVerdictExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VerifyResultVerdict value)
        {
            return value switch
            {
                VerifyResultVerdict.Authentic => "AUTHENTIC",
                VerifyResultVerdict.Doctored => "DOCTORED",
                VerifyResultVerdict.LikelyDoctored => "LIKELY_DOCTORED",
                VerifyResultVerdict.NoStrongSignal => "NO_STRONG_SIGNAL",
                VerifyResultVerdict.Suspicious => "SUSPICIOUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VerifyResultVerdict? ToEnum(string value)
        {
            return value switch
            {
                "AUTHENTIC" => VerifyResultVerdict.Authentic,
                "DOCTORED" => VerifyResultVerdict.Doctored,
                "LIKELY_DOCTORED" => VerifyResultVerdict.LikelyDoctored,
                "NO_STRONG_SIGNAL" => VerifyResultVerdict.NoStrongSignal,
                "SUSPICIOUS" => VerifyResultVerdict.Suspicious,
                _ => null,
            };
        }
    }
}