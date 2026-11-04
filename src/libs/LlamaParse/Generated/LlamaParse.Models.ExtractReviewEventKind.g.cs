
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// What happened.
    /// </summary>
    public enum ExtractReviewEventKind
    {
        /// <summary>
        ///
        /// </summary>
        Approved,
        /// <summary>
        ///
        /// </summary>
        Created,
        /// <summary>
        ///
        /// </summary>
        FieldCleared,
        /// <summary>
        ///
        /// </summary>
        FieldConfirmed,
        /// <summary>
        ///
        /// </summary>
        FieldCorrected,
        /// <summary>
        ///
        /// </summary>
        FieldRestored,
        /// <summary>
        ///
        /// </summary>
        FieldUndone,
        /// <summary>
        ///
        /// </summary>
        FlagsSignedOff,
        /// <summary>
        ///
        /// </summary>
        Rejected,
        /// <summary>
        ///
        /// </summary>
        Reopened,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtractReviewEventKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractReviewEventKind value)
        {
            return value switch
            {
                ExtractReviewEventKind.Approved => "approved",
                ExtractReviewEventKind.Created => "created",
                ExtractReviewEventKind.FieldCleared => "field_cleared",
                ExtractReviewEventKind.FieldConfirmed => "field_confirmed",
                ExtractReviewEventKind.FieldCorrected => "field_corrected",
                ExtractReviewEventKind.FieldRestored => "field_restored",
                ExtractReviewEventKind.FieldUndone => "field_undone",
                ExtractReviewEventKind.FlagsSignedOff => "flags_signed_off",
                ExtractReviewEventKind.Rejected => "rejected",
                ExtractReviewEventKind.Reopened => "reopened",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractReviewEventKind? ToEnum(string value)
        {
            return value switch
            {
                "approved" => ExtractReviewEventKind.Approved,
                "created" => ExtractReviewEventKind.Created,
                "field_cleared" => ExtractReviewEventKind.FieldCleared,
                "field_confirmed" => ExtractReviewEventKind.FieldConfirmed,
                "field_corrected" => ExtractReviewEventKind.FieldCorrected,
                "field_restored" => ExtractReviewEventKind.FieldRestored,
                "field_undone" => ExtractReviewEventKind.FieldUndone,
                "flags_signed_off" => ExtractReviewEventKind.FlagsSignedOff,
                "rejected" => ExtractReviewEventKind.Rejected,
                "reopened" => ExtractReviewEventKind.Reopened,
                _ => null,
            };
        }
    }
}