
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::LlamaParse.JsonConverters.AutoModeParsingConfTier2JsonConverter),

            typeof(global::LlamaParse.JsonConverters.AutoModeParsingConfTier2NullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.AutoModeParsingConfVersionJsonConverter),

            typeof(global::LlamaParse.JsonConverters.AutoModeParsingConfVersionNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.AutoModeParsingConfSpecializedChartParsing2JsonConverter),

            typeof(global::LlamaParse.JsonConverters.AutoModeParsingConfSpecializedChartParsing2NullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.BatchFileStatusJsonConverter),

            typeof(global::LlamaParse.JsonConverters.BatchFileStatusNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.BatchJobStatusJsonConverter),

            typeof(global::LlamaParse.JsonConverters.BatchJobStatusNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.BatchJobTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.BatchJobTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.BatchParseJobConfigPriority2JsonConverter),

            typeof(global::LlamaParse.JsonConverters.BatchParseJobConfigPriority2NullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.BatchParseJobConfigImagesToSaveVariant1ItemJsonConverter),

            typeof(global::LlamaParse.JsonConverters.BatchParseJobConfigImagesToSaveVariant1ItemNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.BoxAuthMechanismJsonConverter),

            typeof(global::LlamaParse.JsonConverters.BoxAuthMechanismNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ClassifyModeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ClassifyModeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ClassifyV2JobResponseStatusJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ClassifyV2JobResponseStatusNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ClassifyV2JobResponseDocumentInputTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ClassifyV2JobResponseDocumentInputTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.CloudJiraDataSourceV2ApiVersionJsonConverter),

            typeof(global::LlamaParse.JsonConverters.CloudJiraDataSourceV2ApiVersionNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.CompositeRetrievalModeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.CompositeRetrievalModeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ConfigurableDataSinkNamesJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ConfigurableDataSinkNamesNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ConfigurableDataSourceNamesJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ConfigurableDataSourceNamesNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ConfigurationCreateRequestParametersDiscriminatorProductTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ConfigurationCreateRequestParametersDiscriminatorProductTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ConfigurationResponseProductTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ConfigurationResponseProductTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ConfigurationResponseParametersDiscriminatorProductTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ConfigurationResponseParametersDiscriminatorProductTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ConfigurationUpdateRequestParametersVariant1DiscriminatorProductTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ConfigurationUpdateRequestParametersVariant1DiscriminatorProductTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.DataSourceReaderVersionMetadataReaderVersion2JsonConverter),

            typeof(global::LlamaParse.JsonConverters.DataSourceReaderVersionMetadataReaderVersion2NullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.DocumentChunkModeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.DocumentChunkModeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.EmbeddingModelConfigEmbeddingConfigDiscriminatorTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.EmbeddingModelConfigEmbeddingConfigDiscriminatorTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ExtractConfigPriority2JsonConverter),

            typeof(global::LlamaParse.JsonConverters.ExtractConfigPriority2NullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ExtractConfigurationTierJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ExtractConfigurationTierNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ExtractConfigurationExtractionTargetJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ExtractConfigurationExtractionTargetNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ExtractJobStatusJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ExtractJobStatusNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ExtractJobCreatePriority2JsonConverter),

            typeof(global::LlamaParse.JsonConverters.ExtractJobCreatePriority2NullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ExtractModeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ExtractModeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ExtractModelsJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ExtractModelsNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ExtractStateJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ExtractStateNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ExtractTargetJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ExtractTargetNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ExtractV2ParametersTierJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ExtractV2ParametersTierNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ExtractV2ParametersExtractionTargetJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ExtractV2ParametersExtractionTargetNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.FailPageModeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.FailPageModeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.FilterConditionJsonConverter),

            typeof(global::LlamaParse.JsonConverters.FilterConditionNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.FilterOperatorJsonConverter),

            typeof(global::LlamaParse.JsonConverters.FilterOperatorNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.FilterTypeUnionIntFloatOperatorJsonConverter),

            typeof(global::LlamaParse.JsonConverters.FilterTypeUnionIntFloatOperatorNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.FilterTypeUnionStrIntBoolFloatOperatorJsonConverter),

            typeof(global::LlamaParse.JsonConverters.FilterTypeUnionStrIntBoolFloatOperatorNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.FilterTypeStrOperatorJsonConverter),

            typeof(global::LlamaParse.JsonConverters.FilterTypeStrOperatorNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.FooterItemItemDiscriminatorTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.FooterItemItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.HeaderItemItemDiscriminatorTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.HeaderItemItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ImageMetadataCategory2JsonConverter),

            typeof(global::LlamaParse.JsonConverters.ImageMetadataCategory2NullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.JobNameMappingJsonConverter),

            typeof(global::LlamaParse.JsonConverters.JobNameMappingNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.LlamaParseOutputOptionsImagesToSaveItemJsonConverter),

            typeof(global::LlamaParse.JsonConverters.LlamaParseOutputOptionsImagesToSaveItemNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.LlamaParseParametersPriority2JsonConverter),

            typeof(global::LlamaParse.JsonConverters.LlamaParseParametersPriority2NullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.LlamaParseParametersImagesToSaveVariant1ItemJsonConverter),

            typeof(global::LlamaParse.JsonConverters.LlamaParseParametersImagesToSaveVariant1ItemNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.LlamaParseProcessingOptionsSpecializedChartParsing2JsonConverter),

            typeof(global::LlamaParse.JsonConverters.LlamaParseProcessingOptionsSpecializedChartParsing2NullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.LlamaParseSupportedFileExtensionsJsonConverter),

            typeof(global::LlamaParse.JsonConverters.LlamaParseSupportedFileExtensionsNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ManagedIngestionStatusJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ManagedIngestionStatusNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.MessageRoleJsonConverter),

            typeof(global::LlamaParse.JsonConverters.MessageRoleNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.NodeRelationshipJsonConverter),

            typeof(global::LlamaParse.JsonConverters.NodeRelationshipNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ObjectTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ObjectTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PGVectorDistanceMethodJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PGVectorDistanceMethodNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PGVectorVectorTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PGVectorVectorTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParseJobResponseStatusJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParseJobResponseStatusNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParsePlanLevelJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParsePlanLevelNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParseRequestConfigurationTierJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParseRequestConfigurationTierNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParseRequestConfigurationVersionJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParseRequestConfigurationVersionNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParseV2ParametersTierJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParseV2ParametersTierNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParseV2ParametersVersionJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParseV2ParametersVersionNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParseVersionsResponseFastItemJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParseVersionsResponseFastItemNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParseVersionsResponseCostEffectiveItemJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParseVersionsResponseCostEffectiveItemNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParseVersionsResponseAgenticItemJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParseVersionsResponseAgenticItemNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParseVersionsResponseAgenticPluJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParseVersionsResponseAgenticPluNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParserLanguagesJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParserLanguagesNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParsingModeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParsingModeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PartitionNamesJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PartitionNamesNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PipelineEmbeddingConfigDiscriminatorTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PipelineEmbeddingConfigDiscriminatorTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PipelineStatus2JsonConverter),

            typeof(global::LlamaParse.JsonConverters.PipelineStatus2NullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PipelineCreateEmbeddingConfigVariant1DiscriminatorTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PipelineCreateEmbeddingConfigVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PipelineDataSourceStatus2JsonConverter),

            typeof(global::LlamaParse.JsonConverters.PipelineDataSourceStatus2NullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PipelineFileStatus2JsonConverter),

            typeof(global::LlamaParse.JsonConverters.PipelineFileStatus2NullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PipelineFileResponseStatus2JsonConverter),

            typeof(global::LlamaParse.JsonConverters.PipelineFileResponseStatus2NullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PipelineTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PipelineTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PipelineUpdateEmbeddingConfigVariant1DiscriminatorTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PipelineUpdateEmbeddingConfigVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PoolingJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PoolingNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PublicModelNameJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PublicModelNameNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ReRankerTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ReRankerTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.RetrievalModeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.RetrievalModeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.SessionGetAPIResponseEventDiscriminatorTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.SessionGetAPIResponseEventDiscriminatorTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.SparseModelTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.SparseModelTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.SplitStrategyAllowUncategorizedJsonConverter),

            typeof(global::LlamaParse.JsonConverters.SplitStrategyAllowUncategorizedNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.SpreadsheetParsingConfigTableMergeSensitivityJsonConverter),

            typeof(global::LlamaParse.JsonConverters.SpreadsheetParsingConfigTableMergeSensitivityNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.SpreadsheetResultTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.SpreadsheetResultTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.SpreadsheetV1ParametersTableMergeSensitivityJsonConverter),

            typeof(global::LlamaParse.JsonConverters.SpreadsheetV1ParametersTableMergeSensitivityNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.StatusEnumJsonConverter),

            typeof(global::LlamaParse.JsonConverters.StatusEnumNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.StructuredResultPageItemDiscriminatorTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.StructuredResultPageItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.SupportedLLMModelNamesJsonConverter),

            typeof(global::LlamaParse.JsonConverters.SupportedLLMModelNamesNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.SyncProductEntryRequestProductTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.SyncProductEntryRequestProductTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.UsageMetricEventTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.UsageMetricEventTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.VertexEmbeddingModeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.VertexEmbeddingModeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.WebhookConfigurationWebhookEventsVariant1ItemJsonConverter),

            typeof(global::LlamaParse.JsonConverters.WebhookConfigurationWebhookEventsVariant1ItemNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ListProjectJobDataPointsApiV1JobDataPointsGetJobTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ListProjectJobDataPointsApiV1JobDataPointsGetJobTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1ItemJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1ItemNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetStatusRefreshPolicyJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetStatusRefreshPolicyNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PaginatedListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsPaginatedGetStatusRefreshPolicyJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PaginatedListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsPaginatedGetStatusRefreshPolicyNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ListDirectoriesApiV1BetaDirectoriesGetType2JsonConverter),

            typeof(global::LlamaParse.JsonConverters.ListDirectoriesApiV1BetaDirectoriesGetType2NullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1ItemJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1ItemNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ListSplitJobsApiV1BetaSplitJobsGetStatus2JsonConverter),

            typeof(global::LlamaParse.JsonConverters.ListSplitJobsApiV1BetaSplitJobsGetStatus2NullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1ItemJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1ItemNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ListParseJobsApiV2ParseGetStatus2JsonConverter),

            typeof(global::LlamaParse.JsonConverters.ListParseJobsApiV2ParseGetStatus2NullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ListClassifyJobsApiV2ClassifyGetStatus2JsonConverter),

            typeof(global::LlamaParse.JsonConverters.ListClassifyJobsApiV2ClassifyGetStatus2NullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ListExtractJobsApiV2ExtractGetStatus2JsonConverter),

            typeof(global::LlamaParse.JsonConverters.ListExtractJobsApiV2ExtractGetStatus2NullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParametersJsonConverter),

            typeof(global::LlamaParse.JsonConverters.Parameters2JsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParametersVariant1JsonConverter),

            typeof(global::LlamaParse.JsonConverters.EmbeddingConfigJsonConverter),

            typeof(global::LlamaParse.JsonConverters.EmbeddingConfig2JsonConverter),

            typeof(global::LlamaParse.JsonConverters.EmbeddingConfigVariant1JsonConverter),

            typeof(global::LlamaParse.JsonConverters.ItemsItemJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ItemsItem2JsonConverter),

            typeof(global::LlamaParse.JsonConverters.EmbeddingConfig3JsonConverter),

            typeof(global::LlamaParse.JsonConverters.EmbeddingConfigVariant12JsonConverter),

            typeof(global::LlamaParse.JsonConverters.EmbeddingConfigVariant13JsonConverter),

            typeof(global::LlamaParse.JsonConverters.EventsItemJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ItemsItem4JsonConverter),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.NoneSegmentationConfig, global::LlamaParse.PageSegmentationConfig, global::LlamaParse.ElementSegmentationConfig>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.NoneChunkingConfig, global::LlamaParse.CharacterChunkingConfig, global::LlamaParse.TokenChunkingConfig, global::LlamaParse.SentenceChunkingConfig, global::LlamaParse.SemanticChunkingConfig>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.AutoModeParsingConfVersion?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.BatchParseJobRecordCreate, global::LlamaParse.ClassifyJob>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::LlamaParse.CloudPineconeVectorStore, global::LlamaParse.CloudPostgresVectorStore, global::LlamaParse.CloudQdrantVectorStore, global::LlamaParse.CloudAzureAISearchVectorStore, global::LlamaParse.CloudMongoDBAtlasVectorSearch, global::LlamaParse.CloudMilvusVectorStore, global::LlamaParse.CloudAstraDBVectorStore>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::LlamaParse.CloudPineconeVectorStore, global::LlamaParse.CloudPostgresVectorStore, global::LlamaParse.CloudQdrantVectorStore, global::LlamaParse.CloudAzureAISearchVectorStore, global::LlamaParse.CloudMongoDBAtlasVectorSearch, global::LlamaParse.CloudMilvusVectorStore, global::LlamaParse.CloudAstraDBVectorStore>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::LlamaParse.CloudPineconeVectorStore, global::LlamaParse.CloudPostgresVectorStore, global::LlamaParse.CloudQdrantVectorStore, global::LlamaParse.CloudAzureAISearchVectorStore, global::LlamaParse.CloudMongoDBAtlasVectorSearch, global::LlamaParse.CloudMilvusVectorStore, global::LlamaParse.CloudAstraDBVectorStore, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::LlamaParse.CloudS3DataSource, global::LlamaParse.CloudAzStorageBlobDataSource, global::LlamaParse.CloudGoogleDriveDataSource, global::LlamaParse.CloudOneDriveDataSource, global::LlamaParse.CloudSharepointDataSource, global::LlamaParse.CloudSlackDataSource, global::LlamaParse.CloudNotionPageDataSource, global::LlamaParse.CloudConfluenceDataSource, global::LlamaParse.CloudJiraDataSource, global::LlamaParse.CloudJiraDataSourceV2, global::LlamaParse.CloudBoxDataSource>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::LlamaParse.CloudS3DataSource, global::LlamaParse.CloudAzStorageBlobDataSource, global::LlamaParse.CloudGoogleDriveDataSource, global::LlamaParse.CloudOneDriveDataSource, global::LlamaParse.CloudSharepointDataSource, global::LlamaParse.CloudSlackDataSource, global::LlamaParse.CloudNotionPageDataSource, global::LlamaParse.CloudConfluenceDataSource, global::LlamaParse.CloudJiraDataSource, global::LlamaParse.CloudJiraDataSourceV2, global::LlamaParse.CloudBoxDataSource>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::LlamaParse.CloudS3DataSource, global::LlamaParse.CloudAzStorageBlobDataSource, global::LlamaParse.CloudGoogleDriveDataSource, global::LlamaParse.CloudOneDriveDataSource, global::LlamaParse.CloudSharepointDataSource, global::LlamaParse.CloudSlackDataSource, global::LlamaParse.CloudNotionPageDataSource, global::LlamaParse.CloudConfluenceDataSource, global::LlamaParse.CloudJiraDataSource, global::LlamaParse.CloudJiraDataSourceV2, global::LlamaParse.CloudBoxDataSource, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, string>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, string>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.ExtractModels?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, string>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, string>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, double?, global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<int?, double?>>>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, double?>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, int?, bool?, double?, global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?, bool?, double?>>>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, int?, bool?, double?>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.TextItem, global::LlamaParse.ListItem>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.MarkdownResultPage, global::LlamaParse.FailedMarkdownPage>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, double?, string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<int>, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.MetadataFilter, global::LlamaParse.MetadataFilters>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.ParseRequestConfigurationVersion?, string>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.ParseV2ParametersVersion?, string>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.AutoTransformConfig, global::LlamaParse.AdvancedModeTransformConfig>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.AutoTransformConfig, global::LlamaParse.AdvancedModeTransformConfig, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::LlamaParse.CloudS3DataSource, global::LlamaParse.CloudAzStorageBlobDataSource, global::LlamaParse.CloudGoogleDriveDataSource, global::LlamaParse.CloudOneDriveDataSource, global::LlamaParse.CloudSharepointDataSource, global::LlamaParse.CloudSlackDataSource, global::LlamaParse.CloudNotionPageDataSource, global::LlamaParse.CloudConfluenceDataSource, global::LlamaParse.CloudJiraDataSource, global::LlamaParse.CloudJiraDataSourceV2, global::LlamaParse.CloudBoxDataSource>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.AutoTransformConfig, global::LlamaParse.AdvancedModeTransformConfig, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.BatchParseJobRecordCreate, global::LlamaParse.ClassifyJob>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.ObjectType?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.FilterTypeUnionStrIntBoolFloat, global::System.Collections.Generic.IList<global::LlamaParse.FilterTypeUnionIntFloat>, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.StructuredResultPage, global::LlamaParse.FailedStructuredPage>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, int?, double?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.RelatedNodeInfo, global::System.Collections.Generic.IList<global::LlamaParse.RelatedNodeInfo>>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, int?>),

            typeof(global::LlamaParse.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::LlamaParse.CloudPineconeVectorStore, global::LlamaParse.CloudPostgresVectorStore, global::LlamaParse.CloudQdrantVectorStore, global::LlamaParse.CloudAzureAISearchVectorStore, global::LlamaParse.CloudMongoDBAtlasVectorSearch, global::LlamaParse.CloudMilvusVectorStore, global::LlamaParse.CloudAstraDBVectorStore>), TypeInfoPropertyName = "CloudAstraDBVectorStore_7213cc45d352cf78")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::LlamaParse.CloudPineconeVectorStore, global::LlamaParse.CloudPostgresVectorStore, global::LlamaParse.CloudQdrantVectorStore, global::LlamaParse.CloudAzureAISearchVectorStore, global::LlamaParse.CloudMongoDBAtlasVectorSearch, global::LlamaParse.CloudMilvusVectorStore, global::LlamaParse.CloudAstraDBVectorStore, object>), TypeInfoPropertyName = "CloudAstraDBVectorStore_object_3f7470369807d660")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::LlamaParse.CloudS3DataSource, global::LlamaParse.CloudAzStorageBlobDataSource, global::LlamaParse.CloudGoogleDriveDataSource, global::LlamaParse.CloudOneDriveDataSource, global::LlamaParse.CloudSharepointDataSource, global::LlamaParse.CloudSlackDataSource, global::LlamaParse.CloudNotionPageDataSource, global::LlamaParse.CloudConfluenceDataSource, global::LlamaParse.CloudJiraDataSource, global::LlamaParse.CloudJiraDataSourceV2, global::LlamaParse.CloudBoxDataSource>), TypeInfoPropertyName = "CloudBoxDataSource_44c4d8909c0abf11")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::LlamaParse.CloudS3DataSource, global::LlamaParse.CloudAzStorageBlobDataSource, global::LlamaParse.CloudGoogleDriveDataSource, global::LlamaParse.CloudOneDriveDataSource, global::LlamaParse.CloudSharepointDataSource, global::LlamaParse.CloudSlackDataSource, global::LlamaParse.CloudNotionPageDataSource, global::LlamaParse.CloudConfluenceDataSource, global::LlamaParse.CloudJiraDataSource, global::LlamaParse.CloudJiraDataSourceV2, global::LlamaParse.CloudBoxDataSource, object>), TypeInfoPropertyName = "CloudBoxDataSource_object_8c6b9addb1a78f63")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::LlamaParse.CloudPineconeVectorStore, global::LlamaParse.CloudPostgresVectorStore, global::LlamaParse.CloudQdrantVectorStore, global::LlamaParse.CloudAzureAISearchVectorStore, global::LlamaParse.CloudMongoDBAtlasVectorSearch, global::LlamaParse.CloudMilvusVectorStore, global::LlamaParse.CloudAstraDBVectorStore>?), TypeInfoPropertyName = "CloudAstraDBVectorStore_2b857d4e76ac6e71")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::LlamaParse.CloudPineconeVectorStore, global::LlamaParse.CloudPostgresVectorStore, global::LlamaParse.CloudQdrantVectorStore, global::LlamaParse.CloudAzureAISearchVectorStore, global::LlamaParse.CloudMongoDBAtlasVectorSearch, global::LlamaParse.CloudMilvusVectorStore, global::LlamaParse.CloudAstraDBVectorStore, object>?), TypeInfoPropertyName = "CloudAstraDBVectorStore_object_d9f8945237261e89")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::LlamaParse.CloudS3DataSource, global::LlamaParse.CloudAzStorageBlobDataSource, global::LlamaParse.CloudGoogleDriveDataSource, global::LlamaParse.CloudOneDriveDataSource, global::LlamaParse.CloudSharepointDataSource, global::LlamaParse.CloudSlackDataSource, global::LlamaParse.CloudNotionPageDataSource, global::LlamaParse.CloudConfluenceDataSource, global::LlamaParse.CloudJiraDataSource, global::LlamaParse.CloudJiraDataSourceV2, global::LlamaParse.CloudBoxDataSource>?), TypeInfoPropertyName = "CloudBoxDataSource_ee99e0e6ec633008")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::LlamaParse.CloudS3DataSource, global::LlamaParse.CloudAzStorageBlobDataSource, global::LlamaParse.CloudGoogleDriveDataSource, global::LlamaParse.CloudOneDriveDataSource, global::LlamaParse.CloudSharepointDataSource, global::LlamaParse.CloudSlackDataSource, global::LlamaParse.CloudNotionPageDataSource, global::LlamaParse.CloudConfluenceDataSource, global::LlamaParse.CloudJiraDataSource, global::LlamaParse.CloudJiraDataSourceV2, global::LlamaParse.CloudBoxDataSource, object>?), TypeInfoPropertyName = "CloudBoxDataSource_object_dfe1806971be6576")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AdvancedModeTransformConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.NoneSegmentationConfig, global::LlamaParse.PageSegmentationConfig, global::LlamaParse.ElementSegmentationConfig>), TypeInfoPropertyName = "AnyOfNoneSegmentationConfigPageSegmentationConfigElementSegmentationConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.NoneSegmentationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PageSegmentationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ElementSegmentationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.NoneChunkingConfig, global::LlamaParse.CharacterChunkingConfig, global::LlamaParse.TokenChunkingConfig, global::LlamaParse.SentenceChunkingConfig, global::LlamaParse.SemanticChunkingConfig>), TypeInfoPropertyName = "AnyOfNoneChunkingConfigCharacterChunkingConfigTokenChunkingConfigSentenceChunkingConfigSemanticChunkingConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.NoneChunkingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.CharacterChunkingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.TokenChunkingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SentenceChunkingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SemanticChunkingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AgentData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AgentDataCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AgentDataUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AggregateGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AggregateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::LlamaParse.FilterOperation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FilterOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AttachmentRef))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AutoModeConfigurationEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AutoModeParsingConf))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<double?, string, object>), TypeInfoPropertyName = "AnyOfDoubleStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<int?, string, object>), TypeInfoPropertyName = "AnyOfInt32StringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AutoModeCropBox))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AutoModeIgnoreOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AutoModeParsingConfTier2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.AutoModeParsingConfVersion?, string, object>), TypeInfoPropertyName = "AnyOfAutoModeParsingConfVersionStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AutoModeParsingConfVersion), TypeInfoPropertyName = "AutoModeParsingConfVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AutoModeParsingConfSpecializedChartParsing2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AutoModeSpatialTextOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AutoModePresentationOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AutoTransformConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AzureOpenAIEmbedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AzureOpenAIEmbeddingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BBox))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BatchFileStatus), TypeInfoPropertyName = "BatchFileStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BatchItemDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BatchItemListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.BatchItemDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BatchJobCancelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BatchJobCancelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BatchJobStatus), TypeInfoPropertyName = "BatchJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BatchJobCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.BatchParseJobRecordCreate, global::LlamaParse.ClassifyJob>), TypeInfoPropertyName = "AnyOfBatchParseJobRecordCreateClassifyJob2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BatchParseJobRecordCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ClassifyJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BatchJobQueryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.BatchJobResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BatchJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BatchJobType), TypeInfoPropertyName = "BatchJobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BatchJobStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BatchParseJobConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.WebhookConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BatchParseJobConfigPriority2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ParserLanguages>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParserLanguages), TypeInfoPropertyName = "ParserLanguages2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.BatchParseJobConfigImagesToSaveVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BatchParseJobConfigImagesToSaveVariant1Item), TypeInfoPropertyName = "BatchParseJobConfigImagesToSaveVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParsingMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FailPageMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::System.Guid?, string>), TypeInfoPropertyName = "AnyOfGuidString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BedrockEmbedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BedrockEmbeddingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BodyImportPipelineMetadataApiV1PipelinesPipelineIdMetadataPut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BodyRunJobOnFileApiV1ExtractionJobsFilePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BodyScreenshotApiV1ParsingScreenshotPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BodyUploadFileApiV1BetaFilesPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BodyUploadFileApiV1ParsingUploadPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BodyUploadFileToDirectoryApiV1BetaDirectoriesDirectoryIdFilesUploadPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BoxAuthMechanism), TypeInfoPropertyName = "BoxAuthMechanism2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ChatData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PresetRetrievalParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LLMParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ChatInputParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.InputMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.InputMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ChatMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.MessageAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.MessageAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.MessageRole), TypeInfoPropertyName = "MessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ChatParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ClassificationResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ClassifierRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.StatusEnum), TypeInfoPropertyName = "StatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ClassifierRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ClassifyMode), TypeInfoPropertyName = "ClassifyMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ClassifyParsingConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ClassifyJobCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.LlamaParseWebhookConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseWebhookConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ClassifyJobResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.FileClassification>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FileClassification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ClassifyV2Configuration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ClassifyV2Rule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ClassifyV2Rule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ClassifyV2ParsingConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ClassifyV2JobCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ClassifyV2JobQueryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ClassifyV2JobResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ClassifyV2JobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<string, global::System.Guid?>), TypeInfoPropertyName = "AnyOfStringGuid2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ClassifyV2JobResponseStatus), TypeInfoPropertyName = "ClassifyV2JobResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ClassifyV2JobResponseDocumentInputType), TypeInfoPropertyName = "ClassifyV2JobResponseDocumentInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ClassifyV2Result))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ClassifyV2Parameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.CloudAstraDBVectorStore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.CloudAzStorageBlobDataSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.CloudAzureAISearchVectorStore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.CloudBoxDataSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.CloudConfluenceDataSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FailureHandlingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.CloudDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.CloudDocumentCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.CloudGoogleDriveDataSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.CloudJiraDataSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.CloudJiraDataSourceV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.CloudJiraDataSourceV2ApiVersion), TypeInfoPropertyName = "CloudJiraDataSourceV2ApiVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.CloudMilvusVectorStore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.CloudMongoDBAtlasVectorSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.CloudNotionPageDataSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.CloudOneDriveDataSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.CloudPineconeVectorStore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.CloudPostgresVectorStore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PGVectorHNSWSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.CloudQdrantVectorStore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.CloudS3DataSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.CloudSharepointDataSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.CloudSlackDataSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.CodeItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.BBox>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.CohereEmbedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.CohereEmbeddingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.CompositeRetrievalMode), TypeInfoPropertyName = "CompositeRetrievalMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.CompositeRetrievalParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ReRankConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.CompositeRetrievalResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.CompositeRetrievedTextNodeWithScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.CompositeRetrievedTextNodeWithScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.PageScreenshotNodeWithScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PageScreenshotNodeWithScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.PageFigureNodeWithScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PageFigureNodeWithScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.CompositeRetrievedTextNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ConfigurableDataSinkNames), TypeInfoPropertyName = "ConfigurableDataSinkNames2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ConfigurableDataSourceNames), TypeInfoPropertyName = "ConfigurableDataSourceNames2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ConfigurationCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.Parameters), TypeInfoPropertyName = "Parameters2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SplitV1Parameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractV2Parameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParseV2Parameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SpreadsheetV1Parameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.UntypedParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ConfigurationCreateRequestParametersDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ConfigurationCreateRequestParametersDiscriminatorProductType), TypeInfoPropertyName = "ConfigurationCreateRequestParametersDiscriminatorProductType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ConfigurationQueryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ConfigurationResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ConfigurationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ConfigurationResponseProductType), TypeInfoPropertyName = "ConfigurationResponseProductType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.Parameters2), TypeInfoPropertyName = "Parameters22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ConfigurationResponseParametersDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ConfigurationResponseParametersDiscriminatorProductType), TypeInfoPropertyName = "ConfigurationResponseParametersDiscriminatorProductType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ConfigurationUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParametersVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ConfigurationUpdateRequestParametersVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ConfigurationUpdateRequestParametersVariant1DiscriminatorProductType), TypeInfoPropertyName = "ConfigurationUpdateRequestParametersVariant1DiscriminatorProductType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DataSink))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DataSinkCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DataSinkUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DataSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>), TypeInfoPropertyName = "AnyOfObjectIListObjectStringInt32DoubleBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DataSourceReaderVersionMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DataSourceCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DataSourceReaderVersionMetadataReaderVersion2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DataSourceSyncRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DataSourceUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DeleteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DirectRetrievalParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.RetrieverPipeline>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.RetrieverPipeline))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DirectoryCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DirectoryFileBulkDeleteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DirectoryFileCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<string, int?, double?, bool?, global::System.Collections.Generic.IList<string>, object>), TypeInfoPropertyName = "AnyOfStringInt32DoubleBooleanIListStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DirectoryFileQueryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.DirectoryFileResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DirectoryFileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PresignedUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DirectoryFileUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DirectoryQueryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.DirectoryResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DirectoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DirectoryUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DocumentChunkMode), TypeInfoPropertyName = "DocumentChunkMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EmbeddingModelConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EmbeddingConfig), TypeInfoPropertyName = "EmbeddingConfig2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.GeminiEmbeddingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.HuggingFaceInferenceAPIEmbeddingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.OpenAIEmbeddingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.VertexAIEmbeddingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EmbeddingModelConfigEmbeddingConfigDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EmbeddingModelConfigEmbeddingConfigDiscriminatorType), TypeInfoPropertyName = "EmbeddingModelConfigEmbeddingConfigDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EmbeddingModelConfigCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EmbeddingConfig2), TypeInfoPropertyName = "EmbeddingConfig22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EmbeddingModelConfigCreateEmbeddingConfigDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType), TypeInfoPropertyName = "EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EmbeddingModelConfigUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EmbeddingConfigVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EmbeddingModelConfigUpdateEmbeddingConfigVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorType), TypeInfoPropertyName = "EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractAgentCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, string>), TypeInfoPropertyName = "AnyOfObjectString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractAgentUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractConfigPriority2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractTarget), TypeInfoPropertyName = "ExtractTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractMode), TypeInfoPropertyName = "ExtractMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PublicModelName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.ExtractModels?, string, object>), TypeInfoPropertyName = "AnyOfExtractModelsStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractModels), TypeInfoPropertyName = "ExtractModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractConfigurationTier), TypeInfoPropertyName = "ExtractConfigurationTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractConfigurationExtractionTarget), TypeInfoPropertyName = "ExtractConfigurationExtractionTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractJobStatus), TypeInfoPropertyName = "ExtractJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.File))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractJobCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractJobCreatePriority2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, string, object>), TypeInfoPropertyName = "AnyOfObjectStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractJobCreateBatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractJobMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractedFieldMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractJobUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractResultset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::System.Collections.Generic.IList<object>, object>), TypeInfoPropertyName = "AnyOfObjectIListObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractState), TypeInfoPropertyName = "ExtractState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractSchemaGenerateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractSchemaGenerateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractSchemaValidateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractSchemaValidateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractStatelessRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FileData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractV2Job))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractV2JobMetadata2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractV2JobCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractV2JobQueryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ExtractV2Job>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractV2ParametersTier), TypeInfoPropertyName = "ExtractV2ParametersTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractV2ParametersExtractionTarget), TypeInfoPropertyName = "ExtractV2ParametersExtractionTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractV2SchemaGenerateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractV2SchemaValidateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractV2SchemaValidateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractedRegionSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FailedMarkdownPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FailedStructuredPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FileCountByStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FileFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FileGrepApiResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.GrepMatchResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.GrepMatchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FileGrepParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FileQueryRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FileQueryResponseV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.FileV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FileV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FileReadApiResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FileReadParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FileSearchApiFileEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FileSearchApiResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.FileSearchApiFileEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FileSearchParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FilterCondition), TypeInfoPropertyName = "FilterCondition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<double?, int?, string, global::System.DateTime?, object>), TypeInfoPropertyName = "AnyOfDoubleInt32StringDateTimeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<double?, int?, string, global::System.DateTime?, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FilterOperator), TypeInfoPropertyName = "FilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FilterTypeUnionIntFloat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FilterTypeUnionIntFloatOperator), TypeInfoPropertyName = "FilterTypeUnionIntFloatOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<int?, double?, global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<int?, double?>>>), TypeInfoPropertyName = "AnyOfInt32DoubleIListAnyOfInt32Double2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<int?, double?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<int?, double?>), TypeInfoPropertyName = "AnyOfInt32Double2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FilterTypeUnionStrIntBoolFloat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FilterTypeUnionStrIntBoolFloatOperator), TypeInfoPropertyName = "FilterTypeUnionStrIntBoolFloatOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<string, int?, bool?, double?, global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?, bool?, double?>>>), TypeInfoPropertyName = "AnyOfStringInt32BooleanDoubleIListAnyOfStringInt32BooleanDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?, bool?, double?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<string, int?, bool?, double?>), TypeInfoPropertyName = "AnyOfStringInt32BooleanDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FilterTypeStr))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FilterTypeStrOperator), TypeInfoPropertyName = "FilterTypeStrOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FooterItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ItemsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ItemsItem), TypeInfoPropertyName = "ItemsItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.TextItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.HeadingItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.TableItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ImageItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LinkItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FooterItemItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FooterItemItemDiscriminatorType), TypeInfoPropertyName = "FooterItemItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.GeminiEmbedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.GenerateTitleParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.HeaderItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ItemsItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ItemsItem2), TypeInfoPropertyName = "ItemsItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.HeaderItemItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.HeaderItemItemDiscriminatorType), TypeInfoPropertyName = "HeaderItemItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.HuggingFaceInferenceAPIEmbedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.Pooling))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<string, bool?, object>), TypeInfoPropertyName = "AnyOfStringBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ImageAttachmentRef))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ImageMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ImageMetadataCategory2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ImageMetadataBBox2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ImagesContentMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ImageMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.IndexCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.SyncProductEntryRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SyncProductEntryRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.IndexMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.IndexQueryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.IndexResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.IndexResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.IngestionErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.JobNameMapping), TypeInfoPropertyName = "JobNameMapping2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ItemProcessingResultsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ProcessingResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ProcessingResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.JobDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.JobStateTransitions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.JobDataPointResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.JobDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.JobMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SupportedLLMModelNames), TypeInfoPropertyName = "SupportedLLMModelNames2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.TextItem, global::LlamaParse.ListItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.TextItem, global::LlamaParse.ListItem>), TypeInfoPropertyName = "AnyOfTextItemListItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseAgenticOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseCostOptimizerParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseCropBox))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseFastOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseHtmlOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseIgnoreOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseInputOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParsePdfOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseSpreadsheetOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParsePresentationOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseJobFailureConditions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseMarkdownOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseTables))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseOcrParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseOutputOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseSpatialTextOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseTablesAsSpreadsheetOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.LlamaParseOutputOptionsImagesToSaveItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseOutputOptionsImagesToSaveItem), TypeInfoPropertyName = "LlamaParseOutputOptionsImagesToSaveItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParsePageRanges))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseParametersPriority2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.LlamaParseParametersImagesToSaveVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseParametersImagesToSaveVariant1Item), TypeInfoPropertyName = "LlamaParseParametersImagesToSaveVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseProcessingControl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseTimeouts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseProcessingOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseProcessingOptionsSpecializedChartParsing2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.AutoModeConfigurationEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseSupportedFileExtensions), TypeInfoPropertyName = "LlamaParseSupportedFileExtensions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ManagedIngestionStatus), TypeInfoPropertyName = "ManagedIngestionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ManagedIngestionStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.IngestionErrorResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ManagedOpenAIEmbedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ManagedOpenAIEmbeddingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.MarkdownResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.MarkdownResultPage, global::LlamaParse.FailedMarkdownPage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.MarkdownResultPage, global::LlamaParse.FailedMarkdownPage>), TypeInfoPropertyName = "AnyOfMarkdownResultPageFailedMarkdownPage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.MarkdownResultPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.MetadataFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<int?, double?, string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<int>, object>), TypeInfoPropertyName = "AnyOfInt32DoubleStringIListStringIListDoubleIListInt32Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.MetadataFilters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.MetadataFilter, global::LlamaParse.MetadataFilters>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.MetadataFilter, global::LlamaParse.MetadataFilters>), TypeInfoPropertyName = "AnyOfMetadataFilterMetadataFilters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.MetadataResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.MetadataResultPage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.MetadataResultPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.MongoStaticFilters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.NodeRelationship), TypeInfoPropertyName = "NodeRelationship2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ObjectType), TypeInfoPropertyName = "ObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.OpenAIEmbedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.Organization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParsePlanLevel), TypeInfoPropertyName = "ParsePlanLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PGVectorDistanceMethod), TypeInfoPropertyName = "PGVectorDistanceMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PGVectorVectorType), TypeInfoPropertyName = "PGVectorVectorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PageFigureMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PageScreenshotMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PaginatedExtractRunsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ExtractRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PaginatedListCloudDocumentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.CloudDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PaginatedListPipelineFilesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.PipelineFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PaginatedResponseAgentData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.AgentData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PaginatedResponseAggregateGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.AggregateGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PaginatedResponseClassifyJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ClassifyJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PaginatedResponseSpreadsheetJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.SpreadsheetJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SpreadsheetJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParseConcernItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParseJobQueryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ParseJobResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParseJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParseJobResponseStatus), TypeInfoPropertyName = "ParseJobResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParseRequestConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParseRequestConfigurationTier), TypeInfoPropertyName = "ParseRequestConfigurationTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.ParseRequestConfigurationVersion?, string>), TypeInfoPropertyName = "AnyOfParseRequestConfigurationVersionString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParseRequestConfigurationVersion), TypeInfoPropertyName = "ParseRequestConfigurationVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParseResultResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::LlamaParse.ResultTypeMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ResultTypeMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.TextResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.StructuredResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParseV2ParametersTier), TypeInfoPropertyName = "ParseV2ParametersTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.ParseV2ParametersVersion?, string>), TypeInfoPropertyName = "AnyOfParseV2ParametersVersionString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParseV2ParametersVersion), TypeInfoPropertyName = "ParseV2ParametersVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParseVersionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ParseVersionsResponseFastItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParseVersionsResponseFastItem), TypeInfoPropertyName = "ParseVersionsResponseFastItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ParseVersionsResponseCostEffectiveItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParseVersionsResponseCostEffectiveItem), TypeInfoPropertyName = "ParseVersionsResponseCostEffectiveItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ParseVersionsResponseAgenticItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParseVersionsResponseAgenticItem), TypeInfoPropertyName = "ParseVersionsResponseAgenticItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ParseVersionsResponseAgenticPlu>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParseVersionsResponseAgenticPlu), TypeInfoPropertyName = "ParseVersionsResponseAgenticPlu2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParsingJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParsingJobJsonResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParsingJobMarkdownResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParsingJobStructuredResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParsingJobTextResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PartitionNames), TypeInfoPropertyName = "PartitionNames2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.Pipeline))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineType), TypeInfoPropertyName = "PipelineType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EmbeddingConfig3), TypeInfoPropertyName = "EmbeddingConfig32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineEmbeddingConfigDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineEmbeddingConfigDiscriminatorType), TypeInfoPropertyName = "PipelineEmbeddingConfigDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SparseModelConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineConfigurationHashes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.AutoTransformConfig, global::LlamaParse.AdvancedModeTransformConfig>), TypeInfoPropertyName = "AnyOfAutoTransformConfigAdvancedModeTransformConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineMetadataConfig2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EmbeddingConfigVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineCreateEmbeddingConfigVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineCreateEmbeddingConfigVariant1DiscriminatorType), TypeInfoPropertyName = "PipelineCreateEmbeddingConfigVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.AutoTransformConfig, global::LlamaParse.AdvancedModeTransformConfig, object>), TypeInfoPropertyName = "AnyOfAutoTransformConfigAdvancedModeTransformConfigObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineDataSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineDataSourceStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineDataSourceCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineDataSourceUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineFileStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineFileCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineFileListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.PipelineFileResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineFileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineFileResponseStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineFileUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EmbeddingConfigVariant13))]
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::LlamaParse.JsonConverters.AutoModeParsingConfTier2JsonConverter),

            typeof(global::LlamaParse.JsonConverters.AutoModeParsingConfTier2NullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.AutoModeParsingConfVersionJsonConverter),

            typeof(global::LlamaParse.JsonConverters.AutoModeParsingConfVersionNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.AutoModeParsingConfSpecializedChartParsing2JsonConverter),

            typeof(global::LlamaParse.JsonConverters.AutoModeParsingConfSpecializedChartParsing2NullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.BatchFileStatusJsonConverter),

            typeof(global::LlamaParse.JsonConverters.BatchFileStatusNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.BatchJobStatusJsonConverter),

            typeof(global::LlamaParse.JsonConverters.BatchJobStatusNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.BatchJobTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.BatchJobTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.BatchParseJobConfigPriority2JsonConverter),

            typeof(global::LlamaParse.JsonConverters.BatchParseJobConfigPriority2NullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.BatchParseJobConfigImagesToSaveVariant1ItemJsonConverter),

            typeof(global::LlamaParse.JsonConverters.BatchParseJobConfigImagesToSaveVariant1ItemNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.BoxAuthMechanismJsonConverter),

            typeof(global::LlamaParse.JsonConverters.BoxAuthMechanismNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ClassifyModeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ClassifyModeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ClassifyV2JobResponseStatusJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ClassifyV2JobResponseStatusNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ClassifyV2JobResponseDocumentInputTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ClassifyV2JobResponseDocumentInputTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.CloudJiraDataSourceV2ApiVersionJsonConverter),

            typeof(global::LlamaParse.JsonConverters.CloudJiraDataSourceV2ApiVersionNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.CompositeRetrievalModeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.CompositeRetrievalModeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ConfigurableDataSinkNamesJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ConfigurableDataSinkNamesNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ConfigurableDataSourceNamesJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ConfigurableDataSourceNamesNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ConfigurationCreateRequestParametersDiscriminatorProductTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ConfigurationCreateRequestParametersDiscriminatorProductTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ConfigurationResponseProductTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ConfigurationResponseProductTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ConfigurationResponseParametersDiscriminatorProductTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ConfigurationResponseParametersDiscriminatorProductTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ConfigurationUpdateRequestParametersVariant1DiscriminatorProductTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ConfigurationUpdateRequestParametersVariant1DiscriminatorProductTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.DataSourceReaderVersionMetadataReaderVersion2JsonConverter),

            typeof(global::LlamaParse.JsonConverters.DataSourceReaderVersionMetadataReaderVersion2NullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.DocumentChunkModeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.DocumentChunkModeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.EmbeddingModelConfigEmbeddingConfigDiscriminatorTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.EmbeddingModelConfigEmbeddingConfigDiscriminatorTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ExtractConfigPriority2JsonConverter),

            typeof(global::LlamaParse.JsonConverters.ExtractConfigPriority2NullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ExtractConfigurationTierJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ExtractConfigurationTierNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ExtractConfigurationExtractionTargetJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ExtractConfigurationExtractionTargetNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ExtractJobStatusJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ExtractJobStatusNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ExtractJobCreatePriority2JsonConverter),

            typeof(global::LlamaParse.JsonConverters.ExtractJobCreatePriority2NullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ExtractModeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ExtractModeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ExtractModelsJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ExtractModelsNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ExtractStateJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ExtractStateNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ExtractTargetJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ExtractTargetNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ExtractV2ParametersTierJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ExtractV2ParametersTierNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ExtractV2ParametersExtractionTargetJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ExtractV2ParametersExtractionTargetNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.FailPageModeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.FailPageModeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.FilterConditionJsonConverter),

            typeof(global::LlamaParse.JsonConverters.FilterConditionNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.FilterOperatorJsonConverter),

            typeof(global::LlamaParse.JsonConverters.FilterOperatorNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.FilterTypeUnionIntFloatOperatorJsonConverter),

            typeof(global::LlamaParse.JsonConverters.FilterTypeUnionIntFloatOperatorNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.FilterTypeUnionStrIntBoolFloatOperatorJsonConverter),

            typeof(global::LlamaParse.JsonConverters.FilterTypeUnionStrIntBoolFloatOperatorNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.FilterTypeStrOperatorJsonConverter),

            typeof(global::LlamaParse.JsonConverters.FilterTypeStrOperatorNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.FooterItemItemDiscriminatorTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.FooterItemItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.HeaderItemItemDiscriminatorTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.HeaderItemItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ImageMetadataCategory2JsonConverter),

            typeof(global::LlamaParse.JsonConverters.ImageMetadataCategory2NullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.JobNameMappingJsonConverter),

            typeof(global::LlamaParse.JsonConverters.JobNameMappingNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.LlamaParseOutputOptionsImagesToSaveItemJsonConverter),

            typeof(global::LlamaParse.JsonConverters.LlamaParseOutputOptionsImagesToSaveItemNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.LlamaParseParametersPriority2JsonConverter),

            typeof(global::LlamaParse.JsonConverters.LlamaParseParametersPriority2NullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.LlamaParseParametersImagesToSaveVariant1ItemJsonConverter),

            typeof(global::LlamaParse.JsonConverters.LlamaParseParametersImagesToSaveVariant1ItemNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.LlamaParseProcessingOptionsSpecializedChartParsing2JsonConverter),

            typeof(global::LlamaParse.JsonConverters.LlamaParseProcessingOptionsSpecializedChartParsing2NullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.LlamaParseSupportedFileExtensionsJsonConverter),

            typeof(global::LlamaParse.JsonConverters.LlamaParseSupportedFileExtensionsNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ManagedIngestionStatusJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ManagedIngestionStatusNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.MessageRoleJsonConverter),

            typeof(global::LlamaParse.JsonConverters.MessageRoleNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.NodeRelationshipJsonConverter),

            typeof(global::LlamaParse.JsonConverters.NodeRelationshipNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ObjectTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ObjectTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PGVectorDistanceMethodJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PGVectorDistanceMethodNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PGVectorVectorTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PGVectorVectorTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParseJobResponseStatusJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParseJobResponseStatusNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParsePlanLevelJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParsePlanLevelNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParseRequestConfigurationTierJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParseRequestConfigurationTierNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParseRequestConfigurationVersionJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParseRequestConfigurationVersionNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParseV2ParametersTierJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParseV2ParametersTierNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParseV2ParametersVersionJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParseV2ParametersVersionNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParseVersionsResponseFastItemJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParseVersionsResponseFastItemNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParseVersionsResponseCostEffectiveItemJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParseVersionsResponseCostEffectiveItemNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParseVersionsResponseAgenticItemJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParseVersionsResponseAgenticItemNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParseVersionsResponseAgenticPluJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParseVersionsResponseAgenticPluNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParserLanguagesJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParserLanguagesNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParsingModeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParsingModeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PartitionNamesJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PartitionNamesNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PipelineEmbeddingConfigDiscriminatorTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PipelineEmbeddingConfigDiscriminatorTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PipelineStatus2JsonConverter),

            typeof(global::LlamaParse.JsonConverters.PipelineStatus2NullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PipelineCreateEmbeddingConfigVariant1DiscriminatorTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PipelineCreateEmbeddingConfigVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PipelineDataSourceStatus2JsonConverter),

            typeof(global::LlamaParse.JsonConverters.PipelineDataSourceStatus2NullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PipelineFileStatus2JsonConverter),

            typeof(global::LlamaParse.JsonConverters.PipelineFileStatus2NullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PipelineFileResponseStatus2JsonConverter),

            typeof(global::LlamaParse.JsonConverters.PipelineFileResponseStatus2NullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PipelineTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PipelineTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PipelineUpdateEmbeddingConfigVariant1DiscriminatorTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PipelineUpdateEmbeddingConfigVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PoolingJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PoolingNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PublicModelNameJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PublicModelNameNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ReRankerTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ReRankerTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.RetrievalModeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.RetrievalModeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.SessionGetAPIResponseEventDiscriminatorTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.SessionGetAPIResponseEventDiscriminatorTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.SparseModelTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.SparseModelTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.SplitStrategyAllowUncategorizedJsonConverter),

            typeof(global::LlamaParse.JsonConverters.SplitStrategyAllowUncategorizedNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.SpreadsheetParsingConfigTableMergeSensitivityJsonConverter),

            typeof(global::LlamaParse.JsonConverters.SpreadsheetParsingConfigTableMergeSensitivityNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.SpreadsheetResultTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.SpreadsheetResultTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.SpreadsheetV1ParametersTableMergeSensitivityJsonConverter),

            typeof(global::LlamaParse.JsonConverters.SpreadsheetV1ParametersTableMergeSensitivityNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.StatusEnumJsonConverter),

            typeof(global::LlamaParse.JsonConverters.StatusEnumNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.StructuredResultPageItemDiscriminatorTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.StructuredResultPageItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.SupportedLLMModelNamesJsonConverter),

            typeof(global::LlamaParse.JsonConverters.SupportedLLMModelNamesNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.SyncProductEntryRequestProductTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.SyncProductEntryRequestProductTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.UsageMetricEventTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.UsageMetricEventTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.VertexEmbeddingModeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.VertexEmbeddingModeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.WebhookConfigurationWebhookEventsVariant1ItemJsonConverter),

            typeof(global::LlamaParse.JsonConverters.WebhookConfigurationWebhookEventsVariant1ItemNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ListProjectJobDataPointsApiV1JobDataPointsGetJobTypeJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ListProjectJobDataPointsApiV1JobDataPointsGetJobTypeNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1ItemJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1ItemNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetStatusRefreshPolicyJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetStatusRefreshPolicyNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PaginatedListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsPaginatedGetStatusRefreshPolicyJsonConverter),

            typeof(global::LlamaParse.JsonConverters.PaginatedListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsPaginatedGetStatusRefreshPolicyNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ListDirectoriesApiV1BetaDirectoriesGetType2JsonConverter),

            typeof(global::LlamaParse.JsonConverters.ListDirectoriesApiV1BetaDirectoriesGetType2NullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1ItemJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1ItemNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ListSplitJobsApiV1BetaSplitJobsGetStatus2JsonConverter),

            typeof(global::LlamaParse.JsonConverters.ListSplitJobsApiV1BetaSplitJobsGetStatus2NullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1ItemJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1ItemNullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ListParseJobsApiV2ParseGetStatus2JsonConverter),

            typeof(global::LlamaParse.JsonConverters.ListParseJobsApiV2ParseGetStatus2NullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ListClassifyJobsApiV2ClassifyGetStatus2JsonConverter),

            typeof(global::LlamaParse.JsonConverters.ListClassifyJobsApiV2ClassifyGetStatus2NullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ListExtractJobsApiV2ExtractGetStatus2JsonConverter),

            typeof(global::LlamaParse.JsonConverters.ListExtractJobsApiV2ExtractGetStatus2NullableJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParametersJsonConverter),

            typeof(global::LlamaParse.JsonConverters.Parameters2JsonConverter),

            typeof(global::LlamaParse.JsonConverters.ParametersVariant1JsonConverter),

            typeof(global::LlamaParse.JsonConverters.EmbeddingConfigJsonConverter),

            typeof(global::LlamaParse.JsonConverters.EmbeddingConfig2JsonConverter),

            typeof(global::LlamaParse.JsonConverters.EmbeddingConfigVariant1JsonConverter),

            typeof(global::LlamaParse.JsonConverters.ItemsItemJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ItemsItem2JsonConverter),

            typeof(global::LlamaParse.JsonConverters.EmbeddingConfig3JsonConverter),

            typeof(global::LlamaParse.JsonConverters.EmbeddingConfigVariant12JsonConverter),

            typeof(global::LlamaParse.JsonConverters.EmbeddingConfigVariant13JsonConverter),

            typeof(global::LlamaParse.JsonConverters.EventsItemJsonConverter),

            typeof(global::LlamaParse.JsonConverters.ItemsItem4JsonConverter),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.NoneSegmentationConfig, global::LlamaParse.PageSegmentationConfig, global::LlamaParse.ElementSegmentationConfig>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.NoneChunkingConfig, global::LlamaParse.CharacterChunkingConfig, global::LlamaParse.TokenChunkingConfig, global::LlamaParse.SentenceChunkingConfig, global::LlamaParse.SemanticChunkingConfig>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.AutoModeParsingConfVersion?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.BatchParseJobRecordCreate, global::LlamaParse.ClassifyJob>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::LlamaParse.CloudPineconeVectorStore, global::LlamaParse.CloudPostgresVectorStore, global::LlamaParse.CloudQdrantVectorStore, global::LlamaParse.CloudAzureAISearchVectorStore, global::LlamaParse.CloudMongoDBAtlasVectorSearch, global::LlamaParse.CloudMilvusVectorStore, global::LlamaParse.CloudAstraDBVectorStore>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::LlamaParse.CloudPineconeVectorStore, global::LlamaParse.CloudPostgresVectorStore, global::LlamaParse.CloudQdrantVectorStore, global::LlamaParse.CloudAzureAISearchVectorStore, global::LlamaParse.CloudMongoDBAtlasVectorSearch, global::LlamaParse.CloudMilvusVectorStore, global::LlamaParse.CloudAstraDBVectorStore>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::LlamaParse.CloudPineconeVectorStore, global::LlamaParse.CloudPostgresVectorStore, global::LlamaParse.CloudQdrantVectorStore, global::LlamaParse.CloudAzureAISearchVectorStore, global::LlamaParse.CloudMongoDBAtlasVectorSearch, global::LlamaParse.CloudMilvusVectorStore, global::LlamaParse.CloudAstraDBVectorStore, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::LlamaParse.CloudS3DataSource, global::LlamaParse.CloudAzStorageBlobDataSource, global::LlamaParse.CloudGoogleDriveDataSource, global::LlamaParse.CloudOneDriveDataSource, global::LlamaParse.CloudSharepointDataSource, global::LlamaParse.CloudSlackDataSource, global::LlamaParse.CloudNotionPageDataSource, global::LlamaParse.CloudConfluenceDataSource, global::LlamaParse.CloudJiraDataSource, global::LlamaParse.CloudJiraDataSourceV2, global::LlamaParse.CloudBoxDataSource>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::LlamaParse.CloudS3DataSource, global::LlamaParse.CloudAzStorageBlobDataSource, global::LlamaParse.CloudGoogleDriveDataSource, global::LlamaParse.CloudOneDriveDataSource, global::LlamaParse.CloudSharepointDataSource, global::LlamaParse.CloudSlackDataSource, global::LlamaParse.CloudNotionPageDataSource, global::LlamaParse.CloudConfluenceDataSource, global::LlamaParse.CloudJiraDataSource, global::LlamaParse.CloudJiraDataSourceV2, global::LlamaParse.CloudBoxDataSource>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::LlamaParse.CloudS3DataSource, global::LlamaParse.CloudAzStorageBlobDataSource, global::LlamaParse.CloudGoogleDriveDataSource, global::LlamaParse.CloudOneDriveDataSource, global::LlamaParse.CloudSharepointDataSource, global::LlamaParse.CloudSlackDataSource, global::LlamaParse.CloudNotionPageDataSource, global::LlamaParse.CloudConfluenceDataSource, global::LlamaParse.CloudJiraDataSource, global::LlamaParse.CloudJiraDataSourceV2, global::LlamaParse.CloudBoxDataSource, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, string>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, string>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.ExtractModels?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, string>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, string>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, double?, global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<int?, double?>>>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, double?>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, int?, bool?, double?, global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?, bool?, double?>>>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, int?, bool?, double?>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.TextItem, global::LlamaParse.ListItem>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.MarkdownResultPage, global::LlamaParse.FailedMarkdownPage>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, double?, string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<int>, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.MetadataFilter, global::LlamaParse.MetadataFilters>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.ParseRequestConfigurationVersion?, string>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.ParseV2ParametersVersion?, string>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.AutoTransformConfig, global::LlamaParse.AdvancedModeTransformConfig>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.AutoTransformConfig, global::LlamaParse.AdvancedModeTransformConfig, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::LlamaParse.CloudS3DataSource, global::LlamaParse.CloudAzStorageBlobDataSource, global::LlamaParse.CloudGoogleDriveDataSource, global::LlamaParse.CloudOneDriveDataSource, global::LlamaParse.CloudSharepointDataSource, global::LlamaParse.CloudSlackDataSource, global::LlamaParse.CloudNotionPageDataSource, global::LlamaParse.CloudConfluenceDataSource, global::LlamaParse.CloudJiraDataSource, global::LlamaParse.CloudJiraDataSourceV2, global::LlamaParse.CloudBoxDataSource>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.AutoTransformConfig, global::LlamaParse.AdvancedModeTransformConfig, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.BatchParseJobRecordCreate, global::LlamaParse.ClassifyJob>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.ObjectType?, string, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.FilterTypeUnionStrIntBoolFloat, global::System.Collections.Generic.IList<global::LlamaParse.FilterTypeUnionIntFloat>, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.StructuredResultPage, global::LlamaParse.FailedStructuredPage>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, int?, double?, object>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.RelatedNodeInfo, global::System.Collections.Generic.IList<global::LlamaParse.RelatedNodeInfo>>),

            typeof(global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, int?>),

            typeof(global::LlamaParse.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::LlamaParse.CloudPineconeVectorStore, global::LlamaParse.CloudPostgresVectorStore, global::LlamaParse.CloudQdrantVectorStore, global::LlamaParse.CloudAzureAISearchVectorStore, global::LlamaParse.CloudMongoDBAtlasVectorSearch, global::LlamaParse.CloudMilvusVectorStore, global::LlamaParse.CloudAstraDBVectorStore>), TypeInfoPropertyName = "CloudAstraDBVectorStore_7213cc45d352cf78")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::LlamaParse.CloudPineconeVectorStore, global::LlamaParse.CloudPostgresVectorStore, global::LlamaParse.CloudQdrantVectorStore, global::LlamaParse.CloudAzureAISearchVectorStore, global::LlamaParse.CloudMongoDBAtlasVectorSearch, global::LlamaParse.CloudMilvusVectorStore, global::LlamaParse.CloudAstraDBVectorStore, object>), TypeInfoPropertyName = "CloudAstraDBVectorStore_object_3f7470369807d660")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::LlamaParse.CloudS3DataSource, global::LlamaParse.CloudAzStorageBlobDataSource, global::LlamaParse.CloudGoogleDriveDataSource, global::LlamaParse.CloudOneDriveDataSource, global::LlamaParse.CloudSharepointDataSource, global::LlamaParse.CloudSlackDataSource, global::LlamaParse.CloudNotionPageDataSource, global::LlamaParse.CloudConfluenceDataSource, global::LlamaParse.CloudJiraDataSource, global::LlamaParse.CloudJiraDataSourceV2, global::LlamaParse.CloudBoxDataSource>), TypeInfoPropertyName = "CloudBoxDataSource_44c4d8909c0abf11")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::LlamaParse.CloudS3DataSource, global::LlamaParse.CloudAzStorageBlobDataSource, global::LlamaParse.CloudGoogleDriveDataSource, global::LlamaParse.CloudOneDriveDataSource, global::LlamaParse.CloudSharepointDataSource, global::LlamaParse.CloudSlackDataSource, global::LlamaParse.CloudNotionPageDataSource, global::LlamaParse.CloudConfluenceDataSource, global::LlamaParse.CloudJiraDataSource, global::LlamaParse.CloudJiraDataSourceV2, global::LlamaParse.CloudBoxDataSource, object>), TypeInfoPropertyName = "CloudBoxDataSource_object_8c6b9addb1a78f63")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::LlamaParse.CloudPineconeVectorStore, global::LlamaParse.CloudPostgresVectorStore, global::LlamaParse.CloudQdrantVectorStore, global::LlamaParse.CloudAzureAISearchVectorStore, global::LlamaParse.CloudMongoDBAtlasVectorSearch, global::LlamaParse.CloudMilvusVectorStore, global::LlamaParse.CloudAstraDBVectorStore>?), TypeInfoPropertyName = "CloudAstraDBVectorStore_2b857d4e76ac6e71")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::LlamaParse.CloudPineconeVectorStore, global::LlamaParse.CloudPostgresVectorStore, global::LlamaParse.CloudQdrantVectorStore, global::LlamaParse.CloudAzureAISearchVectorStore, global::LlamaParse.CloudMongoDBAtlasVectorSearch, global::LlamaParse.CloudMilvusVectorStore, global::LlamaParse.CloudAstraDBVectorStore, object>?), TypeInfoPropertyName = "CloudAstraDBVectorStore_object_d9f8945237261e89")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::LlamaParse.CloudS3DataSource, global::LlamaParse.CloudAzStorageBlobDataSource, global::LlamaParse.CloudGoogleDriveDataSource, global::LlamaParse.CloudOneDriveDataSource, global::LlamaParse.CloudSharepointDataSource, global::LlamaParse.CloudSlackDataSource, global::LlamaParse.CloudNotionPageDataSource, global::LlamaParse.CloudConfluenceDataSource, global::LlamaParse.CloudJiraDataSource, global::LlamaParse.CloudJiraDataSourceV2, global::LlamaParse.CloudBoxDataSource>?), TypeInfoPropertyName = "CloudBoxDataSource_ee99e0e6ec633008")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::LlamaParse.CloudS3DataSource, global::LlamaParse.CloudAzStorageBlobDataSource, global::LlamaParse.CloudGoogleDriveDataSource, global::LlamaParse.CloudOneDriveDataSource, global::LlamaParse.CloudSharepointDataSource, global::LlamaParse.CloudSlackDataSource, global::LlamaParse.CloudNotionPageDataSource, global::LlamaParse.CloudConfluenceDataSource, global::LlamaParse.CloudJiraDataSource, global::LlamaParse.CloudJiraDataSourceV2, global::LlamaParse.CloudBoxDataSource, object>?), TypeInfoPropertyName = "CloudBoxDataSource_object_dfe1806971be6576")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineUpdateEmbeddingConfigVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineUpdateEmbeddingConfigVariant1DiscriminatorType), TypeInfoPropertyName = "PipelineUpdateEmbeddingConfigVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PlaygroundSession))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ChatMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.RetrievalMode), TypeInfoPropertyName = "RetrievalMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ProcessingResultMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.Project))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ProjectQueryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ProjectResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ProjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ReRankerType), TypeInfoPropertyName = "ReRankerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.RelatedNodeInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.ObjectType?, string, object>), TypeInfoPropertyName = "AnyOfObjectTypeStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.RerankApiConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.RetrievalParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.RetrievalResultResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.StaticFieldsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.RetrieveApiResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.RetrievalResultResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.RetrieveParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.FilterTypeUnionStrIntBoolFloat, global::System.Collections.Generic.IList<global::LlamaParse.FilterTypeUnionIntFloat>, object>), TypeInfoPropertyName = "AnyOfFilterTypeUnionStrIntBoolFloatIListFilterTypeUnionIntFloatObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.FilterTypeUnionIntFloat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.RetrieveResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.TextNodeWithScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.TextNodeWithScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.Retriever))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.RetrieverCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.RetrieverUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SearchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SessionCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SessionGetAPIResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.EventsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EventsItem), TypeInfoPropertyName = "EventsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ThinkingDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.TextDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ThinkingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.TextEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ToolCallEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ToolResultEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.StopEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.UserInputEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SessionGetAPIResponseEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SessionGetAPIResponseEventDiscriminatorType), TypeInfoPropertyName = "SessionGetAPIResponseEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SessionListAPIResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.SessionSummaryAPIResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SessionSummaryAPIResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SparseModelType), TypeInfoPropertyName = "SparseModelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SplitCategory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SplitConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.SplitCategory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SplitStrategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SplitCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SplitDocumentInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SplitJobQueryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.SplitJobResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SplitJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SplitResultResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.SplitSegmentResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SplitSegmentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SplitStrategyAllowUncategorized), TypeInfoPropertyName = "SplitStrategyAllowUncategorized2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SpreadsheetParsingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ExtractedRegionSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.WorksheetMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.WorksheetMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SpreadsheetJobCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SpreadsheetParsingConfigTableMergeSensitivity), TypeInfoPropertyName = "SpreadsheetParsingConfigTableMergeSensitivity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SpreadsheetResultType), TypeInfoPropertyName = "SpreadsheetResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SpreadsheetV1ParametersTableMergeSensitivity), TypeInfoPropertyName = "SpreadsheetV1ParametersTableMergeSensitivity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.AttachmentRef>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.Usage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.StructuredResultPage, global::LlamaParse.FailedStructuredPage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.StructuredResultPage, global::LlamaParse.FailedStructuredPage>), TypeInfoPropertyName = "AnyOfStructuredResultPageFailedStructuredPage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.StructuredResultPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ItemsItem4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ItemsItem4), TypeInfoPropertyName = "ItemsItem42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.StructuredResultPageItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.StructuredResultPageItemDiscriminatorType), TypeInfoPropertyName = "StructuredResultPageItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SyncProductEntryRequestProductType), TypeInfoPropertyName = "SyncProductEntryRequestProductType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?, double?, object>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?, double?, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<string, int?, double?, object>), TypeInfoPropertyName = "AnyOfStringInt32DoubleObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ParseConcernItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.TextNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.RelatedNodeInfo, global::System.Collections.Generic.IList<global::LlamaParse.RelatedNodeInfo>>), TypeInfoPropertyName = "AnyOfRelatedNodeInfoIListRelatedNodeInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.RelatedNodeInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.TextResultPage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.TextResultPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.UsageMetric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.UsageMetricEventType), TypeInfoPropertyName = "UsageMetricEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.UsageMetricQueryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.UsageMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.VertexTextEmbedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.VertexEmbeddingMode), TypeInfoPropertyName = "VertexEmbeddingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item), TypeInfoPropertyName = "WebhookConfigurationWebhookEventsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.PipelineDataSourceCreate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.PipelineFileCreate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.CloudDocumentCreate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListProjectJobDataPointsApiV1JobDataPointsGetJobType), TypeInfoPropertyName = "ListProjectJobDataPointsApiV1JobDataPointsGetJobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item), TypeInfoPropertyName = "ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetStatusRefreshPolicy), TypeInfoPropertyName = "ListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetStatusRefreshPolicy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PaginatedListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsPaginatedGetStatusRefreshPolicy), TypeInfoPropertyName = "PaginatedListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsPaginatedGetStatusRefreshPolicy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item), TypeInfoPropertyName = "ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListSplitJobsApiV1BetaSplitJobsGetStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item), TypeInfoPropertyName = "ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListParseJobsApiV2ParseGetStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListClassifyJobsApiV2ClassifyGetStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListExtractJobsApiV2ExtractGetStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.DataSink>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.DataSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.EmbeddingModelConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.Organization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.Project>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.PageScreenshotMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.PageFigureMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.Pipeline>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.PipelineDataSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.TextNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.Retriever>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.LlamaParseSupportedFileExtensions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ExtractJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ExtractAgent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.BatchItemDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.BatchJobResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.WebhookConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ParserLanguages>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.BatchParseJobConfigImagesToSaveVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.InputMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.MessageAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ClassifierRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.LlamaParseWebhookConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.FileClassification>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ClassifyV2Rule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ClassifyV2JobResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.BBox>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.CompositeRetrievedTextNodeWithScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.PageScreenshotNodeWithScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.PageFigureNodeWithScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ConfigurationResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::System.Collections.Generic.List<object>, string, int?, double?, bool?, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.RetrieverPipeline>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<string, int?, double?, bool?, global::System.Collections.Generic.List<string>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.DirectoryFileResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.DirectoryResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::System.Collections.Generic.List<object>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ExtractV2Job>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.GrepMatchResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.FileV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.FileSearchApiFileEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.AnyOf<double?, int?, string, global::System.DateTime?, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<int?, double?, global::System.Collections.Generic.List<global::LlamaParse.AnyOf<int?, double?>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.AnyOf<int?, double?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<string, int?, bool?, double?, global::System.Collections.Generic.List<global::LlamaParse.AnyOf<string, int?, bool?, double?>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.AnyOf<string, int?, bool?, double?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ItemsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ItemsItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ImageMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.SyncProductEntryRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.IndexResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ProcessingResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.JobDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.AnyOf<global::LlamaParse.TextItem, global::LlamaParse.ListItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.LlamaParseOutputOptionsImagesToSaveItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.LlamaParseParametersImagesToSaveVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.AutoModeConfigurationEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.IngestionErrorResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.AnyOf<global::LlamaParse.MarkdownResultPage, global::LlamaParse.FailedMarkdownPage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<int?, double?, string, global::System.Collections.Generic.List<string>, global::System.Collections.Generic.List<double>, global::System.Collections.Generic.List<int>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.AnyOf<global::LlamaParse.MetadataFilter, global::LlamaParse.MetadataFilters>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.MetadataResultPage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ExtractRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.CloudDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.PipelineFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.AgentData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.AggregateGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ClassifyJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.SpreadsheetJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ParseJobResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ParseVersionsResponseFastItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ParseVersionsResponseCostEffectiveItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ParseVersionsResponseAgenticItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ParseVersionsResponseAgenticPlu>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.PipelineFileResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ChatMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ProjectResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.RetrievalResultResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.FilterTypeUnionStrIntBoolFloat, global::System.Collections.Generic.List<global::LlamaParse.FilterTypeUnionIntFloat>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.FilterTypeUnionIntFloat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.TextNodeWithScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.EventsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.SessionSummaryAPIResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.SplitCategory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.SplitJobResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.SplitSegmentResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ExtractedRegionSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.WorksheetMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.AttachmentRef>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.AnyOf<global::LlamaParse.StructuredResultPage, global::LlamaParse.FailedStructuredPage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ItemsItem4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::LlamaParse.AnyOf<string, int?, double?, object>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.AnyOf<string, int?, double?, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ParseConcernItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.RelatedNodeInfo, global::System.Collections.Generic.List<global::LlamaParse.RelatedNodeInfo>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.RelatedNodeInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.TextResultPage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.UsageMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.PipelineDataSourceCreate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.PipelineFileCreate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.CloudDocumentCreate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.DataSink>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.DataSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.EmbeddingModelConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.Organization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.Project>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.PageScreenshotMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.PageFigureMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.Pipeline>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.PipelineDataSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.TextNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.Retriever>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.LlamaParseSupportedFileExtensions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ExtractJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ExtractAgent>))]
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = global::System.Text.Json.Serialization.Metadata.JsonTypeInfoResolver.Combine(
            SourceGenerationContextChunk0.Default,

            SourceGenerationContextChunk1.Default
            );

        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        /// 
        /// </summary>
        public static SourceGenerationContext Default { get; } = new(DefaultOptions);

        private SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            options.Converters.Add(new global::LlamaParse.JsonConverters.AutoModeParsingConfTier2JsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AutoModeParsingConfTier2NullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AutoModeParsingConfVersionJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AutoModeParsingConfVersionNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AutoModeParsingConfSpecializedChartParsing2JsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AutoModeParsingConfSpecializedChartParsing2NullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.BatchFileStatusJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.BatchFileStatusNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.BatchJobStatusJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.BatchJobStatusNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.BatchJobTypeJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.BatchJobTypeNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.BatchParseJobConfigPriority2JsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.BatchParseJobConfigPriority2NullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.BatchParseJobConfigImagesToSaveVariant1ItemJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.BatchParseJobConfigImagesToSaveVariant1ItemNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.BoxAuthMechanismJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.BoxAuthMechanismNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ClassifyModeJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ClassifyModeNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ClassifyV2JobResponseStatusJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ClassifyV2JobResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ClassifyV2JobResponseDocumentInputTypeJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ClassifyV2JobResponseDocumentInputTypeNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.CloudJiraDataSourceV2ApiVersionJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.CloudJiraDataSourceV2ApiVersionNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.CompositeRetrievalModeJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.CompositeRetrievalModeNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ConfigurableDataSinkNamesJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ConfigurableDataSinkNamesNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ConfigurableDataSourceNamesJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ConfigurableDataSourceNamesNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ConfigurationCreateRequestParametersDiscriminatorProductTypeJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ConfigurationCreateRequestParametersDiscriminatorProductTypeNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ConfigurationResponseProductTypeJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ConfigurationResponseProductTypeNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ConfigurationResponseParametersDiscriminatorProductTypeJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ConfigurationResponseParametersDiscriminatorProductTypeNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ConfigurationUpdateRequestParametersVariant1DiscriminatorProductTypeJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ConfigurationUpdateRequestParametersVariant1DiscriminatorProductTypeNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.DataSourceReaderVersionMetadataReaderVersion2JsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.DataSourceReaderVersionMetadataReaderVersion2NullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.DocumentChunkModeJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.DocumentChunkModeNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.EmbeddingModelConfigEmbeddingConfigDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.EmbeddingModelConfigEmbeddingConfigDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ExtractConfigPriority2JsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ExtractConfigPriority2NullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ExtractConfigurationTierJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ExtractConfigurationTierNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ExtractConfigurationExtractionTargetJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ExtractConfigurationExtractionTargetNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ExtractJobStatusJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ExtractJobStatusNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ExtractJobCreatePriority2JsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ExtractJobCreatePriority2NullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ExtractModeJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ExtractModeNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ExtractModelsJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ExtractModelsNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ExtractStateJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ExtractStateNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ExtractTargetJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ExtractTargetNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ExtractV2ParametersTierJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ExtractV2ParametersTierNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ExtractV2ParametersExtractionTargetJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ExtractV2ParametersExtractionTargetNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.FailPageModeJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.FailPageModeNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.FilterConditionJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.FilterConditionNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.FilterOperatorJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.FilterOperatorNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.FilterTypeUnionIntFloatOperatorJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.FilterTypeUnionIntFloatOperatorNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.FilterTypeUnionStrIntBoolFloatOperatorJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.FilterTypeUnionStrIntBoolFloatOperatorNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.FilterTypeStrOperatorJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.FilterTypeStrOperatorNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.FooterItemItemDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.FooterItemItemDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.HeaderItemItemDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.HeaderItemItemDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ImageMetadataCategory2JsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ImageMetadataCategory2NullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.JobNameMappingJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.JobNameMappingNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.LlamaParseOutputOptionsImagesToSaveItemJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.LlamaParseOutputOptionsImagesToSaveItemNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.LlamaParseParametersPriority2JsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.LlamaParseParametersPriority2NullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.LlamaParseParametersImagesToSaveVariant1ItemJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.LlamaParseParametersImagesToSaveVariant1ItemNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.LlamaParseProcessingOptionsSpecializedChartParsing2JsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.LlamaParseProcessingOptionsSpecializedChartParsing2NullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.LlamaParseSupportedFileExtensionsJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.LlamaParseSupportedFileExtensionsNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ManagedIngestionStatusJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ManagedIngestionStatusNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.MessageRoleJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.MessageRoleNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.NodeRelationshipJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.NodeRelationshipNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ObjectTypeJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ObjectTypeNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.PGVectorDistanceMethodJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.PGVectorDistanceMethodNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.PGVectorVectorTypeJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.PGVectorVectorTypeNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ParseJobResponseStatusJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ParseJobResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ParsePlanLevelJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ParsePlanLevelNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ParseRequestConfigurationTierJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ParseRequestConfigurationTierNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ParseRequestConfigurationVersionJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ParseRequestConfigurationVersionNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ParseV2ParametersTierJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ParseV2ParametersTierNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ParseV2ParametersVersionJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ParseV2ParametersVersionNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ParseVersionsResponseFastItemJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ParseVersionsResponseFastItemNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ParseVersionsResponseCostEffectiveItemJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ParseVersionsResponseCostEffectiveItemNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ParseVersionsResponseAgenticItemJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ParseVersionsResponseAgenticItemNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ParseVersionsResponseAgenticPluJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ParseVersionsResponseAgenticPluNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ParserLanguagesJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ParserLanguagesNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ParsingModeJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ParsingModeNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.PartitionNamesJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.PartitionNamesNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.PipelineEmbeddingConfigDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.PipelineEmbeddingConfigDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.PipelineStatus2JsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.PipelineStatus2NullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.PipelineCreateEmbeddingConfigVariant1DiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.PipelineCreateEmbeddingConfigVariant1DiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.PipelineDataSourceStatus2JsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.PipelineDataSourceStatus2NullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.PipelineFileStatus2JsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.PipelineFileStatus2NullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.PipelineFileResponseStatus2JsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.PipelineFileResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.PipelineTypeJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.PipelineTypeNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.PipelineUpdateEmbeddingConfigVariant1DiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.PipelineUpdateEmbeddingConfigVariant1DiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.PoolingJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.PoolingNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.PublicModelNameJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.PublicModelNameNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ReRankerTypeJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ReRankerTypeNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.RetrievalModeJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.RetrievalModeNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.SessionGetAPIResponseEventDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.SessionGetAPIResponseEventDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.SparseModelTypeJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.SparseModelTypeNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.SplitStrategyAllowUncategorizedJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.SplitStrategyAllowUncategorizedNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.SpreadsheetParsingConfigTableMergeSensitivityJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.SpreadsheetParsingConfigTableMergeSensitivityNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.SpreadsheetResultTypeJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.SpreadsheetResultTypeNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.SpreadsheetV1ParametersTableMergeSensitivityJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.SpreadsheetV1ParametersTableMergeSensitivityNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.StatusEnumJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.StatusEnumNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.StructuredResultPageItemDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.StructuredResultPageItemDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.SupportedLLMModelNamesJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.SupportedLLMModelNamesNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.SyncProductEntryRequestProductTypeJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.SyncProductEntryRequestProductTypeNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.UsageMetricEventTypeJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.UsageMetricEventTypeNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.VertexEmbeddingModeJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.VertexEmbeddingModeNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.WebhookConfigurationWebhookEventsVariant1ItemJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.WebhookConfigurationWebhookEventsVariant1ItemNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ListProjectJobDataPointsApiV1JobDataPointsGetJobTypeJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ListProjectJobDataPointsApiV1JobDataPointsGetJobTypeNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1ItemJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1ItemNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetStatusRefreshPolicyJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetStatusRefreshPolicyNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.PaginatedListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsPaginatedGetStatusRefreshPolicyJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.PaginatedListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsPaginatedGetStatusRefreshPolicyNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ListDirectoriesApiV1BetaDirectoriesGetType2JsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ListDirectoriesApiV1BetaDirectoriesGetType2NullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1ItemJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1ItemNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ListSplitJobsApiV1BetaSplitJobsGetStatus2JsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ListSplitJobsApiV1BetaSplitJobsGetStatus2NullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1ItemJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1ItemNullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ListParseJobsApiV2ParseGetStatus2JsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ListParseJobsApiV2ParseGetStatus2NullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ListClassifyJobsApiV2ClassifyGetStatus2JsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ListClassifyJobsApiV2ClassifyGetStatus2NullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ListExtractJobsApiV2ExtractGetStatus2JsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ListExtractJobsApiV2ExtractGetStatus2NullableJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ParametersJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.Parameters2JsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ParametersVariant1JsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.EmbeddingConfigJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.EmbeddingConfig2JsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.EmbeddingConfigVariant1JsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ItemsItemJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ItemsItem2JsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.EmbeddingConfig3JsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.EmbeddingConfigVariant12JsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.EmbeddingConfigVariant13JsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.EventsItemJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ItemsItem4JsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.NoneSegmentationConfig, global::LlamaParse.PageSegmentationConfig, global::LlamaParse.ElementSegmentationConfig>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.NoneChunkingConfig, global::LlamaParse.CharacterChunkingConfig, global::LlamaParse.TokenChunkingConfig, global::LlamaParse.SentenceChunkingConfig, global::LlamaParse.SemanticChunkingConfig>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.AutoModeParsingConfVersion?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.BatchParseJobRecordCreate, global::LlamaParse.ClassifyJob>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::LlamaParse.CloudPineconeVectorStore, global::LlamaParse.CloudPostgresVectorStore, global::LlamaParse.CloudQdrantVectorStore, global::LlamaParse.CloudAzureAISearchVectorStore, global::LlamaParse.CloudMongoDBAtlasVectorSearch, global::LlamaParse.CloudMilvusVectorStore, global::LlamaParse.CloudAstraDBVectorStore>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::LlamaParse.CloudPineconeVectorStore, global::LlamaParse.CloudPostgresVectorStore, global::LlamaParse.CloudQdrantVectorStore, global::LlamaParse.CloudAzureAISearchVectorStore, global::LlamaParse.CloudMongoDBAtlasVectorSearch, global::LlamaParse.CloudMilvusVectorStore, global::LlamaParse.CloudAstraDBVectorStore>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::LlamaParse.CloudPineconeVectorStore, global::LlamaParse.CloudPostgresVectorStore, global::LlamaParse.CloudQdrantVectorStore, global::LlamaParse.CloudAzureAISearchVectorStore, global::LlamaParse.CloudMongoDBAtlasVectorSearch, global::LlamaParse.CloudMilvusVectorStore, global::LlamaParse.CloudAstraDBVectorStore, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::LlamaParse.CloudS3DataSource, global::LlamaParse.CloudAzStorageBlobDataSource, global::LlamaParse.CloudGoogleDriveDataSource, global::LlamaParse.CloudOneDriveDataSource, global::LlamaParse.CloudSharepointDataSource, global::LlamaParse.CloudSlackDataSource, global::LlamaParse.CloudNotionPageDataSource, global::LlamaParse.CloudConfluenceDataSource, global::LlamaParse.CloudJiraDataSource, global::LlamaParse.CloudJiraDataSourceV2, global::LlamaParse.CloudBoxDataSource>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::LlamaParse.CloudS3DataSource, global::LlamaParse.CloudAzStorageBlobDataSource, global::LlamaParse.CloudGoogleDriveDataSource, global::LlamaParse.CloudOneDriveDataSource, global::LlamaParse.CloudSharepointDataSource, global::LlamaParse.CloudSlackDataSource, global::LlamaParse.CloudNotionPageDataSource, global::LlamaParse.CloudConfluenceDataSource, global::LlamaParse.CloudJiraDataSource, global::LlamaParse.CloudJiraDataSourceV2, global::LlamaParse.CloudBoxDataSource>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::LlamaParse.CloudS3DataSource, global::LlamaParse.CloudAzStorageBlobDataSource, global::LlamaParse.CloudGoogleDriveDataSource, global::LlamaParse.CloudOneDriveDataSource, global::LlamaParse.CloudSharepointDataSource, global::LlamaParse.CloudSlackDataSource, global::LlamaParse.CloudNotionPageDataSource, global::LlamaParse.CloudConfluenceDataSource, global::LlamaParse.CloudJiraDataSource, global::LlamaParse.CloudJiraDataSourceV2, global::LlamaParse.CloudBoxDataSource, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, string>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, string>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.ExtractModels?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, string>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, string>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, double?, global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<int?, double?>>>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, double?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, int?, bool?, double?, global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?, bool?, double?>>>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, int?, bool?, double?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.TextItem, global::LlamaParse.ListItem>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.MarkdownResultPage, global::LlamaParse.FailedMarkdownPage>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, double?, string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<int>, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.MetadataFilter, global::LlamaParse.MetadataFilters>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.ParseRequestConfigurationVersion?, string>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.ParseV2ParametersVersion?, string>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.AutoTransformConfig, global::LlamaParse.AdvancedModeTransformConfig>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.AutoTransformConfig, global::LlamaParse.AdvancedModeTransformConfig, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::LlamaParse.CloudS3DataSource, global::LlamaParse.CloudAzStorageBlobDataSource, global::LlamaParse.CloudGoogleDriveDataSource, global::LlamaParse.CloudOneDriveDataSource, global::LlamaParse.CloudSharepointDataSource, global::LlamaParse.CloudSlackDataSource, global::LlamaParse.CloudNotionPageDataSource, global::LlamaParse.CloudConfluenceDataSource, global::LlamaParse.CloudJiraDataSource, global::LlamaParse.CloudJiraDataSourceV2, global::LlamaParse.CloudBoxDataSource>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.AutoTransformConfig, global::LlamaParse.AdvancedModeTransformConfig, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.BatchParseJobRecordCreate, global::LlamaParse.ClassifyJob>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.ObjectType?, string, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.FilterTypeUnionStrIntBoolFloat, global::System.Collections.Generic.IList<global::LlamaParse.FilterTypeUnionIntFloat>, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.StructuredResultPage, global::LlamaParse.FailedStructuredPage>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, int?, double?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.RelatedNodeInfo, global::System.Collections.Generic.IList<global::LlamaParse.RelatedNodeInfo>>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, int?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.UnixTimestampJsonConverter());

            return options;
        }
    }
}