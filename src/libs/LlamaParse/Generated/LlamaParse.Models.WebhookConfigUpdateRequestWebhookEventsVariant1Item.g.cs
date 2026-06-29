
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookConfigUpdateRequestWebhookEventsVariant1Item
    {
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookConfigUpdateRequestWebhookEventsVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookConfigUpdateRequestWebhookEventsVariant1Item value)
        {
            return value switch
            {
                WebhookConfigUpdateRequestWebhookEventsVariant1Item.ClassifyCancelled => "classify.cancelled",
                WebhookConfigUpdateRequestWebhookEventsVariant1Item.ClassifyError => "classify.error",
                WebhookConfigUpdateRequestWebhookEventsVariant1Item.ClassifyPartialSuccess => "classify.partial_success",
                WebhookConfigUpdateRequestWebhookEventsVariant1Item.ClassifyPending => "classify.pending",
                WebhookConfigUpdateRequestWebhookEventsVariant1Item.ClassifyRunning => "classify.running",
                WebhookConfigUpdateRequestWebhookEventsVariant1Item.ClassifySuccess => "classify.success",
                WebhookConfigUpdateRequestWebhookEventsVariant1Item.ExtractCancelled => "extract.cancelled",
                WebhookConfigUpdateRequestWebhookEventsVariant1Item.ExtractError => "extract.error",
                WebhookConfigUpdateRequestWebhookEventsVariant1Item.ExtractPartialSuccess => "extract.partial_success",
                WebhookConfigUpdateRequestWebhookEventsVariant1Item.ExtractPending => "extract.pending",
                WebhookConfigUpdateRequestWebhookEventsVariant1Item.ExtractSuccess => "extract.success",
                WebhookConfigUpdateRequestWebhookEventsVariant1Item.ParseCancelled => "parse.cancelled",
                WebhookConfigUpdateRequestWebhookEventsVariant1Item.ParseError => "parse.error",
                WebhookConfigUpdateRequestWebhookEventsVariant1Item.ParsePartialSuccess => "parse.partial_success",
                WebhookConfigUpdateRequestWebhookEventsVariant1Item.ParsePending => "parse.pending",
                WebhookConfigUpdateRequestWebhookEventsVariant1Item.ParseRunning => "parse.running",
                WebhookConfigUpdateRequestWebhookEventsVariant1Item.ParseSuccess => "parse.success",
                WebhookConfigUpdateRequestWebhookEventsVariant1Item.SheetsCancelled => "sheets.cancelled",
                WebhookConfigUpdateRequestWebhookEventsVariant1Item.SheetsError => "sheets.error",
                WebhookConfigUpdateRequestWebhookEventsVariant1Item.SheetsPartialSuccess => "sheets.partial_success",
                WebhookConfigUpdateRequestWebhookEventsVariant1Item.SheetsPending => "sheets.pending",
                WebhookConfigUpdateRequestWebhookEventsVariant1Item.SheetsSuccess => "sheets.success",
                WebhookConfigUpdateRequestWebhookEventsVariant1Item.SplitCancelled => "split.cancelled",
                WebhookConfigUpdateRequestWebhookEventsVariant1Item.SplitError => "split.error",
                WebhookConfigUpdateRequestWebhookEventsVariant1Item.SplitPending => "split.pending",
                WebhookConfigUpdateRequestWebhookEventsVariant1Item.SplitProcessing => "split.processing",
                WebhookConfigUpdateRequestWebhookEventsVariant1Item.SplitSuccess => "split.success",
                WebhookConfigUpdateRequestWebhookEventsVariant1Item.UnmappedEvent => "unmapped_event",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookConfigUpdateRequestWebhookEventsVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "classify.cancelled" => WebhookConfigUpdateRequestWebhookEventsVariant1Item.ClassifyCancelled,
                "classify.error" => WebhookConfigUpdateRequestWebhookEventsVariant1Item.ClassifyError,
                "classify.partial_success" => WebhookConfigUpdateRequestWebhookEventsVariant1Item.ClassifyPartialSuccess,
                "classify.pending" => WebhookConfigUpdateRequestWebhookEventsVariant1Item.ClassifyPending,
                "classify.running" => WebhookConfigUpdateRequestWebhookEventsVariant1Item.ClassifyRunning,
                "classify.success" => WebhookConfigUpdateRequestWebhookEventsVariant1Item.ClassifySuccess,
                "extract.cancelled" => WebhookConfigUpdateRequestWebhookEventsVariant1Item.ExtractCancelled,
                "extract.error" => WebhookConfigUpdateRequestWebhookEventsVariant1Item.ExtractError,
                "extract.partial_success" => WebhookConfigUpdateRequestWebhookEventsVariant1Item.ExtractPartialSuccess,
                "extract.pending" => WebhookConfigUpdateRequestWebhookEventsVariant1Item.ExtractPending,
                "extract.success" => WebhookConfigUpdateRequestWebhookEventsVariant1Item.ExtractSuccess,
                "parse.cancelled" => WebhookConfigUpdateRequestWebhookEventsVariant1Item.ParseCancelled,
                "parse.error" => WebhookConfigUpdateRequestWebhookEventsVariant1Item.ParseError,
                "parse.partial_success" => WebhookConfigUpdateRequestWebhookEventsVariant1Item.ParsePartialSuccess,
                "parse.pending" => WebhookConfigUpdateRequestWebhookEventsVariant1Item.ParsePending,
                "parse.running" => WebhookConfigUpdateRequestWebhookEventsVariant1Item.ParseRunning,
                "parse.success" => WebhookConfigUpdateRequestWebhookEventsVariant1Item.ParseSuccess,
                "sheets.cancelled" => WebhookConfigUpdateRequestWebhookEventsVariant1Item.SheetsCancelled,
                "sheets.error" => WebhookConfigUpdateRequestWebhookEventsVariant1Item.SheetsError,
                "sheets.partial_success" => WebhookConfigUpdateRequestWebhookEventsVariant1Item.SheetsPartialSuccess,
                "sheets.pending" => WebhookConfigUpdateRequestWebhookEventsVariant1Item.SheetsPending,
                "sheets.success" => WebhookConfigUpdateRequestWebhookEventsVariant1Item.SheetsSuccess,
                "split.cancelled" => WebhookConfigUpdateRequestWebhookEventsVariant1Item.SplitCancelled,
                "split.error" => WebhookConfigUpdateRequestWebhookEventsVariant1Item.SplitError,
                "split.pending" => WebhookConfigUpdateRequestWebhookEventsVariant1Item.SplitPending,
                "split.processing" => WebhookConfigUpdateRequestWebhookEventsVariant1Item.SplitProcessing,
                "split.success" => WebhookConfigUpdateRequestWebhookEventsVariant1Item.SplitSuccess,
                "unmapped_event" => WebhookConfigUpdateRequestWebhookEventsVariant1Item.UnmappedEvent,
                _ => null,
            };
        }
    }
}