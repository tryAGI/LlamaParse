
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// A webhook endpoint kept in a saved Parse configuration.
    /// </summary>
    public sealed partial class StoredParseWebhookConfiguration
    {
        /// <summary>
        /// Webhook ID, set by the server. Send it back unchanged so a masked credential keeps this webhook's saved value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// HTTPS URL to receive webhook POST requests. Must be publicly accessible
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Custom HTTP headers to include in webhook requests. Use for authentication tokens or custom routing. Example: {'Authorization': 'Bearer xyz'}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_headers")]
        public object? WebhookHeaders { get; set; }

        /// <summary>
        /// Shared signing secret used to sign webhook deliveries. When set, each request includes an HMAC-SHA256 signature of the request body in the 'LC-Signature' header (value 'sha256=&lt;hex&gt;'). Recompute the HMAC over the raw request body with this secret to verify the delivery is authentic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_signing_secret")]
        public string? WebhookSigningSecret { get; set; }

        /// <summary>
        /// Events that trigger this webhook. Options: 'parse.success' (job completed), 'parse.error' (job failed), 'parse.partial_success' (some pages failed), 'parse.pending', 'parse.running', 'parse.cancelled'. If not specified, webhook fires for all events
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_events")]
        public global::System.Collections.Generic.IList<string>? WebhookEvents { get; set; }

        /// <summary>
        /// Format of the webhook payload body. 'string' (default) sends the payload as a JSON-encoded string; 'json' sends it as a JSON object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_output_format")]
        public global::LlamaParse.StoredParseWebhookConfigurationWebhookOutputFormat? WebhookOutputFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoredParseWebhookConfiguration" /> class.
        /// </summary>
        /// <param name="id">
        /// Webhook ID, set by the server. Send it back unchanged so a masked credential keeps this webhook's saved value.
        /// </param>
        /// <param name="webhookUrl">
        /// HTTPS URL to receive webhook POST requests. Must be publicly accessible
        /// </param>
        /// <param name="webhookHeaders">
        /// Custom HTTP headers to include in webhook requests. Use for authentication tokens or custom routing. Example: {'Authorization': 'Bearer xyz'}
        /// </param>
        /// <param name="webhookSigningSecret">
        /// Shared signing secret used to sign webhook deliveries. When set, each request includes an HMAC-SHA256 signature of the request body in the 'LC-Signature' header (value 'sha256=&lt;hex&gt;'). Recompute the HMAC over the raw request body with this secret to verify the delivery is authentic.
        /// </param>
        /// <param name="webhookEvents">
        /// Events that trigger this webhook. Options: 'parse.success' (job completed), 'parse.error' (job failed), 'parse.partial_success' (some pages failed), 'parse.pending', 'parse.running', 'parse.cancelled'. If not specified, webhook fires for all events
        /// </param>
        /// <param name="webhookOutputFormat">
        /// Format of the webhook payload body. 'string' (default) sends the payload as a JSON-encoded string; 'json' sends it as a JSON object.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StoredParseWebhookConfiguration(
            string? id,
            string? webhookUrl,
            object? webhookHeaders,
            string? webhookSigningSecret,
            global::System.Collections.Generic.IList<string>? webhookEvents,
            global::LlamaParse.StoredParseWebhookConfigurationWebhookOutputFormat? webhookOutputFormat)
        {
            this.Id = id;
            this.WebhookUrl = webhookUrl;
            this.WebhookHeaders = webhookHeaders;
            this.WebhookSigningSecret = webhookSigningSecret;
            this.WebhookEvents = webhookEvents;
            this.WebhookOutputFormat = webhookOutputFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoredParseWebhookConfiguration" /> class.
        /// </summary>
        public StoredParseWebhookConfiguration()
        {
        }

    }
}