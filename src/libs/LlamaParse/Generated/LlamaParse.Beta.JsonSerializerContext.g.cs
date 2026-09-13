
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::LlamaParse.CloudPineconeVectorStore, global::LlamaParse.CloudPostgresVectorStore, global::LlamaParse.CloudQdrantVectorStore, global::LlamaParse.CloudAzureAISearchVectorStore, global::LlamaParse.CloudMongoDBAtlasVectorSearch, global::LlamaParse.CloudMilvusVectorStore, global::LlamaParse.CloudAstraDBVectorStore>?), TypeInfoPropertyName = "CloudAstraDBVectorStore_2b857d4e76ac6e71")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AutoModeConfigurationEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AutoModeParsingConf))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<double?, string, object>), TypeInfoPropertyName = "AnyOfDoubleStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<int?, string, object>), TypeInfoPropertyName = "AnyOfInt32StringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AutoModeCropBox))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AutoModeIgnoreOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AutoModeParsingConfTier), TypeInfoPropertyName = "AutoModeParsingConfTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.AutoModeParsingConfVersion?, string, object>), TypeInfoPropertyName = "AnyOfAutoModeParsingConfVersionStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AutoModeParsingConfVersion), TypeInfoPropertyName = "AutoModeParsingConfVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AutoModeParsingConfSpecializedChartParsing), TypeInfoPropertyName = "AutoModeParsingConfSpecializedChartParsing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AutoModeSpatialTextOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AutoModePresentationOptions))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BatchJobType), TypeInfoPropertyName = "BatchJobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BatchJobStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BatchParseJobConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BatchParseJobConfigPriority), TypeInfoPropertyName = "BatchParseJobConfigPriority2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ParserLanguages>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParserLanguages), TypeInfoPropertyName = "ParserLanguages2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.BatchParseJobConfigImagesToSaveVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BatchParseJobConfigImagesToSaveVariant1Item), TypeInfoPropertyName = "BatchParseJobConfigImagesToSaveVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParsingMode), TypeInfoPropertyName = "ParsingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FailPageMode), TypeInfoPropertyName = "FailPageMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::System.Guid?, string>), TypeInfoPropertyName = "AnyOfGuidString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BodyUploadFileApiV1BetaFilesPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BodyUploadFileToDirectoryApiV1BetaDirectoriesDirectoryIdFilesUploadPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ClassifierRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.StatusEnum), TypeInfoPropertyName = "StatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ClassifierRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ClassifyMode), TypeInfoPropertyName = "ClassifyMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ClassifyParsingConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ClassifyV2Rule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ClassifyV2Rule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ClassifyV2ParsingConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ClassifyV2Parameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.CloudAstraDBVectorStore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.CloudAzureAISearchVectorStore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.CloudMilvusVectorStore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.CloudMongoDBAtlasVectorSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.CloudPineconeVectorStore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.CloudPostgresVectorStore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PGVectorHNSWSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.CloudQdrantVectorStore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ConfigurableDataSinkNames), TypeInfoPropertyName = "ConfigurableDataSinkNames2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DataSinkQueryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.DataSink>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>), TypeInfoPropertyName = "AnyOfObjectIListObjectStringInt32DoubleBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DeleteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DeleteResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DirectoryResponseType), TypeInfoPropertyName = "DirectoryResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DirectoryUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DocumentChunkMode), TypeInfoPropertyName = "DocumentChunkMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractAgentQueryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ExtractAgent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractConfigPriority), TypeInfoPropertyName = "ExtractConfigPriority2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractTarget), TypeInfoPropertyName = "ExtractTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractMode), TypeInfoPropertyName = "ExtractMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PublicModelName), TypeInfoPropertyName = "PublicModelName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.ExtractModels?, string, object>), TypeInfoPropertyName = "AnyOfExtractModelsStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractModels), TypeInfoPropertyName = "ExtractModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractV2ParametersTier), TypeInfoPropertyName = "ExtractV2ParametersTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractV2ParametersExtractionTarget), TypeInfoPropertyName = "ExtractV2ParametersExtractionTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractV2ParametersParseTier), TypeInfoPropertyName = "ExtractV2ParametersParseTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FileAttachmentListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.FileAttachmentMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FileAttachmentMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FileFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FileQueryRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FileQueryResponseV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.FileV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FileV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<double?, int?, string, global::System.DateTime?, object>), TypeInfoPropertyName = "AnyOfDoubleInt32StringDateTimeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<double?, int?, string, global::System.DateTime?, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ItemProcessingResultsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ProcessingResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ProcessingResult))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseProcessingControl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseTimeouts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseProcessingOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseProcessingOptionsSpecializedChartParsing), TypeInfoPropertyName = "LlamaParseProcessingOptionsSpecializedChartParsing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.AutoModeConfigurationEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseProcessingOptionsForms), TypeInfoPropertyName = "LlamaParseProcessingOptionsForms2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseWebhookConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseWebhookConfigurationWebhookOutputFormat), TypeInfoPropertyName = "LlamaParseWebhookConfigurationWebhookOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.MetadataValue), TypeInfoPropertyName = "MetadataValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.MetadataScalarValue), TypeInfoPropertyName = "MetadataScalarValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PGVectorDistanceMethod), TypeInfoPropertyName = "PGVectorDistanceMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PGVectorVectorType), TypeInfoPropertyName = "PGVectorVectorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.LlamaParseWebhookConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParseV2ParametersTier), TypeInfoPropertyName = "ParseV2ParametersTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.ParseV2ParametersVersion?, string>), TypeInfoPropertyName = "AnyOfParseV2ParametersVersionString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParseV2ParametersVersion), TypeInfoPropertyName = "ParseV2ParametersVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineFileListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.PipelineFileResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineFileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineFileResponseStatus), TypeInfoPropertyName = "PipelineFileResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ProcessingResultMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SearchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SplitCategory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SplitConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.SplitCategory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SplitStrategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SplitCreateRequestBeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SplitDocumentInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SplitJobQueryResponseBeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.SplitJobResponseBeta>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SplitJobResponseBeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SplitResultResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.SplitSegmentResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SplitSegmentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SplitStrategyAllowUncategorized), TypeInfoPropertyName = "SplitStrategyAllowUncategorized2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SpreadsheetV1ParametersTier), TypeInfoPropertyName = "SpreadsheetV1ParametersTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SpreadsheetV1ParametersTableMergeSensitivity), TypeInfoPropertyName = "SpreadsheetV1ParametersTableMergeSensitivity2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.WebhookConfigCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigCreateRequestWebhookEventsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.WebhookConfigCreateRequestWebhookEventsVariant1Item), TypeInfoPropertyName = "WebhookConfigCreateRequestWebhookEventsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.WebhookConfigCreateRequestWebhookOutputFormat), TypeInfoPropertyName = "WebhookConfigCreateRequestWebhookOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.WebhookConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigResponseWebhookEventsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.WebhookConfigResponseWebhookEventsVariant1Item), TypeInfoPropertyName = "WebhookConfigResponseWebhookEventsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.WebhookConfigResponseWebhookOutputFormat), TypeInfoPropertyName = "WebhookConfigResponseWebhookOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.WebhookConfigUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigUpdateRequestWebhookEventsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.WebhookConfigUpdateRequestWebhookEventsVariant1Item), TypeInfoPropertyName = "WebhookConfigUpdateRequestWebhookEventsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.WebhookConfigUpdateRequestWebhookOutputFormat), TypeInfoPropertyName = "WebhookConfigUpdateRequestWebhookOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item), TypeInfoPropertyName = "WebhookConfigurationWebhookEventsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem), TypeInfoPropertyName = "AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetType), TypeInfoPropertyName = "ListDirectoriesApiV1BetaDirectoriesGetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1Item), TypeInfoPropertyName = "ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item), TypeInfoPropertyName = "ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListSplitJobsApiV1BetaSplitJobsGetStatus), TypeInfoPropertyName = "ListSplitJobsApiV1BetaSplitJobsGetStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item), TypeInfoPropertyName = "ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<double?, string, object>?), TypeInfoPropertyName = "NullableAnyOfDoubleStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<int?, string, object>?), TypeInfoPropertyName = "NullableAnyOfInt32StringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AutoModeParsingConfTier?), TypeInfoPropertyName = "NullableAutoModeParsingConfTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.AutoModeParsingConfVersion?, string, object>?), TypeInfoPropertyName = "NullableAnyOfAutoModeParsingConfVersionStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AutoModeParsingConfVersion?), TypeInfoPropertyName = "NullableAutoModeParsingConfVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AutoModeParsingConfSpecializedChartParsing?), TypeInfoPropertyName = "NullableAutoModeParsingConfSpecializedChartParsing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BatchFileStatus?), TypeInfoPropertyName = "NullableBatchFileStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BatchJobStatus?), TypeInfoPropertyName = "NullableBatchJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.BatchParseJobRecordCreate, global::LlamaParse.ClassifyJob>?), TypeInfoPropertyName = "NullableAnyOfBatchParseJobRecordCreateClassifyJob2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BatchJobType?), TypeInfoPropertyName = "NullableBatchJobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BatchParseJobConfigPriority?), TypeInfoPropertyName = "NullableBatchParseJobConfigPriority2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParserLanguages?), TypeInfoPropertyName = "NullableParserLanguages2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.BatchParseJobConfigImagesToSaveVariant1Item?), TypeInfoPropertyName = "NullableBatchParseJobConfigImagesToSaveVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParsingMode?), TypeInfoPropertyName = "NullableParsingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.FailPageMode?), TypeInfoPropertyName = "NullableFailPageMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::System.Guid?, string>?), TypeInfoPropertyName = "NullableAnyOfGuidString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.StatusEnum?), TypeInfoPropertyName = "NullableStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ClassifyMode?), TypeInfoPropertyName = "NullableClassifyMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ConfigurableDataSinkNames?), TypeInfoPropertyName = "NullableConfigurableDataSinkNames2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.Parameters?), TypeInfoPropertyName = "NullableParameters2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ConfigurationCreateRequestParametersDiscriminatorProductType?), TypeInfoPropertyName = "NullableConfigurationCreateRequestParametersDiscriminatorProductType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ConfigurationResponseProductType?), TypeInfoPropertyName = "NullableConfigurationResponseProductType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.Parameters2?), TypeInfoPropertyName = "NullableParameters22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ConfigurationResponseParametersDiscriminatorProductType?), TypeInfoPropertyName = "NullableConfigurationResponseParametersDiscriminatorProductType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ConfigurationUpdateRequestParametersVariant1DiscriminatorProductType?), TypeInfoPropertyName = "NullableConfigurationUpdateRequestParametersVariant1DiscriminatorProductType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>?), TypeInfoPropertyName = "NullableAnyOfObjectIListObjectStringInt32DoubleBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DirectoryCreateRequestType?), TypeInfoPropertyName = "NullableDirectoryCreateRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DirectoryResponseType?), TypeInfoPropertyName = "NullableDirectoryResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.DocumentChunkMode?), TypeInfoPropertyName = "NullableDocumentChunkMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractConfigPriority?), TypeInfoPropertyName = "NullableExtractConfigPriority2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractTarget?), TypeInfoPropertyName = "NullableExtractTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractMode?), TypeInfoPropertyName = "NullableExtractMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PublicModelName?), TypeInfoPropertyName = "NullablePublicModelName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.ExtractModels?, string, object>?), TypeInfoPropertyName = "NullableAnyOfExtractModelsStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractModels?), TypeInfoPropertyName = "NullableExtractModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractV2ParametersTier?), TypeInfoPropertyName = "NullableExtractV2ParametersTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractV2ParametersExtractionTarget?), TypeInfoPropertyName = "NullableExtractV2ParametersExtractionTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ExtractV2ParametersParseTier?), TypeInfoPropertyName = "NullableExtractV2ParametersParseTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<double?, int?, string, global::System.DateTime?, object>?), TypeInfoPropertyName = "NullableAnyOfDoubleInt32StringDateTimeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseOutputOptionsImagesToSaveVariant1Item?), TypeInfoPropertyName = "NullableLlamaParseOutputOptionsImagesToSaveVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseOutputOptionsGranularBboxe?), TypeInfoPropertyName = "NullableLlamaParseOutputOptionsGranularBboxe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseProcessingOptionsSpecializedChartParsing?), TypeInfoPropertyName = "NullableLlamaParseProcessingOptionsSpecializedChartParsing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseProcessingOptionsForms?), TypeInfoPropertyName = "NullableLlamaParseProcessingOptionsForms2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.LlamaParseWebhookConfigurationWebhookOutputFormat?), TypeInfoPropertyName = "NullableLlamaParseWebhookConfigurationWebhookOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.MetadataValue?), TypeInfoPropertyName = "NullableMetadataValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.MetadataScalarValue?), TypeInfoPropertyName = "NullableMetadataScalarValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PGVectorDistanceMethod?), TypeInfoPropertyName = "NullablePGVectorDistanceMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PGVectorVectorType?), TypeInfoPropertyName = "NullablePGVectorVectorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParseV2ParametersTier?), TypeInfoPropertyName = "NullableParseV2ParametersTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<global::LlamaParse.ParseV2ParametersVersion?, string>?), TypeInfoPropertyName = "NullableAnyOfParseV2ParametersVersionString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ParseV2ParametersVersion?), TypeInfoPropertyName = "NullableParseV2ParametersVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.PipelineFileResponseStatus?), TypeInfoPropertyName = "NullablePipelineFileResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SplitStrategyAllowUncategorized?), TypeInfoPropertyName = "NullableSplitStrategyAllowUncategorized2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SpreadsheetV1ParametersTier?), TypeInfoPropertyName = "NullableSpreadsheetV1ParametersTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.SpreadsheetV1ParametersTableMergeSensitivity?), TypeInfoPropertyName = "NullableSpreadsheetV1ParametersTableMergeSensitivity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.UsageMetricEventType?), TypeInfoPropertyName = "NullableUsageMetricEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.UsageMetricAggregateResponseGroupByItem?), TypeInfoPropertyName = "NullableUsageMetricAggregateResponseGroupByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.WebhookConfigCreateRequestWebhookEventsVariant1Item?), TypeInfoPropertyName = "NullableWebhookConfigCreateRequestWebhookEventsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.WebhookConfigCreateRequestWebhookOutputFormat?), TypeInfoPropertyName = "NullableWebhookConfigCreateRequestWebhookOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.WebhookConfigResponseWebhookEventsVariant1Item?), TypeInfoPropertyName = "NullableWebhookConfigResponseWebhookEventsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.WebhookConfigResponseWebhookOutputFormat?), TypeInfoPropertyName = "NullableWebhookConfigResponseWebhookOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.WebhookConfigUpdateRequestWebhookEventsVariant1Item?), TypeInfoPropertyName = "NullableWebhookConfigUpdateRequestWebhookEventsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.WebhookConfigUpdateRequestWebhookOutputFormat?), TypeInfoPropertyName = "NullableWebhookConfigUpdateRequestWebhookOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item?), TypeInfoPropertyName = "NullableWebhookConfigurationWebhookEventsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem?), TypeInfoPropertyName = "NullableAggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetType?), TypeInfoPropertyName = "NullableListDirectoriesApiV1BetaDirectoriesGetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1Item?), TypeInfoPropertyName = "NullableListDirectoriesApiV1BetaDirectoriesGetTypesVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item?), TypeInfoPropertyName = "NullableListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListSplitJobsApiV1BetaSplitJobsGetStatus?), TypeInfoPropertyName = "NullableListSplitJobsApiV1BetaSplitJobsGetStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item?), TypeInfoPropertyName = "NullableListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.AggregateGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.AgentData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.WebhookConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.BatchItemDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.BatchJobResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ParserLanguages>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.BatchParseJobConfigImagesToSaveVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ClassifierRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ClassifyV2Rule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ConfigurationResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.DataSink>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LlamaParse.AnyOf<object, global::System.Collections.Generic.List<object>, string, int?, double?, bool?, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.DirectoryFileResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.DirectoryResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ExtractAgent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.FileAttachmentMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.FileV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.AnyOf<double?, int?, string, global::System.DateTime?, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ProcessingResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.LlamaParseOutputOptionsImagesToSaveVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.LlamaParseOutputOptionsGranularBboxe>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.AutoModeConfigurationEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.LlamaParseWebhookConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.PipelineFileResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.SplitCategory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.SplitJobResponseBeta>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.SplitSegmentResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.UsageMetricAggregateResponseGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.UsageMetricAggregateBucket>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.UsageMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.WebhookConfigCreateRequestWebhookEventsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.WebhookConfigResponseWebhookEventsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.WebhookConfigUpdateRequestWebhookEventsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LlamaParse.WebhookConfigResponse>))]
    internal sealed partial class BetaSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static BetaSourceGenerationContext Default { get; } = new(DefaultOptions);

        private BetaSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::LlamaParse.JsonConverters.ParametersJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.Parameters2JsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.ParametersVariant1JsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.MetadataScalarValueJsonConverter());
            options.Converters.Add(new global::LlamaParse.JsonConverters.MetadataValueJsonConverter());
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
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
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
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, double?, string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<int>, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, double?, global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<int?, double?>>>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<int?, double?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.ParseV2ParametersVersion?, string>());
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
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<global::LlamaParse.BatchParseJobRecordCreate, global::LlamaParse.ClassifyJob>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, int?, double?, object>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, int?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, int?, bool?, double?, global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?, bool?, double?>>>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.AnyOfJsonConverter<string, int?, bool?, double?>());
            options.Converters.Add(new global::LlamaParse.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::LlamaParse.AutoModeParsingConfTier)

                    || typeToConvert == typeof(global::LlamaParse.AutoModeParsingConfTier?)

                    || typeToConvert == typeof(global::LlamaParse.AutoModeParsingConfVersion)

                    || typeToConvert == typeof(global::LlamaParse.AutoModeParsingConfVersion?)

                    || typeToConvert == typeof(global::LlamaParse.AutoModeParsingConfSpecializedChartParsing)

                    || typeToConvert == typeof(global::LlamaParse.AutoModeParsingConfSpecializedChartParsing?)

                    || typeToConvert == typeof(global::LlamaParse.BatchFileStatus)

                    || typeToConvert == typeof(global::LlamaParse.BatchFileStatus?)

                    || typeToConvert == typeof(global::LlamaParse.BatchJobStatus)

                    || typeToConvert == typeof(global::LlamaParse.BatchJobStatus?)

                    || typeToConvert == typeof(global::LlamaParse.BatchJobType)

                    || typeToConvert == typeof(global::LlamaParse.BatchJobType?)

                    || typeToConvert == typeof(global::LlamaParse.BatchParseJobConfigPriority)

                    || typeToConvert == typeof(global::LlamaParse.BatchParseJobConfigPriority?)

                    || typeToConvert == typeof(global::LlamaParse.BatchParseJobConfigImagesToSaveVariant1Item)

                    || typeToConvert == typeof(global::LlamaParse.BatchParseJobConfigImagesToSaveVariant1Item?)

                    || typeToConvert == typeof(global::LlamaParse.ClassifyMode)

                    || typeToConvert == typeof(global::LlamaParse.ClassifyMode?)

                    || typeToConvert == typeof(global::LlamaParse.ConfigurableDataSinkNames)

                    || typeToConvert == typeof(global::LlamaParse.ConfigurableDataSinkNames?)

                    || typeToConvert == typeof(global::LlamaParse.ConfigurationCreateRequestParametersDiscriminatorProductType)

                    || typeToConvert == typeof(global::LlamaParse.ConfigurationCreateRequestParametersDiscriminatorProductType?)

                    || typeToConvert == typeof(global::LlamaParse.ConfigurationResponseProductType)

                    || typeToConvert == typeof(global::LlamaParse.ConfigurationResponseProductType?)

                    || typeToConvert == typeof(global::LlamaParse.ConfigurationResponseParametersDiscriminatorProductType)

                    || typeToConvert == typeof(global::LlamaParse.ConfigurationResponseParametersDiscriminatorProductType?)

                    || typeToConvert == typeof(global::LlamaParse.ConfigurationUpdateRequestParametersVariant1DiscriminatorProductType)

                    || typeToConvert == typeof(global::LlamaParse.ConfigurationUpdateRequestParametersVariant1DiscriminatorProductType?)

                    || typeToConvert == typeof(global::LlamaParse.DirectoryCreateRequestType)

                    || typeToConvert == typeof(global::LlamaParse.DirectoryCreateRequestType?)

                    || typeToConvert == typeof(global::LlamaParse.DirectoryResponseType)

                    || typeToConvert == typeof(global::LlamaParse.DirectoryResponseType?)

                    || typeToConvert == typeof(global::LlamaParse.DocumentChunkMode)

                    || typeToConvert == typeof(global::LlamaParse.DocumentChunkMode?)

                    || typeToConvert == typeof(global::LlamaParse.ExtractConfigPriority)

                    || typeToConvert == typeof(global::LlamaParse.ExtractConfigPriority?)

                    || typeToConvert == typeof(global::LlamaParse.ExtractMode)

                    || typeToConvert == typeof(global::LlamaParse.ExtractMode?)

                    || typeToConvert == typeof(global::LlamaParse.ExtractModels)

                    || typeToConvert == typeof(global::LlamaParse.ExtractModels?)

                    || typeToConvert == typeof(global::LlamaParse.ExtractTarget)

                    || typeToConvert == typeof(global::LlamaParse.ExtractTarget?)

                    || typeToConvert == typeof(global::LlamaParse.ExtractV2ParametersTier)

                    || typeToConvert == typeof(global::LlamaParse.ExtractV2ParametersTier?)

                    || typeToConvert == typeof(global::LlamaParse.ExtractV2ParametersExtractionTarget)

                    || typeToConvert == typeof(global::LlamaParse.ExtractV2ParametersExtractionTarget?)

                    || typeToConvert == typeof(global::LlamaParse.ExtractV2ParametersParseTier)

                    || typeToConvert == typeof(global::LlamaParse.ExtractV2ParametersParseTier?)

                    || typeToConvert == typeof(global::LlamaParse.FailPageMode)

                    || typeToConvert == typeof(global::LlamaParse.FailPageMode?)

                    || typeToConvert == typeof(global::LlamaParse.LlamaParseOutputOptionsImagesToSaveVariant1Item)

                    || typeToConvert == typeof(global::LlamaParse.LlamaParseOutputOptionsImagesToSaveVariant1Item?)

                    || typeToConvert == typeof(global::LlamaParse.LlamaParseOutputOptionsGranularBboxe)

                    || typeToConvert == typeof(global::LlamaParse.LlamaParseOutputOptionsGranularBboxe?)

                    || typeToConvert == typeof(global::LlamaParse.LlamaParseProcessingOptionsSpecializedChartParsing)

                    || typeToConvert == typeof(global::LlamaParse.LlamaParseProcessingOptionsSpecializedChartParsing?)

                    || typeToConvert == typeof(global::LlamaParse.LlamaParseProcessingOptionsForms)

                    || typeToConvert == typeof(global::LlamaParse.LlamaParseProcessingOptionsForms?)

                    || typeToConvert == typeof(global::LlamaParse.LlamaParseWebhookConfigurationWebhookOutputFormat)

                    || typeToConvert == typeof(global::LlamaParse.LlamaParseWebhookConfigurationWebhookOutputFormat?)

                    || typeToConvert == typeof(global::LlamaParse.PGVectorDistanceMethod)

                    || typeToConvert == typeof(global::LlamaParse.PGVectorDistanceMethod?)

                    || typeToConvert == typeof(global::LlamaParse.PGVectorVectorType)

                    || typeToConvert == typeof(global::LlamaParse.PGVectorVectorType?)

                    || typeToConvert == typeof(global::LlamaParse.ParseV2ParametersTier)

                    || typeToConvert == typeof(global::LlamaParse.ParseV2ParametersTier?)

                    || typeToConvert == typeof(global::LlamaParse.ParseV2ParametersVersion)

                    || typeToConvert == typeof(global::LlamaParse.ParseV2ParametersVersion?)

                    || typeToConvert == typeof(global::LlamaParse.ParserLanguages)

                    || typeToConvert == typeof(global::LlamaParse.ParserLanguages?)

                    || typeToConvert == typeof(global::LlamaParse.ParsingMode)

                    || typeToConvert == typeof(global::LlamaParse.ParsingMode?)

                    || typeToConvert == typeof(global::LlamaParse.PipelineFileResponseStatus)

                    || typeToConvert == typeof(global::LlamaParse.PipelineFileResponseStatus?)

                    || typeToConvert == typeof(global::LlamaParse.PublicModelName)

                    || typeToConvert == typeof(global::LlamaParse.PublicModelName?)

                    || typeToConvert == typeof(global::LlamaParse.SplitStrategyAllowUncategorized)

                    || typeToConvert == typeof(global::LlamaParse.SplitStrategyAllowUncategorized?)

                    || typeToConvert == typeof(global::LlamaParse.SpreadsheetV1ParametersTier)

                    || typeToConvert == typeof(global::LlamaParse.SpreadsheetV1ParametersTier?)

                    || typeToConvert == typeof(global::LlamaParse.SpreadsheetV1ParametersTableMergeSensitivity)

                    || typeToConvert == typeof(global::LlamaParse.SpreadsheetV1ParametersTableMergeSensitivity?)

                    || typeToConvert == typeof(global::LlamaParse.StatusEnum)

                    || typeToConvert == typeof(global::LlamaParse.StatusEnum?)

                    || typeToConvert == typeof(global::LlamaParse.UsageMetricEventType)

                    || typeToConvert == typeof(global::LlamaParse.UsageMetricEventType?)

                    || typeToConvert == typeof(global::LlamaParse.UsageMetricAggregateResponseGroupByItem)

                    || typeToConvert == typeof(global::LlamaParse.UsageMetricAggregateResponseGroupByItem?)

                    || typeToConvert == typeof(global::LlamaParse.WebhookConfigCreateRequestWebhookEventsVariant1Item)

                    || typeToConvert == typeof(global::LlamaParse.WebhookConfigCreateRequestWebhookEventsVariant1Item?)

                    || typeToConvert == typeof(global::LlamaParse.WebhookConfigCreateRequestWebhookOutputFormat)

                    || typeToConvert == typeof(global::LlamaParse.WebhookConfigCreateRequestWebhookOutputFormat?)

                    || typeToConvert == typeof(global::LlamaParse.WebhookConfigResponseWebhookEventsVariant1Item)

                    || typeToConvert == typeof(global::LlamaParse.WebhookConfigResponseWebhookEventsVariant1Item?)

                    || typeToConvert == typeof(global::LlamaParse.WebhookConfigResponseWebhookOutputFormat)

                    || typeToConvert == typeof(global::LlamaParse.WebhookConfigResponseWebhookOutputFormat?)

                    || typeToConvert == typeof(global::LlamaParse.WebhookConfigUpdateRequestWebhookEventsVariant1Item)

                    || typeToConvert == typeof(global::LlamaParse.WebhookConfigUpdateRequestWebhookEventsVariant1Item?)

                    || typeToConvert == typeof(global::LlamaParse.WebhookConfigUpdateRequestWebhookOutputFormat)

                    || typeToConvert == typeof(global::LlamaParse.WebhookConfigUpdateRequestWebhookOutputFormat?)

                    || typeToConvert == typeof(global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item)

                    || typeToConvert == typeof(global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item?)

                    || typeToConvert == typeof(global::LlamaParse.AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem)

                    || typeToConvert == typeof(global::LlamaParse.AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem?)

                    || typeToConvert == typeof(global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetType)

                    || typeToConvert == typeof(global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetType?)

                    || typeToConvert == typeof(global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1Item)

                    || typeToConvert == typeof(global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1Item?)

                    || typeToConvert == typeof(global::LlamaParse.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item)

                    || typeToConvert == typeof(global::LlamaParse.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item?)

                    || typeToConvert == typeof(global::LlamaParse.ListSplitJobsApiV1BetaSplitJobsGetStatus)

                    || typeToConvert == typeof(global::LlamaParse.ListSplitJobsApiV1BetaSplitJobsGetStatus?)

                    || typeToConvert == typeof(global::LlamaParse.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item)

                    || typeToConvert == typeof(global::LlamaParse.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::LlamaParse.AutoModeParsingConfTier))
                {
                    return new global::LlamaParse.JsonConverters.AutoModeParsingConfTierJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.AutoModeParsingConfTier?))
                {
                    return new global::LlamaParse.JsonConverters.AutoModeParsingConfTierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.AutoModeParsingConfVersion))
                {
                    return new global::LlamaParse.JsonConverters.AutoModeParsingConfVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.AutoModeParsingConfVersion?))
                {
                    return new global::LlamaParse.JsonConverters.AutoModeParsingConfVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.AutoModeParsingConfSpecializedChartParsing))
                {
                    return new global::LlamaParse.JsonConverters.AutoModeParsingConfSpecializedChartParsingJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.AutoModeParsingConfSpecializedChartParsing?))
                {
                    return new global::LlamaParse.JsonConverters.AutoModeParsingConfSpecializedChartParsingNullableJsonConverter();
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

                if (typeToConvert == typeof(global::LlamaParse.BatchParseJobConfigPriority))
                {
                    return new global::LlamaParse.JsonConverters.BatchParseJobConfigPriorityJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.BatchParseJobConfigPriority?))
                {
                    return new global::LlamaParse.JsonConverters.BatchParseJobConfigPriorityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.BatchParseJobConfigImagesToSaveVariant1Item))
                {
                    return new global::LlamaParse.JsonConverters.BatchParseJobConfigImagesToSaveVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.BatchParseJobConfigImagesToSaveVariant1Item?))
                {
                    return new global::LlamaParse.JsonConverters.BatchParseJobConfigImagesToSaveVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ClassifyMode))
                {
                    return new global::LlamaParse.JsonConverters.ClassifyModeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ClassifyMode?))
                {
                    return new global::LlamaParse.JsonConverters.ClassifyModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ConfigurableDataSinkNames))
                {
                    return new global::LlamaParse.JsonConverters.ConfigurableDataSinkNamesJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ConfigurableDataSinkNames?))
                {
                    return new global::LlamaParse.JsonConverters.ConfigurableDataSinkNamesNullableJsonConverter();
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

                if (typeToConvert == typeof(global::LlamaParse.DirectoryCreateRequestType))
                {
                    return new global::LlamaParse.JsonConverters.DirectoryCreateRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.DirectoryCreateRequestType?))
                {
                    return new global::LlamaParse.JsonConverters.DirectoryCreateRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.DirectoryResponseType))
                {
                    return new global::LlamaParse.JsonConverters.DirectoryResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.DirectoryResponseType?))
                {
                    return new global::LlamaParse.JsonConverters.DirectoryResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.DocumentChunkMode))
                {
                    return new global::LlamaParse.JsonConverters.DocumentChunkModeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.DocumentChunkMode?))
                {
                    return new global::LlamaParse.JsonConverters.DocumentChunkModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ExtractConfigPriority))
                {
                    return new global::LlamaParse.JsonConverters.ExtractConfigPriorityJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ExtractConfigPriority?))
                {
                    return new global::LlamaParse.JsonConverters.ExtractConfigPriorityNullableJsonConverter();
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

                if (typeToConvert == typeof(global::LlamaParse.ExtractV2ParametersParseTier))
                {
                    return new global::LlamaParse.JsonConverters.ExtractV2ParametersParseTierJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ExtractV2ParametersParseTier?))
                {
                    return new global::LlamaParse.JsonConverters.ExtractV2ParametersParseTierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.FailPageMode))
                {
                    return new global::LlamaParse.JsonConverters.FailPageModeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.FailPageMode?))
                {
                    return new global::LlamaParse.JsonConverters.FailPageModeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::LlamaParse.LlamaParseProcessingOptionsSpecializedChartParsing))
                {
                    return new global::LlamaParse.JsonConverters.LlamaParseProcessingOptionsSpecializedChartParsingJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.LlamaParseProcessingOptionsSpecializedChartParsing?))
                {
                    return new global::LlamaParse.JsonConverters.LlamaParseProcessingOptionsSpecializedChartParsingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.LlamaParseProcessingOptionsForms))
                {
                    return new global::LlamaParse.JsonConverters.LlamaParseProcessingOptionsFormsJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.LlamaParseProcessingOptionsForms?))
                {
                    return new global::LlamaParse.JsonConverters.LlamaParseProcessingOptionsFormsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.LlamaParseWebhookConfigurationWebhookOutputFormat))
                {
                    return new global::LlamaParse.JsonConverters.LlamaParseWebhookConfigurationWebhookOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.LlamaParseWebhookConfigurationWebhookOutputFormat?))
                {
                    return new global::LlamaParse.JsonConverters.LlamaParseWebhookConfigurationWebhookOutputFormatNullableJsonConverter();
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

                if (typeToConvert == typeof(global::LlamaParse.PipelineFileResponseStatus))
                {
                    return new global::LlamaParse.JsonConverters.PipelineFileResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.PipelineFileResponseStatus?))
                {
                    return new global::LlamaParse.JsonConverters.PipelineFileResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.PublicModelName))
                {
                    return new global::LlamaParse.JsonConverters.PublicModelNameJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.PublicModelName?))
                {
                    return new global::LlamaParse.JsonConverters.PublicModelNameNullableJsonConverter();
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

                if (typeToConvert == typeof(global::LlamaParse.WebhookConfigCreateRequestWebhookEventsVariant1Item))
                {
                    return new global::LlamaParse.JsonConverters.WebhookConfigCreateRequestWebhookEventsVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.WebhookConfigCreateRequestWebhookEventsVariant1Item?))
                {
                    return new global::LlamaParse.JsonConverters.WebhookConfigCreateRequestWebhookEventsVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.WebhookConfigCreateRequestWebhookOutputFormat))
                {
                    return new global::LlamaParse.JsonConverters.WebhookConfigCreateRequestWebhookOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.WebhookConfigCreateRequestWebhookOutputFormat?))
                {
                    return new global::LlamaParse.JsonConverters.WebhookConfigCreateRequestWebhookOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.WebhookConfigResponseWebhookEventsVariant1Item))
                {
                    return new global::LlamaParse.JsonConverters.WebhookConfigResponseWebhookEventsVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.WebhookConfigResponseWebhookEventsVariant1Item?))
                {
                    return new global::LlamaParse.JsonConverters.WebhookConfigResponseWebhookEventsVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.WebhookConfigResponseWebhookOutputFormat))
                {
                    return new global::LlamaParse.JsonConverters.WebhookConfigResponseWebhookOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.WebhookConfigResponseWebhookOutputFormat?))
                {
                    return new global::LlamaParse.JsonConverters.WebhookConfigResponseWebhookOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.WebhookConfigUpdateRequestWebhookEventsVariant1Item))
                {
                    return new global::LlamaParse.JsonConverters.WebhookConfigUpdateRequestWebhookEventsVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.WebhookConfigUpdateRequestWebhookEventsVariant1Item?))
                {
                    return new global::LlamaParse.JsonConverters.WebhookConfigUpdateRequestWebhookEventsVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.WebhookConfigUpdateRequestWebhookOutputFormat))
                {
                    return new global::LlamaParse.JsonConverters.WebhookConfigUpdateRequestWebhookOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.WebhookConfigUpdateRequestWebhookOutputFormat?))
                {
                    return new global::LlamaParse.JsonConverters.WebhookConfigUpdateRequestWebhookOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item))
                {
                    return new global::LlamaParse.JsonConverters.WebhookConfigurationWebhookEventsVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item?))
                {
                    return new global::LlamaParse.JsonConverters.WebhookConfigurationWebhookEventsVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem))
                {
                    return new global::LlamaParse.JsonConverters.AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItemJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem?))
                {
                    return new global::LlamaParse.JsonConverters.AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetType))
                {
                    return new global::LlamaParse.JsonConverters.ListDirectoriesApiV1BetaDirectoriesGetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetType?))
                {
                    return new global::LlamaParse.JsonConverters.ListDirectoriesApiV1BetaDirectoriesGetTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::LlamaParse.ListSplitJobsApiV1BetaSplitJobsGetStatus))
                {
                    return new global::LlamaParse.JsonConverters.ListSplitJobsApiV1BetaSplitJobsGetStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ListSplitJobsApiV1BetaSplitJobsGetStatus?))
                {
                    return new global::LlamaParse.JsonConverters.ListSplitJobsApiV1BetaSplitJobsGetStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item))
                {
                    return new global::LlamaParse.JsonConverters.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::LlamaParse.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item?))
                {
                    return new global::LlamaParse.JsonConverters.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1ItemNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

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
                    0 => new BetaSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}