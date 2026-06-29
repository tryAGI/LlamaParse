
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Request to update a stored webhook configuration. Only set fields change.
    /// </summary>
    public sealed partial class WebhookConfigUpdateRequest
    {
        /// <summary>
        /// Updated webhook URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Updated signing secret (write-only). Send to rotate the secret.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_signing_secret")]
        public string? WebhookSigningSecret { get; set; }

        /// <summary>
        /// Updated headers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? WebhookHeaders { get; set; }

        /// <summary>
        /// Updated event subscriptions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_events")]
        public global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigUpdateRequestWebhookEventsVariant1Item>? WebhookEvents { get; set; }

        /// <summary>
        /// Updated output format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_output_format")]
        public global::LlamaParse.WebhookConfigUpdateRequestWebhookOutputFormat2? WebhookOutputFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookConfigUpdateRequest" /> class.
        /// </summary>
        /// <param name="webhookUrl">
        /// Updated webhook URL.
        /// </param>
        /// <param name="webhookSigningSecret">
        /// Updated signing secret (write-only). Send to rotate the secret.
        /// </param>
        /// <param name="webhookHeaders">
        /// Updated headers.
        /// </param>
        /// <param name="webhookEvents">
        /// Updated event subscriptions.
        /// </param>
        /// <param name="webhookOutputFormat">
        /// Updated output format.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookConfigUpdateRequest(
            string? webhookUrl,
            string? webhookSigningSecret,
            global::System.Collections.Generic.Dictionary<string, string>? webhookHeaders,
            global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigUpdateRequestWebhookEventsVariant1Item>? webhookEvents,
            global::LlamaParse.WebhookConfigUpdateRequestWebhookOutputFormat2? webhookOutputFormat)
        {
            this.WebhookUrl = webhookUrl;
            this.WebhookSigningSecret = webhookSigningSecret;
            this.WebhookHeaders = webhookHeaders;
            this.WebhookEvents = webhookEvents;
            this.WebhookOutputFormat = webhookOutputFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookConfigUpdateRequest" /> class.
        /// </summary>
        public WebhookConfigUpdateRequest()
        {
        }

    }
}