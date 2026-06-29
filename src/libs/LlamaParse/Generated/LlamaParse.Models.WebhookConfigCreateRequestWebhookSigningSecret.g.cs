
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Shared secret used to sign deliveries to this endpoint. Write-only: it is never returned in responses.
    /// </summary>
    public sealed partial class WebhookConfigCreateRequestWebhookSigningSecret
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}