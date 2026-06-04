
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Job-time parameters returned on a spreadsheet job response.
    /// </summary>
    public sealed partial class SpreadsheetJobParameters
    {
        /// <summary>
        /// Webhook configurations for job status notifications.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_configurations")]
        public global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfiguration>? WebhookConfigurations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpreadsheetJobParameters" /> class.
        /// </summary>
        /// <param name="webhookConfigurations">
        /// Webhook configurations for job status notifications.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpreadsheetJobParameters(
            global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfiguration>? webhookConfigurations)
        {
            this.WebhookConfigurations = webhookConfigurations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpreadsheetJobParameters" /> class.
        /// </summary>
        public SpreadsheetJobParameters()
        {
        }

    }
}