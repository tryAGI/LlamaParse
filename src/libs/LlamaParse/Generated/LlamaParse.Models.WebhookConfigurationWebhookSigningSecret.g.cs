
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Shared signing secret used to sign webhook deliveries. When set, each request includes an HMAC-SHA256 signature of the request body in the 'LC-Signature' header (value 'sha256=&lt;hex&gt;'). Recompute the HMAC over the raw request body with this secret to verify the delivery is authentic.
    /// </summary>
    public sealed partial class WebhookConfigurationWebhookSigningSecret
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}