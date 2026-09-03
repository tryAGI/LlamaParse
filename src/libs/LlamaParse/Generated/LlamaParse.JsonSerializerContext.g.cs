
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
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::LlamaParse.CloudPineconeVectorStore, global::LlamaParse.CloudPostgresVectorStore, global::LlamaParse.CloudQdrantVectorStore, global::LlamaParse.CloudAzureAISearchVectorStore, global::LlamaParse.CloudMongoDBAtlasVectorSearch, global::LlamaParse.CloudMilvusVectorStore, global::LlamaParse.CloudAstraDBVectorStore>), TypeInfoPropertyName = "CloudAstraDBVectorStore_7213cc45d352cf78")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::LlamaParse.CloudPineconeVectorStore, global::LlamaParse.CloudPostgresVectorStore, global::LlamaParse.CloudQdrantVectorStore, global::LlamaParse.CloudAzureAISearchVectorStore, global::LlamaParse.CloudMongoDBAtlasVectorSearch, global::LlamaParse.CloudMilvusVectorStore, global::LlamaParse.CloudAstraDBVectorStore, object>), TypeInfoPropertyName = "CloudAstraDBVectorStore_object_3f7470369807d660")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::LlamaParse.CloudS3DataSource, global::LlamaParse.CloudAzStorageBlobDataSource, global::LlamaParse.CloudGoogleDriveDataSource, global::LlamaParse.CloudOneDriveDataSource, global::LlamaParse.CloudSharepointDataSource, global::LlamaParse.CloudSlackDataSource, global::LlamaParse.CloudNotionPageDataSource, global::LlamaParse.CloudConfluenceDataSource, global::LlamaParse.CloudJiraDataSource, global::LlamaParse.CloudJiraDataSourceV2, global::LlamaParse.CloudBoxDataSource>), TypeInfoPropertyName = "CloudBoxDataSource_44c4d8909c0abf11")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::LlamaParse.CloudS3DataSource, global::LlamaParse.CloudAzStorageBlobDataSource, global::LlamaParse.CloudGoogleDriveDataSource, global::LlamaParse.CloudOneDriveDataSource, global::LlamaParse.CloudSharepointDataSource, global::LlamaParse.CloudSlackDataSource, global::LlamaParse.CloudNotionPageDataSource, global::LlamaParse.CloudConfluenceDataSource, global::LlamaParse.CloudJiraDataSource, global::LlamaParse.CloudJiraDataSourceV2, global::LlamaParse.CloudBoxDataSource, object>), TypeInfoPropertyName = "CloudBoxDataSource_object_8c6b9addb1a78f63")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::LlamaParse.CloudPineconeVectorStore, global::LlamaParse.CloudPostgresVectorStore, global::LlamaParse.CloudQdrantVectorStore, global::LlamaParse.CloudAzureAISearchVectorStore, global::LlamaParse.CloudMongoDBAtlasVectorSearch, global::LlamaParse.CloudMilvusVectorStore, global::LlamaParse.CloudAstraDBVectorStore>?), TypeInfoPropertyName = "CloudAstraDBVectorStore_2b857d4e76ac6e71")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::LlamaParse.CloudPineconeVectorStore, global::LlamaParse.CloudPostgresVectorStore, global::LlamaParse.CloudQdrantVectorStore, global::LlamaParse.CloudAzureAISearchVectorStore, global::LlamaParse.CloudMongoDBAtlasVectorSearch, global::LlamaParse.CloudMilvusVectorStore, global::LlamaParse.CloudAstraDBVectorStore, object>?), TypeInfoPropertyName = "CloudAstraDBVectorStore_object_d9f8945237261e89")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::LlamaParse.CloudS3DataSource, global::LlamaParse.CloudAzStorageBlobDataSource, global::LlamaParse.CloudGoogleDriveDataSource, global::LlamaParse.CloudOneDriveDataSource, global::LlamaParse.CloudSharepointDataSource, global::LlamaParse.CloudSlackDataSource, global::LlamaParse.CloudNotionPageDataSource, global::LlamaParse.CloudConfluenceDataSource, global::LlamaParse.CloudJiraDataSource, global::LlamaParse.CloudJiraDataSourceV2, global::LlamaParse.CloudBoxDataSource>?), TypeInfoPropertyName = "CloudBoxDataSource_ee99e0e6ec633008")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::LlamaParse.CloudS3DataSource, global::LlamaParse.CloudAzStorageBlobDataSource, global::LlamaParse.CloudGoogleDriveDataSource, global::LlamaParse.CloudOneDriveDataSource, global::LlamaParse.CloudSharepointDataSource, global::LlamaParse.CloudSlackDataSource, global::LlamaParse.CloudNotionPageDataSource, global::LlamaParse.CloudConfluenceDataSource, global::LlamaParse.CloudJiraDataSource, global::LlamaParse.CloudJiraDataSourceV2, global::LlamaParse.CloudBoxDataSource, object>?), TypeInfoPropertyName = "CloudBoxDataSource_object_dfe1806971be6576")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AgentDataAggregateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.AggregateGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AggregateGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AgentDataCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AgentDataSearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.AgentData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AgentDataUpdate))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AutoModeParsingConfTier2), TypeInfoPropertyName = "AutoModeParsingConfTier22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.AutoModeParsingConfVersion?, string, object>), TypeInfoPropertyName = "AnyOfAutoModeParsingConfVersionStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AutoModeParsingConfVersion), TypeInfoPropertyName = "AutoModeParsingConfVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AutoModeParsingConfSpecializedChartParsing2), TypeInfoPropertyName = "AutoModeParsingConfSpecializedChartParsing22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AutoModeSpatialTextOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AutoModePresentationOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AutoTransformConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AzureOpenAIEmbedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AzureOpenAIEmbeddingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BBox))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BatchConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BatchJobConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BatchCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.WebhookConfiguration))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BatchJobReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BatchJobType), TypeInfoPropertyName = "BatchJobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BatchJobStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BatchParseJobConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BatchParseJobConfigPriority2), TypeInfoPropertyName = "BatchParseJobConfigPriority22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ParserLanguages>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParserLanguages), TypeInfoPropertyName = "ParserLanguages2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.BatchParseJobConfigImagesToSaveVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BatchParseJobConfigImagesToSaveVariant1Item), TypeInfoPropertyName = "BatchParseJobConfigImagesToSaveVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParsingMode), TypeInfoPropertyName = "ParsingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FailPageMode), TypeInfoPropertyName = "FailPageMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::System.Guid?, string>), TypeInfoPropertyName = "AnyOfGuidString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BatchQueryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.BatchResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BatchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<string, global::System.Guid?>), TypeInfoPropertyName = "AnyOfStringGuid2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BatchResponseStatus), TypeInfoPropertyName = "BatchResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.BatchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BatchResult))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ChatSessionSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.JobMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ClassifierRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.StatusEnum), TypeInfoPropertyName = "StatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ClassifierRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ClassifyMode), TypeInfoPropertyName = "ClassifyMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ClassifyParsingConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ClassifyV2Configuration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ClassifyV2Rule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ClassifyV2Rule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ClassifyV2ParsingConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ClassifyV2JobCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ClassifyV2JobQueryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ClassifyV2JobResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ClassifyV2JobResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DataSourceReaderVersionMetadataReaderVersion2), TypeInfoPropertyName = "DataSourceReaderVersionMetadataReaderVersion22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DataSourceSyncRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DataSourceUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DeleteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DirectRetrievalParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.RetrieverPipeline>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.RetrieverPipeline))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DirectoryCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DirectoryCreateRequestType), TypeInfoPropertyName = "DirectoryCreateRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DirectoryFileBulkDeleteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DirectoryFileCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.MetadataDict))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DirectoryFileQueryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.DirectoryFileResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DirectoryFileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PresignedUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DirectoryFileUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DirectoryQueryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.DirectoryResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DirectoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DirectoryResponseType2), TypeInfoPropertyName = "DirectoryResponseType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DirectoryUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DocumentChunkMode), TypeInfoPropertyName = "DocumentChunkMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DocumentCountByStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractConfigPriority2), TypeInfoPropertyName = "ExtractConfigPriority22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractTarget), TypeInfoPropertyName = "ExtractTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractMode), TypeInfoPropertyName = "ExtractMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PublicModelName), TypeInfoPropertyName = "PublicModelName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.ExtractModels?, string, object>), TypeInfoPropertyName = "AnyOfExtractModelsStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractModels), TypeInfoPropertyName = "ExtractModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractConfigurationTier), TypeInfoPropertyName = "ExtractConfigurationTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractConfigurationExtractionTarget), TypeInfoPropertyName = "ExtractConfigurationExtractionTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractConfigurationParseTier2), TypeInfoPropertyName = "ExtractConfigurationParseTier22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractJobStatus), TypeInfoPropertyName = "ExtractJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.File))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractJobCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractJobCreatePriority2), TypeInfoPropertyName = "ExtractJobCreatePriority22")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractV2Job))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractV2JobMetadata2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractV2JobCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractV2JobQueryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ExtractV2Job>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractV2ParametersTier), TypeInfoPropertyName = "ExtractV2ParametersTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractV2ParametersExtractionTarget), TypeInfoPropertyName = "ExtractV2ParametersExtractionTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractV2ParametersParseTier2), TypeInfoPropertyName = "ExtractV2ParametersParseTier22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractV2SchemaGenerateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractV2SchemaValidateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractV2SchemaValidateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FailedFormsPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FailedMarkdownPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FailedStructuredPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FileAttachmentListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.FileAttachmentMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FileAttachmentMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FileCountByStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FileFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FileFindEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FileFindParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FileFindResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.FileFindEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FileGrepMatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FileGrepParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FileGrepResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.FileGrepMatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FileQueryRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FileQueryResponseV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.FileV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FileV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FileReadParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FileReadResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FilterCondition), TypeInfoPropertyName = "FilterCondition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<double?, int?, string, global::System.DateTime?, object>), TypeInfoPropertyName = "AnyOfDoubleInt32StringDateTimeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<double?, int?, string, global::System.DateTime?, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FilterOperator), TypeInfoPropertyName = "FilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FooterItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ItemsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ItemsItem), TypeInfoPropertyName = "ItemsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.TextItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.HeadingItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.TableItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ImageItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LinkItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FooterItemItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FooterItemItemDiscriminatorType), TypeInfoPropertyName = "FooterItemItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.Form))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.JsonItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.JsonItem), TypeInfoPropertyName = "JsonItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FormSection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FormField))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FormTable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FormJsonItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FormJsonItemDiscriminatorType), TypeInfoPropertyName = "FormJsonItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FormListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FormFieldField), TypeInfoPropertyName = "FormFieldField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<string, bool?, object>), TypeInfoPropertyName = "AnyOfStringBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ValueItemsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ValueItemsVariant1Item), TypeInfoPropertyName = "ValueItemsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FormFieldValueItemsVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FormFieldValueItemsVariant1ItemDiscriminatorType), TypeInfoPropertyName = "FormFieldValueItemsVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.FormListTextItem, global::LlamaParse.FormListItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.FormListTextItem, global::LlamaParse.FormListItem>), TypeInfoPropertyName = "AnyOfFormListTextItemFormListItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FormListTextItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ItemsItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ItemsItem3), TypeInfoPropertyName = "ItemsItem32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FormSectionItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FormSectionItemDiscriminatorType), TypeInfoPropertyName = "FormSectionItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, global::LlamaParse.FormTableCellItems, object>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, global::LlamaParse.FormTableCellItems, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<string, global::LlamaParse.FormTableCellItems, object>), TypeInfoPropertyName = "AnyOfStringFormTableCellItemsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FormTableCellItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ItemsItem4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ItemsItem4), TypeInfoPropertyName = "ItemsItem42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FormTableCellItemsItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FormTableCellItemsItemDiscriminatorType), TypeInfoPropertyName = "FormTableCellItemsItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FormsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.FormsResultPage, global::LlamaParse.FailedFormsPage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.FormsResultPage, global::LlamaParse.FailedFormsPage>), TypeInfoPropertyName = "AnyOfFormsResultPageFailedFormsPage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FormsResultPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.Form>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.GeminiEmbedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.HeaderItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ItemsItem5>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ItemsItem5), TypeInfoPropertyName = "ItemsItem52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.HeaderItemItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.HeaderItemItemDiscriminatorType), TypeInfoPropertyName = "HeaderItemItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.HuggingFaceInferenceAPIEmbedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.Pooling), TypeInfoPropertyName = "Pooling2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ImageAttachmentRef))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ImageMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ImageMetadataCategory2), TypeInfoPropertyName = "ImageMetadataCategory22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ImageMetadataBBox2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ImagesContentMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ImageMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.IndexCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.IndexProductEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.IndexProductEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.IndexCreateRequestVectorTarget), TypeInfoPropertyName = "IndexCreateRequestVectorTarget2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.JobUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SupportedLLMModelNames), TypeInfoPropertyName = "SupportedLLMModelNames2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.TextItem, global::LlamaParse.ListItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.TextItem, global::LlamaParse.ListItem>), TypeInfoPropertyName = "AnyOfTextItemListItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseAgenticOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseCostOptimizerParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseCropBox))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseFastOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseHtmlOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseIgnoreOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseImageOptions))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.LlamaParseOutputOptionsImagesToSaveVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseOutputOptionsImagesToSaveVariant1Item), TypeInfoPropertyName = "LlamaParseOutputOptionsImagesToSaveVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.LlamaParseOutputOptionsGranularBboxe>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseOutputOptionsGranularBboxe), TypeInfoPropertyName = "LlamaParseOutputOptionsGranularBboxe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParsePageRanges))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseParametersPriority2), TypeInfoPropertyName = "LlamaParseParametersPriority22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.LlamaParseParametersImagesToSaveVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseParametersImagesToSaveVariant1Item), TypeInfoPropertyName = "LlamaParseParametersImagesToSaveVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseProcessingControl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseTimeouts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseProcessingOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseProcessingOptionsSpecializedChartParsing2), TypeInfoPropertyName = "LlamaParseProcessingOptionsSpecializedChartParsing22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.AutoModeConfigurationEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseProcessingOptionsForms2), TypeInfoPropertyName = "LlamaParseProcessingOptionsForms22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseSupportedFileExtensions), TypeInfoPropertyName = "LlamaParseSupportedFileExtensions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseWebhookConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseWebhookConfigurationWebhookOutputFormat2), TypeInfoPropertyName = "LlamaParseWebhookConfigurationWebhookOutputFormat22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ManagedIngestionStatus), TypeInfoPropertyName = "ManagedIngestionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ManagedIngestionStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.IngestionErrorResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ManagedOpenAIEmbedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ManagedOpenAIEmbeddingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.MarkdownLineNumberAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.MarkdownResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.MarkdownResultPage, global::LlamaParse.FailedMarkdownPage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.MarkdownResultPage, global::LlamaParse.FailedMarkdownPage>), TypeInfoPropertyName = "AnyOfMarkdownResultPageFailedMarkdownPage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.MarkdownResultPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.MarkdownLineNumberAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.MetadataValue), TypeInfoPropertyName = "MetadataValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.MetadataFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<int?, double?, string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<int>, object>), TypeInfoPropertyName = "AnyOfInt32DoubleStringIListStringIListDoubleIListInt32Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.MetadataFilters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.MetadataFilter, global::LlamaParse.MetadataFilters>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.MetadataFilter, global::LlamaParse.MetadataFilters>), TypeInfoPropertyName = "AnyOfMetadataFilterMetadataFilters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.MetadataResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.MetadataResultPage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.MetadataResultPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.MetadataResultDocument2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.MetadataResultDocumentConfidenceBreakdown2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.MetadataScalarValue), TypeInfoPropertyName = "MetadataScalarValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.MongoStaticFilters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.StringFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.NodeRelationship), TypeInfoPropertyName = "NodeRelationship2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.NumericRangeFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.NumericRangeFilterOperator), TypeInfoPropertyName = "NumericRangeFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<int?, double?, global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<int?, double?>>>), TypeInfoPropertyName = "AnyOfInt32DoubleIListAnyOfInt32Double2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<int?, double?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<int?, double?>), TypeInfoPropertyName = "AnyOfInt32Double2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ObjectType), TypeInfoPropertyName = "ObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.OpenAIEmbedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.Organization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParsePlanLevel), TypeInfoPropertyName = "ParsePlanLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.OrganizationQueryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.OrganizationResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.OrganizationResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParseConcernItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParseJobQueryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ParseJobResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParseJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParseJobResponseStatus), TypeInfoPropertyName = "ParseJobResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParseLatestVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParseRequestConfiguration))]
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
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::LlamaParse.CloudPineconeVectorStore, global::LlamaParse.CloudPostgresVectorStore, global::LlamaParse.CloudQdrantVectorStore, global::LlamaParse.CloudAzureAISearchVectorStore, global::LlamaParse.CloudMongoDBAtlasVectorSearch, global::LlamaParse.CloudMilvusVectorStore, global::LlamaParse.CloudAstraDBVectorStore>), TypeInfoPropertyName = "CloudAstraDBVectorStore_7213cc45d352cf78")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::LlamaParse.CloudPineconeVectorStore, global::LlamaParse.CloudPostgresVectorStore, global::LlamaParse.CloudQdrantVectorStore, global::LlamaParse.CloudAzureAISearchVectorStore, global::LlamaParse.CloudMongoDBAtlasVectorSearch, global::LlamaParse.CloudMilvusVectorStore, global::LlamaParse.CloudAstraDBVectorStore, object>), TypeInfoPropertyName = "CloudAstraDBVectorStore_object_3f7470369807d660")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::LlamaParse.CloudS3DataSource, global::LlamaParse.CloudAzStorageBlobDataSource, global::LlamaParse.CloudGoogleDriveDataSource, global::LlamaParse.CloudOneDriveDataSource, global::LlamaParse.CloudSharepointDataSource, global::LlamaParse.CloudSlackDataSource, global::LlamaParse.CloudNotionPageDataSource, global::LlamaParse.CloudConfluenceDataSource, global::LlamaParse.CloudJiraDataSource, global::LlamaParse.CloudJiraDataSourceV2, global::LlamaParse.CloudBoxDataSource>), TypeInfoPropertyName = "CloudBoxDataSource_44c4d8909c0abf11")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::LlamaParse.CloudS3DataSource, global::LlamaParse.CloudAzStorageBlobDataSource, global::LlamaParse.CloudGoogleDriveDataSource, global::LlamaParse.CloudOneDriveDataSource, global::LlamaParse.CloudSharepointDataSource, global::LlamaParse.CloudSlackDataSource, global::LlamaParse.CloudNotionPageDataSource, global::LlamaParse.CloudConfluenceDataSource, global::LlamaParse.CloudJiraDataSource, global::LlamaParse.CloudJiraDataSourceV2, global::LlamaParse.CloudBoxDataSource, object>), TypeInfoPropertyName = "CloudBoxDataSource_object_8c6b9addb1a78f63")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::LlamaParse.CloudPineconeVectorStore, global::LlamaParse.CloudPostgresVectorStore, global::LlamaParse.CloudQdrantVectorStore, global::LlamaParse.CloudAzureAISearchVectorStore, global::LlamaParse.CloudMongoDBAtlasVectorSearch, global::LlamaParse.CloudMilvusVectorStore, global::LlamaParse.CloudAstraDBVectorStore>?), TypeInfoPropertyName = "CloudAstraDBVectorStore_2b857d4e76ac6e71")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::LlamaParse.CloudPineconeVectorStore, global::LlamaParse.CloudPostgresVectorStore, global::LlamaParse.CloudQdrantVectorStore, global::LlamaParse.CloudAzureAISearchVectorStore, global::LlamaParse.CloudMongoDBAtlasVectorSearch, global::LlamaParse.CloudMilvusVectorStore, global::LlamaParse.CloudAstraDBVectorStore, object>?), TypeInfoPropertyName = "CloudAstraDBVectorStore_object_d9f8945237261e89")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::LlamaParse.CloudS3DataSource, global::LlamaParse.CloudAzStorageBlobDataSource, global::LlamaParse.CloudGoogleDriveDataSource, global::LlamaParse.CloudOneDriveDataSource, global::LlamaParse.CloudSharepointDataSource, global::LlamaParse.CloudSlackDataSource, global::LlamaParse.CloudNotionPageDataSource, global::LlamaParse.CloudConfluenceDataSource, global::LlamaParse.CloudJiraDataSource, global::LlamaParse.CloudJiraDataSourceV2, global::LlamaParse.CloudBoxDataSource>?), TypeInfoPropertyName = "CloudBoxDataSource_ee99e0e6ec633008")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::LlamaParse.CloudS3DataSource, global::LlamaParse.CloudAzStorageBlobDataSource, global::LlamaParse.CloudGoogleDriveDataSource, global::LlamaParse.CloudOneDriveDataSource, global::LlamaParse.CloudSharepointDataSource, global::LlamaParse.CloudSlackDataSource, global::LlamaParse.CloudNotionPageDataSource, global::LlamaParse.CloudConfluenceDataSource, global::LlamaParse.CloudJiraDataSource, global::LlamaParse.CloudJiraDataSourceV2, global::LlamaParse.CloudBoxDataSource, object>?), TypeInfoPropertyName = "CloudBoxDataSource_object_dfe1806971be6576")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.ParseRequestConfigurationTier?, string>), TypeInfoPropertyName = "AnyOfParseRequestConfigurationTierString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParseRequestConfigurationTier), TypeInfoPropertyName = "ParseRequestConfigurationTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.ParseRequestConfigurationVersion?, string>), TypeInfoPropertyName = "AnyOfParseRequestConfigurationVersionString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParseRequestConfigurationVersion), TypeInfoPropertyName = "ParseRequestConfigurationVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.LlamaParseWebhookConfiguration>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineStatus2), TypeInfoPropertyName = "PipelineStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineMetadataConfig2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EmbeddingConfigVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineCreateEmbeddingConfigVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineCreateEmbeddingConfigVariant1DiscriminatorType), TypeInfoPropertyName = "PipelineCreateEmbeddingConfigVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.AutoTransformConfig, global::LlamaParse.AdvancedModeTransformConfig, object>), TypeInfoPropertyName = "AnyOfAutoTransformConfigAdvancedModeTransformConfigObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineDataSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineDataSourceStatus2), TypeInfoPropertyName = "PipelineDataSourceStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineDataSourceCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineDataSourceUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineFileStatus2), TypeInfoPropertyName = "PipelineFileStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineFileCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineFileListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.PipelineFileResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineFileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineFileResponseStatus2), TypeInfoPropertyName = "PipelineFileResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineFileUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineQueryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.PipelineResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineResponsePipelineType), TypeInfoPropertyName = "PipelineResponsePipelineType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineResponseStatus2), TypeInfoPropertyName = "PipelineResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EmbeddingConfigVariant13))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.RerankConfig2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.RetrievalParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.RetrievalResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.StaticFields))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.RetrieveParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.ValueFilter, global::System.Collections.Generic.IList<global::LlamaParse.NumericRangeFilter>, object>), TypeInfoPropertyName = "AnyOfValueFilterIListNumericRangeFilterObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ValueFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.NumericRangeFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.RetrieveResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.RetrievalResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.RetrieveResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.TextNodeWithScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.TextNodeWithScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.Retriever))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.RetrieverCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.RetrieverUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.Revision))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.RevisionType), TypeInfoPropertyName = "RevisionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.RevisionBBox))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.RevisionTargetSpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.RevisionTargetSpan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SearchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SessionCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SessionDetail))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SessionDetailEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SessionDetailEventDiscriminatorType), TypeInfoPropertyName = "SessionDetailEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SessionList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ChatSessionSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SparseModelType), TypeInfoPropertyName = "SparseModelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SplitCategory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SplitConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.SplitCategory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SplitStrategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SplitCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SplitCreateRequestBeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SplitDocumentInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SplitJobQueryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.SplitJobResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SplitJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SplitJobQueryResponseBeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.SplitJobResponseBeta>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SplitJobResponseBeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SplitJobResponseDocumentInputType), TypeInfoPropertyName = "SplitJobResponseDocumentInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SplitResultResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.SplitSegmentResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SplitSegmentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SplitStrategyAllowUncategorized), TypeInfoPropertyName = "SplitStrategyAllowUncategorized2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SpreadsheetV1ParametersTier), TypeInfoPropertyName = "SpreadsheetV1ParametersTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SpreadsheetV1ParametersTableMergeSensitivity), TypeInfoPropertyName = "SpreadsheetV1ParametersTableMergeSensitivity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.AttachmentRef>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.Usage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.StringFilterOperator), TypeInfoPropertyName = "StringFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.StructuredResultPage, global::LlamaParse.FailedStructuredPage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.StructuredResultPage, global::LlamaParse.FailedStructuredPage>), TypeInfoPropertyName = "AnyOfStructuredResultPageFailedStructuredPage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.StructuredResultPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ItemsItem7>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ItemsItem7), TypeInfoPropertyName = "ItemsItem72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.StructuredResultPageItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.StructuredResultPageItemDiscriminatorType), TypeInfoPropertyName = "StructuredResultPageItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.Revision>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.UsageMetricAggregateBucket))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.UsageMetricAggregateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.UsageMetricAggregateResponseGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.UsageMetricAggregateResponseGroupByItem), TypeInfoPropertyName = "UsageMetricAggregateResponseGroupByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.UsageMetricAggregateBucket>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.UsageMetricQueryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.UsageMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ValueFilterOperator), TypeInfoPropertyName = "ValueFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<string, int?, bool?, double?, global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?, bool?, double?>>>), TypeInfoPropertyName = "AnyOfStringInt32BooleanDoubleIListAnyOfStringInt32BooleanDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?, bool?, double?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<string, int?, bool?, double?>), TypeInfoPropertyName = "AnyOfStringInt32BooleanDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.VertexTextEmbedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.VertexEmbeddingMode), TypeInfoPropertyName = "VertexEmbeddingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.WebhookConfigCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigCreateRequestWebhookEventsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.WebhookConfigCreateRequestWebhookEventsVariant1Item), TypeInfoPropertyName = "WebhookConfigCreateRequestWebhookEventsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.WebhookConfigCreateRequestWebhookOutputFormat2), TypeInfoPropertyName = "WebhookConfigCreateRequestWebhookOutputFormat22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.WebhookConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigResponseWebhookEventsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.WebhookConfigResponseWebhookEventsVariant1Item), TypeInfoPropertyName = "WebhookConfigResponseWebhookEventsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.WebhookConfigResponseWebhookOutputFormat2), TypeInfoPropertyName = "WebhookConfigResponseWebhookOutputFormat22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.WebhookConfigUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigUpdateRequestWebhookEventsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.WebhookConfigUpdateRequestWebhookEventsVariant1Item), TypeInfoPropertyName = "WebhookConfigUpdateRequestWebhookEventsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.WebhookConfigUpdateRequestWebhookOutputFormat2), TypeInfoPropertyName = "WebhookConfigUpdateRequestWebhookOutputFormat22")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListSplitJobsApiV1SplitJobsGetStatus2), TypeInfoPropertyName = "ListSplitJobsApiV1SplitJobsGetStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem), TypeInfoPropertyName = "AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetType2), TypeInfoPropertyName = "ListDirectoriesApiV1BetaDirectoriesGetType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1Item), TypeInfoPropertyName = "ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item), TypeInfoPropertyName = "ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListSplitJobsApiV1BetaSplitJobsGetStatus2), TypeInfoPropertyName = "ListSplitJobsApiV1BetaSplitJobsGetStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item), TypeInfoPropertyName = "ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListParseJobsApiV2ParseGetStatus2), TypeInfoPropertyName = "ListParseJobsApiV2ParseGetStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListClassifyJobsApiV2ClassifyGetStatus2), TypeInfoPropertyName = "ListClassifyJobsApiV2ClassifyGetStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListExtractJobsApiV2ExtractGetStatus2), TypeInfoPropertyName = "ListExtractJobsApiV2ExtractGetStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListPipelinesApiV2PipelinesGetPipelineType2), TypeInfoPropertyName = "ListPipelinesApiV2PipelinesGetPipelineType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListBatchesApiV2BatchesGetStatus2), TypeInfoPropertyName = "ListBatchesApiV2BatchesGetStatus22")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.NoneSegmentationConfig, global::LlamaParse.PageSegmentationConfig, global::LlamaParse.ElementSegmentationConfig>?), TypeInfoPropertyName = "NullableAnyOfNoneSegmentationConfigPageSegmentationConfigElementSegmentationConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.NoneChunkingConfig, global::LlamaParse.CharacterChunkingConfig, global::LlamaParse.TokenChunkingConfig, global::LlamaParse.SentenceChunkingConfig, global::LlamaParse.SemanticChunkingConfig>?), TypeInfoPropertyName = "NullableAnyOfNoneChunkingConfigCharacterChunkingConfigTokenChunkingConfigSentenceChunkingConfigSemanticChunkingConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<double?, string, object>?), TypeInfoPropertyName = "NullableAnyOfDoubleStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<int?, string, object>?), TypeInfoPropertyName = "NullableAnyOfInt32StringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AutoModeParsingConfTier2?), TypeInfoPropertyName = "NullableAutoModeParsingConfTier22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.AutoModeParsingConfVersion?, string, object>?), TypeInfoPropertyName = "NullableAnyOfAutoModeParsingConfVersionStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AutoModeParsingConfVersion?), TypeInfoPropertyName = "NullableAutoModeParsingConfVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AutoModeParsingConfSpecializedChartParsing2?), TypeInfoPropertyName = "NullableAutoModeParsingConfSpecializedChartParsing22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BatchFileStatus?), TypeInfoPropertyName = "NullableBatchFileStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BatchJobStatus?), TypeInfoPropertyName = "NullableBatchJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.BatchParseJobRecordCreate, global::LlamaParse.ClassifyJob>?), TypeInfoPropertyName = "NullableAnyOfBatchParseJobRecordCreateClassifyJob2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BatchJobType?), TypeInfoPropertyName = "NullableBatchJobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BatchParseJobConfigPriority2?), TypeInfoPropertyName = "NullableBatchParseJobConfigPriority22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParserLanguages?), TypeInfoPropertyName = "NullableParserLanguages2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BatchParseJobConfigImagesToSaveVariant1Item?), TypeInfoPropertyName = "NullableBatchParseJobConfigImagesToSaveVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParsingMode?), TypeInfoPropertyName = "NullableParsingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FailPageMode?), TypeInfoPropertyName = "NullableFailPageMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::System.Guid?, string>?), TypeInfoPropertyName = "NullableAnyOfGuidString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<string, global::System.Guid?>?), TypeInfoPropertyName = "NullableAnyOfStringGuid2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BatchResponseStatus?), TypeInfoPropertyName = "NullableBatchResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BoxAuthMechanism?), TypeInfoPropertyName = "NullableBoxAuthMechanism2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.MessageRole?), TypeInfoPropertyName = "NullableMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.StatusEnum?), TypeInfoPropertyName = "NullableStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ClassifyMode?), TypeInfoPropertyName = "NullableClassifyMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ClassifyV2JobResponseStatus?), TypeInfoPropertyName = "NullableClassifyV2JobResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ClassifyV2JobResponseDocumentInputType?), TypeInfoPropertyName = "NullableClassifyV2JobResponseDocumentInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.CloudJiraDataSourceV2ApiVersion?), TypeInfoPropertyName = "NullableCloudJiraDataSourceV2ApiVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.CompositeRetrievalMode?), TypeInfoPropertyName = "NullableCompositeRetrievalMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ConfigurableDataSinkNames?), TypeInfoPropertyName = "NullableConfigurableDataSinkNames2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ConfigurableDataSourceNames?), TypeInfoPropertyName = "NullableConfigurableDataSourceNames2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.Parameters?), TypeInfoPropertyName = "NullableParameters2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ConfigurationCreateRequestParametersDiscriminatorProductType?), TypeInfoPropertyName = "NullableConfigurationCreateRequestParametersDiscriminatorProductType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ConfigurationResponseProductType?), TypeInfoPropertyName = "NullableConfigurationResponseProductType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.Parameters2?), TypeInfoPropertyName = "NullableParameters22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ConfigurationResponseParametersDiscriminatorProductType?), TypeInfoPropertyName = "NullableConfigurationResponseParametersDiscriminatorProductType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ConfigurationUpdateRequestParametersVariant1DiscriminatorProductType?), TypeInfoPropertyName = "NullableConfigurationUpdateRequestParametersVariant1DiscriminatorProductType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>?), TypeInfoPropertyName = "NullableAnyOfObjectIListObjectStringInt32DoubleBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DataSourceReaderVersionMetadataReaderVersion2?), TypeInfoPropertyName = "NullableDataSourceReaderVersionMetadataReaderVersion22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DirectoryCreateRequestType?), TypeInfoPropertyName = "NullableDirectoryCreateRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DirectoryResponseType2?), TypeInfoPropertyName = "NullableDirectoryResponseType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DocumentChunkMode?), TypeInfoPropertyName = "NullableDocumentChunkMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EmbeddingConfig?), TypeInfoPropertyName = "NullableEmbeddingConfig2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EmbeddingModelConfigEmbeddingConfigDiscriminatorType?), TypeInfoPropertyName = "NullableEmbeddingModelConfigEmbeddingConfigDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EmbeddingConfig2?), TypeInfoPropertyName = "NullableEmbeddingConfig22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType?), TypeInfoPropertyName = "NullableEmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableEmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, string>?), TypeInfoPropertyName = "NullableAnyOfObjectString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractConfigPriority2?), TypeInfoPropertyName = "NullableExtractConfigPriority22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractTarget?), TypeInfoPropertyName = "NullableExtractTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractMode?), TypeInfoPropertyName = "NullableExtractMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PublicModelName?), TypeInfoPropertyName = "NullablePublicModelName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.ExtractModels?, string, object>?), TypeInfoPropertyName = "NullableAnyOfExtractModelsStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractModels?), TypeInfoPropertyName = "NullableExtractModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractConfigurationTier?), TypeInfoPropertyName = "NullableExtractConfigurationTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractConfigurationExtractionTarget?), TypeInfoPropertyName = "NullableExtractConfigurationExtractionTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractConfigurationParseTier2?), TypeInfoPropertyName = "NullableExtractConfigurationParseTier22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractJobStatus?), TypeInfoPropertyName = "NullableExtractJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractJobCreatePriority2?), TypeInfoPropertyName = "NullableExtractJobCreatePriority22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, string, object>?), TypeInfoPropertyName = "NullableAnyOfObjectStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::System.Collections.Generic.IList<object>, object>?), TypeInfoPropertyName = "NullableAnyOfObjectIListObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractState?), TypeInfoPropertyName = "NullableExtractState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractV2ParametersTier?), TypeInfoPropertyName = "NullableExtractV2ParametersTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractV2ParametersExtractionTarget?), TypeInfoPropertyName = "NullableExtractV2ParametersExtractionTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractV2ParametersParseTier2?), TypeInfoPropertyName = "NullableExtractV2ParametersParseTier22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FilterCondition?), TypeInfoPropertyName = "NullableFilterCondition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<double?, int?, string, global::System.DateTime?, object>?), TypeInfoPropertyName = "NullableAnyOfDoubleInt32StringDateTimeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FilterOperator?), TypeInfoPropertyName = "NullableFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ItemsItem?), TypeInfoPropertyName = "NullableItemsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FooterItemItemDiscriminatorType?), TypeInfoPropertyName = "NullableFooterItemItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.JsonItem?), TypeInfoPropertyName = "NullableJsonItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FormJsonItemDiscriminatorType?), TypeInfoPropertyName = "NullableFormJsonItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FormFieldField?), TypeInfoPropertyName = "NullableFormFieldField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<string, bool?, object>?), TypeInfoPropertyName = "NullableAnyOfStringBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ValueItemsVariant1Item?), TypeInfoPropertyName = "NullableValueItemsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FormFieldValueItemsVariant1ItemDiscriminatorType?), TypeInfoPropertyName = "NullableFormFieldValueItemsVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.FormListTextItem, global::LlamaParse.FormListItem>?), TypeInfoPropertyName = "NullableAnyOfFormListTextItemFormListItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ItemsItem3?), TypeInfoPropertyName = "NullableItemsItem32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FormSectionItemDiscriminatorType?), TypeInfoPropertyName = "NullableFormSectionItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<string, global::LlamaParse.FormTableCellItems, object>?), TypeInfoPropertyName = "NullableAnyOfStringFormTableCellItemsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ItemsItem4?), TypeInfoPropertyName = "NullableItemsItem42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FormTableCellItemsItemDiscriminatorType?), TypeInfoPropertyName = "NullableFormTableCellItemsItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.FormsResultPage, global::LlamaParse.FailedFormsPage>?), TypeInfoPropertyName = "NullableAnyOfFormsResultPageFailedFormsPage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ItemsItem5?), TypeInfoPropertyName = "NullableItemsItem52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.HeaderItemItemDiscriminatorType?), TypeInfoPropertyName = "NullableHeaderItemItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.Pooling?), TypeInfoPropertyName = "NullablePooling2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ImageMetadataCategory2?), TypeInfoPropertyName = "NullableImageMetadataCategory22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.IndexCreateRequestVectorTarget?), TypeInfoPropertyName = "NullableIndexCreateRequestVectorTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.JobNameMapping?), TypeInfoPropertyName = "NullableJobNameMapping2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SupportedLLMModelNames?), TypeInfoPropertyName = "NullableSupportedLLMModelNames2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.TextItem, global::LlamaParse.ListItem>?), TypeInfoPropertyName = "NullableAnyOfTextItemListItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseOutputOptionsImagesToSaveVariant1Item?), TypeInfoPropertyName = "NullableLlamaParseOutputOptionsImagesToSaveVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseOutputOptionsGranularBboxe?), TypeInfoPropertyName = "NullableLlamaParseOutputOptionsGranularBboxe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseParametersPriority2?), TypeInfoPropertyName = "NullableLlamaParseParametersPriority22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseParametersImagesToSaveVariant1Item?), TypeInfoPropertyName = "NullableLlamaParseParametersImagesToSaveVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseProcessingOptionsSpecializedChartParsing2?), TypeInfoPropertyName = "NullableLlamaParseProcessingOptionsSpecializedChartParsing22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseProcessingOptionsForms2?), TypeInfoPropertyName = "NullableLlamaParseProcessingOptionsForms22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseSupportedFileExtensions?), TypeInfoPropertyName = "NullableLlamaParseSupportedFileExtensions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseWebhookConfigurationWebhookOutputFormat2?), TypeInfoPropertyName = "NullableLlamaParseWebhookConfigurationWebhookOutputFormat22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ManagedIngestionStatus?), TypeInfoPropertyName = "NullableManagedIngestionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.MarkdownResultPage, global::LlamaParse.FailedMarkdownPage>?), TypeInfoPropertyName = "NullableAnyOfMarkdownResultPageFailedMarkdownPage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.MetadataValue?), TypeInfoPropertyName = "NullableMetadataValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<int?, double?, string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<int>, object>?), TypeInfoPropertyName = "NullableAnyOfInt32DoubleStringIListStringIListDoubleIListInt32Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.MetadataFilter, global::LlamaParse.MetadataFilters>?), TypeInfoPropertyName = "NullableAnyOfMetadataFilterMetadataFilters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.MetadataScalarValue?), TypeInfoPropertyName = "NullableMetadataScalarValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.NodeRelationship?), TypeInfoPropertyName = "NullableNodeRelationship2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.NumericRangeFilterOperator?), TypeInfoPropertyName = "NullableNumericRangeFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<int?, double?, global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<int?, double?>>>?), TypeInfoPropertyName = "NullableAnyOfInt32DoubleIListAnyOfInt32Double2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<int?, double?>?), TypeInfoPropertyName = "NullableAnyOfInt32Double2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ObjectType?), TypeInfoPropertyName = "NullableObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParsePlanLevel?), TypeInfoPropertyName = "NullableParsePlanLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PGVectorDistanceMethod?), TypeInfoPropertyName = "NullablePGVectorDistanceMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PGVectorVectorType?), TypeInfoPropertyName = "NullablePGVectorVectorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParseJobResponseStatus?), TypeInfoPropertyName = "NullableParseJobResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.ParseRequestConfigurationTier?, string>?), TypeInfoPropertyName = "NullableAnyOfParseRequestConfigurationTierString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParseRequestConfigurationTier?), TypeInfoPropertyName = "NullableParseRequestConfigurationTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.ParseRequestConfigurationVersion?, string>?), TypeInfoPropertyName = "NullableAnyOfParseRequestConfigurationVersionString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParseRequestConfigurationVersion?), TypeInfoPropertyName = "NullableParseRequestConfigurationVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParseV2ParametersTier?), TypeInfoPropertyName = "NullableParseV2ParametersTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.ParseV2ParametersVersion?, string>?), TypeInfoPropertyName = "NullableAnyOfParseV2ParametersVersionString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParseV2ParametersVersion?), TypeInfoPropertyName = "NullableParseV2ParametersVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParseVersionsResponseFastItem?), TypeInfoPropertyName = "NullableParseVersionsResponseFastItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParseVersionsResponseCostEffectiveItem?), TypeInfoPropertyName = "NullableParseVersionsResponseCostEffectiveItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParseVersionsResponseAgenticItem?), TypeInfoPropertyName = "NullableParseVersionsResponseAgenticItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParseVersionsResponseAgenticPlu?), TypeInfoPropertyName = "NullableParseVersionsResponseAgenticPlu2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PartitionNames?), TypeInfoPropertyName = "NullablePartitionNames2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineType?), TypeInfoPropertyName = "NullablePipelineType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EmbeddingConfig3?), TypeInfoPropertyName = "NullableEmbeddingConfig32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineEmbeddingConfigDiscriminatorType?), TypeInfoPropertyName = "NullablePipelineEmbeddingConfigDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.AutoTransformConfig, global::LlamaParse.AdvancedModeTransformConfig>?), TypeInfoPropertyName = "NullableAnyOfAutoTransformConfigAdvancedModeTransformConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineStatus2?), TypeInfoPropertyName = "NullablePipelineStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineCreateEmbeddingConfigVariant1DiscriminatorType?), TypeInfoPropertyName = "NullablePipelineCreateEmbeddingConfigVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.AutoTransformConfig, global::LlamaParse.AdvancedModeTransformConfig, object>?), TypeInfoPropertyName = "NullableAnyOfAutoTransformConfigAdvancedModeTransformConfigObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineDataSourceStatus2?), TypeInfoPropertyName = "NullablePipelineDataSourceStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineFileStatus2?), TypeInfoPropertyName = "NullablePipelineFileStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineFileResponseStatus2?), TypeInfoPropertyName = "NullablePipelineFileResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineResponsePipelineType?), TypeInfoPropertyName = "NullablePipelineResponsePipelineType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineResponseStatus2?), TypeInfoPropertyName = "NullablePipelineResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineUpdateEmbeddingConfigVariant1DiscriminatorType?), TypeInfoPropertyName = "NullablePipelineUpdateEmbeddingConfigVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.RetrievalMode?), TypeInfoPropertyName = "NullableRetrievalMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ReRankerType?), TypeInfoPropertyName = "NullableReRankerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.ObjectType?, string, object>?), TypeInfoPropertyName = "NullableAnyOfObjectTypeStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.ValueFilter, global::System.Collections.Generic.IList<global::LlamaParse.NumericRangeFilter>, object>?), TypeInfoPropertyName = "NullableAnyOfValueFilterIListNumericRangeFilterObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.RevisionType?), TypeInfoPropertyName = "NullableRevisionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.EventsItem?), TypeInfoPropertyName = "NullableEventsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SessionDetailEventDiscriminatorType?), TypeInfoPropertyName = "NullableSessionDetailEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SparseModelType?), TypeInfoPropertyName = "NullableSparseModelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SplitJobResponseDocumentInputType?), TypeInfoPropertyName = "NullableSplitJobResponseDocumentInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SplitStrategyAllowUncategorized?), TypeInfoPropertyName = "NullableSplitStrategyAllowUncategorized2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SpreadsheetV1ParametersTier?), TypeInfoPropertyName = "NullableSpreadsheetV1ParametersTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SpreadsheetV1ParametersTableMergeSensitivity?), TypeInfoPropertyName = "NullableSpreadsheetV1ParametersTableMergeSensitivity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.StringFilterOperator?), TypeInfoPropertyName = "NullableStringFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.StructuredResultPage, global::LlamaParse.FailedStructuredPage>?), TypeInfoPropertyName = "NullableAnyOfStructuredResultPageFailedStructuredPage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ItemsItem7?), TypeInfoPropertyName = "NullableItemsItem72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.StructuredResultPageItemDiscriminatorType?), TypeInfoPropertyName = "NullableStructuredResultPageItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<string, int?, double?, object>?), TypeInfoPropertyName = "NullableAnyOfStringInt32DoubleObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.RelatedNodeInfo, global::System.Collections.Generic.IList<global::LlamaParse.RelatedNodeInfo>>?), TypeInfoPropertyName = "NullableAnyOfRelatedNodeInfoIListRelatedNodeInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.UsageMetricEventType?), TypeInfoPropertyName = "NullableUsageMetricEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.UsageMetricAggregateResponseGroupByItem?), TypeInfoPropertyName = "NullableUsageMetricAggregateResponseGroupByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ValueFilterOperator?), TypeInfoPropertyName = "NullableValueFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<string, int?, bool?, double?, global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?, bool?, double?>>>?), TypeInfoPropertyName = "NullableAnyOfStringInt32BooleanDoubleIListAnyOfStringInt32BooleanDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<string, int?, bool?, double?>?), TypeInfoPropertyName = "NullableAnyOfStringInt32BooleanDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.VertexEmbeddingMode?), TypeInfoPropertyName = "NullableVertexEmbeddingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.WebhookConfigCreateRequestWebhookEventsVariant1Item?), TypeInfoPropertyName = "NullableWebhookConfigCreateRequestWebhookEventsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.WebhookConfigCreateRequestWebhookOutputFormat2?), TypeInfoPropertyName = "NullableWebhookConfigCreateRequestWebhookOutputFormat22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.WebhookConfigResponseWebhookEventsVariant1Item?), TypeInfoPropertyName = "NullableWebhookConfigResponseWebhookEventsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.WebhookConfigResponseWebhookOutputFormat2?), TypeInfoPropertyName = "NullableWebhookConfigResponseWebhookOutputFormat22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.WebhookConfigUpdateRequestWebhookEventsVariant1Item?), TypeInfoPropertyName = "NullableWebhookConfigUpdateRequestWebhookEventsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.WebhookConfigUpdateRequestWebhookOutputFormat2?), TypeInfoPropertyName = "NullableWebhookConfigUpdateRequestWebhookOutputFormat22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item?), TypeInfoPropertyName = "NullableWebhookConfigurationWebhookEventsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListProjectJobDataPointsApiV1JobDataPointsGetJobType?), TypeInfoPropertyName = "NullableListProjectJobDataPointsApiV1JobDataPointsGetJobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item?), TypeInfoPropertyName = "NullableListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetStatusRefreshPolicy?), TypeInfoPropertyName = "NullableListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetStatusRefreshPolicy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PaginatedListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsPaginatedGetStatusRefreshPolicy?), TypeInfoPropertyName = "NullablePaginatedListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsPaginatedGetStatusRefreshPolicy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListSplitJobsApiV1SplitJobsGetStatus2?), TypeInfoPropertyName = "NullableListSplitJobsApiV1SplitJobsGetStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem?), TypeInfoPropertyName = "NullableAggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetType2?), TypeInfoPropertyName = "NullableListDirectoriesApiV1BetaDirectoriesGetType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1Item?), TypeInfoPropertyName = "NullableListDirectoriesApiV1BetaDirectoriesGetTypesVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item?), TypeInfoPropertyName = "NullableListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListSplitJobsApiV1BetaSplitJobsGetStatus2?), TypeInfoPropertyName = "NullableListSplitJobsApiV1BetaSplitJobsGetStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item?), TypeInfoPropertyName = "NullableListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListParseJobsApiV2ParseGetStatus2?), TypeInfoPropertyName = "NullableListParseJobsApiV2ParseGetStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListClassifyJobsApiV2ClassifyGetStatus2?), TypeInfoPropertyName = "NullableListClassifyJobsApiV2ClassifyGetStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListExtractJobsApiV2ExtractGetStatus2?), TypeInfoPropertyName = "NullableListExtractJobsApiV2ExtractGetStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListPipelinesApiV2PipelinesGetPipelineType2?), TypeInfoPropertyName = "NullableListPipelinesApiV2PipelinesGetPipelineType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListBatchesApiV2BatchesGetStatus2?), TypeInfoPropertyName = "NullableListBatchesApiV2BatchesGetStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.AggregateGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.AgentData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.WebhookConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.BatchItemDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.BatchJobResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ParserLanguages>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.BatchParseJobConfigImagesToSaveVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.BatchResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.BatchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.InputMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.MessageAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ClassifierRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ClassifyV2Rule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ClassifyV2JobResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.BBox>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.CompositeRetrievedTextNodeWithScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.PageScreenshotNodeWithScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.PageFigureNodeWithScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ConfigurationResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::System.Collections.Generic.List<object>, string, int?, double?, bool?, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.RetrieverPipeline>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.DirectoryFileResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.DirectoryResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::System.Collections.Generic.List<object>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ExtractV2Job>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.FileAttachmentMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.FileFindEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.FileGrepMatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.FileV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.AnyOf<double?, int?, string, global::System.DateTime?, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ItemsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.JsonItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ValueItemsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.AnyOf<global::LlamaParse.FormListTextItem, global::LlamaParse.FormListItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ItemsItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::LlamaParse.AnyOf<string, global::LlamaParse.FormTableCellItems, object>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.AnyOf<string, global::LlamaParse.FormTableCellItems, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ItemsItem4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.AnyOf<global::LlamaParse.FormsResultPage, global::LlamaParse.FailedFormsPage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.Form>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ItemsItem5>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ImageMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.IndexProductEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.IndexResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ProcessingResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.JobDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.AnyOf<global::LlamaParse.TextItem, global::LlamaParse.ListItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.LlamaParseOutputOptionsImagesToSaveVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.LlamaParseOutputOptionsGranularBboxe>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.LlamaParseParametersImagesToSaveVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.AutoModeConfigurationEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.IngestionErrorResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.AnyOf<global::LlamaParse.MarkdownResultPage, global::LlamaParse.FailedMarkdownPage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.MarkdownLineNumberAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<int?, double?, string, global::System.Collections.Generic.List<string>, global::System.Collections.Generic.List<double>, global::System.Collections.Generic.List<int>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.AnyOf<global::LlamaParse.MetadataFilter, global::LlamaParse.MetadataFilters>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.MetadataResultPage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<int?, double?, global::System.Collections.Generic.List<global::LlamaParse.AnyOf<int?, double?>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.AnyOf<int?, double?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.OrganizationResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ExtractRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.CloudDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.PipelineFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ParseJobResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.LlamaParseWebhookConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ParseVersionsResponseFastItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ParseVersionsResponseCostEffectiveItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ParseVersionsResponseAgenticItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ParseVersionsResponseAgenticPlu>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.PipelineFileResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.PipelineResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ChatMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ProjectResponse>))]
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::LlamaParse.CloudPineconeVectorStore, global::LlamaParse.CloudPostgresVectorStore, global::LlamaParse.CloudQdrantVectorStore, global::LlamaParse.CloudAzureAISearchVectorStore, global::LlamaParse.CloudMongoDBAtlasVectorSearch, global::LlamaParse.CloudMilvusVectorStore, global::LlamaParse.CloudAstraDBVectorStore>), TypeInfoPropertyName = "CloudAstraDBVectorStore_7213cc45d352cf78")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::LlamaParse.CloudPineconeVectorStore, global::LlamaParse.CloudPostgresVectorStore, global::LlamaParse.CloudQdrantVectorStore, global::LlamaParse.CloudAzureAISearchVectorStore, global::LlamaParse.CloudMongoDBAtlasVectorSearch, global::LlamaParse.CloudMilvusVectorStore, global::LlamaParse.CloudAstraDBVectorStore, object>), TypeInfoPropertyName = "CloudAstraDBVectorStore_object_3f7470369807d660")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::LlamaParse.CloudS3DataSource, global::LlamaParse.CloudAzStorageBlobDataSource, global::LlamaParse.CloudGoogleDriveDataSource, global::LlamaParse.CloudOneDriveDataSource, global::LlamaParse.CloudSharepointDataSource, global::LlamaParse.CloudSlackDataSource, global::LlamaParse.CloudNotionPageDataSource, global::LlamaParse.CloudConfluenceDataSource, global::LlamaParse.CloudJiraDataSource, global::LlamaParse.CloudJiraDataSourceV2, global::LlamaParse.CloudBoxDataSource>), TypeInfoPropertyName = "CloudBoxDataSource_44c4d8909c0abf11")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::LlamaParse.CloudS3DataSource, global::LlamaParse.CloudAzStorageBlobDataSource, global::LlamaParse.CloudGoogleDriveDataSource, global::LlamaParse.CloudOneDriveDataSource, global::LlamaParse.CloudSharepointDataSource, global::LlamaParse.CloudSlackDataSource, global::LlamaParse.CloudNotionPageDataSource, global::LlamaParse.CloudConfluenceDataSource, global::LlamaParse.CloudJiraDataSource, global::LlamaParse.CloudJiraDataSourceV2, global::LlamaParse.CloudBoxDataSource, object>), TypeInfoPropertyName = "CloudBoxDataSource_object_8c6b9addb1a78f63")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::LlamaParse.CloudPineconeVectorStore, global::LlamaParse.CloudPostgresVectorStore, global::LlamaParse.CloudQdrantVectorStore, global::LlamaParse.CloudAzureAISearchVectorStore, global::LlamaParse.CloudMongoDBAtlasVectorSearch, global::LlamaParse.CloudMilvusVectorStore, global::LlamaParse.CloudAstraDBVectorStore>?), TypeInfoPropertyName = "CloudAstraDBVectorStore_2b857d4e76ac6e71")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::LlamaParse.CloudPineconeVectorStore, global::LlamaParse.CloudPostgresVectorStore, global::LlamaParse.CloudQdrantVectorStore, global::LlamaParse.CloudAzureAISearchVectorStore, global::LlamaParse.CloudMongoDBAtlasVectorSearch, global::LlamaParse.CloudMilvusVectorStore, global::LlamaParse.CloudAstraDBVectorStore, object>?), TypeInfoPropertyName = "CloudAstraDBVectorStore_object_d9f8945237261e89")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::LlamaParse.CloudS3DataSource, global::LlamaParse.CloudAzStorageBlobDataSource, global::LlamaParse.CloudGoogleDriveDataSource, global::LlamaParse.CloudOneDriveDataSource, global::LlamaParse.CloudSharepointDataSource, global::LlamaParse.CloudSlackDataSource, global::LlamaParse.CloudNotionPageDataSource, global::LlamaParse.CloudConfluenceDataSource, global::LlamaParse.CloudJiraDataSource, global::LlamaParse.CloudJiraDataSourceV2, global::LlamaParse.CloudBoxDataSource>?), TypeInfoPropertyName = "CloudBoxDataSource_ee99e0e6ec633008")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::LlamaParse.CloudS3DataSource, global::LlamaParse.CloudAzStorageBlobDataSource, global::LlamaParse.CloudGoogleDriveDataSource, global::LlamaParse.CloudOneDriveDataSource, global::LlamaParse.CloudSharepointDataSource, global::LlamaParse.CloudSlackDataSource, global::LlamaParse.CloudNotionPageDataSource, global::LlamaParse.CloudConfluenceDataSource, global::LlamaParse.CloudJiraDataSource, global::LlamaParse.CloudJiraDataSourceV2, global::LlamaParse.CloudBoxDataSource, object>?), TypeInfoPropertyName = "CloudBoxDataSource_object_dfe1806971be6576")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.ValueFilter, global::System.Collections.Generic.List<global::LlamaParse.NumericRangeFilter>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.NumericRangeFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.RetrievalResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.TextNodeWithScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.RevisionTargetSpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.EventsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ChatSessionSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.SplitCategory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.SplitJobResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.SplitJobResponseBeta>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.SplitSegmentResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.AttachmentRef>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.AnyOf<global::LlamaParse.StructuredResultPage, global::LlamaParse.FailedStructuredPage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ItemsItem7>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.Revision>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::LlamaParse.AnyOf<string, int?, double?, object>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.AnyOf<string, int?, double?, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ParseConcernItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.RelatedNodeInfo, global::System.Collections.Generic.List<global::LlamaParse.RelatedNodeInfo>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.RelatedNodeInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.TextResultPage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.UsageMetricAggregateResponseGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.UsageMetricAggregateBucket>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.UsageMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<string, int?, bool?, double?, global::System.Collections.Generic.List<global::LlamaParse.AnyOf<string, int?, bool?, double?>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.AnyOf<string, int?, bool?, double?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.WebhookConfigCreateRequestWebhookEventsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.WebhookConfigResponseWebhookEventsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.WebhookConfigUpdateRequestWebhookEventsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.PipelineDataSourceCreate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.PipelineFileCreate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.CloudDocumentCreate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1Item>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.WebhookConfigResponse>))]
    internal sealed partial class SourceGenerationContextChunk2 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

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
            options.Converters.Add(new global::LlamaParse.JsonConverters.ParametersJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.Parameters2JsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ParametersVariant1JsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.EmbeddingConfigJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.EmbeddingConfig2JsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.EmbeddingConfigVariant1JsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ItemsItemJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.JsonItemJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ValueItemsVariant1ItemJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ItemsItem3JsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ItemsItem4JsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ItemsItem5JsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.MetadataScalarValueJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.MetadataValueJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.EmbeddingConfig3JsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.EmbeddingConfigVariant12JsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.EmbeddingConfigVariant13JsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.EventsItemJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ItemsItem7JsonConverter());
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
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.FormListTextItem, global::LlamaParse.FormListItem>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, global::LlamaParse.FormTableCellItems, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.FormsResultPage, global::LlamaParse.FailedFormsPage>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.TextItem, global::LlamaParse.ListItem>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.MarkdownResultPage, global::LlamaParse.FailedMarkdownPage>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, double?, string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<int>, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.MetadataFilter, global::LlamaParse.MetadataFilters>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, double?, global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<int?, double?>>>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, double?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.ParseRequestConfigurationTier?, string>());
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
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.ValueFilter, global::System.Collections.Generic.IList<global::LlamaParse.NumericRangeFilter>, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.StructuredResultPage, global::LlamaParse.FailedStructuredPage>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, int?, double?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.RelatedNodeInfo, global::System.Collections.Generic.IList<global::LlamaParse.RelatedNodeInfo>>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, int?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, int?, bool?, double?, global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?, bool?, double?>>>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, int?, bool?, double?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.UnixTimestampJsonConverter());

            options.Converters.Add(new LazyEnumJsonConverterFactory());

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::LlamaParse.AutoModeParsingConfTier2)

                    || typeToConvert == typeof(global::LlamaParse.AutoModeParsingConfTier2?)

                    || typeToConvert == typeof(global::LlamaParse.AutoModeParsingConfVersion)

                    || typeToConvert == typeof(global::LlamaParse.AutoModeParsingConfVersion?)

                    || typeToConvert == typeof(global::LlamaParse.AutoModeParsingConfSpecializedChartParsing2)

                    || typeToConvert == typeof(global::LlamaParse.AutoModeParsingConfSpecializedChartParsing2?)

                    || typeToConvert == typeof(global::LlamaParse.BatchFileStatus)

                    || typeToConvert == typeof(global::LlamaParse.BatchFileStatus?)

                    || typeToConvert == typeof(global::LlamaParse.BatchJobStatus)

                    || typeToConvert == typeof(global::LlamaParse.BatchJobStatus?)

                    || typeToConvert == typeof(global::LlamaParse.BatchJobType)

                    || typeToConvert == typeof(global::LlamaParse.BatchJobType?)

                    || typeToConvert == typeof(global::LlamaParse.BatchParseJobConfigPriority2)

                    || typeToConvert == typeof(global::LlamaParse.BatchParseJobConfigPriority2?)

                    || typeToConvert == typeof(global::LlamaParse.BatchParseJobConfigImagesToSaveVariant1Item)

                    || typeToConvert == typeof(global::LlamaParse.BatchParseJobConfigImagesToSaveVariant1Item?)

                    || typeToConvert == typeof(global::LlamaParse.BatchResponseStatus)

                    || typeToConvert == typeof(global::LlamaParse.BatchResponseStatus?)

                    || typeToConvert == typeof(global::LlamaParse.BoxAuthMechanism)

                    || typeToConvert == typeof(global::LlamaParse.BoxAuthMechanism?)

                    || typeToConvert == typeof(global::LlamaParse.ClassifyMode)

                    || typeToConvert == typeof(global::LlamaParse.ClassifyMode?)

                    || typeToConvert == typeof(global::LlamaParse.ClassifyV2JobResponseStatus)

                    || typeToConvert == typeof(global::LlamaParse.ClassifyV2JobResponseStatus?)

                    || typeToConvert == typeof(global::LlamaParse.ClassifyV2JobResponseDocumentInputType)

                    || typeToConvert == typeof(global::LlamaParse.ClassifyV2JobResponseDocumentInputType?)

                    || typeToConvert == typeof(global::LlamaParse.CloudJiraDataSourceV2ApiVersion)

                    || typeToConvert == typeof(global::LlamaParse.CloudJiraDataSourceV2ApiVersion?)

                    || typeToConvert == typeof(global::LlamaParse.CompositeRetrievalMode)

                    || typeToConvert == typeof(global::LlamaParse.CompositeRetrievalMode?)

                    || typeToConvert == typeof(global::LlamaParse.ConfigurableDataSinkNames)

                    || typeToConvert == typeof(global::LlamaParse.ConfigurableDataSinkNames?)

                    || typeToConvert == typeof(global::LlamaParse.ConfigurableDataSourceNames)

                    || typeToConvert == typeof(global::LlamaParse.ConfigurableDataSourceNames?)

                    || typeToConvert == typeof(global::LlamaParse.ConfigurationCreateRequestParametersDiscriminatorProductType)

                    || typeToConvert == typeof(global::LlamaParse.ConfigurationCreateRequestParametersDiscriminatorProductType?)

                    || typeToConvert == typeof(global::LlamaParse.ConfigurationResponseProductType)

                    || typeToConvert == typeof(global::LlamaParse.ConfigurationResponseProductType?)

                    || typeToConvert == typeof(global::LlamaParse.ConfigurationResponseParametersDiscriminatorProductType)

                    || typeToConvert == typeof(global::LlamaParse.ConfigurationResponseParametersDiscriminatorProductType?)

                    || typeToConvert == typeof(global::LlamaParse.ConfigurationUpdateRequestParametersVariant1DiscriminatorProductType)

                    || typeToConvert == typeof(global::LlamaParse.ConfigurationUpdateRequestParametersVariant1DiscriminatorProductType?)

                    || typeToConvert == typeof(global::LlamaParse.DataSourceReaderVersionMetadataReaderVersion2)

                    || typeToConvert == typeof(global::LlamaParse.DataSourceReaderVersionMetadataReaderVersion2?)

                    || typeToConvert == typeof(global::LlamaParse.DirectoryCreateRequestType)

                    || typeToConvert == typeof(global::LlamaParse.DirectoryCreateRequestType?)

                    || typeToConvert == typeof(global::LlamaParse.DirectoryResponseType2)

                    || typeToConvert == typeof(global::LlamaParse.DirectoryResponseType2?)

                    || typeToConvert == typeof(global::LlamaParse.DocumentChunkMode)

                    || typeToConvert == typeof(global::LlamaParse.DocumentChunkMode?)

                    || typeToConvert == typeof(global::LlamaParse.EmbeddingModelConfigEmbeddingConfigDiscriminatorType)

                    || typeToConvert == typeof(global::LlamaParse.EmbeddingModelConfigEmbeddingConfigDiscriminatorType?)

                    || typeToConvert == typeof(global::LlamaParse.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType)

                    || typeToConvert == typeof(global::LlamaParse.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType?)

                    || typeToConvert == typeof(global::LlamaParse.EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::LlamaParse.EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::LlamaParse.ExtractConfigPriority2)

                    || typeToConvert == typeof(global::LlamaParse.ExtractConfigPriority2?)

                    || typeToConvert == typeof(global::LlamaParse.ExtractConfigurationTier)

                    || typeToConvert == typeof(global::LlamaParse.ExtractConfigurationTier?)

                    || typeToConvert == typeof(global::LlamaParse.ExtractConfigurationExtractionTarget)

                    || typeToConvert == typeof(global::LlamaParse.ExtractConfigurationExtractionTarget?)

                    || typeToConvert == typeof(global::LlamaParse.ExtractConfigurationParseTier2)

                    || typeToConvert == typeof(global::LlamaParse.ExtractConfigurationParseTier2?)

                    || typeToConvert == typeof(global::LlamaParse.ExtractJobStatus)

                    || typeToConvert == typeof(global::LlamaParse.ExtractJobStatus?)

                    || typeToConvert == typeof(global::LlamaParse.ExtractJobCreatePriority2)

                    || typeToConvert == typeof(global::LlamaParse.ExtractJobCreatePriority2?)

                    || typeToConvert == typeof(global::LlamaParse.ExtractMode)

                    || typeToConvert == typeof(global::LlamaParse.ExtractMode?)

                    || typeToConvert == typeof(global::LlamaParse.ExtractModels)

                    || typeToConvert == typeof(global::LlamaParse.ExtractModels?)

                    || typeToConvert == typeof(global::LlamaParse.ExtractState)

                    || typeToConvert == typeof(global::LlamaParse.ExtractState?)

                    || typeToConvert == typeof(global::LlamaParse.ExtractTarget)

                    || typeToConvert == typeof(global::LlamaParse.ExtractTarget?)

                    || typeToConvert == typeof(global::LlamaParse.ExtractV2ParametersTier)

                    || typeToConvert == typeof(global::LlamaParse.ExtractV2ParametersTier?)

                    || typeToConvert == typeof(global::LlamaParse.ExtractV2ParametersExtractionTarget)

                    || typeToConvert == typeof(global::LlamaParse.ExtractV2ParametersExtractionTarget?)

                    || typeToConvert == typeof(global::LlamaParse.ExtractV2ParametersParseTier2)

                    || typeToConvert == typeof(global::LlamaParse.ExtractV2ParametersParseTier2?)

                    || typeToConvert == typeof(global::LlamaParse.FailPageMode)

                    || typeToConvert == typeof(global::LlamaParse.FailPageMode?)

                    || typeToConvert == typeof(global::LlamaParse.FilterCondition)

                    || typeToConvert == typeof(global::LlamaParse.FilterCondition?)

                    || typeToConvert == typeof(global::LlamaParse.FilterOperator)

                    || typeToConvert == typeof(global::LlamaParse.FilterOperator?)

                    || typeToConvert == typeof(global::LlamaParse.FooterItemItemDiscriminatorType)

                    || typeToConvert == typeof(global::LlamaParse.FooterItemItemDiscriminatorType?)

                    || typeToConvert == typeof(global::LlamaParse.FormJsonItemDiscriminatorType)

                    || typeToConvert == typeof(global::LlamaParse.FormJsonItemDiscriminatorType?)

                    || typeToConvert == typeof(global::LlamaParse.FormFieldField)

                    || typeToConvert == typeof(global::LlamaParse.FormFieldField?)

                    || typeToConvert == typeof(global::LlamaParse.FormFieldValueItemsVariant1ItemDiscriminatorType)

                    || typeToConvert == typeof(global::LlamaParse.FormFieldValueItemsVariant1ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::LlamaParse.FormSectionItemDiscriminatorType)

                    || typeToConvert == typeof(global::LlamaParse.FormSectionItemDiscriminatorType?)

                    || typeToConvert == typeof(global::LlamaParse.FormTableCellItemsItemDiscriminatorType)

                    || typeToConvert == typeof(global::LlamaParse.FormTableCellItemsItemDiscriminatorType?)

                    || typeToConvert == typeof(global::LlamaParse.HeaderItemItemDiscriminatorType)

                    || typeToConvert == typeof(global::LlamaParse.HeaderItemItemDiscriminatorType?)

                    || typeToConvert == typeof(global::LlamaParse.ImageMetadataCategory2)

                    || typeToConvert == typeof(global::LlamaParse.ImageMetadataCategory2?)

                    || typeToConvert == typeof(global::LlamaParse.IndexCreateRequestVectorTarget)

                    || typeToConvert == typeof(global::LlamaParse.IndexCreateRequestVectorTarget?)

                    || typeToConvert == typeof(global::LlamaParse.JobNameMapping)

                    || typeToConvert == typeof(global::LlamaParse.JobNameMapping?)

                    || typeToConvert == typeof(global::LlamaParse.LlamaParseOutputOptionsImagesToSaveVariant1Item)

                    || typeToConvert == typeof(global::LlamaParse.LlamaParseOutputOptionsImagesToSaveVariant1Item?)

                    || typeToConvert == typeof(global::LlamaParse.LlamaParseOutputOptionsGranularBboxe)

                    || typeToConvert == typeof(global::LlamaParse.LlamaParseOutputOptionsGranularBboxe?)

                    || typeToConvert == typeof(global::LlamaParse.LlamaParseParametersPriority2)

                    || typeToConvert == typeof(global::LlamaParse.LlamaParseParametersPriority2?)

                    || typeToConvert == typeof(global::LlamaParse.LlamaParseParametersImagesToSaveVariant1Item)

                    || typeToConvert == typeof(global::LlamaParse.LlamaParseParametersImagesToSaveVariant1Item?)

                    || typeToConvert == typeof(global::LlamaParse.LlamaParseProcessingOptionsSpecializedChartParsing2)

                    || typeToConvert == typeof(global::LlamaParse.LlamaParseProcessingOptionsSpecializedChartParsing2?)

                    || typeToConvert == typeof(global::LlamaParse.LlamaParseProcessingOptionsForms2)

                    || typeToConvert == typeof(global::LlamaParse.LlamaParseProcessingOptionsForms2?)

                    || typeToConvert == typeof(global::LlamaParse.LlamaParseSupportedFileExtensions)

                    || typeToConvert == typeof(global::LlamaParse.LlamaParseSupportedFileExtensions?)

                    || typeToConvert == typeof(global::LlamaParse.LlamaParseWebhookConfigurationWebhookOutputFormat2)

                    || typeToConvert == typeof(global::LlamaParse.LlamaParseWebhookConfigurationWebhookOutputFormat2?)

                    || typeToConvert == typeof(global::LlamaParse.ManagedIngestionStatus)

                    || typeToConvert == typeof(global::LlamaParse.ManagedIngestionStatus?)

                    || typeToConvert == typeof(global::LlamaParse.MessageRole)

                    || typeToConvert == typeof(global::LlamaParse.MessageRole?)

                    || typeToConvert == typeof(global::LlamaParse.NodeRelationship)

                    || typeToConvert == typeof(global::LlamaParse.NodeRelationship?)

                    || typeToConvert == typeof(global::LlamaParse.NumericRangeFilterOperator)

                    || typeToConvert == typeof(global::LlamaParse.NumericRangeFilterOperator?)

                    || typeToConvert == typeof(global::LlamaParse.ObjectType)

                    || typeToConvert == typeof(global::LlamaParse.ObjectType?)

                    || typeToConvert == typeof(global::LlamaParse.PGVectorDistanceMethod)

                    || typeToConvert == typeof(global::LlamaParse.PGVectorDistanceMethod?)

                    || typeToConvert == typeof(global::LlamaParse.PGVectorVectorType)

                    || typeToConvert == typeof(global::LlamaParse.PGVectorVectorType?)

                    || typeToConvert == typeof(global::LlamaParse.ParseJobResponseStatus)

                    || typeToConvert == typeof(global::LlamaParse.ParseJobResponseStatus?)

                    || typeToConvert == typeof(global::LlamaParse.ParsePlanLevel)

                    || typeToConvert == typeof(global::LlamaParse.ParsePlanLevel?)

                    || typeToConvert == typeof(global::LlamaParse.ParseRequestConfigurationTier)

                    || typeToConvert == typeof(global::LlamaParse.ParseRequestConfigurationTier?)

                    || typeToConvert == typeof(global::LlamaParse.ParseRequestConfigurationVersion)

                    || typeToConvert == typeof(global::LlamaParse.ParseRequestConfigurationVersion?)

                    || typeToConvert == typeof(global::LlamaParse.ParseV2ParametersTier)

                    || typeToConvert == typeof(global::LlamaParse.ParseV2ParametersTier?)

                    || typeToConvert == typeof(global::LlamaParse.ParseV2ParametersVersion)

                    || typeToConvert == typeof(global::LlamaParse.ParseV2ParametersVersion?)

                    || typeToConvert == typeof(global::LlamaParse.ParseVersionsResponseFastItem)

                    || typeToConvert == typeof(global::LlamaParse.ParseVersionsResponseFastItem?)

                    || typeToConvert == typeof(global::LlamaParse.ParseVersionsResponseCostEffectiveItem)

                    || typeToConvert == typeof(global::LlamaParse.ParseVersionsResponseCostEffectiveItem?)

                    || typeToConvert == typeof(global::LlamaParse.ParseVersionsResponseAgenticItem)

                    || typeToConvert == typeof(global::LlamaParse.ParseVersionsResponseAgenticItem?)

                    || typeToConvert == typeof(global::LlamaParse.ParseVersionsResponseAgenticPlu)

                    || typeToConvert == typeof(global::LlamaParse.ParseVersionsResponseAgenticPlu?)

                    || typeToConvert == typeof(global::LlamaParse.ParserLanguages)

                    || typeToConvert == typeof(global::LlamaParse.ParserLanguages?)

                    || typeToConvert == typeof(global::LlamaParse.ParsingMode)

                    || typeToConvert == typeof(global::LlamaParse.ParsingMode?)

                    || typeToConvert == typeof(global::LlamaParse.PartitionNames)

                    || typeToConvert == typeof(global::LlamaParse.PartitionNames?)

                    || typeToConvert == typeof(global::LlamaParse.PipelineEmbeddingConfigDiscriminatorType)

                    || typeToConvert == typeof(global::LlamaParse.PipelineEmbeddingConfigDiscriminatorType?)

                    || typeToConvert == typeof(global::LlamaParse.PipelineStatus2)

                    || typeToConvert == typeof(global::LlamaParse.PipelineStatus2?)

                    || typeToConvert == typeof(global::LlamaParse.PipelineCreateEmbeddingConfigVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::LlamaParse.PipelineCreateEmbeddingConfigVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::LlamaParse.PipelineDataSourceStatus2)

                    || typeToConvert == typeof(global::LlamaParse.PipelineDataSourceStatus2?)

                    || typeToConvert == typeof(global::LlamaParse.PipelineFileStatus2)

                    || typeToConvert == typeof(global::LlamaParse.PipelineFileStatus2?)

                    || typeToConvert == typeof(global::LlamaParse.PipelineFileResponseStatus2)

                    || typeToConvert == typeof(global::LlamaParse.PipelineFileResponseStatus2?)

                    || typeToConvert == typeof(global::LlamaParse.PipelineResponsePipelineType)

                    || typeToConvert == typeof(global::LlamaParse.PipelineResponsePipelineType?)

                    || typeToConvert == typeof(global::LlamaParse.PipelineResponseStatus2)

                    || typeToConvert == typeof(global::LlamaParse.PipelineResponseStatus2?)

                    || typeToConvert == typeof(global::LlamaParse.PipelineType)

                    || typeToConvert == typeof(global::LlamaParse.PipelineType?)

                    || typeToConvert == typeof(global::LlamaParse.PipelineUpdateEmbeddingConfigVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::LlamaParse.PipelineUpdateEmbeddingConfigVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::LlamaParse.Pooling)

                    || typeToConvert == typeof(global::LlamaParse.Pooling?)

                    || typeToConvert == typeof(global::LlamaParse.PublicModelName)

                    || typeToConvert == typeof(global::LlamaParse.PublicModelName?)

                    || typeToConvert == typeof(global::LlamaParse.ReRankerType)

                    || typeToConvert == typeof(global::LlamaParse.ReRankerType?)

                    || typeToConvert == typeof(global::LlamaParse.RetrievalMode)

                    || typeToConvert == typeof(global::LlamaParse.RetrievalMode?)

                    || typeToConvert == typeof(global::LlamaParse.RevisionType)

                    || typeToConvert == typeof(global::LlamaParse.RevisionType?)

                    || typeToConvert == typeof(global::LlamaParse.SessionDetailEventDiscriminatorType)

                    || typeToConvert == typeof(global::LlamaParse.SessionDetailEventDiscriminatorType?)

                    || typeToConvert == typeof(global::LlamaParse.SparseModelType)

                    || typeToConvert == typeof(global::LlamaParse.SparseModelType?)

                    || typeToConvert == typeof(global::LlamaParse.SplitJobResponseDocumentInputType)

                    || typeToConvert == typeof(global::LlamaParse.SplitJobResponseDocumentInputType?)

                    || typeToConvert == typeof(global::LlamaParse.SplitStrategyAllowUncategorized)

                    || typeToConvert == typeof(global::LlamaParse.SplitStrategyAllowUncategorized?)

                    || typeToConvert == typeof(global::LlamaParse.SpreadsheetV1ParametersTier)

                    || typeToConvert == typeof(global::LlamaParse.SpreadsheetV1ParametersTier?)

                    || typeToConvert == typeof(global::LlamaParse.SpreadsheetV1ParametersTableMergeSensitivity)

                    || typeToConvert == typeof(global::LlamaParse.SpreadsheetV1ParametersTableMergeSensitivity?)

                    || typeToConvert == typeof(global::LlamaParse.StatusEnum)

                    || typeToConvert == typeof(global::LlamaParse.StatusEnum?)

                    || typeToConvert == typeof(global::LlamaParse.StringFilterOperator)

                    || typeToConvert == typeof(global::LlamaParse.StringFilterOperator?)

                    || typeToConvert == typeof(global::LlamaParse.StructuredResultPageItemDiscriminatorType)

                    || typeToConvert == typeof(global::LlamaParse.StructuredResultPageItemDiscriminatorType?)

                    || typeToConvert == typeof(global::LlamaParse.SupportedLLMModelNames)

                    || typeToConvert == typeof(global::LlamaParse.SupportedLLMModelNames?)

                    || typeToConvert == typeof(global::LlamaParse.UsageMetricEventType)

                    || typeToConvert == typeof(global::LlamaParse.UsageMetricEventType?)

                    || typeToConvert == typeof(global::LlamaParse.UsageMetricAggregateResponseGroupByItem)

                    || typeToConvert == typeof(global::LlamaParse.UsageMetricAggregateResponseGroupByItem?)

                    || typeToConvert == typeof(global::LlamaParse.ValueFilterOperator)

                    || typeToConvert == typeof(global::LlamaParse.ValueFilterOperator?)

                    || typeToConvert == typeof(global::LlamaParse.VertexEmbeddingMode)

                    || typeToConvert == typeof(global::LlamaParse.VertexEmbeddingMode?)

                    || typeToConvert == typeof(global::LlamaParse.WebhookConfigCreateRequestWebhookEventsVariant1Item)

                    || typeToConvert == typeof(global::LlamaParse.WebhookConfigCreateRequestWebhookEventsVariant1Item?)

                    || typeToConvert == typeof(global::LlamaParse.WebhookConfigCreateRequestWebhookOutputFormat2)

                    || typeToConvert == typeof(global::LlamaParse.WebhookConfigCreateRequestWebhookOutputFormat2?)

                    || typeToConvert == typeof(global::LlamaParse.WebhookConfigResponseWebhookEventsVariant1Item)

                    || typeToConvert == typeof(global::LlamaParse.WebhookConfigResponseWebhookEventsVariant1Item?)

                    || typeToConvert == typeof(global::LlamaParse.WebhookConfigResponseWebhookOutputFormat2)

                    || typeToConvert == typeof(global::LlamaParse.WebhookConfigResponseWebhookOutputFormat2?)

                    || typeToConvert == typeof(global::LlamaParse.WebhookConfigUpdateRequestWebhookEventsVariant1Item)

                    || typeToConvert == typeof(global::LlamaParse.WebhookConfigUpdateRequestWebhookEventsVariant1Item?)

                    || typeToConvert == typeof(global::LlamaParse.WebhookConfigUpdateRequestWebhookOutputFormat2)

                    || typeToConvert == typeof(global::LlamaParse.WebhookConfigUpdateRequestWebhookOutputFormat2?)

                    || typeToConvert == typeof(global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item)

                    || typeToConvert == typeof(global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item?)

                    || typeToConvert == typeof(global::LlamaParse.ListProjectJobDataPointsApiV1JobDataPointsGetJobType)

                    || typeToConvert == typeof(global::LlamaParse.ListProjectJobDataPointsApiV1JobDataPointsGetJobType?)

                    || typeToConvert == typeof(global::LlamaParse.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item)

                    || typeToConvert == typeof(global::LlamaParse.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item?)

                    || typeToConvert == typeof(global::LlamaParse.ListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetStatusRefreshPolicy)

                    || typeToConvert == typeof(global::LlamaParse.ListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetStatusRefreshPolicy?)

                    || typeToConvert == typeof(global::LlamaParse.PaginatedListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsPaginatedGetStatusRefreshPolicy)

                    || typeToConvert == typeof(global::LlamaParse.PaginatedListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsPaginatedGetStatusRefreshPolicy?)

                    || typeToConvert == typeof(global::LlamaParse.ListSplitJobsApiV1SplitJobsGetStatus2)

                    || typeToConvert == typeof(global::LlamaParse.ListSplitJobsApiV1SplitJobsGetStatus2?)

                    || typeToConvert == typeof(global::LlamaParse.AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem)

                    || typeToConvert == typeof(global::LlamaParse.AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem?)

                    || typeToConvert == typeof(global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetType2)

                    || typeToConvert == typeof(global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetType2?)

                    || typeToConvert == typeof(global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1Item)

                    || typeToConvert == typeof(global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1Item?)

                    || typeToConvert == typeof(global::LlamaParse.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item)

                    || typeToConvert == typeof(global::LlamaParse.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item?)

                    || typeToConvert == typeof(global::LlamaParse.ListSplitJobsApiV1BetaSplitJobsGetStatus2)

                    || typeToConvert == typeof(global::LlamaParse.ListSplitJobsApiV1BetaSplitJobsGetStatus2?)

                    || typeToConvert == typeof(global::LlamaParse.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item)

                    || typeToConvert == typeof(global::LlamaParse.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item?)

                    || typeToConvert == typeof(global::LlamaParse.ListParseJobsApiV2ParseGetStatus2)

                    || typeToConvert == typeof(global::LlamaParse.ListParseJobsApiV2ParseGetStatus2?)

                    || typeToConvert == typeof(global::LlamaParse.ListClassifyJobsApiV2ClassifyGetStatus2)

                    || typeToConvert == typeof(global::LlamaParse.ListClassifyJobsApiV2ClassifyGetStatus2?)

                    || typeToConvert == typeof(global::LlamaParse.ListExtractJobsApiV2ExtractGetStatus2)

                    || typeToConvert == typeof(global::LlamaParse.ListExtractJobsApiV2ExtractGetStatus2?)

                    || typeToConvert == typeof(global::LlamaParse.ListPipelinesApiV2PipelinesGetPipelineType2)

                    || typeToConvert == typeof(global::LlamaParse.ListPipelinesApiV2PipelinesGetPipelineType2?)

                    || typeToConvert == typeof(global::LlamaParse.ListBatchesApiV2BatchesGetStatus2)

                    || typeToConvert == typeof(global::LlamaParse.ListBatchesApiV2BatchesGetStatus2?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::LlamaParse.AutoModeParsingConfTier2))
                {
                    return new global::LlamaParse.JsonConverters.AutoModeParsingConfTier2JsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.AutoModeParsingConfTier2?))
                {
                    return new global::LlamaParse.JsonConverters.AutoModeParsingConfTier2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.AutoModeParsingConfVersion))
                {
                    return new global::LlamaParse.JsonConverters.AutoModeParsingConfVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.AutoModeParsingConfVersion?))
                {
                    return new global::LlamaParse.JsonConverters.AutoModeParsingConfVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.AutoModeParsingConfSpecializedChartParsing2))
                {
                    return new global::LlamaParse.JsonConverters.AutoModeParsingConfSpecializedChartParsing2JsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.AutoModeParsingConfSpecializedChartParsing2?))
                {
                    return new global::LlamaParse.JsonConverters.AutoModeParsingConfSpecializedChartParsing2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.BatchFileStatus))
                {
                    return new global::LlamaParse.JsonConverters.BatchFileStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.BatchFileStatus?))
                {
                    return new global::LlamaParse.JsonConverters.BatchFileStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.BatchJobStatus))
                {
                    return new global::LlamaParse.JsonConverters.BatchJobStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.BatchJobStatus?))
                {
                    return new global::LlamaParse.JsonConverters.BatchJobStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.BatchJobType))
                {
                    return new global::LlamaParse.JsonConverters.BatchJobTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.BatchJobType?))
                {
                    return new global::LlamaParse.JsonConverters.BatchJobTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.BatchParseJobConfigPriority2))
                {
                    return new global::LlamaParse.JsonConverters.BatchParseJobConfigPriority2JsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.BatchParseJobConfigPriority2?))
                {
                    return new global::LlamaParse.JsonConverters.BatchParseJobConfigPriority2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.BatchParseJobConfigImagesToSaveVariant1Item))
                {
                    return new global::LlamaParse.JsonConverters.BatchParseJobConfigImagesToSaveVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.BatchParseJobConfigImagesToSaveVariant1Item?))
                {
                    return new global::LlamaParse.JsonConverters.BatchParseJobConfigImagesToSaveVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.BatchResponseStatus))
                {
                    return new global::LlamaParse.JsonConverters.BatchResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.BatchResponseStatus?))
                {
                    return new global::LlamaParse.JsonConverters.BatchResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.BoxAuthMechanism))
                {
                    return new global::LlamaParse.JsonConverters.BoxAuthMechanismJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.BoxAuthMechanism?))
                {
                    return new global::LlamaParse.JsonConverters.BoxAuthMechanismNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ClassifyMode))
                {
                    return new global::LlamaParse.JsonConverters.ClassifyModeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ClassifyMode?))
                {
                    return new global::LlamaParse.JsonConverters.ClassifyModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ClassifyV2JobResponseStatus))
                {
                    return new global::LlamaParse.JsonConverters.ClassifyV2JobResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ClassifyV2JobResponseStatus?))
                {
                    return new global::LlamaParse.JsonConverters.ClassifyV2JobResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ClassifyV2JobResponseDocumentInputType))
                {
                    return new global::LlamaParse.JsonConverters.ClassifyV2JobResponseDocumentInputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ClassifyV2JobResponseDocumentInputType?))
                {
                    return new global::LlamaParse.JsonConverters.ClassifyV2JobResponseDocumentInputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.CloudJiraDataSourceV2ApiVersion))
                {
                    return new global::LlamaParse.JsonConverters.CloudJiraDataSourceV2ApiVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.CloudJiraDataSourceV2ApiVersion?))
                {
                    return new global::LlamaParse.JsonConverters.CloudJiraDataSourceV2ApiVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.CompositeRetrievalMode))
                {
                    return new global::LlamaParse.JsonConverters.CompositeRetrievalModeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.CompositeRetrievalMode?))
                {
                    return new global::LlamaParse.JsonConverters.CompositeRetrievalModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ConfigurableDataSinkNames))
                {
                    return new global::LlamaParse.JsonConverters.ConfigurableDataSinkNamesJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ConfigurableDataSinkNames?))
                {
                    return new global::LlamaParse.JsonConverters.ConfigurableDataSinkNamesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ConfigurableDataSourceNames))
                {
                    return new global::LlamaParse.JsonConverters.ConfigurableDataSourceNamesJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ConfigurableDataSourceNames?))
                {
                    return new global::LlamaParse.JsonConverters.ConfigurableDataSourceNamesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ConfigurationCreateRequestParametersDiscriminatorProductType))
                {
                    return new global::LlamaParse.JsonConverters.ConfigurationCreateRequestParametersDiscriminatorProductTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ConfigurationCreateRequestParametersDiscriminatorProductType?))
                {
                    return new global::LlamaParse.JsonConverters.ConfigurationCreateRequestParametersDiscriminatorProductTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ConfigurationResponseProductType))
                {
                    return new global::LlamaParse.JsonConverters.ConfigurationResponseProductTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ConfigurationResponseProductType?))
                {
                    return new global::LlamaParse.JsonConverters.ConfigurationResponseProductTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ConfigurationResponseParametersDiscriminatorProductType))
                {
                    return new global::LlamaParse.JsonConverters.ConfigurationResponseParametersDiscriminatorProductTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ConfigurationResponseParametersDiscriminatorProductType?))
                {
                    return new global::LlamaParse.JsonConverters.ConfigurationResponseParametersDiscriminatorProductTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ConfigurationUpdateRequestParametersVariant1DiscriminatorProductType))
                {
                    return new global::LlamaParse.JsonConverters.ConfigurationUpdateRequestParametersVariant1DiscriminatorProductTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ConfigurationUpdateRequestParametersVariant1DiscriminatorProductType?))
                {
                    return new global::LlamaParse.JsonConverters.ConfigurationUpdateRequestParametersVariant1DiscriminatorProductTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.DataSourceReaderVersionMetadataReaderVersion2))
                {
                    return new global::LlamaParse.JsonConverters.DataSourceReaderVersionMetadataReaderVersion2JsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.DataSourceReaderVersionMetadataReaderVersion2?))
                {
                    return new global::LlamaParse.JsonConverters.DataSourceReaderVersionMetadataReaderVersion2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.DirectoryCreateRequestType))
                {
                    return new global::LlamaParse.JsonConverters.DirectoryCreateRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.DirectoryCreateRequestType?))
                {
                    return new global::LlamaParse.JsonConverters.DirectoryCreateRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.DirectoryResponseType2))
                {
                    return new global::LlamaParse.JsonConverters.DirectoryResponseType2JsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.DirectoryResponseType2?))
                {
                    return new global::LlamaParse.JsonConverters.DirectoryResponseType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.DocumentChunkMode))
                {
                    return new global::LlamaParse.JsonConverters.DocumentChunkModeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.DocumentChunkMode?))
                {
                    return new global::LlamaParse.JsonConverters.DocumentChunkModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.EmbeddingModelConfigEmbeddingConfigDiscriminatorType))
                {
                    return new global::LlamaParse.JsonConverters.EmbeddingModelConfigEmbeddingConfigDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.EmbeddingModelConfigEmbeddingConfigDiscriminatorType?))
                {
                    return new global::LlamaParse.JsonConverters.EmbeddingModelConfigEmbeddingConfigDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType))
                {
                    return new global::LlamaParse.JsonConverters.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType?))
                {
                    return new global::LlamaParse.JsonConverters.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorType))
                {
                    return new global::LlamaParse.JsonConverters.EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorType?))
                {
                    return new global::LlamaParse.JsonConverters.EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ExtractConfigPriority2))
                {
                    return new global::LlamaParse.JsonConverters.ExtractConfigPriority2JsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ExtractConfigPriority2?))
                {
                    return new global::LlamaParse.JsonConverters.ExtractConfigPriority2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ExtractConfigurationTier))
                {
                    return new global::LlamaParse.JsonConverters.ExtractConfigurationTierJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ExtractConfigurationTier?))
                {
                    return new global::LlamaParse.JsonConverters.ExtractConfigurationTierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ExtractConfigurationExtractionTarget))
                {
                    return new global::LlamaParse.JsonConverters.ExtractConfigurationExtractionTargetJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ExtractConfigurationExtractionTarget?))
                {
                    return new global::LlamaParse.JsonConverters.ExtractConfigurationExtractionTargetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ExtractConfigurationParseTier2))
                {
                    return new global::LlamaParse.JsonConverters.ExtractConfigurationParseTier2JsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ExtractConfigurationParseTier2?))
                {
                    return new global::LlamaParse.JsonConverters.ExtractConfigurationParseTier2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ExtractJobStatus))
                {
                    return new global::LlamaParse.JsonConverters.ExtractJobStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ExtractJobStatus?))
                {
                    return new global::LlamaParse.JsonConverters.ExtractJobStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ExtractJobCreatePriority2))
                {
                    return new global::LlamaParse.JsonConverters.ExtractJobCreatePriority2JsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ExtractJobCreatePriority2?))
                {
                    return new global::LlamaParse.JsonConverters.ExtractJobCreatePriority2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ExtractMode))
                {
                    return new global::LlamaParse.JsonConverters.ExtractModeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ExtractMode?))
                {
                    return new global::LlamaParse.JsonConverters.ExtractModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ExtractModels))
                {
                    return new global::LlamaParse.JsonConverters.ExtractModelsJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ExtractModels?))
                {
                    return new global::LlamaParse.JsonConverters.ExtractModelsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ExtractState))
                {
                    return new global::LlamaParse.JsonConverters.ExtractStateJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ExtractState?))
                {
                    return new global::LlamaParse.JsonConverters.ExtractStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ExtractTarget))
                {
                    return new global::LlamaParse.JsonConverters.ExtractTargetJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ExtractTarget?))
                {
                    return new global::LlamaParse.JsonConverters.ExtractTargetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ExtractV2ParametersTier))
                {
                    return new global::LlamaParse.JsonConverters.ExtractV2ParametersTierJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ExtractV2ParametersTier?))
                {
                    return new global::LlamaParse.JsonConverters.ExtractV2ParametersTierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ExtractV2ParametersExtractionTarget))
                {
                    return new global::LlamaParse.JsonConverters.ExtractV2ParametersExtractionTargetJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ExtractV2ParametersExtractionTarget?))
                {
                    return new global::LlamaParse.JsonConverters.ExtractV2ParametersExtractionTargetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ExtractV2ParametersParseTier2))
                {
                    return new global::LlamaParse.JsonConverters.ExtractV2ParametersParseTier2JsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ExtractV2ParametersParseTier2?))
                {
                    return new global::LlamaParse.JsonConverters.ExtractV2ParametersParseTier2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.FailPageMode))
                {
                    return new global::LlamaParse.JsonConverters.FailPageModeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.FailPageMode?))
                {
                    return new global::LlamaParse.JsonConverters.FailPageModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.FilterCondition))
                {
                    return new global::LlamaParse.JsonConverters.FilterConditionJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.FilterCondition?))
                {
                    return new global::LlamaParse.JsonConverters.FilterConditionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.FilterOperator))
                {
                    return new global::LlamaParse.JsonConverters.FilterOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.FilterOperator?))
                {
                    return new global::LlamaParse.JsonConverters.FilterOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.FooterItemItemDiscriminatorType))
                {
                    return new global::LlamaParse.JsonConverters.FooterItemItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.FooterItemItemDiscriminatorType?))
                {
                    return new global::LlamaParse.JsonConverters.FooterItemItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.FormJsonItemDiscriminatorType))
                {
                    return new global::LlamaParse.JsonConverters.FormJsonItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.FormJsonItemDiscriminatorType?))
                {
                    return new global::LlamaParse.JsonConverters.FormJsonItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.FormFieldField))
                {
                    return new global::LlamaParse.JsonConverters.FormFieldFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.FormFieldField?))
                {
                    return new global::LlamaParse.JsonConverters.FormFieldFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.FormFieldValueItemsVariant1ItemDiscriminatorType))
                {
                    return new global::LlamaParse.JsonConverters.FormFieldValueItemsVariant1ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.FormFieldValueItemsVariant1ItemDiscriminatorType?))
                {
                    return new global::LlamaParse.JsonConverters.FormFieldValueItemsVariant1ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.FormSectionItemDiscriminatorType))
                {
                    return new global::LlamaParse.JsonConverters.FormSectionItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.FormSectionItemDiscriminatorType?))
                {
                    return new global::LlamaParse.JsonConverters.FormSectionItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.FormTableCellItemsItemDiscriminatorType))
                {
                    return new global::LlamaParse.JsonConverters.FormTableCellItemsItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.FormTableCellItemsItemDiscriminatorType?))
                {
                    return new global::LlamaParse.JsonConverters.FormTableCellItemsItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.HeaderItemItemDiscriminatorType))
                {
                    return new global::LlamaParse.JsonConverters.HeaderItemItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.HeaderItemItemDiscriminatorType?))
                {
                    return new global::LlamaParse.JsonConverters.HeaderItemItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ImageMetadataCategory2))
                {
                    return new global::LlamaParse.JsonConverters.ImageMetadataCategory2JsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ImageMetadataCategory2?))
                {
                    return new global::LlamaParse.JsonConverters.ImageMetadataCategory2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.IndexCreateRequestVectorTarget))
                {
                    return new global::LlamaParse.JsonConverters.IndexCreateRequestVectorTargetJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.IndexCreateRequestVectorTarget?))
                {
                    return new global::LlamaParse.JsonConverters.IndexCreateRequestVectorTargetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.JobNameMapping))
                {
                    return new global::LlamaParse.JsonConverters.JobNameMappingJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.JobNameMapping?))
                {
                    return new global::LlamaParse.JsonConverters.JobNameMappingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.LlamaParseOutputOptionsImagesToSaveVariant1Item))
                {
                    return new global::LlamaParse.JsonConverters.LlamaParseOutputOptionsImagesToSaveVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.LlamaParseOutputOptionsImagesToSaveVariant1Item?))
                {
                    return new global::LlamaParse.JsonConverters.LlamaParseOutputOptionsImagesToSaveVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.LlamaParseOutputOptionsGranularBboxe))
                {
                    return new global::LlamaParse.JsonConverters.LlamaParseOutputOptionsGranularBboxeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.LlamaParseOutputOptionsGranularBboxe?))
                {
                    return new global::LlamaParse.JsonConverters.LlamaParseOutputOptionsGranularBboxeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.LlamaParseParametersPriority2))
                {
                    return new global::LlamaParse.JsonConverters.LlamaParseParametersPriority2JsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.LlamaParseParametersPriority2?))
                {
                    return new global::LlamaParse.JsonConverters.LlamaParseParametersPriority2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.LlamaParseParametersImagesToSaveVariant1Item))
                {
                    return new global::LlamaParse.JsonConverters.LlamaParseParametersImagesToSaveVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.LlamaParseParametersImagesToSaveVariant1Item?))
                {
                    return new global::LlamaParse.JsonConverters.LlamaParseParametersImagesToSaveVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.LlamaParseProcessingOptionsSpecializedChartParsing2))
                {
                    return new global::LlamaParse.JsonConverters.LlamaParseProcessingOptionsSpecializedChartParsing2JsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.LlamaParseProcessingOptionsSpecializedChartParsing2?))
                {
                    return new global::LlamaParse.JsonConverters.LlamaParseProcessingOptionsSpecializedChartParsing2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.LlamaParseProcessingOptionsForms2))
                {
                    return new global::LlamaParse.JsonConverters.LlamaParseProcessingOptionsForms2JsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.LlamaParseProcessingOptionsForms2?))
                {
                    return new global::LlamaParse.JsonConverters.LlamaParseProcessingOptionsForms2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.LlamaParseSupportedFileExtensions))
                {
                    return new global::LlamaParse.JsonConverters.LlamaParseSupportedFileExtensionsJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.LlamaParseSupportedFileExtensions?))
                {
                    return new global::LlamaParse.JsonConverters.LlamaParseSupportedFileExtensionsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.LlamaParseWebhookConfigurationWebhookOutputFormat2))
                {
                    return new global::LlamaParse.JsonConverters.LlamaParseWebhookConfigurationWebhookOutputFormat2JsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.LlamaParseWebhookConfigurationWebhookOutputFormat2?))
                {
                    return new global::LlamaParse.JsonConverters.LlamaParseWebhookConfigurationWebhookOutputFormat2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ManagedIngestionStatus))
                {
                    return new global::LlamaParse.JsonConverters.ManagedIngestionStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ManagedIngestionStatus?))
                {
                    return new global::LlamaParse.JsonConverters.ManagedIngestionStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.MessageRole))
                {
                    return new global::LlamaParse.JsonConverters.MessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.MessageRole?))
                {
                    return new global::LlamaParse.JsonConverters.MessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.NodeRelationship))
                {
                    return new global::LlamaParse.JsonConverters.NodeRelationshipJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.NodeRelationship?))
                {
                    return new global::LlamaParse.JsonConverters.NodeRelationshipNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.NumericRangeFilterOperator))
                {
                    return new global::LlamaParse.JsonConverters.NumericRangeFilterOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.NumericRangeFilterOperator?))
                {
                    return new global::LlamaParse.JsonConverters.NumericRangeFilterOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ObjectType))
                {
                    return new global::LlamaParse.JsonConverters.ObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ObjectType?))
                {
                    return new global::LlamaParse.JsonConverters.ObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.PGVectorDistanceMethod))
                {
                    return new global::LlamaParse.JsonConverters.PGVectorDistanceMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.PGVectorDistanceMethod?))
                {
                    return new global::LlamaParse.JsonConverters.PGVectorDistanceMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.PGVectorVectorType))
                {
                    return new global::LlamaParse.JsonConverters.PGVectorVectorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.PGVectorVectorType?))
                {
                    return new global::LlamaParse.JsonConverters.PGVectorVectorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ParseJobResponseStatus))
                {
                    return new global::LlamaParse.JsonConverters.ParseJobResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ParseJobResponseStatus?))
                {
                    return new global::LlamaParse.JsonConverters.ParseJobResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ParsePlanLevel))
                {
                    return new global::LlamaParse.JsonConverters.ParsePlanLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ParsePlanLevel?))
                {
                    return new global::LlamaParse.JsonConverters.ParsePlanLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ParseRequestConfigurationTier))
                {
                    return new global::LlamaParse.JsonConverters.ParseRequestConfigurationTierJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ParseRequestConfigurationTier?))
                {
                    return new global::LlamaParse.JsonConverters.ParseRequestConfigurationTierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ParseRequestConfigurationVersion))
                {
                    return new global::LlamaParse.JsonConverters.ParseRequestConfigurationVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ParseRequestConfigurationVersion?))
                {
                    return new global::LlamaParse.JsonConverters.ParseRequestConfigurationVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ParseV2ParametersTier))
                {
                    return new global::LlamaParse.JsonConverters.ParseV2ParametersTierJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ParseV2ParametersTier?))
                {
                    return new global::LlamaParse.JsonConverters.ParseV2ParametersTierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ParseV2ParametersVersion))
                {
                    return new global::LlamaParse.JsonConverters.ParseV2ParametersVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ParseV2ParametersVersion?))
                {
                    return new global::LlamaParse.JsonConverters.ParseV2ParametersVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ParseVersionsResponseFastItem))
                {
                    return new global::LlamaParse.JsonConverters.ParseVersionsResponseFastItemJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ParseVersionsResponseFastItem?))
                {
                    return new global::LlamaParse.JsonConverters.ParseVersionsResponseFastItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ParseVersionsResponseCostEffectiveItem))
                {
                    return new global::LlamaParse.JsonConverters.ParseVersionsResponseCostEffectiveItemJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ParseVersionsResponseCostEffectiveItem?))
                {
                    return new global::LlamaParse.JsonConverters.ParseVersionsResponseCostEffectiveItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ParseVersionsResponseAgenticItem))
                {
                    return new global::LlamaParse.JsonConverters.ParseVersionsResponseAgenticItemJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ParseVersionsResponseAgenticItem?))
                {
                    return new global::LlamaParse.JsonConverters.ParseVersionsResponseAgenticItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ParseVersionsResponseAgenticPlu))
                {
                    return new global::LlamaParse.JsonConverters.ParseVersionsResponseAgenticPluJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ParseVersionsResponseAgenticPlu?))
                {
                    return new global::LlamaParse.JsonConverters.ParseVersionsResponseAgenticPluNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ParserLanguages))
                {
                    return new global::LlamaParse.JsonConverters.ParserLanguagesJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ParserLanguages?))
                {
                    return new global::LlamaParse.JsonConverters.ParserLanguagesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ParsingMode))
                {
                    return new global::LlamaParse.JsonConverters.ParsingModeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ParsingMode?))
                {
                    return new global::LlamaParse.JsonConverters.ParsingModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.PartitionNames))
                {
                    return new global::LlamaParse.JsonConverters.PartitionNamesJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.PartitionNames?))
                {
                    return new global::LlamaParse.JsonConverters.PartitionNamesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.PipelineEmbeddingConfigDiscriminatorType))
                {
                    return new global::LlamaParse.JsonConverters.PipelineEmbeddingConfigDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.PipelineEmbeddingConfigDiscriminatorType?))
                {
                    return new global::LlamaParse.JsonConverters.PipelineEmbeddingConfigDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.PipelineStatus2))
                {
                    return new global::LlamaParse.JsonConverters.PipelineStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.PipelineStatus2?))
                {
                    return new global::LlamaParse.JsonConverters.PipelineStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.PipelineCreateEmbeddingConfigVariant1DiscriminatorType))
                {
                    return new global::LlamaParse.JsonConverters.PipelineCreateEmbeddingConfigVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.PipelineCreateEmbeddingConfigVariant1DiscriminatorType?))
                {
                    return new global::LlamaParse.JsonConverters.PipelineCreateEmbeddingConfigVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.PipelineDataSourceStatus2))
                {
                    return new global::LlamaParse.JsonConverters.PipelineDataSourceStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.PipelineDataSourceStatus2?))
                {
                    return new global::LlamaParse.JsonConverters.PipelineDataSourceStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.PipelineFileStatus2))
                {
                    return new global::LlamaParse.JsonConverters.PipelineFileStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.PipelineFileStatus2?))
                {
                    return new global::LlamaParse.JsonConverters.PipelineFileStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.PipelineFileResponseStatus2))
                {
                    return new global::LlamaParse.JsonConverters.PipelineFileResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.PipelineFileResponseStatus2?))
                {
                    return new global::LlamaParse.JsonConverters.PipelineFileResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.PipelineResponsePipelineType))
                {
                    return new global::LlamaParse.JsonConverters.PipelineResponsePipelineTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.PipelineResponsePipelineType?))
                {
                    return new global::LlamaParse.JsonConverters.PipelineResponsePipelineTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.PipelineResponseStatus2))
                {
                    return new global::LlamaParse.JsonConverters.PipelineResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.PipelineResponseStatus2?))
                {
                    return new global::LlamaParse.JsonConverters.PipelineResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.PipelineType))
                {
                    return new global::LlamaParse.JsonConverters.PipelineTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.PipelineType?))
                {
                    return new global::LlamaParse.JsonConverters.PipelineTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.PipelineUpdateEmbeddingConfigVariant1DiscriminatorType))
                {
                    return new global::LlamaParse.JsonConverters.PipelineUpdateEmbeddingConfigVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.PipelineUpdateEmbeddingConfigVariant1DiscriminatorType?))
                {
                    return new global::LlamaParse.JsonConverters.PipelineUpdateEmbeddingConfigVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.Pooling))
                {
                    return new global::LlamaParse.JsonConverters.PoolingJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.Pooling?))
                {
                    return new global::LlamaParse.JsonConverters.PoolingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.PublicModelName))
                {
                    return new global::LlamaParse.JsonConverters.PublicModelNameJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.PublicModelName?))
                {
                    return new global::LlamaParse.JsonConverters.PublicModelNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ReRankerType))
                {
                    return new global::LlamaParse.JsonConverters.ReRankerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ReRankerType?))
                {
                    return new global::LlamaParse.JsonConverters.ReRankerTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.RetrievalMode))
                {
                    return new global::LlamaParse.JsonConverters.RetrievalModeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.RetrievalMode?))
                {
                    return new global::LlamaParse.JsonConverters.RetrievalModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.RevisionType))
                {
                    return new global::LlamaParse.JsonConverters.RevisionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.RevisionType?))
                {
                    return new global::LlamaParse.JsonConverters.RevisionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.SessionDetailEventDiscriminatorType))
                {
                    return new global::LlamaParse.JsonConverters.SessionDetailEventDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.SessionDetailEventDiscriminatorType?))
                {
                    return new global::LlamaParse.JsonConverters.SessionDetailEventDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.SparseModelType))
                {
                    return new global::LlamaParse.JsonConverters.SparseModelTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.SparseModelType?))
                {
                    return new global::LlamaParse.JsonConverters.SparseModelTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.SplitJobResponseDocumentInputType))
                {
                    return new global::LlamaParse.JsonConverters.SplitJobResponseDocumentInputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.SplitJobResponseDocumentInputType?))
                {
                    return new global::LlamaParse.JsonConverters.SplitJobResponseDocumentInputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.SplitStrategyAllowUncategorized))
                {
                    return new global::LlamaParse.JsonConverters.SplitStrategyAllowUncategorizedJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.SplitStrategyAllowUncategorized?))
                {
                    return new global::LlamaParse.JsonConverters.SplitStrategyAllowUncategorizedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.SpreadsheetV1ParametersTier))
                {
                    return new global::LlamaParse.JsonConverters.SpreadsheetV1ParametersTierJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.SpreadsheetV1ParametersTier?))
                {
                    return new global::LlamaParse.JsonConverters.SpreadsheetV1ParametersTierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.SpreadsheetV1ParametersTableMergeSensitivity))
                {
                    return new global::LlamaParse.JsonConverters.SpreadsheetV1ParametersTableMergeSensitivityJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.SpreadsheetV1ParametersTableMergeSensitivity?))
                {
                    return new global::LlamaParse.JsonConverters.SpreadsheetV1ParametersTableMergeSensitivityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.StatusEnum))
                {
                    return new global::LlamaParse.JsonConverters.StatusEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.StatusEnum?))
                {
                    return new global::LlamaParse.JsonConverters.StatusEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.StringFilterOperator))
                {
                    return new global::LlamaParse.JsonConverters.StringFilterOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.StringFilterOperator?))
                {
                    return new global::LlamaParse.JsonConverters.StringFilterOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.StructuredResultPageItemDiscriminatorType))
                {
                    return new global::LlamaParse.JsonConverters.StructuredResultPageItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.StructuredResultPageItemDiscriminatorType?))
                {
                    return new global::LlamaParse.JsonConverters.StructuredResultPageItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.SupportedLLMModelNames))
                {
                    return new global::LlamaParse.JsonConverters.SupportedLLMModelNamesJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.SupportedLLMModelNames?))
                {
                    return new global::LlamaParse.JsonConverters.SupportedLLMModelNamesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.UsageMetricEventType))
                {
                    return new global::LlamaParse.JsonConverters.UsageMetricEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.UsageMetricEventType?))
                {
                    return new global::LlamaParse.JsonConverters.UsageMetricEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.UsageMetricAggregateResponseGroupByItem))
                {
                    return new global::LlamaParse.JsonConverters.UsageMetricAggregateResponseGroupByItemJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.UsageMetricAggregateResponseGroupByItem?))
                {
                    return new global::LlamaParse.JsonConverters.UsageMetricAggregateResponseGroupByItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ValueFilterOperator))
                {
                    return new global::LlamaParse.JsonConverters.ValueFilterOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ValueFilterOperator?))
                {
                    return new global::LlamaParse.JsonConverters.ValueFilterOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.VertexEmbeddingMode))
                {
                    return new global::LlamaParse.JsonConverters.VertexEmbeddingModeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.VertexEmbeddingMode?))
                {
                    return new global::LlamaParse.JsonConverters.VertexEmbeddingModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.WebhookConfigCreateRequestWebhookEventsVariant1Item))
                {
                    return new global::LlamaParse.JsonConverters.WebhookConfigCreateRequestWebhookEventsVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.WebhookConfigCreateRequestWebhookEventsVariant1Item?))
                {
                    return new global::LlamaParse.JsonConverters.WebhookConfigCreateRequestWebhookEventsVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.WebhookConfigCreateRequestWebhookOutputFormat2))
                {
                    return new global::LlamaParse.JsonConverters.WebhookConfigCreateRequestWebhookOutputFormat2JsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.WebhookConfigCreateRequestWebhookOutputFormat2?))
                {
                    return new global::LlamaParse.JsonConverters.WebhookConfigCreateRequestWebhookOutputFormat2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.WebhookConfigResponseWebhookEventsVariant1Item))
                {
                    return new global::LlamaParse.JsonConverters.WebhookConfigResponseWebhookEventsVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.WebhookConfigResponseWebhookEventsVariant1Item?))
                {
                    return new global::LlamaParse.JsonConverters.WebhookConfigResponseWebhookEventsVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.WebhookConfigResponseWebhookOutputFormat2))
                {
                    return new global::LlamaParse.JsonConverters.WebhookConfigResponseWebhookOutputFormat2JsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.WebhookConfigResponseWebhookOutputFormat2?))
                {
                    return new global::LlamaParse.JsonConverters.WebhookConfigResponseWebhookOutputFormat2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.WebhookConfigUpdateRequestWebhookEventsVariant1Item))
                {
                    return new global::LlamaParse.JsonConverters.WebhookConfigUpdateRequestWebhookEventsVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.WebhookConfigUpdateRequestWebhookEventsVariant1Item?))
                {
                    return new global::LlamaParse.JsonConverters.WebhookConfigUpdateRequestWebhookEventsVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.WebhookConfigUpdateRequestWebhookOutputFormat2))
                {
                    return new global::LlamaParse.JsonConverters.WebhookConfigUpdateRequestWebhookOutputFormat2JsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.WebhookConfigUpdateRequestWebhookOutputFormat2?))
                {
                    return new global::LlamaParse.JsonConverters.WebhookConfigUpdateRequestWebhookOutputFormat2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item))
                {
                    return new global::LlamaParse.JsonConverters.WebhookConfigurationWebhookEventsVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item?))
                {
                    return new global::LlamaParse.JsonConverters.WebhookConfigurationWebhookEventsVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ListProjectJobDataPointsApiV1JobDataPointsGetJobType))
                {
                    return new global::LlamaParse.JsonConverters.ListProjectJobDataPointsApiV1JobDataPointsGetJobTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ListProjectJobDataPointsApiV1JobDataPointsGetJobType?))
                {
                    return new global::LlamaParse.JsonConverters.ListProjectJobDataPointsApiV1JobDataPointsGetJobTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item))
                {
                    return new global::LlamaParse.JsonConverters.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item?))
                {
                    return new global::LlamaParse.JsonConverters.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetStatusRefreshPolicy))
                {
                    return new global::LlamaParse.JsonConverters.ListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetStatusRefreshPolicyJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetStatusRefreshPolicy?))
                {
                    return new global::LlamaParse.JsonConverters.ListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetStatusRefreshPolicyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.PaginatedListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsPaginatedGetStatusRefreshPolicy))
                {
                    return new global::LlamaParse.JsonConverters.PaginatedListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsPaginatedGetStatusRefreshPolicyJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.PaginatedListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsPaginatedGetStatusRefreshPolicy?))
                {
                    return new global::LlamaParse.JsonConverters.PaginatedListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsPaginatedGetStatusRefreshPolicyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ListSplitJobsApiV1SplitJobsGetStatus2))
                {
                    return new global::LlamaParse.JsonConverters.ListSplitJobsApiV1SplitJobsGetStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ListSplitJobsApiV1SplitJobsGetStatus2?))
                {
                    return new global::LlamaParse.JsonConverters.ListSplitJobsApiV1SplitJobsGetStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem))
                {
                    return new global::LlamaParse.JsonConverters.AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItemJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem?))
                {
                    return new global::LlamaParse.JsonConverters.AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetType2))
                {
                    return new global::LlamaParse.JsonConverters.ListDirectoriesApiV1BetaDirectoriesGetType2JsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetType2?))
                {
                    return new global::LlamaParse.JsonConverters.ListDirectoriesApiV1BetaDirectoriesGetType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1Item))
                {
                    return new global::LlamaParse.JsonConverters.ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1Item?))
                {
                    return new global::LlamaParse.JsonConverters.ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item))
                {
                    return new global::LlamaParse.JsonConverters.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item?))
                {
                    return new global::LlamaParse.JsonConverters.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ListSplitJobsApiV1BetaSplitJobsGetStatus2))
                {
                    return new global::LlamaParse.JsonConverters.ListSplitJobsApiV1BetaSplitJobsGetStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ListSplitJobsApiV1BetaSplitJobsGetStatus2?))
                {
                    return new global::LlamaParse.JsonConverters.ListSplitJobsApiV1BetaSplitJobsGetStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item))
                {
                    return new global::LlamaParse.JsonConverters.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item?))
                {
                    return new global::LlamaParse.JsonConverters.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ListParseJobsApiV2ParseGetStatus2))
                {
                    return new global::LlamaParse.JsonConverters.ListParseJobsApiV2ParseGetStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ListParseJobsApiV2ParseGetStatus2?))
                {
                    return new global::LlamaParse.JsonConverters.ListParseJobsApiV2ParseGetStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ListClassifyJobsApiV2ClassifyGetStatus2))
                {
                    return new global::LlamaParse.JsonConverters.ListClassifyJobsApiV2ClassifyGetStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ListClassifyJobsApiV2ClassifyGetStatus2?))
                {
                    return new global::LlamaParse.JsonConverters.ListClassifyJobsApiV2ClassifyGetStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ListExtractJobsApiV2ExtractGetStatus2))
                {
                    return new global::LlamaParse.JsonConverters.ListExtractJobsApiV2ExtractGetStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ListExtractJobsApiV2ExtractGetStatus2?))
                {
                    return new global::LlamaParse.JsonConverters.ListExtractJobsApiV2ExtractGetStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ListPipelinesApiV2PipelinesGetPipelineType2))
                {
                    return new global::LlamaParse.JsonConverters.ListPipelinesApiV2PipelinesGetPipelineType2JsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ListPipelinesApiV2PipelinesGetPipelineType2?))
                {
                    return new global::LlamaParse.JsonConverters.ListPipelinesApiV2PipelinesGetPipelineType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ListBatchesApiV2BatchesGetStatus2))
                {
                    return new global::LlamaParse.JsonConverters.ListBatchesApiV2BatchesGetStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ListBatchesApiV2BatchesGetStatus2?))
                {
                    return new global::LlamaParse.JsonConverters.ListBatchesApiV2BatchesGetStatus2NullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[3];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new SourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),

                    2 => new SourceGenerationContextChunk2(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}