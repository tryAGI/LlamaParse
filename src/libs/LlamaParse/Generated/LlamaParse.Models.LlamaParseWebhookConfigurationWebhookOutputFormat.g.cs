
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Format of the webhook payload body. 'string' (default) sends the payload as a JSON-encoded string; 'json' sends it as a JSON object.
    /// </summary>
    public sealed partial class LlamaParseWebhookConfigurationWebhookOutputFormat
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}