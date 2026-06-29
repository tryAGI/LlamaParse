
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookConfigCreateRequestWebhookEventsVariant1Item
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
    public static class WebhookConfigCreateRequestWebhookEventsVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookConfigCreateRequestWebhookEventsVariant1Item value)
        {
            return value switch
            {
                WebhookConfigCreateRequestWebhookEventsVariant1Item.ClassifyCancelled => "classify.cancelled",
                WebhookConfigCreateRequestWebhookEventsVariant1Item.ClassifyError => "classify.error",
                WebhookConfigCreateRequestWebhookEventsVariant1Item.ClassifyPartialSuccess => "classify.partial_success",
                WebhookConfigCreateRequestWebhookEventsVariant1Item.ClassifyPending => "classify.pending",
                WebhookConfigCreateRequestWebhookEventsVariant1Item.ClassifyRunning => "classify.running",
                WebhookConfigCreateRequestWebhookEventsVariant1Item.ClassifySuccess => "classify.success",
                WebhookConfigCreateRequestWebhookEventsVariant1Item.ExtractCancelled => "extract.cancelled",
                WebhookConfigCreateRequestWebhookEventsVariant1Item.ExtractError => "extract.error",
                WebhookConfigCreateRequestWebhookEventsVariant1Item.ExtractPartialSuccess => "extract.partial_success",
                WebhookConfigCreateRequestWebhookEventsVariant1Item.ExtractPending => "extract.pending",
                WebhookConfigCreateRequestWebhookEventsVariant1Item.ExtractSuccess => "extract.success",
                WebhookConfigCreateRequestWebhookEventsVariant1Item.ParseCancelled => "parse.cancelled",
                WebhookConfigCreateRequestWebhookEventsVariant1Item.ParseError => "parse.error",
                WebhookConfigCreateRequestWebhookEventsVariant1Item.ParsePartialSuccess => "parse.partial_success",
                WebhookConfigCreateRequestWebhookEventsVariant1Item.ParsePending => "parse.pending",
                WebhookConfigCreateRequestWebhookEventsVariant1Item.ParseRunning => "parse.running",
                WebhookConfigCreateRequestWebhookEventsVariant1Item.ParseSuccess => "parse.success",
                WebhookConfigCreateRequestWebhookEventsVariant1Item.SheetsCancelled => "sheets.cancelled",
                WebhookConfigCreateRequestWebhookEventsVariant1Item.SheetsError => "sheets.error",
                WebhookConfigCreateRequestWebhookEventsVariant1Item.SheetsPartialSuccess => "sheets.partial_success",
                WebhookConfigCreateRequestWebhookEventsVariant1Item.SheetsPending => "sheets.pending",
                WebhookConfigCreateRequestWebhookEventsVariant1Item.SheetsSuccess => "sheets.success",
                WebhookConfigCreateRequestWebhookEventsVariant1Item.SplitCancelled => "split.cancelled",
                WebhookConfigCreateRequestWebhookEventsVariant1Item.SplitError => "split.error",
                WebhookConfigCreateRequestWebhookEventsVariant1Item.SplitPending => "split.pending",
                WebhookConfigCreateRequestWebhookEventsVariant1Item.SplitProcessing => "split.processing",
                WebhookConfigCreateRequestWebhookEventsVariant1Item.SplitSuccess => "split.success",
                WebhookConfigCreateRequestWebhookEventsVariant1Item.UnmappedEvent => "unmapped_event",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookConfigCreateRequestWebhookEventsVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "classify.cancelled" => WebhookConfigCreateRequestWebhookEventsVariant1Item.ClassifyCancelled,
                "classify.error" => WebhookConfigCreateRequestWebhookEventsVariant1Item.ClassifyError,
                "classify.partial_success" => WebhookConfigCreateRequestWebhookEventsVariant1Item.ClassifyPartialSuccess,
                "classify.pending" => WebhookConfigCreateRequestWebhookEventsVariant1Item.ClassifyPending,
                "classify.running" => WebhookConfigCreateRequestWebhookEventsVariant1Item.ClassifyRunning,
                "classify.success" => WebhookConfigCreateRequestWebhookEventsVariant1Item.ClassifySuccess,
                "extract.cancelled" => WebhookConfigCreateRequestWebhookEventsVariant1Item.ExtractCancelled,
                "extract.error" => WebhookConfigCreateRequestWebhookEventsVariant1Item.ExtractError,
                "extract.partial_success" => WebhookConfigCreateRequestWebhookEventsVariant1Item.ExtractPartialSuccess,
                "extract.pending" => WebhookConfigCreateRequestWebhookEventsVariant1Item.ExtractPending,
                "extract.success" => WebhookConfigCreateRequestWebhookEventsVariant1Item.ExtractSuccess,
                "parse.cancelled" => WebhookConfigCreateRequestWebhookEventsVariant1Item.ParseCancelled,
                "parse.error" => WebhookConfigCreateRequestWebhookEventsVariant1Item.ParseError,
                "parse.partial_success" => WebhookConfigCreateRequestWebhookEventsVariant1Item.ParsePartialSuccess,
                "parse.pending" => WebhookConfigCreateRequestWebhookEventsVariant1Item.ParsePending,
                "parse.running" => WebhookConfigCreateRequestWebhookEventsVariant1Item.ParseRunning,
                "parse.success" => WebhookConfigCreateRequestWebhookEventsVariant1Item.ParseSuccess,
                "sheets.cancelled" => WebhookConfigCreateRequestWebhookEventsVariant1Item.SheetsCancelled,
                "sheets.error" => WebhookConfigCreateRequestWebhookEventsVariant1Item.SheetsError,
                "sheets.partial_success" => WebhookConfigCreateRequestWebhookEventsVariant1Item.SheetsPartialSuccess,
                "sheets.pending" => WebhookConfigCreateRequestWebhookEventsVariant1Item.SheetsPending,
                "sheets.success" => WebhookConfigCreateRequestWebhookEventsVariant1Item.SheetsSuccess,
                "split.cancelled" => WebhookConfigCreateRequestWebhookEventsVariant1Item.SplitCancelled,
                "split.error" => WebhookConfigCreateRequestWebhookEventsVariant1Item.SplitError,
                "split.pending" => WebhookConfigCreateRequestWebhookEventsVariant1Item.SplitPending,
                "split.processing" => WebhookConfigCreateRequestWebhookEventsVariant1Item.SplitProcessing,
                "split.success" => WebhookConfigCreateRequestWebhookEventsVariant1Item.SplitSuccess,
                "unmapped_event" => WebhookConfigCreateRequestWebhookEventsVariant1Item.UnmappedEvent,
                _ => null,
            };
        }
    }
}