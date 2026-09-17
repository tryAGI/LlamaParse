
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
        public global::LlamaParse.AnyOf<double?, string, object>? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<int?, string, object>? Type33 { get; set; }
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
        public global::LlamaParse.AnyOf<global::LlamaParse.AutoModeParsingConfVersion?, string, object>? Type37 { get; set; }
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
        public global::LlamaParse.ClassifierRule? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StatusEnum? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ClassifierRule>? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyMode? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyParsingConfiguration? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyV2Configuration? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ClassifyV2Rule>? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyV2Rule? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyV2ParsingConfiguration? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyV2JobCreateRequest? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyV2JobDeleteResponse? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyV2JobQueryResponse? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ClassifyV2JobResponse>? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyV2JobResponse? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyV2JobResponseStatus? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyV2JobResponseDocumentInputType? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyV2Result? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyV2Parameters? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudAstraDBVectorStore? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudAzStorageBlobDataSource? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudAzureAISearchVectorStore? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudBoxDataSource? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudConfluenceDataSource? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FailureHandlingConfig? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudDocument? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudDocumentCreate? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudGoogleDriveDataSource? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudJiraDataSource? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudJiraDataSourceV2? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudJiraDataSourceV2ApiVersion? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudMilvusVectorStore? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudMongoDBAtlasVectorSearch? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudNotionPageDataSource? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudOneDriveDataSource? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudPineconeVectorStore? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudPostgresVectorStore? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PGVectorHNSWSettings? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudQdrantVectorStore? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudS3DataSource? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudSharepointDataSource? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudSlackDataSource? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CodeItem? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.BBox>? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CohereEmbedding? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CohereEmbeddingConfig? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CompositeRetrievalMode? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CompositeRetrievalParams? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ReRankConfig? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CompositeRetrievalResult? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.CompositeRetrievedTextNodeWithScore>? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CompositeRetrievedTextNodeWithScore? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PageScreenshotNodeWithScore>? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PageScreenshotNodeWithScore? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PageFigureNodeWithScore>? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PageFigureNodeWithScore? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CompositeRetrievedTextNode? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurableDataSinkNames? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurableDataSourceNames? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurationCreateRequest? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Parameters? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitV1Parameters? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2Parameters? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseV2Parameters? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SpreadsheetV1Parameters? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.UntypedParameters? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurationCreateRequestParametersDiscriminator? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurationCreateRequestParametersDiscriminatorProductType? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurationQueryResponse? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ConfigurationResponse>? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurationResponse? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurationResponseProductType? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Parameters2? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurationResponseParametersDiscriminator? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurationResponseParametersDiscriminatorProductType? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurationUpdateRequest? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParametersVariant1? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurationUpdateRequestParametersVariant1Discriminator? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurationUpdateRequestParametersVariant1DiscriminatorProductType? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DataSink? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DataSinkCreate? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DataSinkQueryResponse? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.DataSink>? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DataSinkUpdate? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DataSource? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DataSourceReaderVersionMetadata? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DataSourceCreate? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DataSourceReaderVersionMetadataReaderVersion? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DataSourceSyncRequest? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DataSourceUpdate? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DeleteRequest? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DeleteResponse? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectRetrievalParams? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.RetrieverPipeline>? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrieverPipeline? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryCreateRequest? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryCreateRequestType? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryFileBulkDeleteRequest? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryFileCreateRequest? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MetadataDict? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryFileQueryResponse? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.DirectoryFileResponse>? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryFileResponse? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PresignedUrl? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryFileUpdateRequest? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryQueryResponse? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.DirectoryResponse>? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryResponse? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryResponseType? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryUpdateRequest? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DocumentChunkMode? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DocumentCountByStatusResponse? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingModelConfig? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingConfig? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.GeminiEmbeddingConfig? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.HuggingFaceInferenceAPIEmbeddingConfig? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.OpenAIEmbeddingConfig? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VertexAIEmbeddingConfig? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingModelConfigEmbeddingConfigDiscriminator? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingModelConfigEmbeddingConfigDiscriminatorType? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingModelConfigCreate? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingConfig2? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingModelConfigCreateEmbeddingConfigDiscriminator? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingModelConfigUpdate? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingConfigVariant1? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingModelConfigUpdateEmbeddingConfigVariant1Discriminator? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorType? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractAgent? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractConfig? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractAgentCreate? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<object, string>? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractAgentQueryResponse? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ExtractAgent>? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractAgentUpdate? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractConfigPriority? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractTarget? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractMode? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PublicModelName? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.ExtractModels?, string, object>? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractModels? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractConfiguration? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractConfigurationTier? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractConfigurationExtractionTarget? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractConfigurationParseTier? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractJob? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractJobStatus? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.File? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractJobCreate? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractJobCreatePriority? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<object, string, object>? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractJobCreateBatch? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractJobMetadata? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractedFieldMetadata? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractJobUsage? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractResultset? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<object, global::System.Collections.Generic.IList<object>, object>? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractRun? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractState? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractSchemaGenerateRequest? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractSchemaGenerateResponse? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractSchemaValidateRequest? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractSchemaValidateResponse? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractStatelessRequest? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileData? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractUsage? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2Job? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2JobMetadata? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2JobCreate? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2JobQueryResponse? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ExtractV2Job>? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2ParametersTier? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2ParametersExtractionTarget? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2ParametersParseTier? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2SchemaGenerateRequest? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2SchemaValidateRequest? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2SchemaValidateResponse? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FailedFormsPage? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FailedMarkdownPage? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FailedStructuredPage? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileAttachmentListResponse? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.FileAttachmentMetadata>? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileAttachmentMetadata? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileCountByStatusResponse? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileFilter? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileFindEntry? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileFindParams? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileFindResult? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.FileFindEntry>? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileGrepMatch? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileGrepParams? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileGrepResult? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.FileGrepMatch>? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileQueryRequest? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileQueryResponseV2? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.FileV2>? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileV2? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileReadParams? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileReadResult? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FilterCondition? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<double?, int?, string, global::System.DateTime?, object>? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<double?, int?, string, global::System.DateTime?, object>>? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FilterOperator? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FooterItem? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ItemsItem>? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ItemsItem? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.TextItem? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.HeadingItem? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListItem? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.TableItem? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ImageItem? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LinkItem? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FooterItemItemDiscriminator? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FooterItemItemDiscriminatorType? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Form? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.JsonItem>? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.JsonItem? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormSection? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormField? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormTable? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormJsonItemDiscriminator? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormJsonItemDiscriminatorType? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormListItem? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormFieldGrounding? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormFieldField? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<string, bool?, object>? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ValueItemsVariant1Item>? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ValueItemsVariant1Item? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormFieldValueItemsVariant1ItemDiscriminator? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormFieldValueItemsVariant1ItemDiscriminatorType? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormTextGrounding? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.FormListTextItem, global::LlamaParse.FormListItem>>? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.FormListTextItem, global::LlamaParse.FormListItem>? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormListTextItem? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormSectionGrounding? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ItemsItem3>? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ItemsItem3? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormSectionItemDiscriminator? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormSectionItemDiscriminatorType? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormTableGrounding? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, global::LlamaParse.FormTableCellItems, object>>>? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, global::LlamaParse.FormTableCellItems, object>>? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<string, global::LlamaParse.FormTableCellItems, object>? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormTableCellItems? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ItemsItem4>? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ItemsItem4? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormTableCellItemsItemDiscriminator? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormTableCellItemsItemDiscriminatorType? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.FormTextGrounding>? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::LlamaParse.FormTextGrounding>>? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.GroundedLine>? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.GroundedLine? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormsResult? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.FormsResultPage, global::LlamaParse.FailedFormsPage>>? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.FormsResultPage, global::LlamaParse.FailedFormsPage>? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormsResultPage? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.Form>? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.GeminiEmbedding? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<long>? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.GroundedWord>? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.GroundedWord? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.HTTPValidationError? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ValidationError>? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ValidationError? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.HeaderItem? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ItemsItem5>? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ItemsItem5? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.HeaderItemItemDiscriminator? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.HeaderItemItemDiscriminatorType? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.HuggingFaceInferenceAPIEmbedding? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Pooling? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ImageAttachmentRef? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ImageMetadata? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ImageMetadataCategory? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ImageMetadataBBox? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ImagesContentMetadata? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ImageMetadata>? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.IndexCreateRequest? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.IndexProductEntry>? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.IndexProductEntry? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.IndexCreateRequestVectorTarget? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.IndexMetadata? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.IndexQueryResponse? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.IndexResponse>? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.IndexResponse? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.IngestionErrorResponse? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.JobNameMapping? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ItemProcessingResultsResponse? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ProcessingResult>? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ProcessingResult? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.JobUsage? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SupportedLLMModelNames? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.TextItem, global::LlamaParse.ListItem>>? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.TextItem, global::LlamaParse.ListItem>? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseAgenticOptions? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseCostOptimizerParameters? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseCropBox? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseFastOptions? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseHtmlOptions? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseIgnoreOptions? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseImageOptions? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseInputOptions? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParsePdfOptions? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseSpreadsheetOptions? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParsePresentationOptions? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseJobFailureConditions? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseMarkdownOptions? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseTables? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseOcrParameters? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseOutputOptions? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseSpatialTextOptions? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseTablesAsSpreadsheetOptions? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.LlamaParseOutputOptionsImagesToSaveVariant1Item>? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseOutputOptionsImagesToSaveVariant1Item? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.LlamaParseOutputOptionsGranularBboxe>? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseOutputOptionsGranularBboxe? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParsePageRanges? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseParameters? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseParametersPriority? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.LlamaParseParametersImagesToSaveVariant1Item>? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseParametersImagesToSaveVariant1Item? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseProcessingControl? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseTimeouts? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseProcessingOptions? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseProcessingOptionsSpecializedChartParsing? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AutoModeConfigurationEntry>? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseProcessingOptionsForms? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseSupportedFileExtensions? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseWebhookConfiguration? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseWebhookConfigurationWebhookOutputFormat? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ManagedIngestionStatus? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ManagedIngestionStatusResponse? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.IngestionErrorResponse>? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ManagedOpenAIEmbedding? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ManagedOpenAIEmbeddingConfig? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MarkdownLineNumberAnnotation? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MarkdownResult? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.MarkdownResultPage, global::LlamaParse.FailedMarkdownPage>>? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.MarkdownResultPage, global::LlamaParse.FailedMarkdownPage>? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MarkdownResultPage? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.MarkdownLineNumberAnnotation>? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MetadataValue? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MetadataFilter? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<int?, double?, string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<int>, object>? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MetadataFilters? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.MetadataFilter, global::LlamaParse.MetadataFilters>>? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.MetadataFilter, global::LlamaParse.MetadataFilters>? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MetadataResult? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.MetadataResultPage>? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MetadataResultPage? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MetadataResultDocument? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MetadataResultDocumentConfidenceBreakdown? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MetadataScalarValue? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MongoStaticFilters? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StringFilter? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.NodeRelationship? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.NumericRangeFilter? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.NumericRangeFilterOperator? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<int?, double?, global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<int?, double?>>>? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<int?, double?>>? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<int?, double?>? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ObjectType? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.OpenAIEmbedding? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Organization? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParsePlanLevel? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.OrganizationQueryResponse? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.OrganizationResponse>? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.OrganizationResponse? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PGVectorDistanceMethod? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PGVectorVectorType? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PageFigureMetadata? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PageScreenshotMetadata? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PaginatedExtractRunsResponse? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ExtractRun>? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PaginatedListCloudDocumentsResponse? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.CloudDocument>? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PaginatedListPipelineFilesResponse? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PipelineFile>? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineFile? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseConcernItem? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseJobDeleteResponse? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseJobQueryResponse? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ParseJobResponse>? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseJobResponse? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseJobResponseStatus? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseLatestVersions? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseRequestConfiguration? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.ParseRequestConfigurationTier?, string>? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseRequestConfigurationTier? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.ParseRequestConfigurationVersion?, string>? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseRequestConfigurationVersion? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.LlamaParseWebhookConfiguration>? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseResultResponse? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LlamaParse.ResultTypeMetadata>? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ResultTypeMetadata? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.TextResult? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StructuredResult? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseV2ParametersTier? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.ParseV2ParametersVersion?, string>? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseV2ParametersVersion? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseVersionsResponse? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ParseVersionsResponseFastItem>? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseVersionsResponseFastItem? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ParseVersionsResponseCostEffectiveItem>? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseVersionsResponseCostEffectiveItem? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ParseVersionsResponseAgenticItem>? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseVersionsResponseAgenticItem? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ParseVersionsResponseAgenticPlu>? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseVersionsResponseAgenticPlu? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParsingJob? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParsingJobJsonResult? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParsingJobMarkdownResult? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParsingJobStructuredResult? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParsingJobTextResult? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PartitionNames? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Pipeline? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineType? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingConfig3? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineEmbeddingConfigDiscriminator? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineEmbeddingConfigDiscriminatorType? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SparseModelConfig? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineConfigurationHashes? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.AutoTransformConfig, global::LlamaParse.AdvancedModeTransformConfig>? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineStatus? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineMetadataConfig? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineCreate? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingConfigVariant12? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineCreateEmbeddingConfigVariant1Discriminator? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineCreateEmbeddingConfigVariant1DiscriminatorType? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.AutoTransformConfig, global::LlamaParse.AdvancedModeTransformConfig, object>? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineDataSource? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineDataSourceStatus? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineDataSourceCreate? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineDataSourceUpdate? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineFileStatus? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineFileCreate? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineFileListResponse? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PipelineFileResponse>? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineFileResponse? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineFileResponseStatus? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineFileUpdate? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineQueryResponse? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PipelineResponse>? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineResponse? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineResponsePipelineType? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineResponseStatus? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineUpdate? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingConfigVariant13? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineUpdateEmbeddingConfigVariant1Discriminator? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineUpdateEmbeddingConfigVariant1DiscriminatorType? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PlaygroundSession? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ChatMessage>? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrievalMode? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ProcessingResultMetadata? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Project? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ProjectQueryResponse? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ProjectResponse>? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ProjectResponse? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ReRankerType? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RelatedNodeInfo? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.ObjectType?, string, object>? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RerankConfig2? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrievalParams? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrievalResult? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StaticFields? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrieveParams? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.ValueFilter, global::System.Collections.Generic.IList<global::LlamaParse.NumericRangeFilter>, object>? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ValueFilter? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.NumericRangeFilter>? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrieveResult? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.RetrievalResult>? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrieveResults? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.TextNodeWithScore>? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.TextNodeWithScore? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Retriever? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrieverCreate? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrieverQueryResponse? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.Retriever>? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrieverUpdate? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Revision? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RevisionType? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RevisionBBox? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.RevisionTargetSpan>? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RevisionTargetSpan? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SearchRequest? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SessionCreate? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SessionDetail? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.EventsItem>? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EventsItem? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ThinkingDeltaEvent? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.TextDeltaEvent? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ThinkingEvent? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.TextEvent? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ToolCallEvent? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ToolResultEvent? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StopEvent? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.UserInputEvent? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SessionDetailEventDiscriminator? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SessionDetailEventDiscriminatorType? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SessionList? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ChatSessionSummary>? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SparseModelType? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitCategory? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitConfiguration? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.SplitCategory>? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitStrategy? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitConfigurationParseTier? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitConfigurationBeta? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitCreateRequest? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitCreateRequestBeta? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitDocumentInput? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitJobQueryResponse? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.SplitJobResponse>? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitJobResponse? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitJobQueryResponseBeta? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.SplitJobResponseBeta>? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitJobResponseBeta? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitJobResponseDocumentInputType? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitResultResponse? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.SplitSegmentResponse>? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitSegmentResponse? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitStrategyAllowUncategorized? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitV1ParametersParseTier? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SpreadsheetV1ParametersTier? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SpreadsheetV1ParametersTableMergeSensitivity? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AttachmentRef>? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Usage? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StringFilterOperator? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.StructuredResultPage, global::LlamaParse.FailedStructuredPage>>? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.StructuredResultPage, global::LlamaParse.FailedStructuredPage>? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StructuredResultPage? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ItemsItem7>? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ItemsItem7? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StructuredResultPageItemDiscriminator? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StructuredResultPageItemDiscriminatorType? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.Revision>? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?, double?, object>>>? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?, double?, object>>? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<string, int?, double?, object>? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ParseConcernItem>? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.TextNode? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.RelatedNodeInfo, global::System.Collections.Generic.IList<global::LlamaParse.RelatedNodeInfo>>? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.RelatedNodeInfo>? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.TextResultPage>? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.TextResultPage? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.UsageMetric? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.UsageMetricEventType? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.UsageMetricAggregateBucket? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.UsageMetricAggregateResponse? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.UsageMetricAggregateResponseGroupByItem>? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.UsageMetricAggregateResponseGroupByItem? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.UsageMetricAggregateBucket>? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.UsageMetricQueryResponse? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.UsageMetric>? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?>>? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<string, int?>? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ValueFilterOperator? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<string, int?, bool?, double?, global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?, bool?, double?>>>? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?, bool?, double?>>? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<string, int?, bool?, double?>? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VertexTextEmbedding? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VertexEmbeddingMode? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigCreateRequest? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigCreateRequestWebhookEventsVariant1Item>? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigCreateRequestWebhookEventsVariant1Item? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigCreateRequestWebhookOutputFormat? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigQueryResponse? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigResponse>? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigResponse? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigResponseTenantType? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigResponseWebhookEventsVariant1Item>? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigResponseWebhookEventsVariant1Item? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigResponseWebhookOutputFormat? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigUpdateRequest? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigUpdateRequestWebhookEventsVariant1Item>? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigUpdateRequestWebhookEventsVariant1Item? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigUpdateRequestWebhookOutputFormat? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item>? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PipelineDataSourceCreate>? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PipelineFileCreate>? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.CloudDocumentCreate>? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item>? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetStatusRefreshPolicy? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PaginatedListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsPaginatedGetStatusRefreshPolicy? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListSplitJobsApiV1SplitJobsGetStatus? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem>? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetType? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1Item>? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1Item? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item>? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CreateWebhookConfigApiV1BetaWebhookConfigsPostTenantType? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListWebhookConfigsApiV1BetaWebhookConfigsGetTenantType? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.GetWebhookConfigApiV1BetaWebhookConfigsConfigIdGetTenantType? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.UpdateWebhookConfigApiV1BetaWebhookConfigsConfigIdPutTenantType? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DeleteWebhookConfigApiV1BetaWebhookConfigsConfigIdDeleteTenantType? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListSplitJobsApiV1BetaSplitJobsGetStatus? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item>? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListParseJobsApiV2ParseGetStatus? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListClassifyJobsApiV2ClassifyGetStatus? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListExtractJobsApiV2ExtractGetStatus? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListPipelinesApiV2PipelinesGetPipelineType? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.QueryWebhookConfigsApiV2WebhookConfigsGetTenantType? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListBatchesApiV2BatchesGetStatus? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.DataSource>? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.EmbeddingModelConfig>? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.Organization>? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.Project>? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PageScreenshotMetadata>? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PageFigureMetadata>? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.Pipeline>? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PipelineDataSource>? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.TextNode>? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.LlamaParseSupportedFileExtensions>? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ExtractJob>? Type735 { get; set; }

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
        public global::LlamaParse.AnyOf<object, global::System.Collections.Generic.List<object>, string, int?, double?, bool?, object>? ListType22 { get; set; }
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
        public global::LlamaParse.AnyOf<object, global::System.Collections.Generic.List<object>, object>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ExtractV2Job>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.FileAttachmentMetadata>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.FileFindEntry>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.FileGrepMatch>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.FileV2>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<double?, int?, string, global::System.DateTime?, object>>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ItemsItem>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.JsonItem>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ValueItemsVariant1Item>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<global::LlamaParse.FormListTextItem, global::LlamaParse.FormListItem>>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ItemsItem3>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::LlamaParse.AnyOf<string, global::LlamaParse.FormTableCellItems, object>>>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<string, global::LlamaParse.FormTableCellItems, object>>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ItemsItem4>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.FormTextGrounding>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::LlamaParse.FormTextGrounding>>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.GroundedLine>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<global::LlamaParse.FormsResultPage, global::LlamaParse.FailedFormsPage>>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.Form>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<long>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.GroundedWord>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ValidationError>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ItemsItem5>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ImageMetadata>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.IndexProductEntry>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.IndexResponse>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ProcessingResult>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<global::LlamaParse.TextItem, global::LlamaParse.ListItem>>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.LlamaParseOutputOptionsImagesToSaveVariant1Item>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.LlamaParseOutputOptionsGranularBboxe>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.LlamaParseParametersImagesToSaveVariant1Item>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AutoModeConfigurationEntry>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.IngestionErrorResponse>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<global::LlamaParse.MarkdownResultPage, global::LlamaParse.FailedMarkdownPage>>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.MarkdownLineNumberAnnotation>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<int?, double?, string, global::System.Collections.Generic.List<string>, global::System.Collections.Generic.List<double>, global::System.Collections.Generic.List<int>, object>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<global::LlamaParse.MetadataFilter, global::LlamaParse.MetadataFilters>>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.MetadataResultPage>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<int?, double?, global::System.Collections.Generic.List<global::LlamaParse.AnyOf<int?, double?>>>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<int?, double?>>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.OrganizationResponse>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ExtractRun>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.CloudDocument>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.PipelineFile>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ParseJobResponse>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.LlamaParseWebhookConfiguration>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ParseVersionsResponseFastItem>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ParseVersionsResponseCostEffectiveItem>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ParseVersionsResponseAgenticItem>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ParseVersionsResponseAgenticPlu>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.PipelineFileResponse>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.PipelineResponse>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ChatMessage>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ProjectResponse>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.ValueFilter, global::System.Collections.Generic.List<global::LlamaParse.NumericRangeFilter>, object>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.NumericRangeFilter>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.RetrievalResult>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.TextNodeWithScore>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.Retriever>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.RevisionTargetSpan>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.EventsItem>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ChatSessionSummary>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.SplitCategory>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.SplitJobResponse>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.SplitJobResponseBeta>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.SplitSegmentResponse>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AttachmentRef>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<string, global::System.Collections.Generic.List<string>>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<global::LlamaParse.StructuredResultPage, global::LlamaParse.FailedStructuredPage>>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ItemsItem7>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.Revision>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::LlamaParse.AnyOf<string, int?, double?, object>>>? ListType102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<string, int?, double?, object>>? ListType103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ParseConcernItem>? ListType104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.RelatedNodeInfo, global::System.Collections.Generic.List<global::LlamaParse.RelatedNodeInfo>>? ListType105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.RelatedNodeInfo>? ListType106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.TextResultPage>? ListType107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.UsageMetricAggregateResponseGroupByItem>? ListType108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.UsageMetricAggregateBucket>? ListType109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.UsageMetric>? ListType110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<string, int?>>? ListType111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<string, int?, bool?, double?, global::System.Collections.Generic.List<global::LlamaParse.AnyOf<string, int?, bool?, double?>>>? ListType112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<string, int?, bool?, double?>>? ListType113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.WebhookConfigCreateRequestWebhookEventsVariant1Item>? ListType114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.WebhookConfigResponse>? ListType115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.WebhookConfigResponseWebhookEventsVariant1Item>? ListType116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.WebhookConfigUpdateRequestWebhookEventsVariant1Item>? ListType117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item>? ListType118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.PipelineDataSourceCreate>? ListType119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.PipelineFileCreate>? ListType120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.CloudDocumentCreate>? ListType121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item>? ListType122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem>? ListType123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1Item>? ListType124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item>? ListType125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item>? ListType126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.DataSource>? ListType127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.EmbeddingModelConfig>? ListType128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.Organization>? ListType129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.Project>? ListType130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.PageScreenshotMetadata>? ListType131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.PageFigureMetadata>? ListType132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.Pipeline>? ListType133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.PipelineDataSource>? ListType134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.TextNode>? ListType135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.LlamaParseSupportedFileExtensions>? ListType136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ExtractJob>? ListType137 { get; set; }
    }
}