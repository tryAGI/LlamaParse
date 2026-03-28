
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Schema for creating a data source.
    /// </summary>
    public sealed partial class DataSourceCreate
    {
        /// <summary>
        /// The name of the data source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LlamaParse.JsonConverters.ConfigurableDataSourceNamesJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.ConfigurableDataSourceNames SourceType { get; set; }

        /// <summary>
        /// Custom metadata that will be present on all data loaded from the data source
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_metadata")]
        public object? CustomMetadata { get; set; }

        /// <summary>
        /// Component that implements the data source
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("component")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::LlamaParse.CloudS3DataSource, global::LlamaParse.CloudAzStorageBlobDataSource, global::LlamaParse.CloudGoogleDriveDataSource, global::LlamaParse.CloudOneDriveDataSource, global::LlamaParse.CloudSharepointDataSource, global::LlamaParse.CloudSlackDataSource, global::LlamaParse.CloudNotionPageDataSource, global::LlamaParse.CloudConfluenceDataSource, global::LlamaParse.CloudJiraDataSource, global::LlamaParse.CloudJiraDataSourceV2, global::LlamaParse.CloudBoxDataSource>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LlamaParse.AnyOf<object, global::LlamaParse.CloudS3DataSource, global::LlamaParse.CloudAzStorageBlobDataSource, global::LlamaParse.CloudGoogleDriveDataSource, global::LlamaParse.CloudOneDriveDataSource, global::LlamaParse.CloudSharepointDataSource, global::LlamaParse.CloudSlackDataSource, global::LlamaParse.CloudNotionPageDataSource, global::LlamaParse.CloudConfluenceDataSource, global::LlamaParse.CloudJiraDataSource, global::LlamaParse.CloudJiraDataSourceV2, global::LlamaParse.CloudBoxDataSource> Component { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSourceCreate" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the data source.
        /// </param>
        /// <param name="sourceType"></param>
        /// <param name="customMetadata">
        /// Custom metadata that will be present on all data loaded from the data source
        /// </param>
        /// <param name="component">
        /// Component that implements the data source
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataSourceCreate(
            string name,
            global::LlamaParse.ConfigurableDataSourceNames sourceType,
            global::LlamaParse.AnyOf<object, global::LlamaParse.CloudS3DataSource, global::LlamaParse.CloudAzStorageBlobDataSource, global::LlamaParse.CloudGoogleDriveDataSource, global::LlamaParse.CloudOneDriveDataSource, global::LlamaParse.CloudSharepointDataSource, global::LlamaParse.CloudSlackDataSource, global::LlamaParse.CloudNotionPageDataSource, global::LlamaParse.CloudConfluenceDataSource, global::LlamaParse.CloudJiraDataSource, global::LlamaParse.CloudJiraDataSourceV2, global::LlamaParse.CloudBoxDataSource> component,
            object? customMetadata)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SourceType = sourceType;
            this.Component = component;
            this.CustomMetadata = customMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSourceCreate" /> class.
        /// </summary>
        public DataSourceCreate()
        {
        }
    }
}