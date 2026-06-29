
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Request to create a stored webhook configuration.<br/>
    /// The owning tenant is taken from the request context (e.g. the project in the<br/>
    /// path), not the body.
    /// </summary>
    public sealed partial class WebhookConfigCreateRequest
    {
        /// <summary>
        /// URL to receive webhook POST notifications.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WebhookUrl { get; set; }

        /// <summary>
        /// Shared secret used to sign deliveries to this endpoint. Write-only: it is never returned in responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_signing_secret")]
        public string? WebhookSigningSecret { get; set; }

        /// <summary>
        /// Custom HTTP headers sent with each webhook request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? WebhookHeaders { get; set; }

        /// <summary>
        /// Events to subscribe to. If null, all events are delivered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_events")]
        public global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigCreateRequestWebhookEventsVariant1Item>? WebhookEvents { get; set; }

        /// <summary>
        /// Response format sent to the webhook: 'string' (default) or 'json'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_output_format")]
        public global::LlamaParse.WebhookConfigCreateRequestWebhookOutputFormat2? WebhookOutputFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookConfigCreateRequest" /> class.
        /// </summary>
        /// <param name="webhookUrl">
        /// URL to receive webhook POST notifications.
        /// </param>
        /// <param name="webhookSigningSecret">
        /// Shared secret used to sign deliveries to this endpoint. Write-only: it is never returned in responses.
        /// </param>
        /// <param name="webhookHeaders">
        /// Custom HTTP headers sent with each webhook request.
        /// </param>
        /// <param name="webhookEvents">
        /// Events to subscribe to. If null, all events are delivered.
        /// </param>
        /// <param name="webhookOutputFormat">
        /// Response format sent to the webhook: 'string' (default) or 'json'.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookConfigCreateRequest(
            string webhookUrl,
            string? webhookSigningSecret,
            global::System.Collections.Generic.Dictionary<string, string>? webhookHeaders,
            global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigCreateRequestWebhookEventsVariant1Item>? webhookEvents,
            global::LlamaParse.WebhookConfigCreateRequestWebhookOutputFormat2? webhookOutputFormat)
        {
            this.WebhookUrl = webhookUrl ?? throw new global::System.ArgumentNullException(nameof(webhookUrl));
            this.WebhookSigningSecret = webhookSigningSecret;
            this.WebhookHeaders = webhookHeaders;
            this.WebhookEvents = webhookEvents;
            this.WebhookOutputFormat = webhookOutputFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookConfigCreateRequest" /> class.
        /// </summary>
        public WebhookConfigCreateRequest()
        {
        }

    }
}