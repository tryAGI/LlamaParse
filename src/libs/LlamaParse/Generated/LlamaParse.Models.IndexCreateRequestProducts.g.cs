
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Product configurations for syncing. Omit to use a default parse configuration. Include an explicit entry per product type (e.g. parse, extract) to override the default.
    /// </summary>
    public sealed partial class IndexCreateRequestProducts
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}