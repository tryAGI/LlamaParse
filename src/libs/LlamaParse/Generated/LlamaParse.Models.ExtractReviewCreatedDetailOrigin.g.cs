
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Turned on as the job ran, from History, by a first edit, by the API, or by the configuration's review policy as the job completed.
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
        Policy,
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
                ExtractReviewCreatedDetailOrigin.Policy => "policy",
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
                "policy" => ExtractReviewCreatedDetailOrigin.Policy,
                "run" => ExtractReviewCreatedDetailOrigin.Run,
                _ => null,
            };
        }
    }
}