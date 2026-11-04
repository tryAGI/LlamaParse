
#nullable enable

namespace LlamaParse
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateExtractReviewApiV2ExtractJobIdReviewPostOrigin
    {
        /// <summary>
        ///
        /// </summary>
        History,
        /// <summary>
        ///
        /// </summary>
        Run,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateExtractReviewApiV2ExtractJobIdReviewPostOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateExtractReviewApiV2ExtractJobIdReviewPostOrigin value)
        {
            return value switch
            {
                CreateExtractReviewApiV2ExtractJobIdReviewPostOrigin.History => "history",
                CreateExtractReviewApiV2ExtractJobIdReviewPostOrigin.Run => "run",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateExtractReviewApiV2ExtractJobIdReviewPostOrigin? ToEnum(string value)
        {
            return value switch
            {
                "history" => CreateExtractReviewApiV2ExtractJobIdReviewPostOrigin.History,
                "run" => CreateExtractReviewApiV2ExtractJobIdReviewPostOrigin.Run,
                _ => null,
            };
        }
    }
}