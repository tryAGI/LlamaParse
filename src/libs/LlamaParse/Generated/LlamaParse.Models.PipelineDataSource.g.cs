
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Schema for a data source in a pipeline.
    /// </summary>
    public sealed partial class PipelineDataSource
    {
        /// <summary>
        /// Unique identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

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
        /// Version metadata for the data source
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_metadata")]
        public global::LlamaParse.DataSourceReaderVersionMetadata? VersionMetadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// The ID of the data source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_source_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid DataSourceId { get; set; }

        /// <summary>
        /// The ID of the pipeline.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipeline_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid PipelineId { get; set; }

        /// <summary>
        /// The last time the data source was automatically synced.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_synced_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastSyncedAt { get; set; }

        /// <summary>
        /// The interval at which the data source should be synced.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sync_interval")]
        public double? SyncInterval { get; set; }

        /// <summary>
        /// The id of the user who set the sync schedule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sync_schedule_set_by")]
        public string? SyncScheduleSetBy { get; set; }

        /// <summary>
        /// The status of the data source in the pipeline.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public global::LlamaParse.PipelineDataSourceStatus2? Status { get; set; }

        /// <summary>
        /// The last time the status was updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_updated_at")]
        public global::System.DateTime? StatusUpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineDataSource" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier
        /// </param>
        /// <param name="createdAt">
        /// Creation datetime
        /// </param>
        /// <param name="updatedAt">
        /// Update datetime
        /// </param>
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
        /// <param name="versionMetadata">
        /// Version metadata for the data source
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="dataSourceId">
        /// The ID of the data source.
        /// </param>
        /// <param name="pipelineId">
        /// The ID of the pipeline.
        /// </param>
        /// <param name="lastSyncedAt">
        /// The last time the data source was automatically synced.
        /// </param>
        /// <param name="syncInterval">
        /// The interval at which the data source should be synced.
        /// </param>
        /// <param name="syncScheduleSetBy">
        /// The id of the user who set the sync schedule.
        /// </param>
        /// <param name="status">
        /// The status of the data source in the pipeline.
        /// </param>
        /// <param name="statusUpdatedAt">
        /// The last time the status was updated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PipelineDataSource(
            global::System.Guid id,
            string name,
            global::LlamaParse.ConfigurableDataSourceNames sourceType,
            global::LlamaParse.AnyOf<object, global::LlamaParse.CloudS3DataSource, global::LlamaParse.CloudAzStorageBlobDataSource, global::LlamaParse.CloudGoogleDriveDataSource, global::LlamaParse.CloudOneDriveDataSource, global::LlamaParse.CloudSharepointDataSource, global::LlamaParse.CloudSlackDataSource, global::LlamaParse.CloudNotionPageDataSource, global::LlamaParse.CloudConfluenceDataSource, global::LlamaParse.CloudJiraDataSource, global::LlamaParse.CloudJiraDataSourceV2, global::LlamaParse.CloudBoxDataSource> component,
            global::System.Guid projectId,
            global::System.Guid dataSourceId,
            global::System.Guid pipelineId,
            global::System.DateTime lastSyncedAt,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            object? customMetadata,
            global::LlamaParse.DataSourceReaderVersionMetadata? versionMetadata,
            double? syncInterval,
            string? syncScheduleSetBy,
            global::LlamaParse.PipelineDataSourceStatus2? status,
            global::System.DateTime? statusUpdatedAt)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SourceType = sourceType;
            this.Component = component;
            this.ProjectId = projectId;
            this.DataSourceId = dataSourceId;
            this.PipelineId = pipelineId;
            this.LastSyncedAt = lastSyncedAt;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.CustomMetadata = customMetadata;
            this.VersionMetadata = versionMetadata;
            this.SyncInterval = syncInterval;
            this.SyncScheduleSetBy = syncScheduleSetBy;
            this.Status = status;
            this.StatusUpdatedAt = statusUpdatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineDataSource" /> class.
        /// </summary>
        public PipelineDataSource()
        {
        }
    }
}