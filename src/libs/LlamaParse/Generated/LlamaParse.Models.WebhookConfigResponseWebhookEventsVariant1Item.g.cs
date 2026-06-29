
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookConfigResponseWebhookEventsVariant1Item
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
    public static class WebhookConfigResponseWebhookEventsVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookConfigResponseWebhookEventsVariant1Item value)
        {
            return value switch
            {
                WebhookConfigResponseWebhookEventsVariant1Item.ClassifyCancelled => "classify.cancelled",
                WebhookConfigResponseWebhookEventsVariant1Item.ClassifyError => "classify.error",
                WebhookConfigResponseWebhookEventsVariant1Item.ClassifyPartialSuccess => "classify.partial_success",
                WebhookConfigResponseWebhookEventsVariant1Item.ClassifyPending => "classify.pending",
                WebhookConfigResponseWebhookEventsVariant1Item.ClassifyRunning => "classify.running",
                WebhookConfigResponseWebhookEventsVariant1Item.ClassifySuccess => "classify.success",
                WebhookConfigResponseWebhookEventsVariant1Item.ExtractCancelled => "extract.cancelled",
                WebhookConfigResponseWebhookEventsVariant1Item.ExtractError => "extract.error",
                WebhookConfigResponseWebhookEventsVariant1Item.ExtractPartialSuccess => "extract.partial_success",
                WebhookConfigResponseWebhookEventsVariant1Item.ExtractPending => "extract.pending",
                WebhookConfigResponseWebhookEventsVariant1Item.ExtractSuccess => "extract.success",
                WebhookConfigResponseWebhookEventsVariant1Item.ParseCancelled => "parse.cancelled",
                WebhookConfigResponseWebhookEventsVariant1Item.ParseError => "parse.error",
                WebhookConfigResponseWebhookEventsVariant1Item.ParsePartialSuccess => "parse.partial_success",
                WebhookConfigResponseWebhookEventsVariant1Item.ParsePending => "parse.pending",
                WebhookConfigResponseWebhookEventsVariant1Item.ParseRunning => "parse.running",
                WebhookConfigResponseWebhookEventsVariant1Item.ParseSuccess => "parse.success",
                WebhookConfigResponseWebhookEventsVariant1Item.SheetsCancelled => "sheets.cancelled",
                WebhookConfigResponseWebhookEventsVariant1Item.SheetsError => "sheets.error",
                WebhookConfigResponseWebhookEventsVariant1Item.SheetsPartialSuccess => "sheets.partial_success",
                WebhookConfigResponseWebhookEventsVariant1Item.SheetsPending => "sheets.pending",
                WebhookConfigResponseWebhookEventsVariant1Item.SheetsSuccess => "sheets.success",
                WebhookConfigResponseWebhookEventsVariant1Item.SplitCancelled => "split.cancelled",
                WebhookConfigResponseWebhookEventsVariant1Item.SplitError => "split.error",
                WebhookConfigResponseWebhookEventsVariant1Item.SplitPending => "split.pending",
                WebhookConfigResponseWebhookEventsVariant1Item.SplitProcessing => "split.processing",
                WebhookConfigResponseWebhookEventsVariant1Item.SplitSuccess => "split.success",
                WebhookConfigResponseWebhookEventsVariant1Item.UnmappedEvent => "unmapped_event",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookConfigResponseWebhookEventsVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "classify.cancelled" => WebhookConfigResponseWebhookEventsVariant1Item.ClassifyCancelled,
                "classify.error" => WebhookConfigResponseWebhookEventsVariant1Item.ClassifyError,
                "classify.partial_success" => WebhookConfigResponseWebhookEventsVariant1Item.ClassifyPartialSuccess,
                "classify.pending" => WebhookConfigResponseWebhookEventsVariant1Item.ClassifyPending,
                "classify.running" => WebhookConfigResponseWebhookEventsVariant1Item.ClassifyRunning,
                "classify.success" => WebhookConfigResponseWebhookEventsVariant1Item.ClassifySuccess,
                "extract.cancelled" => WebhookConfigResponseWebhookEventsVariant1Item.ExtractCancelled,
                "extract.error" => WebhookConfigResponseWebhookEventsVariant1Item.ExtractError,
                "extract.partial_success" => WebhookConfigResponseWebhookEventsVariant1Item.ExtractPartialSuccess,
                "extract.pending" => WebhookConfigResponseWebhookEventsVariant1Item.ExtractPending,
                "extract.success" => WebhookConfigResponseWebhookEventsVariant1Item.ExtractSuccess,
                "parse.cancelled" => WebhookConfigResponseWebhookEventsVariant1Item.ParseCancelled,
                "parse.error" => WebhookConfigResponseWebhookEventsVariant1Item.ParseError,
                "parse.partial_success" => WebhookConfigResponseWebhookEventsVariant1Item.ParsePartialSuccess,
                "parse.pending" => WebhookConfigResponseWebhookEventsVariant1Item.ParsePending,
                "parse.running" => WebhookConfigResponseWebhookEventsVariant1Item.ParseRunning,
                "parse.success" => WebhookConfigResponseWebhookEventsVariant1Item.ParseSuccess,
                "sheets.cancelled" => WebhookConfigResponseWebhookEventsVariant1Item.SheetsCancelled,
                "sheets.error" => WebhookConfigResponseWebhookEventsVariant1Item.SheetsError,
                "sheets.partial_success" => WebhookConfigResponseWebhookEventsVariant1Item.SheetsPartialSuccess,
                "sheets.pending" => WebhookConfigResponseWebhookEventsVariant1Item.SheetsPending,
                "sheets.success" => WebhookConfigResponseWebhookEventsVariant1Item.SheetsSuccess,
                "split.cancelled" => WebhookConfigResponseWebhookEventsVariant1Item.SplitCancelled,
                "split.error" => WebhookConfigResponseWebhookEventsVariant1Item.SplitError,
                "split.pending" => WebhookConfigResponseWebhookEventsVariant1Item.SplitPending,
                "split.processing" => WebhookConfigResponseWebhookEventsVariant1Item.SplitProcessing,
                "split.success" => WebhookConfigResponseWebhookEventsVariant1Item.SplitSuccess,
                "unmapped_event" => WebhookConfigResponseWebhookEventsVariant1Item.UnmappedEvent,
                _ => null,
            };
        }
    }
}