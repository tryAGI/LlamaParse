
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class LlamaParseClient : global::LlamaParse.ILlamaParseClient, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://api.cloud.llamaindex.ai";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::LlamaParse.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif
        /// <summary>
        /// 
        /// </summary>
        #pragma warning disable CS0618 // Type or member is obsolete
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::LlamaParse.JsonConverters.ApplyStatusDetailsStatusJsonConverter(),
                    new global::LlamaParse.JsonConverters.ApplyStatusDetailsStatusNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.AutoModeParsingConfTier2JsonConverter(),
                    new global::LlamaParse.JsonConverters.AutoModeParsingConfTier2NullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.AutoModeParsingConfVersionJsonConverter(),
                    new global::LlamaParse.JsonConverters.AutoModeParsingConfVersionNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.AutoModeParsingConfSpecializedChartParsing2JsonConverter(),
                    new global::LlamaParse.JsonConverters.AutoModeParsingConfSpecializedChartParsing2NullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.BatchFileStatusJsonConverter(),
                    new global::LlamaParse.JsonConverters.BatchFileStatusNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.BatchJobStatusJsonConverter(),
                    new global::LlamaParse.JsonConverters.BatchJobStatusNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.BatchJobTypeJsonConverter(),
                    new global::LlamaParse.JsonConverters.BatchJobTypeNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.BatchParseJobConfigPriority2JsonConverter(),
                    new global::LlamaParse.JsonConverters.BatchParseJobConfigPriority2NullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.BatchParseJobConfigImagesToSaveVariant1ItemJsonConverter(),
                    new global::LlamaParse.JsonConverters.BatchParseJobConfigImagesToSaveVariant1ItemNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.BoxAuthMechanismJsonConverter(),
                    new global::LlamaParse.JsonConverters.BoxAuthMechanismNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.ClassifyModeJsonConverter(),
                    new global::LlamaParse.JsonConverters.ClassifyModeNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.ClassifyV2JobResponseStatusJsonConverter(),
                    new global::LlamaParse.JsonConverters.ClassifyV2JobResponseStatusNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.ClassifyV2JobResponseDocumentInputTypeJsonConverter(),
                    new global::LlamaParse.JsonConverters.ClassifyV2JobResponseDocumentInputTypeNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.CloudJiraDataSourceV2ApiVersionJsonConverter(),
                    new global::LlamaParse.JsonConverters.CloudJiraDataSourceV2ApiVersionNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.CompositeRetrievalModeJsonConverter(),
                    new global::LlamaParse.JsonConverters.CompositeRetrievalModeNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.ConfigurableDataSinkNamesJsonConverter(),
                    new global::LlamaParse.JsonConverters.ConfigurableDataSinkNamesNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.ConfigurableDataSourceNamesJsonConverter(),
                    new global::LlamaParse.JsonConverters.ConfigurableDataSourceNamesNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.ConfigurationCreateRequestParametersDiscriminatorProductTypeJsonConverter(),
                    new global::LlamaParse.JsonConverters.ConfigurationCreateRequestParametersDiscriminatorProductTypeNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.ConfigurationResponseProductTypeJsonConverter(),
                    new global::LlamaParse.JsonConverters.ConfigurationResponseProductTypeNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.ConfigurationResponseParametersDiscriminatorProductTypeJsonConverter(),
                    new global::LlamaParse.JsonConverters.ConfigurationResponseParametersDiscriminatorProductTypeNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.ConfigurationUpdateRequestParametersVariant1DiscriminatorProductTypeJsonConverter(),
                    new global::LlamaParse.JsonConverters.ConfigurationUpdateRequestParametersVariant1DiscriminatorProductTypeNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.DataSourceReaderVersionMetadataReaderVersion2JsonConverter(),
                    new global::LlamaParse.JsonConverters.DataSourceReaderVersionMetadataReaderVersion2NullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.DiffingStatusDetailsStatusJsonConverter(),
                    new global::LlamaParse.JsonConverters.DiffingStatusDetailsStatusNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.DocumentChunkModeJsonConverter(),
                    new global::LlamaParse.JsonConverters.DocumentChunkModeNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.EmbeddingModelConfigEmbeddingConfigDiscriminatorTypeJsonConverter(),
                    new global::LlamaParse.JsonConverters.EmbeddingModelConfigEmbeddingConfigDiscriminatorTypeNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorTypeJsonConverter(),
                    new global::LlamaParse.JsonConverters.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorTypeNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorTypeJsonConverter(),
                    new global::LlamaParse.JsonConverters.EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.ExtractConfigPriority2JsonConverter(),
                    new global::LlamaParse.JsonConverters.ExtractConfigPriority2NullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.ExtractConfigurationTierJsonConverter(),
                    new global::LlamaParse.JsonConverters.ExtractConfigurationTierNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.ExtractConfigurationExtractionTargetJsonConverter(),
                    new global::LlamaParse.JsonConverters.ExtractConfigurationExtractionTargetNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.ExtractJobStatusJsonConverter(),
                    new global::LlamaParse.JsonConverters.ExtractJobStatusNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.ExtractJobCreatePriority2JsonConverter(),
                    new global::LlamaParse.JsonConverters.ExtractJobCreatePriority2NullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.ExtractModeJsonConverter(),
                    new global::LlamaParse.JsonConverters.ExtractModeNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.ExtractModelsJsonConverter(),
                    new global::LlamaParse.JsonConverters.ExtractModelsNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.ExtractStateJsonConverter(),
                    new global::LlamaParse.JsonConverters.ExtractStateNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.ExtractTargetJsonConverter(),
                    new global::LlamaParse.JsonConverters.ExtractTargetNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.ExtractV2ParametersTierJsonConverter(),
                    new global::LlamaParse.JsonConverters.ExtractV2ParametersTierNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.ExtractV2ParametersExtractionTargetJsonConverter(),
                    new global::LlamaParse.JsonConverters.ExtractV2ParametersExtractionTargetNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.FailPageModeJsonConverter(),
                    new global::LlamaParse.JsonConverters.FailPageModeNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.FileCreateStorageTypeJsonConverter(),
                    new global::LlamaParse.JsonConverters.FileCreateStorageTypeNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.FileCreateFromUrlStorageTypeJsonConverter(),
                    new global::LlamaParse.JsonConverters.FileCreateFromUrlStorageTypeNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.FilterConditionJsonConverter(),
                    new global::LlamaParse.JsonConverters.FilterConditionNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.FilterOperatorJsonConverter(),
                    new global::LlamaParse.JsonConverters.FilterOperatorNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.FooterItemItemDiscriminatorTypeJsonConverter(),
                    new global::LlamaParse.JsonConverters.FooterItemItemDiscriminatorTypeNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.HeaderItemItemDiscriminatorTypeJsonConverter(),
                    new global::LlamaParse.JsonConverters.HeaderItemItemDiscriminatorTypeNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.ImageMetadataCategory2JsonConverter(),
                    new global::LlamaParse.JsonConverters.ImageMetadataCategory2NullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.JobNameMappingJsonConverter(),
                    new global::LlamaParse.JsonConverters.JobNameMappingNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.ListingStatusDetailsStatusJsonConverter(),
                    new global::LlamaParse.JsonConverters.ListingStatusDetailsStatusNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.LlamaParseOutputOptionsImagesToSaveItemJsonConverter(),
                    new global::LlamaParse.JsonConverters.LlamaParseOutputOptionsImagesToSaveItemNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.LlamaParseParametersPriority2JsonConverter(),
                    new global::LlamaParse.JsonConverters.LlamaParseParametersPriority2NullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.LlamaParseParametersImagesToSaveVariant1ItemJsonConverter(),
                    new global::LlamaParse.JsonConverters.LlamaParseParametersImagesToSaveVariant1ItemNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.LlamaParseProcessingOptionsSpecializedChartParsing2JsonConverter(),
                    new global::LlamaParse.JsonConverters.LlamaParseProcessingOptionsSpecializedChartParsing2NullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.LlamaParseSupportedFileExtensionsJsonConverter(),
                    new global::LlamaParse.JsonConverters.LlamaParseSupportedFileExtensionsNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.ManagedIngestionStatusJsonConverter(),
                    new global::LlamaParse.JsonConverters.ManagedIngestionStatusNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.MessageRoleJsonConverter(),
                    new global::LlamaParse.JsonConverters.MessageRoleNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.NodeRelationshipJsonConverter(),
                    new global::LlamaParse.JsonConverters.NodeRelationshipNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.ObjectTypeJsonConverter(),
                    new global::LlamaParse.JsonConverters.ObjectTypeNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.PGVectorDistanceMethodJsonConverter(),
                    new global::LlamaParse.JsonConverters.PGVectorDistanceMethodNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.PGVectorVectorTypeJsonConverter(),
                    new global::LlamaParse.JsonConverters.PGVectorVectorTypeNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.ParseJobResponseStatusJsonConverter(),
                    new global::LlamaParse.JsonConverters.ParseJobResponseStatusNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.ParsePlanLevelJsonConverter(),
                    new global::LlamaParse.JsonConverters.ParsePlanLevelNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.ParseRequestConfigurationTierJsonConverter(),
                    new global::LlamaParse.JsonConverters.ParseRequestConfigurationTierNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.ParseRequestConfigurationVersionJsonConverter(),
                    new global::LlamaParse.JsonConverters.ParseRequestConfigurationVersionNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.ParseV2ParametersTierJsonConverter(),
                    new global::LlamaParse.JsonConverters.ParseV2ParametersTierNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.ParseV2ParametersVersionJsonConverter(),
                    new global::LlamaParse.JsonConverters.ParseV2ParametersVersionNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.ParserLanguagesJsonConverter(),
                    new global::LlamaParse.JsonConverters.ParserLanguagesNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.ParsingModeJsonConverter(),
                    new global::LlamaParse.JsonConverters.ParsingModeNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.PartitionNamesJsonConverter(),
                    new global::LlamaParse.JsonConverters.PartitionNamesNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.PipelineEmbeddingConfigDiscriminatorTypeJsonConverter(),
                    new global::LlamaParse.JsonConverters.PipelineEmbeddingConfigDiscriminatorTypeNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.PipelineStatus2JsonConverter(),
                    new global::LlamaParse.JsonConverters.PipelineStatus2NullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.PipelineCreateEmbeddingConfigVariant1DiscriminatorTypeJsonConverter(),
                    new global::LlamaParse.JsonConverters.PipelineCreateEmbeddingConfigVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.PipelineDataSourceStatus2JsonConverter(),
                    new global::LlamaParse.JsonConverters.PipelineDataSourceStatus2NullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.PipelineFileStatus2JsonConverter(),
                    new global::LlamaParse.JsonConverters.PipelineFileStatus2NullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.PipelineFileResponseStatus2JsonConverter(),
                    new global::LlamaParse.JsonConverters.PipelineFileResponseStatus2NullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.PipelineTypeJsonConverter(),
                    new global::LlamaParse.JsonConverters.PipelineTypeNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.PipelineUpdateEmbeddingConfigVariant1DiscriminatorTypeJsonConverter(),
                    new global::LlamaParse.JsonConverters.PipelineUpdateEmbeddingConfigVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.PoolingJsonConverter(),
                    new global::LlamaParse.JsonConverters.PoolingNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.PublicModelNameJsonConverter(),
                    new global::LlamaParse.JsonConverters.PublicModelNameNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.ReRankerTypeJsonConverter(),
                    new global::LlamaParse.JsonConverters.ReRankerTypeNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.RetrievalModeJsonConverter(),
                    new global::LlamaParse.JsonConverters.RetrievalModeNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.SparseModelTypeJsonConverter(),
                    new global::LlamaParse.JsonConverters.SparseModelTypeNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.SplitStrategyAllowUncategorizedJsonConverter(),
                    new global::LlamaParse.JsonConverters.SplitStrategyAllowUncategorizedNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.SpreadsheetParsingConfigTableMergeSensitivityJsonConverter(),
                    new global::LlamaParse.JsonConverters.SpreadsheetParsingConfigTableMergeSensitivityNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.SpreadsheetResultTypeJsonConverter(),
                    new global::LlamaParse.JsonConverters.SpreadsheetResultTypeNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.StatusEnumJsonConverter(),
                    new global::LlamaParse.JsonConverters.StatusEnumNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.StructuredResultPageItemDiscriminatorTypeJsonConverter(),
                    new global::LlamaParse.JsonConverters.StructuredResultPageItemDiscriminatorTypeNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.SupportedLLMModelNamesJsonConverter(),
                    new global::LlamaParse.JsonConverters.SupportedLLMModelNamesNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.UsageMetricEventTypeJsonConverter(),
                    new global::LlamaParse.JsonConverters.UsageMetricEventTypeNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.VertexEmbeddingModeJsonConverter(),
                    new global::LlamaParse.JsonConverters.VertexEmbeddingModeNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.WebhookConfigurationWebhookEventsVariant1ItemJsonConverter(),
                    new global::LlamaParse.JsonConverters.WebhookConfigurationWebhookEventsVariant1ItemNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1ItemJsonConverter(),
                    new global::LlamaParse.JsonConverters.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1ItemNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.ListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetStatusRefreshPolicyJsonConverter(),
                    new global::LlamaParse.JsonConverters.ListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetStatusRefreshPolicyNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.PaginatedListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsPaginatedGetStatusRefreshPolicyJsonConverter(),
                    new global::LlamaParse.JsonConverters.PaginatedListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsPaginatedGetStatusRefreshPolicyNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1ItemJsonConverter(),
                    new global::LlamaParse.JsonConverters.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1ItemNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.ListSplitJobsApiV1BetaSplitJobsGetStatus2JsonConverter(),
                    new global::LlamaParse.JsonConverters.ListSplitJobsApiV1BetaSplitJobsGetStatus2NullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1ItemJsonConverter(),
                    new global::LlamaParse.JsonConverters.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1ItemNullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.ListParseJobsApiV2ParseGetStatus2JsonConverter(),
                    new global::LlamaParse.JsonConverters.ListParseJobsApiV2ParseGetStatus2NullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.ListClassifyJobsApiV2ClassifyGetStatus2JsonConverter(),
                    new global::LlamaParse.JsonConverters.ListClassifyJobsApiV2ClassifyGetStatus2NullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.ListExtractJobsApiV2ExtractGetStatus2JsonConverter(),
                    new global::LlamaParse.JsonConverters.ListExtractJobsApiV2ExtractGetStatus2NullableJsonConverter(),
                    new global::LlamaParse.JsonConverters.ParametersJsonConverter(),
                    new global::LlamaParse.JsonConverters.Parameters2JsonConverter(),
                    new global::LlamaParse.JsonConverters.ParametersVariant1JsonConverter(),
                    new global::LlamaParse.JsonConverters.EmbeddingConfigJsonConverter(),
                    new global::LlamaParse.JsonConverters.EmbeddingConfig2JsonConverter(),
                    new global::LlamaParse.JsonConverters.EmbeddingConfigVariant1JsonConverter(),
                    new global::LlamaParse.JsonConverters.ItemsItemJsonConverter(),
                    new global::LlamaParse.JsonConverters.ItemsItem2JsonConverter(),
                    new global::LlamaParse.JsonConverters.EmbeddingConfig3JsonConverter(),
                    new global::LlamaParse.JsonConverters.EmbeddingConfigVariant12JsonConverter(),
                    new global::LlamaParse.JsonConverters.EmbeddingConfigVariant13JsonConverter(),
                    new global::LlamaParse.JsonConverters.ItemsItem4JsonConverter(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.NoneSegmentationConfig, global::LlamaParse.PageSegmentationConfig, global::LlamaParse.ElementSegmentationConfig>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.NoneChunkingConfig, global::LlamaParse.CharacterChunkingConfig, global::LlamaParse.TokenChunkingConfig, global::LlamaParse.SentenceChunkingConfig, global::LlamaParse.SemanticChunkingConfig>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, string, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, string, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.AutoModeParsingConfVersion?, string, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.BatchParseJobRecordCreate, global::LlamaParse.ClassifyJob>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::LlamaParse.CloudPineconeVectorStore, global::LlamaParse.CloudPostgresVectorStore, global::LlamaParse.CloudQdrantVectorStore, global::LlamaParse.CloudAzureAISearchVectorStore, global::LlamaParse.CloudMongoDBAtlasVectorSearch, global::LlamaParse.CloudMilvusVectorStore, global::LlamaParse.CloudAstraDBVectorStore>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::LlamaParse.CloudPineconeVectorStore, global::LlamaParse.CloudPostgresVectorStore, global::LlamaParse.CloudQdrantVectorStore, global::LlamaParse.CloudAzureAISearchVectorStore, global::LlamaParse.CloudMongoDBAtlasVectorSearch, global::LlamaParse.CloudMilvusVectorStore, global::LlamaParse.CloudAstraDBVectorStore>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::LlamaParse.CloudPineconeVectorStore, global::LlamaParse.CloudPostgresVectorStore, global::LlamaParse.CloudQdrantVectorStore, global::LlamaParse.CloudAzureAISearchVectorStore, global::LlamaParse.CloudMongoDBAtlasVectorSearch, global::LlamaParse.CloudMilvusVectorStore, global::LlamaParse.CloudAstraDBVectorStore, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::LlamaParse.CloudS3DataSource, global::LlamaParse.CloudAzStorageBlobDataSource, global::LlamaParse.CloudGoogleDriveDataSource, global::LlamaParse.CloudOneDriveDataSource, global::LlamaParse.CloudSharepointDataSource, global::LlamaParse.CloudSlackDataSource, global::LlamaParse.CloudNotionPageDataSource, global::LlamaParse.CloudConfluenceDataSource, global::LlamaParse.CloudJiraDataSource, global::LlamaParse.CloudJiraDataSourceV2, global::LlamaParse.CloudBoxDataSource>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::LlamaParse.CloudS3DataSource, global::LlamaParse.CloudAzStorageBlobDataSource, global::LlamaParse.CloudGoogleDriveDataSource, global::LlamaParse.CloudOneDriveDataSource, global::LlamaParse.CloudSharepointDataSource, global::LlamaParse.CloudSlackDataSource, global::LlamaParse.CloudNotionPageDataSource, global::LlamaParse.CloudConfluenceDataSource, global::LlamaParse.CloudJiraDataSource, global::LlamaParse.CloudJiraDataSourceV2, global::LlamaParse.CloudBoxDataSource>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::LlamaParse.CloudS3DataSource, global::LlamaParse.CloudAzStorageBlobDataSource, global::LlamaParse.CloudGoogleDriveDataSource, global::LlamaParse.CloudOneDriveDataSource, global::LlamaParse.CloudSharepointDataSource, global::LlamaParse.CloudSlackDataSource, global::LlamaParse.CloudNotionPageDataSource, global::LlamaParse.CloudConfluenceDataSource, global::LlamaParse.CloudJiraDataSource, global::LlamaParse.CloudJiraDataSourceV2, global::LlamaParse.CloudBoxDataSource, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, string>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, string>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.ExtractModels?, string, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, string, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, string, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, string, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, string>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, string>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.FileCreateStorageType?, string>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.FileCreateFromUrlStorageType?, string>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.TextItem, global::LlamaParse.ListItem>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.MarkdownResultPage, global::LlamaParse.FailedMarkdownPage>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, double?, string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<int>, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.MetadataFilter, global::LlamaParse.MetadataFilters>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.ParseRequestConfigurationVersion?, string>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.ParseV2ParametersVersion?, string>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.AutoTransformConfig, global::LlamaParse.AdvancedModeTransformConfig>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.AutoTransformConfig, global::LlamaParse.AdvancedModeTransformConfig, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::LlamaParse.CloudS3DataSource, global::LlamaParse.CloudAzStorageBlobDataSource, global::LlamaParse.CloudGoogleDriveDataSource, global::LlamaParse.CloudOneDriveDataSource, global::LlamaParse.CloudSharepointDataSource, global::LlamaParse.CloudSlackDataSource, global::LlamaParse.CloudNotionPageDataSource, global::LlamaParse.CloudConfluenceDataSource, global::LlamaParse.CloudJiraDataSource, global::LlamaParse.CloudJiraDataSourceV2, global::LlamaParse.CloudBoxDataSource>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.AutoTransformConfig, global::LlamaParse.AdvancedModeTransformConfig, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.BatchParseJobRecordCreate, global::LlamaParse.ClassifyJob>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.ObjectType?, string, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.StructuredResultPage, global::LlamaParse.FailedStructuredPage>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, int?, double?, object>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.RelatedNodeInfo, global::System.Collections.Generic.IList<global::LlamaParse.RelatedNodeInfo>>(),
                    new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, int?>(),
                    new global::LlamaParse.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// 
        /// </summary>
        public BetaClient Beta => new BetaClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ClassifierClient Classifier => new ClassifierClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DataSinksClient DataSinks => new DataSinksClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DataSourcesClient DataSources => new DataSourcesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingModelConfigsClient EmbeddingModelConfigs => new EmbeddingModelConfigsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FilesClient Files => new FilesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public LlamaExtractClient LlamaExtract => new LlamaExtractClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public OrganizationsClient Organizations => new OrganizationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PageFiguresClient PageFigures => new PageFiguresClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PageScreenshotsClient PageScreenshots => new PageScreenshotsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ParsingClient Parsing => new ParsingClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PipelineDataSourcesClient PipelineDataSources => new PipelineDataSourcesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PipelineFilesClient PipelineFiles => new PipelineFilesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PipelinesClient Pipelines => new PipelinesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ProjectsClient Projects => new ProjectsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public RetrieversClient Retrievers => new RetrieversClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public V2Client V2 => new V2Client(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Creates a new instance of the LlamaParseClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public LlamaParseClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::LlamaParse.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::LlamaParse.EndPointAuthorization>();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}