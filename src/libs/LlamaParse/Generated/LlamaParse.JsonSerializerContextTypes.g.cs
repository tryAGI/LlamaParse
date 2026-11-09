
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
        public global::LlamaParse.AutoModeCropBox? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AutoModeIgnoreOptions? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AutoModeParsingConfTier? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.AutoModeParsingConfVersion?, string>? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AutoModeParsingConfVersion? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AutoModeParsingConfSpecializedChartParsing? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AutoModeSpatialTextOptions? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AutoModePresentationOptions? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AutoTransformConfig? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AzureOpenAIEmbedding? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AzureOpenAIEmbeddingConfig? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BBox? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchConfiguration? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchJobConfig? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchCreateRequest? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfiguration>? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfiguration? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchFileStatus? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchItemDetail? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchItemListResponse? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.BatchItemDetail>? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchJobCancelRequest? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchJobCancelResponse? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchJobStatus? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchJobCreateRequest? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.BatchParseJobRecordCreate, global::LlamaParse.ClassifyJob>? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchParseJobRecordCreate? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyJob? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchJobQueryResponse? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.BatchJobResponse>? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchJobResponse? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchJobReference? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchJobType? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchJobStatusResponse? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchParseJobConfig? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchParseJobConfigPriority? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ParserLanguages>? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParserLanguages? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.BatchParseJobConfigImagesToSaveVariant1Item>? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchParseJobConfigImagesToSaveVariant1Item? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParsingMode? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FailPageMode? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::System.Guid?, string>? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchQueryResponse? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.BatchResponse>? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchResponse? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<string, global::System.Guid?>? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchResponseStatus? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.BatchResult>? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BatchResult? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BedrockEmbedding? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BedrockEmbeddingConfig? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BodyImportPipelineMetadataApiV1PipelinesPipelineIdMetadataPut? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BodyRunJobOnFileApiV1ExtractionJobsFilePost? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BodyScreenshotApiV1ParsingScreenshotPost? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BodyUploadFileApiV1BetaFilesPost? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BodyUploadFileApiV1ParsingUploadPost? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BodyUploadFileToDirectoryApiV1BetaDirectoriesDirectoryIdFilesUploadPost? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.BoxAuthMechanism? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ChatData? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PresetRetrievalParams? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LLMParameters? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ChatInputParams? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.InputMessage>? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.InputMessage? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ChatMessage? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.MessageAnnotation>? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MessageAnnotation? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MessageRole? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ChatParams? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ChatSessionSummary? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.JobMetadata? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ChatSessionSummarySharedAccess? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifierRule? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StatusEnum? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ClassifierRule>? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyMode? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyParsingConfiguration? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyUsage? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyV2Configuration? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ClassifyV2Rule>? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyV2Rule? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyV2ParsingConfiguration? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyV2JobCreateRequest? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyV2JobDeleteResponse? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyV2JobQueryResponse? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ClassifyV2JobResponse>? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyV2JobResponse? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyV2JobResponseStatus? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyV2JobResponseDocumentInputType? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyV2Result? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyV2Parameters? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudAstraDBVectorStore? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudAzStorageBlobDataSource? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudAzureAISearchVectorStore? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudBoxDataSource? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudConfluenceDataSource? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FailureHandlingConfig? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudDocument? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudDocumentCreate? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudGoogleDriveDataSource? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudJiraDataSource? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudJiraDataSourceV2? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudJiraDataSourceV2ApiVersion? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudMilvusVectorStore? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudMongoDBAtlasVectorSearch? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudNotionPageDataSource? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudOneDriveDataSource? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudPineconeVectorStore? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudPostgresVectorStore? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PGVectorHNSWSettings? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudQdrantVectorStore? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudS3DataSource? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudSharepointDataSource? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudSlackDataSource? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CodeItem? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.BBox>? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CohereEmbedding? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CohereEmbeddingConfig? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CompositeRetrievalMode? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CompositeRetrievalParams? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ReRankConfig? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CompositeRetrievalResult? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.CompositeRetrievedTextNodeWithScore>? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CompositeRetrievedTextNodeWithScore? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PageScreenshotNodeWithScore>? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PageScreenshotNodeWithScore? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PageFigureNodeWithScore>? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PageFigureNodeWithScore? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CompositeRetrievedTextNode? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurableDataSinkNames? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurableDataSourceNames? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurationCreateRequest? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Parameters? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitV1Parameters? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2Parameters? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseV2Parameters? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SpreadsheetV1Parameters? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.UntypedParameters? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurationCreateRequestParametersDiscriminator? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurationCreateRequestParametersDiscriminatorProductType? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurationQueryResponse? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ConfigurationResponse>? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurationResponse? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurationResponseProductType? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Parameters2? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurationResponseParametersDiscriminator? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurationResponseParametersDiscriminatorProductType? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurationUpdateRequest? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParametersVariant1? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurationUpdateRequestParametersVariant1Discriminator? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurationUpdateRequestParametersVariant1DiscriminatorProductType? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DataSink? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DataSinkCreate? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DataSinkQueryResponse? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.DataSink>? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DataSinkUpdate? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DataSource? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?>? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DataSourceReaderVersionMetadata? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DataSourceCreate? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DataSourceReaderVersionMetadataReaderVersion? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DataSourceSyncRequest? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DataSourceUpdate? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DeleteRequest? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DeleteResponse? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectRetrievalParams? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.RetrieverPipeline>? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrieverPipeline? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryConflictDetail? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryConflictResponse? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryCreateRequest? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryCreateRequestType? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryFileBulkDeleteRequest? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryFileCreateRequest? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LlamaParse.MetadataValue>? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryFileQueryResponse? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.DirectoryFileResponse>? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryFileResponse? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PresignedUrl? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryFileUpdateRequest? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryQueryResponse? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.DirectoryResponse>? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryResponse? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryResponseType? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryUpdateRequest? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DocumentChunkMode? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DocumentCountByStatusResponse? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingModelConfig? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingConfig? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.GeminiEmbeddingConfig? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.HuggingFaceInferenceAPIEmbeddingConfig? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.OpenAIEmbeddingConfig? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VertexAIEmbeddingConfig? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingModelConfigEmbeddingConfigDiscriminator? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingModelConfigEmbeddingConfigDiscriminatorType? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingModelConfigCreate? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingConfig2? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingModelConfigCreateEmbeddingConfigDiscriminator? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingModelConfigUpdate? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingConfigVariant1? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingModelConfigUpdateEmbeddingConfigVariant1Discriminator? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorType? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractAgent? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractConfig? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractAgentCreate? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<object, string>? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractAgentQueryResponse? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ExtractAgent>? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractAgentUpdate? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractConfigPriority? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractTarget? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractMode? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PublicModelName? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.ExtractModels?, string>? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractModels? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractConfiguration? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractConfigurationTier? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractConfigurationExtractionTarget? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractConfigurationParseTier? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractJob? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractJobStatus? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.File? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractJobCreate? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractJobCreatePriority? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractJobCreateBatch? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractJobMetadata? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractedFieldMetadata? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractJobUsage? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractResultset? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<object, global::System.Collections.Generic.IList<object>>? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractReviewApproveRequest? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractReviewCreateRequest? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractReviewCreatedDetail? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractReviewCreatedDetailOrigin? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractReviewEvent? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractReviewEventKind? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.ExtractReviewCreatedDetail, global::LlamaParse.ExtractReviewRejectedDetail, global::LlamaParse.ExtractReviewSignedOffDetail>? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractReviewRejectedDetail? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractReviewSignedOffDetail? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractReviewEventListResponse? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ExtractReviewEvent>? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractReviewFieldAction? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractReviewFieldActionAction? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractReviewFieldChange? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractReviewFieldChangeChange? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractReviewFieldsRequest? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ExtractReviewFieldChange>? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractReviewFlag? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractReviewFlagReason? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractReviewFlagCell? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractReviewRejectRequest? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractReviewResponse? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractReviewResponseStatus? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LlamaParse.ExtractReviewFieldAction>? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ExtractReviewFlag>? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractReviewRevisionRequest? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractRun? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractState? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractSchemaGenerateRequest? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractSchemaGenerateResponse? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractSchemaValidateRequest? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractSchemaValidateResponse? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractStatelessRequest? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileData? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractUsage? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2Job? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2JobMetadata? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2JobCreate? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2JobQueryResponse? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ExtractV2Job>? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2ParametersTier? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2ParametersExtractionTarget? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2ParametersParseTier? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2SchemaGenerateRequest? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2SchemaValidateRequest? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2SchemaValidateResponse? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FailedFormsPage? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FailedMarkdownPage? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FailedStructuredPage? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileAttachmentListResponse? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.FileAttachmentMetadata>? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileAttachmentMetadata? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileCountByStatusResponse? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileFilter? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileFindEntry? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileFindParams? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileFindResult? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.FileFindEntry>? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileGrepMatch? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileGrepParams? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileGrepResult? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.FileGrepMatch>? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileQueryRequest? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileQueryResponseV2? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.FileV2>? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileV2? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileReadParams? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileReadResult? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FilterCondition? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<double?, int?, string, global::System.DateTime?>? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<double?, int?, string, global::System.DateTime?>?>? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FilterOperator? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FooterItem? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ItemsItem>? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ItemsItem? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.TextItem? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.HeadingItem? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListItem? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.TableItem? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ImageItem? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LinkItem? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FooterItemItemDiscriminator? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FooterItemItemDiscriminatorType? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Form? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.JsonItem>? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.JsonItem? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormSection? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormField? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormTable? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormText? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormJsonItemDiscriminator? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormJsonItemDiscriminatorType? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormListItem? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormFieldGrounding? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormFieldField? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<string, bool?>? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ValueItemsVariant1Item>? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ValueItemsVariant1Item? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormFieldValueItemsVariant1ItemDiscriminator? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormFieldValueItemsVariant1ItemDiscriminatorType? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormTextGrounding? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.FormListTextItem, global::LlamaParse.FormListItem>>? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.FormListTextItem, global::LlamaParse.FormListItem>? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormListTextItem? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormSectionGrounding? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ItemsItem3>? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ItemsItem3? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormSectionItemDiscriminator? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormSectionItemDiscriminatorType? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormTableGrounding? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, global::LlamaParse.FormTableCellItems>?>>? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, global::LlamaParse.FormTableCellItems>?>? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<string, global::LlamaParse.FormTableCellItems>? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormTableCellItems? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ItemsItem4>? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ItemsItem4? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormTableCellItemsItemDiscriminator? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormTableCellItemsItemDiscriminatorType? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.FormTextGrounding>? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::LlamaParse.FormTextGrounding>>? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.GroundedLine>? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.GroundedLine? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormsResult? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.FormsResultPage, global::LlamaParse.FailedFormsPage>>? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.FormsResultPage, global::LlamaParse.FailedFormsPage>? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormsResultPage? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.Form>? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.GeminiEmbedding? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.GroundedChar? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<long>? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.GroundedWord>? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.GroundedWord? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.GroundedChar>? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.HTTPValidationError? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ValidationError>? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ValidationError? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.HeaderItem? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ItemsItem5>? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ItemsItem5? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.HeaderItemItemDiscriminator? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.HeaderItemItemDiscriminatorType? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.HuggingFaceInferenceAPIEmbedding? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Pooling? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ImageAttachmentRef? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ImageMetadata? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ImageMetadataCategory? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ImageMetadataBBox? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ImagesContentMetadata? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ImageMetadata>? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.IndexCreateRequest? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.IndexProductEntry>? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.IndexProductEntry? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.IndexCreateRequestVectorTarget? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.IndexMetadata? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.IndexQueryResponse? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.IndexResponse>? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.IndexResponse? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.IngestionErrorResponse? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.JobNameMapping? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ItemProcessingResultsResponse? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ProcessingResult>? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ProcessingResult? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.JobUsage? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SupportedLLMModelNames? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.TextItem, global::LlamaParse.ListItem>>? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.TextItem, global::LlamaParse.ListItem>? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseAgenticOptions? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseCostOptimizerParameters? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseCropBox? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseFastOptions? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseHtmlOptions? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseIgnoreOptions? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseImageOptions? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseInputOptions? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParsePdfOptions? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseSpreadsheetOptions? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParsePresentationOptions? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseJobFailureConditions? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseMarkdownOptions? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseTables? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseOcrParameters? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseOutputOptions? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseSpatialTextOptions? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseTablesAsSpreadsheetOptions? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseOutputOptionsWatermarkHandling? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.LlamaParseOutputOptionsImagesToSaveVariant1Item>? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseOutputOptionsImagesToSaveVariant1Item? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.LlamaParseOutputOptionsGranularBboxe>? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseOutputOptionsGranularBboxe? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParsePageRanges? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseParameters? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.StoredWebhookConfiguration>? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StoredWebhookConfiguration? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseParametersPriority? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.LlamaParseParametersImagesToSaveVariant1Item>? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseParametersImagesToSaveVariant1Item? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseProcessingControl? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseTimeouts? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseProcessingOptions? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseProcessingOptionsSpecializedChartParsing? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AutoModeConfigurationEntry>? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseProcessingOptionsForms? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseSupportedFileExtensions? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseWebhookConfiguration? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseWebhookConfigurationWebhookOutputFormat? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ManagedIngestionStatus? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ManagedIngestionStatusResponse? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.IngestionErrorResponse>? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ManagedOpenAIEmbedding? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ManagedOpenAIEmbeddingConfig? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MarkdownLineNumberAnnotation? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MarkdownResult? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.MarkdownResultPage, global::LlamaParse.FailedMarkdownPage>>? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.MarkdownResultPage, global::LlamaParse.FailedMarkdownPage>? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MarkdownResultPage? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.MarkdownLineNumberAnnotation>? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MetadataValue? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MetadataFilter? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<int?, double?, string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<int>>? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MetadataFilters? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.MetadataFilter, global::LlamaParse.MetadataFilters>>? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.MetadataFilter, global::LlamaParse.MetadataFilters>? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MetadataResult? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.MetadataResultPage>? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MetadataResultPage? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MetadataResultDocument? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MetadataResultDocumentConfidenceBreakdown? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MetadataScalarValue? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MongoStaticFilters? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StringFilter? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.NodeRelationship? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.NumericRangeFilter? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.NumericRangeFilterOperator? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<int?, double?, global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<int?, double?>>>? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<int?, double?>>? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<int?, double?>? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ObjectType? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.OpenAIEmbedding? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Organization? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParsePlanLevel? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.OrganizationQueryResponse? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.OrganizationResponse>? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.OrganizationResponse? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PGVectorDistanceMethod? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PGVectorVectorType? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PageFigureMetadata? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PageScreenshotMetadata? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PaginatedExtractRunsResponse? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ExtractRun>? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PaginatedListCloudDocumentsResponse? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.CloudDocument>? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PaginatedListPipelineFilesResponse? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PipelineFile>? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineFile? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseConcernItem? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseJobDeleteResponse? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseJobQueryResponse? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ParseJobResponse>? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseJobResponse? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseJobResponseStatus? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseLatestVersions? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseRequestConfiguration? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.ParseRequestConfigurationTier?, string>? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseRequestConfigurationTier? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.ParseRequestConfigurationVersion?, string>? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseRequestConfigurationVersion? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.LlamaParseWebhookConfiguration>? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseResultResponse? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LlamaParse.ResultTypeMetadata>? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ResultTypeMetadata? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.TextResult? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StructuredResult? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseV2ParametersTier? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.ParseV2ParametersVersion?, string>? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseV2ParametersVersion? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.StoredParseWebhookConfiguration>? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StoredParseWebhookConfiguration? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseVersionsResponse? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ParseVersionsResponseFastItem>? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseVersionsResponseFastItem? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ParseVersionsResponseCostEffectiveItem>? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseVersionsResponseCostEffectiveItem? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ParseVersionsResponseAgenticItem>? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseVersionsResponseAgenticItem? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ParseVersionsResponseAgenticPlu>? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseVersionsResponseAgenticPlu? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParsingJob? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParsingJobJsonResult? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParsingJobMarkdownResult? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParsingJobStructuredResult? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParsingJobTextResult? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PartitionNames? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Pipeline? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineType? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SparseModelConfig? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineConfigurationHashes? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.AutoTransformConfig, global::LlamaParse.AdvancedModeTransformConfig>? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineStatus? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineMetadataConfig? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingConfig3? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineEmbeddingConfigDiscriminator? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineEmbeddingConfigDiscriminatorType? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineCreate? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingConfigVariant12? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineCreateEmbeddingConfigVariant1Discriminator? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineCreateEmbeddingConfigVariant1DiscriminatorType? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineDataSource? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineDataSourceStatus? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineDataSourceCreate? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineDataSourceUpdate? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineFileStatus? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineFileCreate? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineFileListResponse? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PipelineFileResponse>? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineFileResponse? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineFileResponseStatus? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineFileUpdate? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineListItem? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineListItemStatus? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingConfigVariant13? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineListItemEmbeddingConfigVariant1Discriminator? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineListItemEmbeddingConfigVariant1DiscriminatorType? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineQueryResponse? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PipelineResponse>? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineResponse? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineResponsePipelineType? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineResponseStatus? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineUpdate? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingConfigVariant14? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineUpdateEmbeddingConfigVariant1Discriminator? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineUpdateEmbeddingConfigVariant1DiscriminatorType? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PlaygroundSession? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ChatMessage>? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrievalMode? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ProcessingResultMetadata? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Project? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ProjectQueryResponse? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ProjectResponse>? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ProjectResponse? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ReRankerType? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RelatedNodeInfo? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.ObjectType?, string>? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RerankConfig2? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrievalParams? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrievalResult? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StaticFields? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrieveParams? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.ValueFilter, global::System.Collections.Generic.IList<global::LlamaParse.NumericRangeFilter>>? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ValueFilter? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.NumericRangeFilter>? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrieveResult? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.RetrievalResult>? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrieveResults? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.TextNodeWithScore>? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.TextNodeWithScore? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Retriever? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrieverCreate? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrieverQueryResponse? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.Retriever>? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrieverUpdate? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Revision? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RevisionType? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RevisionBBox? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.RevisionTargetSpan>? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RevisionTargetSpan? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SearchRequest? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SessionCreate? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SessionCreateSharedAccess? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SessionDetail? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SessionDetailSharedAccess? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.EventsItem>? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EventsItem? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ThinkingDeltaEvent? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.TextDeltaEvent? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ThinkingEvent? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.TextEvent? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ToolCallEvent? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ToolResultEvent? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StopEvent? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.UserInputEvent? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SessionDetailEventDiscriminator? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SessionDetailEventDiscriminatorType? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SessionList? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ChatSessionSummary>? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SparseModelType? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitCategory? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitConfiguration? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.SplitCategory>? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitStrategy? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitConfigurationParseTier? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitConfigurationBeta? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitCreateRequest? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitCreateRequestBeta? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitDocumentInput? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitJobQueryResponse? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.SplitJobResponse>? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitJobResponse? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitJobQueryResponseBeta? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.SplitJobResponseBeta>? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitJobResponseBeta? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitJobResponseDocumentInputType? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitResultResponse? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.SplitSegmentResponse>? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitSegmentResponse? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitStrategyAllowUncategorized? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitV1ParametersParseTier? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SpreadsheetV1ParametersTier? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SpreadsheetV1ParametersTableMergeSensitivity? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AttachmentRef>? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Usage? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StoredParseWebhookConfigurationWebhookOutputFormat? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.StoredWebhookConfigurationWebhookEventsVariant1Item>? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StoredWebhookConfigurationWebhookEventsVariant1Item? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StringFilterOperator? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.StructuredResultPage, global::LlamaParse.FailedStructuredPage>>? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.StructuredResultPage, global::LlamaParse.FailedStructuredPage>? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StructuredResultPage? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ItemsItem7>? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ItemsItem7? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StructuredResultPageItemDiscriminator? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StructuredResultPageItemDiscriminatorType? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.Revision>? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?, double?>?>>? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?, double?>?>? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<string, int?, double?>? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ParseConcernItem>? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.TextNode? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.RelatedNodeInfo, global::System.Collections.Generic.IList<global::LlamaParse.RelatedNodeInfo>>? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.RelatedNodeInfo>? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.TextResultPage>? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.TextResultPage? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.UsageMetric? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.UsageMetricEventType? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.UsageMetricAggregateBucket? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.UsageMetricAggregateResponse? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.UsageMetricAggregateResponseGroupByItem>? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.UsageMetricAggregateResponseGroupByItem? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.UsageMetricAggregateBucket>? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.UsageMetricQueryResponse? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.UsageMetric>? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?>>? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<string, int?>? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ValueFilterOperator? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<string, int?, bool?, double?, global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?, bool?, double?>>>? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?, bool?, double?>>? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<string, int?, bool?, double?>? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VerifyCompositeScore? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VerifyCompositeScores? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VerifyConfiguration? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VerifyConfigurationTier? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VerifyDegradedTool? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VerifyEvidence? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VerifyHeatmap? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VerifyJobDetailsResponse? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.VerifyRegion>? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VerifyRegion? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.VerifyEvidence>? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.VerifyDegradedTool>? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.VerifyHeatmap>? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.VerifyPageDimension>? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VerifyPageDimension? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VerifyJobQueryResponse? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.VerifyJobResponse>? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VerifyJobResponse? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VerifyJobResponseStatus? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VerifyJobResponseDocumentInputType? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VerifyResult? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VerifyRequest? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VerifyResultVerdict? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.VerifySuspectRegion>? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VerifySuspectRegion? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VertexTextEmbedding? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VertexEmbeddingMode? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigCreateRequest? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigCreateRequestWebhookEventsVariant1Item>? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigCreateRequestWebhookEventsVariant1Item? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigCreateRequestWebhookOutputFormat? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigQueryResponse? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigResponse>? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigResponse? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigResponseTenantType? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigResponseWebhookEventsVariant1Item>? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigResponseWebhookEventsVariant1Item? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigResponseWebhookOutputFormat? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigUpdateRequest? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigUpdateRequestWebhookEventsVariant1Item>? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigUpdateRequestWebhookEventsVariant1Item? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigUpdateRequestWebhookOutputFormat? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item>? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PipelineDataSourceCreate>? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PipelineFileCreate>? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.CloudDocumentCreate>? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item>? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetStatusRefreshPolicy? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PaginatedListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsPaginatedGetStatusRefreshPolicy? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListSplitJobsApiV1SplitJobsGetStatus? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem>? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetType? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1Item>? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1Item? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item>? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CreateWebhookConfigApiV1BetaWebhookConfigsPostTenantType? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListWebhookConfigsApiV1BetaWebhookConfigsGetTenantType? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.GetWebhookConfigApiV1BetaWebhookConfigsConfigIdGetTenantType? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.UpdateWebhookConfigApiV1BetaWebhookConfigsConfigIdPutTenantType? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DeleteWebhookConfigApiV1BetaWebhookConfigsConfigIdDeleteTenantType? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListSplitJobsApiV1BetaSplitJobsGetStatus? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item>? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListParseJobsApiV2ParseGetStatus? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListClassifyJobsApiV2ClassifyGetStatus? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListExtractJobsApiV2ExtractGetStatus? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListExtractJobsApiV2ExtractGetReviewStatus? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CreateExtractReviewApiV2ExtractJobIdReviewPostOrigin? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListPipelinesApiV2PipelinesGetPipelineType? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.QueryWebhookConfigsApiV2WebhookConfigsGetTenantType? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListBatchesApiV2BatchesGetStatus? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListVerifyJobsApiAlphaVerifyGetStatus? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.DataSource>? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.EmbeddingModelConfig>? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.Organization>? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.Project>? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PageScreenshotMetadata>? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PageFigureMetadata>? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PipelineListItem>? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PipelineDataSource>? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.TextNode>? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.LlamaParseSupportedFileExtensions>? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ExtractJob>? Type809 { get; set; }

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