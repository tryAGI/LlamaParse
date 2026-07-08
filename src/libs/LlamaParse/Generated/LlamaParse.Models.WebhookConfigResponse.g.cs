
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// A stored webhook configuration. The signing secret is never included.
    /// </summary>
    public sealed partial class WebhookConfigResponse
    {
        /// <summary>
        /// Unique identifier for the webhook configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Creation datetime
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Update datetime
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Owner tenant type.
        /// </summary>
        /// <default>"project"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_type")]
        public string TenantType { get; set; } = "project";

        /// <summary>
        /// Owner tenant ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TenantId { get; set; }

        /// <summary>
        /// URL that receives webhook POST notifications.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WebhookUrl { get; set; }

        /// <summary>
        /// Whether a signing secret is configured for this endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasSecret { get; set; }

        /// <summary>
        /// Custom HTTP headers sent with each request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? WebhookHeaders { get; set; }

        /// <summary>
        /// Subscribed events (null = all events).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_events")]
        public global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigResponseWebhookEventsVariant1Item>? WebhookEvents { get; set; }

        /// <summary>
        /// Response format sent to the webhook.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_output_format")]
        public global::LlamaParse.WebhookConfigResponseWebhookOutputFormat2? WebhookOutputFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookConfigResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the webhook configuration.
        /// </param>
        /// <param name="tenantId">
        /// Owner tenant ID.
        /// </param>
        /// <param name="webhookUrl">
        /// URL that receives webhook POST notifications.
        /// </param>
        /// <param name="hasSecret">
        /// Whether a signing secret is configured for this endpoint.
        /// </param>
        /// <param name="createdAt">
        /// Creation datetime
        /// </param>
        /// <param name="updatedAt">
        /// Update datetime
        /// </param>
        /// <param name="webhookHeaders">
        /// Custom HTTP headers sent with each request.
        /// </param>
        /// <param name="webhookEvents">
        /// Subscribed events (null = all events).
        /// </param>
        /// <param name="webhookOutputFormat">
        /// Response format sent to the webhook.
        /// </param>
        /// <param name="tenantType">
        /// Owner tenant type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookConfigResponse(
            string id,
            string tenantId,
            string webhookUrl,
            bool hasSecret,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::System.Collections.Generic.Dictionary<string, string>? webhookHeaders,
            global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigResponseWebhookEventsVariant1Item>? webhookEvents,
            global::LlamaParse.WebhookConfigResponseWebhookOutputFormat2? webhookOutputFormat,
            string tenantType = "project")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.TenantType = tenantType;
            this.TenantId = tenantId ?? throw new global::System.ArgumentNullException(nameof(tenantId));
            this.WebhookUrl = webhookUrl ?? throw new global::System.ArgumentNullException(nameof(webhookUrl));
            this.HasSecret = hasSecret;
            this.WebhookHeaders = webhookHeaders;
            this.WebhookEvents = webhookEvents;
            this.WebhookOutputFormat = webhookOutputFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookConfigResponse" /> class.
        /// </summary>
        public WebhookConfigResponse()
        {
        }

    }
}