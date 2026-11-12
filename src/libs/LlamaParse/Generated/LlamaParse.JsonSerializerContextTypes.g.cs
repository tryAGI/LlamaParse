
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace LlamaParse
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AdvancedModeTransformConfig? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.NoneSegmentationConfig, global::LlamaParse.PageSegmentationConfig, global::LlamaParse.ElementSegmentationConfig>? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.NoneSegmentationConfig? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PageSegmentationConfig? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ElementSegmentationConfig? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.NoneChunkingConfig, global::LlamaParse.CharacterChunkingConfig, global::LlamaParse.TokenChunkingConfig, global::LlamaParse.SentenceChunkingConfig, global::LlamaParse.SemanticChunkingConfig>? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.NoneChunkingConfig? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CharacterChunkingConfig? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.TokenChunkingConfig? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SentenceChunkingConfig? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SemanticChunkingConfig? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AgentData? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AgentDataAggregateResponse? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AggregateGroup>? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AggregateGroup? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AgentDataCreate? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AgentDataSearchResponse? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AgentData>? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AgentDataUpdate? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AggregateRequest? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LlamaParse.FilterOperation>? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FilterOperation? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AttachmentRef? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AutoModeConfigurationEntry? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AutoModeParsingConf? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<double?, string>? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<int?, string>? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AutoModeConfigurationEntryMinComplexity? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AutoModeCropBox? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AutoModeIgnoreOptions? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AutoModeParsingConfTier? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.AutoModeParsingConfVersion?, string>? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AutoModeParsingConfVersion? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AutoModeParsingConfSpecializedChartParsing? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AutoModeSpatialTextOptions? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AutoModePresentationOptions? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AutoTransformConfig? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AzureOpenAIEmbedding? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AzureOpenAIEmbeddingConfig? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BBox? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchConfiguration? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchJobConfig? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchCreateRequest? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfiguration>? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfiguration? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchFileStatus? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchItemDetail? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchItemListResponse? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.BatchItemDetail>? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchJobCancelRequest? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchJobCancelResponse? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchJobStatus? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchJobCreateRequest? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.BatchParseJobRecordCreate, global::LlamaParse.ClassifyJob>? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchParseJobRecordCreate? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyJob? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchJobQueryResponse? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.BatchJobResponse>? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchJobResponse? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchJobReference? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchJobType? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchJobStatusResponse? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchParseJobConfig? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchParseJobConfigPriority? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ParserLanguages>? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParserLanguages? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.BatchParseJobConfigImagesToSaveVariant1Item>? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchParseJobConfigImagesToSaveVariant1Item? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParsingMode? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FailPageMode? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::System.Guid?, string>? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchQueryResponse? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.BatchResponse>? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchResponse? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<string, global::System.Guid?>? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchResponseStatus? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.BatchResult>? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchResult? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BedrockEmbedding? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BedrockEmbeddingConfig? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BodyImportPipelineMetadataApiV1PipelinesPipelineIdMetadataPut? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BodyRunJobOnFileApiV1ExtractionJobsFilePost? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BodyScreenshotApiV1ParsingScreenshotPost? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BodyUploadFileApiV1BetaFilesPost? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BodyUploadFileApiV1ParsingUploadPost? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BodyUploadFileToDirectoryApiV1BetaDirectoriesDirectoryIdFilesUploadPost? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BoxAuthMechanism? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ChatData? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PresetRetrievalParams? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LLMParameters? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ChatInputParams? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.InputMessage>? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.InputMessage? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ChatMessage? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.MessageAnnotation>? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MessageAnnotation? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MessageRole? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ChatParams? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ChatSessionSummary? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.JobMetadata? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ChatSessionSummarySharedAccess? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifierRule? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StatusEnum? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ClassifierRule>? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyMode? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyParsingConfiguration? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyUsage? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyV2Configuration? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ClassifyV2Rule>? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyV2Rule? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyV2ParsingConfiguration? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyV2JobCreateRequest? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyV2JobDeleteResponse? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyV2JobQueryResponse? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ClassifyV2JobResponse>? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyV2JobResponse? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyV2JobResponseStatus? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyV2JobResponseDocumentInputType? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyV2Result? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyV2Parameters? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudAstraDBVectorStore? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudAzStorageBlobDataSource? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudAzureAISearchVectorStore? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudBoxDataSource? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudConfluenceDataSource? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FailureHandlingConfig? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudDocument? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudDocumentCreate? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudGoogleDriveDataSource? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudJiraDataSource? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudJiraDataSourceV2? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudJiraDataSourceV2ApiVersion? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudMilvusVectorStore? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudMongoDBAtlasVectorSearch? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudNotionPageDataSource? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudOneDriveDataSource? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudPineconeVectorStore? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudPostgresVectorStore? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PGVectorHNSWSettings? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudQdrantVectorStore? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudS3DataSource? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudSharepointDataSource? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudSlackDataSource? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CodeItem? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.BBox>? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CohereEmbedding? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CohereEmbeddingConfig? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CompositeRetrievalMode? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CompositeRetrievalParams? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ReRankConfig? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CompositeRetrievalResult? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.CompositeRetrievedTextNodeWithScore>? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CompositeRetrievedTextNodeWithScore? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PageScreenshotNodeWithScore>? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PageScreenshotNodeWithScore? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PageFigureNodeWithScore>? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PageFigureNodeWithScore? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CompositeRetrievedTextNode? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurableDataSinkNames? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurableDataSourceNames? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurationCreateRequest? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Parameters? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitV1Parameters? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2Parameters? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseV2Parameters? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SpreadsheetV1Parameters? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.UntypedParameters? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurationCreateRequestParametersDiscriminator? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurationCreateRequestParametersDiscriminatorProductType? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurationQueryResponse? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ConfigurationResponse>? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurationResponse? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurationResponseProductType? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Parameters2? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurationResponseParametersDiscriminator? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurationResponseParametersDiscriminatorProductType? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurationUpdateRequest? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParametersVariant1? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurationUpdateRequestParametersVariant1Discriminator? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurationUpdateRequestParametersVariant1DiscriminatorProductType? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DataSink? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DataSinkCreate? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DataSinkQueryResponse? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.DataSink>? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DataSinkUpdate? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DataSource? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DataSourceReaderVersionMetadata? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DataSourceCreate? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DataSourceReaderVersionMetadataReaderVersion? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DataSourceSyncRequest? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DataSourceUpdate? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DeleteRequest? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DeleteResponse? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectRetrievalParams? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.RetrieverPipeline>? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrieverPipeline? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryConflictDetail? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryConflictResponse? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryCreateRequest? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryCreateRequestType? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryFileBulkDeleteRequest? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryFileCreateRequest? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LlamaParse.MetadataValue>? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryFileQueryResponse? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.DirectoryFileResponse>? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryFileResponse? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PresignedUrl? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryFileUpdateRequest? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryQueryResponse? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.DirectoryResponse>? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryResponse? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryResponseType? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryUpdateRequest? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DocumentChunkMode? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DocumentCountByStatusResponse? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingModelConfig? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingConfig? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.GeminiEmbeddingConfig? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.HuggingFaceInferenceAPIEmbeddingConfig? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.OpenAIEmbeddingConfig? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VertexAIEmbeddingConfig? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingModelConfigEmbeddingConfigDiscriminator? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingModelConfigEmbeddingConfigDiscriminatorType? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingModelConfigCreate? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingConfig2? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingModelConfigCreateEmbeddingConfigDiscriminator? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingModelConfigUpdate? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingConfigVariant1? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingModelConfigUpdateEmbeddingConfigVariant1Discriminator? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorType? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractAgent? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractConfig? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractAgentCreate? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<object, string>? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractAgentQueryResponse? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ExtractAgent>? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractAgentUpdate? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractConfigPriority? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractTarget? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractMode? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PublicModelName? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.ExtractModels?, string>? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractModels? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractConfiguration? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractConfigurationTier? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractConfigurationExtractionTarget? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractConfigurationParseTier? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractJob? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractJobStatus? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.File? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractJobCreate? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractJobCreatePriority? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractJobCreateBatch? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractJobMetadata? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractedFieldMetadata? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractJobUsage? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractResultset? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<object, global::System.Collections.Generic.IList<object>>? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractReviewApproveRequest? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractReviewCreateRequest? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractReviewCreatedDetail? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractReviewCreatedDetailOrigin? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractReviewEvent? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractReviewEventKind? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.ExtractReviewCreatedDetail, global::LlamaParse.ExtractReviewRejectedDetail, global::LlamaParse.ExtractReviewSignedOffDetail>? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractReviewRejectedDetail? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractReviewSignedOffDetail? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractReviewEventListResponse? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ExtractReviewEvent>? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractReviewFieldAction? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractReviewFieldActionAction? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractReviewFieldChange? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractReviewFieldChangeChange? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractReviewFieldsRequest? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ExtractReviewFieldChange>? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractReviewFlag? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractReviewFlagReason? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractReviewFlagCell? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractReviewRejectRequest? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractReviewResponse? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractReviewResponseStatus? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LlamaParse.ExtractReviewFieldAction>? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ExtractReviewFlag>? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractReviewRevisionRequest? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractRun? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractState? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractSchemaGenerateRequest? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractSchemaGenerateResponse? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractSchemaValidateRequest? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractSchemaValidateResponse? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractStatelessRequest? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileData? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractUsage? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2Job? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2JobMetadata? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2JobCreate? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2JobQueryResponse? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ExtractV2Job>? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2ParametersTier? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2ParametersExtractionTarget? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2ParametersParseTier? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2SchemaGenerateRequest? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2SchemaValidateRequest? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2SchemaValidateResponse? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FailedFormsPage? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FailedMarkdownPage? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FailedStructuredPage? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileAttachmentListResponse? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.FileAttachmentMetadata>? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileAttachmentMetadata? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileCountByStatusResponse? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileFilter? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileFindEntry? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileFindParams? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileFindResult? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.FileFindEntry>? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileGrepMatch? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileGrepParams? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileGrepResult? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.FileGrepMatch>? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileQueryRequest? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileQueryResponseV2? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.FileV2>? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileV2? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileReadParams? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileReadResult? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FilterCondition? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<double?, int?, string, global::System.DateTime?>? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<double?, int?, string, global::System.DateTime?>?>? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FilterOperator? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FooterItem? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ItemsItem>? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ItemsItem? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.TextItem? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.HeadingItem? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListItem? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.TableItem? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ImageItem? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LinkItem? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FooterItemItemDiscriminator? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FooterItemItemDiscriminatorType? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Form? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.JsonItem>? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.JsonItem? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormSection? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormField? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormTable? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormText? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormJsonItemDiscriminator? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormJsonItemDiscriminatorType? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormListItem? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormFieldGrounding? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormFieldField? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<string, bool?>? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ValueItemsVariant1Item>? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ValueItemsVariant1Item? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormFieldValueItemsVariant1ItemDiscriminator? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormFieldValueItemsVariant1ItemDiscriminatorType? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormTextGrounding? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.FormListTextItem, global::LlamaParse.FormListItem>>? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.FormListTextItem, global::LlamaParse.FormListItem>? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormListTextItem? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormSectionGrounding? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ItemsItem3>? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ItemsItem3? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormSectionItemDiscriminator? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormSectionItemDiscriminatorType? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormTableGrounding? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, global::LlamaParse.FormTableCellItems>?>>? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, global::LlamaParse.FormTableCellItems>?>? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<string, global::LlamaParse.FormTableCellItems>? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormTableCellItems? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ItemsItem4>? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ItemsItem4? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormTableCellItemsItemDiscriminator? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormTableCellItemsItemDiscriminatorType? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.FormTextGrounding>? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::LlamaParse.FormTextGrounding>>? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.GroundedLine>? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.GroundedLine? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormsResult? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.FormsResultPage, global::LlamaParse.FailedFormsPage>>? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.FormsResultPage, global::LlamaParse.FailedFormsPage>? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormsResultPage? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.Form>? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.GeminiEmbedding? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.GroundedChar? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<long>? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.GroundedWord>? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.GroundedWord? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.GroundedChar>? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.HTTPValidationError? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ValidationError>? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ValidationError? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.HeaderItem? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ItemsItem5>? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ItemsItem5? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.HeaderItemItemDiscriminator? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.HeaderItemItemDiscriminatorType? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.HuggingFaceInferenceAPIEmbedding? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Pooling? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ImageAttachmentRef? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ImageMetadata? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ImageMetadataCategory? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ImageMetadataBBox? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ImagesContentMetadata? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ImageMetadata>? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.IndexCreateRequest? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.IndexProductEntry>? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.IndexProductEntry? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.IndexCreateRequestVectorTarget? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.IndexMetadata? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.IndexQueryResponse? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.IndexResponse>? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.IndexResponse? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.IngestionErrorResponse? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.JobNameMapping? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ItemProcessingResultsResponse? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ProcessingResult>? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ProcessingResult? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.JobUsage? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SupportedLLMModelNames? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.TextItem, global::LlamaParse.ListItem>>? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.TextItem, global::LlamaParse.ListItem>? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseAgenticOptions? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseCostOptimizerParameters? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseCropBox? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseFastOptions? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseHtmlOptions? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseIgnoreOptions? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseImageOptions? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseInputOptions? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParsePdfOptions? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseSpreadsheetOptions? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParsePresentationOptions? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseJobFailureConditions? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseMarkdownOptions? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseTables? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseOcrParameters? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseOutputOptions? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseSpatialTextOptions? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseTablesAsSpreadsheetOptions? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseOutputOptionsWatermarkHandling? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.LlamaParseOutputOptionsImagesToSaveVariant1Item>? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseOutputOptionsImagesToSaveVariant1Item? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.LlamaParseOutputOptionsGranularBboxe>? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseOutputOptionsGranularBboxe? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParsePageRanges? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseParameters? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.StoredWebhookConfiguration>? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StoredWebhookConfiguration? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseParametersPriority? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.LlamaParseParametersImagesToSaveVariant1Item>? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseParametersImagesToSaveVariant1Item? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseProcessingControl? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseTimeouts? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseProcessingOptions? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseProcessingOptionsSpecializedChartParsing? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AutoModeConfigurationEntry>? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseProcessingOptionsForms? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseSupportedFileExtensions? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseWebhookConfiguration? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseWebhookConfigurationWebhookOutputFormat? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ManagedIngestionStatus? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ManagedIngestionStatusResponse? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.IngestionErrorResponse>? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ManagedOpenAIEmbedding? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ManagedOpenAIEmbeddingConfig? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MarkdownLineNumberAnnotation? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MarkdownResult? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.MarkdownResultPage, global::LlamaParse.FailedMarkdownPage>>? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.MarkdownResultPage, global::LlamaParse.FailedMarkdownPage>? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MarkdownResultPage? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.MarkdownLineNumberAnnotation>? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MetadataValue? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MetadataFilter? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<int?, double?, string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<int>>? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MetadataFilters? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.MetadataFilter, global::LlamaParse.MetadataFilters>>? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.MetadataFilter, global::LlamaParse.MetadataFilters>? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MetadataResult? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.MetadataResultPage>? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MetadataResultPage? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MetadataResultDocument? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MetadataResultDocumentConfidenceBreakdown? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MetadataScalarValue? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MongoStaticFilters? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StringFilter? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.NodeRelationship? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.NumericRangeFilter? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.NumericRangeFilterOperator? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<int?, double?, global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<int?, double?>>>? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<int?, double?>>? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<int?, double?>? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ObjectType? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.OpenAIEmbedding? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Organization? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParsePlanLevel? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.OrganizationQueryResponse? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.OrganizationResponse>? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.OrganizationResponse? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PGVectorDistanceMethod? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PGVectorVectorType? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PageFigureMetadata? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PageScreenshotMetadata? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PaginatedExtractRunsResponse? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ExtractRun>? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PaginatedListCloudDocumentsResponse? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.CloudDocument>? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PaginatedListPipelineFilesResponse? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PipelineFile>? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineFile? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseConcernItem? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseJobDeleteConflictDetail? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseJobDeleteConflictDetailReason? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseJobDeleteConflictResponse? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseJobDeleteResponse? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseJobQueryResponse? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ParseJobResponse>? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseJobResponse? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseJobResponseStatus? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseLatestVersions? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseRequestConfiguration? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.ParseRequestConfigurationTier?, string>? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseRequestConfigurationTier? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.ParseRequestConfigurationVersion?, string>? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseRequestConfigurationVersion? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.LlamaParseWebhookConfiguration>? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseResultResponse? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LlamaParse.ResultTypeMetadata>? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ResultTypeMetadata? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.TextResult? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StructuredResult? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseV2ParametersTier? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.ParseV2ParametersVersion?, string>? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseV2ParametersVersion? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.StoredParseWebhookConfiguration>? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StoredParseWebhookConfiguration? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseVersionsResponse? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ParseVersionsResponseFastItem>? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseVersionsResponseFastItem? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ParseVersionsResponseCostEffectiveItem>? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseVersionsResponseCostEffectiveItem? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ParseVersionsResponseAgenticItem>? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseVersionsResponseAgenticItem? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ParseVersionsResponseAgenticPlu>? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseVersionsResponseAgenticPlu? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParsingJob? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParsingJobJsonResult? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParsingJobMarkdownResult? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParsingJobStructuredResult? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParsingJobTextResult? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PartitionNames? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Pipeline? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineType? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SparseModelConfig? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineConfigurationHashes? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.AutoTransformConfig, global::LlamaParse.AdvancedModeTransformConfig>? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineStatus? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineMetadataConfig? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingConfig3? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineEmbeddingConfigDiscriminator? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineEmbeddingConfigDiscriminatorType? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineCreate? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingConfigVariant12? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineCreateEmbeddingConfigVariant1Discriminator? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineCreateEmbeddingConfigVariant1DiscriminatorType? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineDataSource? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineDataSourceStatus? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineDataSourceCreate? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineDataSourceUpdate? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineFileStatus? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineFileCreate? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineFileListResponse? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PipelineFileResponse>? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineFileResponse? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineFileResponseStatus? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineFileUpdate? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineListItem? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineListItemStatus? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingConfigVariant13? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineListItemEmbeddingConfigVariant1Discriminator? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineListItemEmbeddingConfigVariant1DiscriminatorType? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineQueryResponse? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PipelineResponse>? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineResponse? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineResponsePipelineType? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineResponseStatus? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineUpdate? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingConfigVariant14? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineUpdateEmbeddingConfigVariant1Discriminator? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineUpdateEmbeddingConfigVariant1DiscriminatorType? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PlaygroundSession? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ChatMessage>? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrievalMode? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ProcessingResultMetadata? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Project? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ProjectQueryResponse? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ProjectResponse>? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ProjectResponse? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ReRankerType? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RelatedNodeInfo? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.ObjectType?, string>? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RerankConfig2? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrievalParams? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrievalResult? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StaticFields? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrieveParams? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.ValueFilter, global::System.Collections.Generic.IList<global::LlamaParse.NumericRangeFilter>>? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ValueFilter? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.NumericRangeFilter>? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrieveResult? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.RetrievalResult>? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrieveResults? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.TextNodeWithScore>? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.TextNodeWithScore? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Retriever? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrieverCreate? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrieverQueryResponse? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.Retriever>? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrieverUpdate? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Revision? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RevisionType? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RevisionBBox? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.RevisionTargetSpan>? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RevisionTargetSpan? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SearchRequest? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SessionCreate? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SessionCreateSharedAccess? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SessionDetail? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SessionDetailSharedAccess? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.EventsItem>? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EventsItem? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ThinkingDeltaEvent? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.TextDeltaEvent? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ThinkingEvent? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.TextEvent? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ToolCallEvent? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ToolResultEvent? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StopEvent? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.UserInputEvent? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SessionDetailEventDiscriminator? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SessionDetailEventDiscriminatorType? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SessionList? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ChatSessionSummary>? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SparseModelType? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitCategory? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitConfiguration? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.SplitCategory>? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitStrategy? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitConfigurationParseTier? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitConfigurationBeta? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitCreateRequest? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitCreateRequestBeta? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitDocumentInput? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitJobQueryResponse? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.SplitJobResponse>? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitJobResponse? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitJobQueryResponseBeta? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.SplitJobResponseBeta>? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitJobResponseBeta? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitJobResponseDocumentInputType? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitResultResponse? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.SplitSegmentResponse>? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitSegmentResponse? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitStrategyAllowUncategorized? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitV1ParametersParseTier? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SpreadsheetV1ParametersTier? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SpreadsheetV1ParametersTableMergeSensitivity? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AttachmentRef>? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Usage? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StoredParseWebhookConfigurationWebhookOutputFormat? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.StoredWebhookConfigurationWebhookEventsVariant1Item>? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StoredWebhookConfigurationWebhookEventsVariant1Item? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StringFilterOperator? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.StructuredResultPage, global::LlamaParse.FailedStructuredPage>>? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.StructuredResultPage, global::LlamaParse.FailedStructuredPage>? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StructuredResultPage? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ItemsItem7>? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ItemsItem7? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StructuredResultPageItemDiscriminator? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StructuredResultPageItemDiscriminatorType? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.Revision>? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?, double?>?>>? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?, double?>?>? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<string, int?, double?>? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ParseConcernItem>? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.TextNode? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.RelatedNodeInfo, global::System.Collections.Generic.IList<global::LlamaParse.RelatedNodeInfo>>? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.RelatedNodeInfo>? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.TextResultPage>? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.TextResultPage? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.UsageMetric? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.UsageMetricEventType? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.UsageMetricAggregateBucket? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.UsageMetricAggregateResponse? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.UsageMetricAggregateResponseGroupByItem>? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.UsageMetricAggregateResponseGroupByItem? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.UsageMetricAggregateBucket>? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.UsageMetricQueryResponse? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.UsageMetric>? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?>>? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<string, int?>? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ValueFilterOperator? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<string, int?, bool?, double?, global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?, bool?, double?>>>? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?, bool?, double?>>? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<string, int?, bool?, double?>? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VerifyCompositeScore? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VerifyCompositeScores? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VerifyConfiguration? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VerifyConfigurationTier? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VerifyDegradedTool? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VerifyEvidence? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VerifyHeatmap? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VerifyJobDetailsResponse? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.VerifyRegion>? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VerifyRegion? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.VerifyEvidence>? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.VerifyDegradedTool>? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.VerifyHeatmap>? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.VerifyPageDimension>? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VerifyPageDimension? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VerifyJobQueryResponse? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.VerifyJobResponse>? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VerifyJobResponse? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VerifyJobResponseStatus? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VerifyJobResponseDocumentInputType? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VerifyResult? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VerifyRequest? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VerifyResultVerdict? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.VerifySuspectRegion>? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VerifySuspectRegion? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VertexTextEmbedding? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VertexEmbeddingMode? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigCreateRequest? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigCreateRequestWebhookEventsVariant1Item>? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigCreateRequestWebhookEventsVariant1Item? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigCreateRequestWebhookOutputFormat? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigQueryResponse? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigResponse>? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigResponse? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigResponseTenantType? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigResponseWebhookEventsVariant1Item>? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigResponseWebhookEventsVariant1Item? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigResponseWebhookOutputFormat? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigUpdateRequest? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigUpdateRequestWebhookEventsVariant1Item>? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigUpdateRequestWebhookEventsVariant1Item? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigUpdateRequestWebhookOutputFormat? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item>? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PipelineDataSourceCreate>? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PipelineFileCreate>? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.CloudDocumentCreate>? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item>? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetStatusRefreshPolicy? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PaginatedListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsPaginatedGetStatusRefreshPolicy? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListSplitJobsApiV1SplitJobsGetStatus? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem>? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetType? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1Item>? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1Item? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item>? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CreateWebhookConfigApiV1BetaWebhookConfigsPostTenantType? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListWebhookConfigsApiV1BetaWebhookConfigsGetTenantType? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.GetWebhookConfigApiV1BetaWebhookConfigsConfigIdGetTenantType? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.UpdateWebhookConfigApiV1BetaWebhookConfigsConfigIdPutTenantType? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DeleteWebhookConfigApiV1BetaWebhookConfigsConfigIdDeleteTenantType? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListSplitJobsApiV1BetaSplitJobsGetStatus? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item>? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListParseJobsApiV2ParseGetStatus? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListClassifyJobsApiV2ClassifyGetStatus? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListExtractJobsApiV2ExtractGetStatus? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListExtractJobsApiV2ExtractGetReviewStatus? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CreateExtractReviewApiV2ExtractJobIdReviewPostOrigin? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListPipelinesApiV2PipelinesGetPipelineType? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.QueryWebhookConfigsApiV2WebhookConfigsGetTenantType? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListBatchesApiV2BatchesGetStatus? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListVerifyJobsApiAlphaVerifyGetStatus? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.DataSource>? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.EmbeddingModelConfig>? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.Organization>? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.Project>? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PageScreenshotMetadata>? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PageFigureMetadata>? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PipelineListItem>? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PipelineDataSource>? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.TextNode>? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.LlamaParseSupportedFileExtensions>? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ExtractJob>? Type813 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AggregateGroup>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AgentData>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.WebhookConfiguration>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.BatchItemDetail>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.BatchJobResponse>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ParserLanguages>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.BatchParseJobConfigImagesToSaveVariant1Item>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.BatchResponse>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.BatchResult>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.InputMessage>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.MessageAnnotation>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ClassifierRule>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ClassifyV2Rule>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ClassifyV2JobResponse>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.BBox>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.CompositeRetrievedTextNodeWithScore>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.PageScreenshotNodeWithScore>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.PageFigureNodeWithScore>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ConfigurationResponse>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.DataSink>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<object, global::System.Collections.Generic.List<object>, string, int?, double?, bool?>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Guid>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.RetrieverPipeline>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.DirectoryFileResponse>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.DirectoryResponse>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ExtractAgent>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<object, global::System.Collections.Generic.List<object>>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ExtractReviewEvent>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ExtractReviewFieldChange>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ExtractReviewFlag>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ExtractV2Job>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.FileAttachmentMetadata>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.FileFindEntry>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.FileGrepMatch>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.FileV2>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<double?, int?, string, global::System.DateTime?>?>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ItemsItem>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.JsonItem>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ValueItemsVariant1Item>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<global::LlamaParse.FormListTextItem, global::LlamaParse.FormListItem>>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ItemsItem3>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::LlamaParse.AnyOf<string, global::LlamaParse.FormTableCellItems>?>>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<string, global::LlamaParse.FormTableCellItems>?>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ItemsItem4>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.FormTextGrounding>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::LlamaParse.FormTextGrounding>>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.GroundedLine>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<global::LlamaParse.FormsResultPage, global::LlamaParse.FailedFormsPage>>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.Form>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<long>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.GroundedWord>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.GroundedChar>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ValidationError>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ItemsItem5>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ImageMetadata>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.IndexProductEntry>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.IndexResponse>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ProcessingResult>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<global::LlamaParse.TextItem, global::LlamaParse.ListItem>>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.LlamaParseOutputOptionsImagesToSaveVariant1Item>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.LlamaParseOutputOptionsGranularBboxe>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.StoredWebhookConfiguration>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.LlamaParseParametersImagesToSaveVariant1Item>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AutoModeConfigurationEntry>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.IngestionErrorResponse>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<global::LlamaParse.MarkdownResultPage, global::LlamaParse.FailedMarkdownPage>>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.MarkdownLineNumberAnnotation>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<int?, double?, string, global::System.Collections.Generic.List<string>, global::System.Collections.Generic.List<double>, global::System.Collections.Generic.List<int>>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<global::LlamaParse.MetadataFilter, global::LlamaParse.MetadataFilters>>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.MetadataResultPage>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<int?, double?, global::System.Collections.Generic.List<global::LlamaParse.AnyOf<int?, double?>>>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<int?, double?>>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.OrganizationResponse>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ExtractRun>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.CloudDocument>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.PipelineFile>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ParseJobResponse>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.LlamaParseWebhookConfiguration>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.StoredParseWebhookConfiguration>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ParseVersionsResponseFastItem>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ParseVersionsResponseCostEffectiveItem>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ParseVersionsResponseAgenticItem>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ParseVersionsResponseAgenticPlu>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.PipelineFileResponse>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.PipelineResponse>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ChatMessage>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ProjectResponse>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.ValueFilter, global::System.Collections.Generic.List<global::LlamaParse.NumericRangeFilter>>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.NumericRangeFilter>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.RetrievalResult>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.TextNodeWithScore>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.Retriever>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.RevisionTargetSpan>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.EventsItem>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ChatSessionSummary>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.SplitCategory>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.SplitJobResponse>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.SplitJobResponseBeta>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.SplitSegmentResponse>? ListType102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AttachmentRef>? ListType103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.StoredWebhookConfigurationWebhookEventsVariant1Item>? ListType104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<string, global::System.Collections.Generic.List<string>>? ListType105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<global::LlamaParse.StructuredResultPage, global::LlamaParse.FailedStructuredPage>>? ListType106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ItemsItem7>? ListType107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.Revision>? ListType108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::LlamaParse.AnyOf<string, int?, double?>?>>? ListType109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<string, int?, double?>?>? ListType110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ParseConcernItem>? ListType111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.RelatedNodeInfo, global::System.Collections.Generic.List<global::LlamaParse.RelatedNodeInfo>>? ListType112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.RelatedNodeInfo>? ListType113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.TextResultPage>? ListType114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.UsageMetricAggregateResponseGroupByItem>? ListType115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.UsageMetricAggregateBucket>? ListType116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.UsageMetric>? ListType117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<string, int?>>? ListType118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<string, int?, bool?, double?, global::System.Collections.Generic.List<global::LlamaParse.AnyOf<string, int?, bool?, double?>>>? ListType119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<string, int?, bool?, double?>>? ListType120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.VerifyRegion>? ListType121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.VerifyEvidence>? ListType122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.VerifyDegradedTool>? ListType123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.VerifyHeatmap>? ListType124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.VerifyPageDimension>? ListType125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.VerifyJobResponse>? ListType126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.VerifySuspectRegion>? ListType127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.WebhookConfigCreateRequestWebhookEventsVariant1Item>? ListType128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.WebhookConfigResponse>? ListType129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.WebhookConfigResponseWebhookEventsVariant1Item>? ListType130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.WebhookConfigUpdateRequestWebhookEventsVariant1Item>? ListType131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item>? ListType132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.PipelineDataSourceCreate>? ListType133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.PipelineFileCreate>? ListType134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.CloudDocumentCreate>? ListType135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item>? ListType136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem>? ListType137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1Item>? ListType138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item>? ListType139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item>? ListType140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.DataSource>? ListType141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.EmbeddingModelConfig>? ListType142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.Organization>? ListType143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.Project>? ListType144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.PageScreenshotMetadata>? ListType145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.PageFigureMetadata>? ListType146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.PipelineListItem>? ListType147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.PipelineDataSource>? ListType148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.TextNode>? ListType149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.LlamaParseSupportedFileExtensions>? ListType150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ExtractJob>? ListType151 { get; set; }
    }
}