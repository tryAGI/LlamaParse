
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Inline brokered-connection pointer for a managed-OAuth Google Drive source.<br/>
    /// Holds no secrets — just enough to vend a provider token headlessly later<br/>
    /// (broker + broker-side user + provider). Additive alternative to<br/>
    /// ``service_account_key``; see the multi-broker OAuth design.
    /// </summary>
    public sealed partial class GDriveBrokeredCreds
    {
        /// <summary>
        /// Credential broker holding the connection (e.g. 'workos').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broker_kind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BrokerKind { get; set; }

        /// <summary>
        /// Broker-side user id used to vend tokens headlessly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broker_user_ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BrokerUserRef { get; set; }

        /// <summary>
        /// The connected data source.<br/>
        /// Default Value: google_drive
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// Connected account display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_name")]
        public string? AccountName { get; set; }

        /// <summary>
        /// Connected account email.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_email")]
        public string? AccountEmail { get; set; }

        /// <summary>
        /// Connected-account id; unused by WorkOS.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_ref")]
        public string? ExternalRef { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GDriveBrokeredCreds" /> class.
        /// </summary>
        /// <param name="brokerKind">
        /// Credential broker holding the connection (e.g. 'workos').
        /// </param>
        /// <param name="brokerUserRef">
        /// Broker-side user id used to vend tokens headlessly.
        /// </param>
        /// <param name="provider">
        /// The connected data source.<br/>
        /// Default Value: google_drive
        /// </param>
        /// <param name="accountName">
        /// Connected account display name.
        /// </param>
        /// <param name="accountEmail">
        /// Connected account email.
        /// </param>
        /// <param name="externalRef">
        /// Connected-account id; unused by WorkOS.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GDriveBrokeredCreds(
            string brokerKind,
            string brokerUserRef,
            string? provider,
            string? accountName,
            string? accountEmail,
            string? externalRef)
        {
            this.BrokerKind = brokerKind ?? throw new global::System.ArgumentNullException(nameof(brokerKind));
            this.BrokerUserRef = brokerUserRef ?? throw new global::System.ArgumentNullException(nameof(brokerUserRef));
            this.Provider = provider;
            this.AccountName = accountName;
            this.AccountEmail = accountEmail;
            this.ExternalRef = externalRef;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GDriveBrokeredCreds" /> class.
        /// </summary>
        public GDriveBrokeredCreds()
        {
        }

    }
}