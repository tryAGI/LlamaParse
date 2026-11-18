
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Advisory finding about split categories; the job still runs.
    /// </summary>
    public sealed partial class SplitConfigurationWarning
    {
        /// <summary>
        /// Rule that produced the warning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LlamaParse.JsonConverters.SplitConfigurationWarningCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.SplitConfigurationWarningCode Code { get; set; }

        /// <summary>
        /// What is ambiguous and how to fix it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Names of the categories the warning concerns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category_names")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> CategoryNames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitConfigurationWarning" /> class.
        /// </summary>
        /// <param name="code">
        /// Rule that produced the warning.
        /// </param>
        /// <param name="message">
        /// What is ambiguous and how to fix it.
        /// </param>
        /// <param name="categoryNames">
        /// Names of the categories the warning concerns.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SplitConfigurationWarning(
            global::LlamaParse.SplitConfigurationWarningCode code,
            string message,
            global::System.Collections.Generic.IList<string> categoryNames)
        {
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.CategoryNames = categoryNames ?? throw new global::System.ArgumentNullException(nameof(categoryNames));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitConfigurationWarning" /> class.
        /// </summary>
        public SplitConfigurationWarning()
        {
        }

    }
}