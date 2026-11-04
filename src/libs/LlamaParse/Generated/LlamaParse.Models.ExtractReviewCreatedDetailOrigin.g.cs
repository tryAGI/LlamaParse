
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Turned on as the job ran, from History, by a first edit, or by the API.
    /// </summary>
    public enum ExtractReviewCreatedDetailOrigin
    {
        /// <summary>
        ///
        /// </summary>
        Api,
        /// <summary>
        ///
        /// </summary>
        Edit,
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
    public static class ExtractReviewCreatedDetailOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractReviewCreatedDetailOrigin value)
        {
            return value switch
            {
                ExtractReviewCreatedDetailOrigin.Api => "api",
                ExtractReviewCreatedDetailOrigin.Edit => "edit",
                ExtractReviewCreatedDetailOrigin.History => "history",
                ExtractReviewCreatedDetailOrigin.Run => "run",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractReviewCreatedDetailOrigin? ToEnum(string value)
        {
            return value switch
            {
                "api" => ExtractReviewCreatedDetailOrigin.Api,
                "edit" => ExtractReviewCreatedDetailOrigin.Edit,
                "history" => ExtractReviewCreatedDetailOrigin.History,
                "run" => ExtractReviewCreatedDetailOrigin.Run,
                _ => null,
            };
        }
    }
}