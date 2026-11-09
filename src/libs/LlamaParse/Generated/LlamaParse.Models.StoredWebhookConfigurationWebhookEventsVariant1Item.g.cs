
#nullable enable

namespace LlamaParse
{
    /// <summary>
    ///
    /// </summary>
    public enum StoredWebhookConfigurationWebhookEventsVariant1Item
    {
        /// <summary>
        ///
        /// </summary>
        BatchCancelled,
        /// <summary>
        ///
        /// </summary>
        BatchError,
        /// <summary>
        ///
        /// </summary>
        BatchPending,
        /// <summary>
        ///
        /// </summary>
        BatchRunning,
        /// <summary>
        ///
        /// </summary>
        BatchSuccess,
        /// <summary>
        ///
        /// </summary>
        ClassifyCancelled,
        /// <summary>
        ///
        /// </summary>
        ClassifyError,
        /// <summary>
        ///
        /// </summary>
        ClassifyPartialSuccess,
        /// <summary>
        ///
        /// </summary>
        ClassifyPending,
        /// <summary>
        ///
        /// </summary>
        ClassifyRunning,
        /// <summary>
        ///
        /// </summary>
        ClassifySuccess,
        /// <summary>
        ///
        /// </summary>
        ExtractCancelled,
        /// <summary>
        ///
        /// </summary>
        ExtractError,
        /// <summary>
        ///
        /// </summary>
        ExtractPartialSuccess,
        /// <summary>
        ///
        /// </summary>
        ExtractPending,
        /// <summary>
        ///
        /// </summary>
        ExtractRunning,
        /// <summary>
        ///
        /// </summary>
        ExtractSuccess,
        /// <summary>
        ///
        /// </summary>
        ParseCancelled,
        /// <summary>
        ///
        /// </summary>
        ParseError,
        /// <summary>
        ///
        /// </summary>
        ParsePartialSuccess,
        /// <summary>
        ///
        /// </summary>
        ParsePending,
        /// <summary>
        ///
        /// </summary>
        ParseRunning,
        /// <summary>
        ///
        /// </summary>
        ParseSuccess,
        /// <summary>
        ///
        /// </summary>
        SheetsCancelled,
        /// <summary>
        ///
        /// </summary>
        SheetsError,
        /// <summary>
        ///
        /// </summary>
        SheetsPartialSuccess,
        /// <summary>
        ///
        /// </summary>
        SheetsPending,
        /// <summary>
        ///
        /// </summary>
        SheetsSuccess,
        /// <summary>
        ///
        /// </summary>
        SplitCancelled,
        /// <summary>
        ///
        /// </summary>
        SplitError,
        /// <summary>
        ///
        /// </summary>
        SplitPending,
        /// <summary>
        ///
        /// </summary>
        SplitProcessing,
        /// <summary>
        ///
        /// </summary>
        SplitSuccess,
        /// <summary>
        ///
        /// </summary>
        UnmappedEvent,
        /// <summary>
        ///
        /// </summary>
        VerifyCancelled,
        /// <summary>
        ///
        /// </summary>
        VerifyError,
        /// <summary>
        ///
        /// </summary>
        VerifyPending,
        /// <summary>
        ///
        /// </summary>
        VerifyRunning,
        /// <summary>
        ///
        /// </summary>
        VerifySuccess,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StoredWebhookConfigurationWebhookEventsVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StoredWebhookConfigurationWebhookEventsVariant1Item value)
        {
            return value switch
            {
                StoredWebhookConfigurationWebhookEventsVariant1Item.BatchCancelled => "batch.cancelled",
                StoredWebhookConfigurationWebhookEventsVariant1Item.BatchError => "batch.error",
                StoredWebhookConfigurationWebhookEventsVariant1Item.BatchPending => "batch.pending",
                StoredWebhookConfigurationWebhookEventsVariant1Item.BatchRunning => "batch.running",
                StoredWebhookConfigurationWebhookEventsVariant1Item.BatchSuccess => "batch.success",
                StoredWebhookConfigurationWebhookEventsVariant1Item.ClassifyCancelled => "classify.cancelled",
                StoredWebhookConfigurationWebhookEventsVariant1Item.ClassifyError => "classify.error",
                StoredWebhookConfigurationWebhookEventsVariant1Item.ClassifyPartialSuccess => "classify.partial_success",
                StoredWebhookConfigurationWebhookEventsVariant1Item.ClassifyPending => "classify.pending",
                StoredWebhookConfigurationWebhookEventsVariant1Item.ClassifyRunning => "classify.running",
                StoredWebhookConfigurationWebhookEventsVariant1Item.ClassifySuccess => "classify.success",
                StoredWebhookConfigurationWebhookEventsVariant1Item.ExtractCancelled => "extract.cancelled",
                StoredWebhookConfigurationWebhookEventsVariant1Item.ExtractError => "extract.error",
                StoredWebhookConfigurationWebhookEventsVariant1Item.ExtractPartialSuccess => "extract.partial_success",
                StoredWebhookConfigurationWebhookEventsVariant1Item.ExtractPending => "extract.pending",
                StoredWebhookConfigurationWebhookEventsVariant1Item.ExtractRunning => "extract.running",
                StoredWebhookConfigurationWebhookEventsVariant1Item.ExtractSuccess => "extract.success",
                StoredWebhookConfigurationWebhookEventsVariant1Item.ParseCancelled => "parse.cancelled",
                StoredWebhookConfigurationWebhookEventsVariant1Item.ParseError => "parse.error",
                StoredWebhookConfigurationWebhookEventsVariant1Item.ParsePartialSuccess => "parse.partial_success",
                StoredWebhookConfigurationWebhookEventsVariant1Item.ParsePending => "parse.pending",
                StoredWebhookConfigurationWebhookEventsVariant1Item.ParseRunning => "parse.running",
                StoredWebhookConfigurationWebhookEventsVariant1Item.ParseSuccess => "parse.success",
                StoredWebhookConfigurationWebhookEventsVariant1Item.SheetsCancelled => "sheets.cancelled",
                StoredWebhookConfigurationWebhookEventsVariant1Item.SheetsError => "sheets.error",
                StoredWebhookConfigurationWebhookEventsVariant1Item.SheetsPartialSuccess => "sheets.partial_success",
                StoredWebhookConfigurationWebhookEventsVariant1Item.SheetsPending => "sheets.pending",
                StoredWebhookConfigurationWebhookEventsVariant1Item.SheetsSuccess => "sheets.success",
                StoredWebhookConfigurationWebhookEventsVariant1Item.SplitCancelled => "split.cancelled",
                StoredWebhookConfigurationWebhookEventsVariant1Item.SplitError => "split.error",
                StoredWebhookConfigurationWebhookEventsVariant1Item.SplitPending => "split.pending",
                StoredWebhookConfigurationWebhookEventsVariant1Item.SplitProcessing => "split.processing",
                StoredWebhookConfigurationWebhookEventsVariant1Item.SplitSuccess => "split.success",
                StoredWebhookConfigurationWebhookEventsVariant1Item.UnmappedEvent => "unmapped_event",
                StoredWebhookConfigurationWebhookEventsVariant1Item.VerifyCancelled => "verify.cancelled",
                StoredWebhookConfigurationWebhookEventsVariant1Item.VerifyError => "verify.error",
                StoredWebhookConfigurationWebhookEventsVariant1Item.VerifyPending => "verify.pending",
                StoredWebhookConfigurationWebhookEventsVariant1Item.VerifyRunning => "verify.running",
                StoredWebhookConfigurationWebhookEventsVariant1Item.VerifySuccess => "verify.success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StoredWebhookConfigurationWebhookEventsVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "batch.cancelled" => StoredWebhookConfigurationWebhookEventsVariant1Item.BatchCancelled,
                "batch.error" => StoredWebhookConfigurationWebhookEventsVariant1Item.BatchError,
                "batch.pending" => StoredWebhookConfigurationWebhookEventsVariant1Item.BatchPending,
                "batch.running" => StoredWebhookConfigurationWebhookEventsVariant1Item.BatchRunning,
                "batch.success" => StoredWebhookConfigurationWebhookEventsVariant1Item.BatchSuccess,
                "classify.cancelled" => StoredWebhookConfigurationWebhookEventsVariant1Item.ClassifyCancelled,
                "classify.error" => StoredWebhookConfigurationWebhookEventsVariant1Item.ClassifyError,
                "classify.partial_success" => StoredWebhookConfigurationWebhookEventsVariant1Item.ClassifyPartialSuccess,
                "classify.pending" => StoredWebhookConfigurationWebhookEventsVariant1Item.ClassifyPending,
                "classify.running" => StoredWebhookConfigurationWebhookEventsVariant1Item.ClassifyRunning,
                "classify.success" => StoredWebhookConfigurationWebhookEventsVariant1Item.ClassifySuccess,
                "extract.cancelled" => StoredWebhookConfigurationWebhookEventsVariant1Item.ExtractCancelled,
                "extract.error" => StoredWebhookConfigurationWebhookEventsVariant1Item.ExtractError,
                "extract.partial_success" => StoredWebhookConfigurationWebhookEventsVariant1Item.ExtractPartialSuccess,
                "extract.pending" => StoredWebhookConfigurationWebhookEventsVariant1Item.ExtractPending,
                "extract.running" => StoredWebhookConfigurationWebhookEventsVariant1Item.ExtractRunning,
                "extract.success" => StoredWebhookConfigurationWebhookEventsVariant1Item.ExtractSuccess,
                "parse.cancelled" => StoredWebhookConfigurationWebhookEventsVariant1Item.ParseCancelled,
                "parse.error" => StoredWebhookConfigurationWebhookEventsVariant1Item.ParseError,
                "parse.partial_success" => StoredWebhookConfigurationWebhookEventsVariant1Item.ParsePartialSuccess,
                "parse.pending" => StoredWebhookConfigurationWebhookEventsVariant1Item.ParsePending,
                "parse.running" => StoredWebhookConfigurationWebhookEventsVariant1Item.ParseRunning,
                "parse.success" => StoredWebhookConfigurationWebhookEventsVariant1Item.ParseSuccess,
                "sheets.cancelled" => StoredWebhookConfigurationWebhookEventsVariant1Item.SheetsCancelled,
                "sheets.error" => StoredWebhookConfigurationWebhookEventsVariant1Item.SheetsError,
                "sheets.partial_success" => StoredWebhookConfigurationWebhookEventsVariant1Item.SheetsPartialSuccess,
                "sheets.pending" => StoredWebhookConfigurationWebhookEventsVariant1Item.SheetsPending,
                "sheets.success" => StoredWebhookConfigurationWebhookEventsVariant1Item.SheetsSuccess,
                "split.cancelled" => StoredWebhookConfigurationWebhookEventsVariant1Item.SplitCancelled,
                "split.error" => StoredWebhookConfigurationWebhookEventsVariant1Item.SplitError,
                "split.pending" => StoredWebhookConfigurationWebhookEventsVariant1Item.SplitPending,
                "split.processing" => StoredWebhookConfigurationWebhookEventsVariant1Item.SplitProcessing,
                "split.success" => StoredWebhookConfigurationWebhookEventsVariant1Item.SplitSuccess,
                "unmapped_event" => StoredWebhookConfigurationWebhookEventsVariant1Item.UnmappedEvent,
                "verify.cancelled" => StoredWebhookConfigurationWebhookEventsVariant1Item.VerifyCancelled,
                "verify.error" => StoredWebhookConfigurationWebhookEventsVariant1Item.VerifyError,
                "verify.pending" => StoredWebhookConfigurationWebhookEventsVariant1Item.VerifyPending,
                "verify.running" => StoredWebhookConfigurationWebhookEventsVariant1Item.VerifyRunning,
                "verify.success" => StoredWebhookConfigurationWebhookEventsVariant1Item.VerifySuccess,
                _ => null,
            };
        }
    }
}