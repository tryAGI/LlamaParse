
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
        public global::LlamaParse.ClassifyV2JobQueryResponse? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ClassifyV2JobResponse>? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyV2JobResponse? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyV2JobResponseStatus? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyV2JobResponseDocumentInputType? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyV2Result? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ClassifyV2Parameters? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudAstraDBVectorStore? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudAzStorageBlobDataSource? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudAzureAISearchVectorStore? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudBoxDataSource? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudConfluenceDataSource? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FailureHandlingConfig? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudDocument? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudDocumentCreate? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudGoogleDriveDataSource? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudJiraDataSource? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudJiraDataSourceV2? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudJiraDataSourceV2ApiVersion? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudMilvusVectorStore? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudMongoDBAtlasVectorSearch? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudNotionPageDataSource? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudOneDriveDataSource? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudPineconeVectorStore? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudPostgresVectorStore? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PGVectorHNSWSettings? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudQdrantVectorStore? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudS3DataSource? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudSharepointDataSource? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CloudSlackDataSource? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CodeItem? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.BBox>? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CohereEmbedding? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CohereEmbeddingConfig? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CompositeRetrievalMode? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CompositeRetrievalParams? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ReRankConfig? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CompositeRetrievalResult? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.CompositeRetrievedTextNodeWithScore>? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CompositeRetrievedTextNodeWithScore? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PageScreenshotNodeWithScore>? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PageScreenshotNodeWithScore? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PageFigureNodeWithScore>? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PageFigureNodeWithScore? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.CompositeRetrievedTextNode? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurableDataSinkNames? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurableDataSourceNames? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurationCreateRequest? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Parameters? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitV1Parameters? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2Parameters? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseV2Parameters? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SpreadsheetV1Parameters? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.UntypedParameters? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurationCreateRequestParametersDiscriminator? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurationCreateRequestParametersDiscriminatorProductType? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurationQueryResponse? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ConfigurationResponse>? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurationResponse? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurationResponseProductType? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Parameters2? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurationResponseParametersDiscriminator? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurationResponseParametersDiscriminatorProductType? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurationUpdateRequest? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParametersVariant1? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurationUpdateRequestParametersVariant1Discriminator? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ConfigurationUpdateRequestParametersVariant1DiscriminatorProductType? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DataSink? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DataSinkCreate? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DataSinkQueryResponse? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.DataSink>? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DataSinkUpdate? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DataSource? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DataSourceReaderVersionMetadata? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DataSourceCreate? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DataSourceReaderVersionMetadataReaderVersion? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DataSourceSyncRequest? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DataSourceUpdate? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DeleteRequest? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DeleteResponse? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectRetrievalParams? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.RetrieverPipeline>? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrieverPipeline? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryCreateRequest? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryCreateRequestType? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryFileBulkDeleteRequest? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryFileCreateRequest? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MetadataDict? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryFileQueryResponse? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.DirectoryFileResponse>? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryFileResponse? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PresignedUrl? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryFileUpdateRequest? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryQueryResponse? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.DirectoryResponse>? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryResponse? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryResponseType? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DirectoryUpdateRequest? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DocumentChunkMode? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.DocumentCountByStatusResponse? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingModelConfig? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingConfig? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.GeminiEmbeddingConfig? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.HuggingFaceInferenceAPIEmbeddingConfig? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.OpenAIEmbeddingConfig? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VertexAIEmbeddingConfig? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingModelConfigEmbeddingConfigDiscriminator? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingModelConfigEmbeddingConfigDiscriminatorType? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingModelConfigCreate? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingConfig2? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingModelConfigCreateEmbeddingConfigDiscriminator? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingModelConfigUpdate? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingConfigVariant1? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingModelConfigUpdateEmbeddingConfigVariant1Discriminator? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorType? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractAgent? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractConfig? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractAgentCreate? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<object, string>? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractAgentQueryResponse? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ExtractAgent>? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractAgentUpdate? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractConfigPriority? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractTarget? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractMode? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PublicModelName? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.ExtractModels?, string, object>? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractModels? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractConfiguration? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractConfigurationTier? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractConfigurationExtractionTarget? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractConfigurationParseTier? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractJob? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractJobStatus? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.File? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractJobCreate? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractJobCreatePriority? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<object, string, object>? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractJobCreateBatch? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractJobMetadata? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractedFieldMetadata? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractJobUsage? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractResultset? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<object, global::System.Collections.Generic.IList<object>, object>? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractRun? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractState? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractSchemaGenerateRequest? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractSchemaGenerateResponse? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractSchemaValidateRequest? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractSchemaValidateResponse? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractStatelessRequest? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileData? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractUsage? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2Job? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2JobMetadata? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2JobCreate? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2JobQueryResponse? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ExtractV2Job>? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2ParametersTier? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2ParametersExtractionTarget? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2ParametersParseTier? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2SchemaGenerateRequest? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2SchemaValidateRequest? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2SchemaValidateResponse? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FailedFormsPage? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FailedMarkdownPage? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FailedStructuredPage? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileAttachmentListResponse? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.FileAttachmentMetadata>? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileAttachmentMetadata? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileCountByStatusResponse? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileFilter? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileFindEntry? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileFindParams? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileFindResult? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.FileFindEntry>? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileGrepMatch? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileGrepParams? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileGrepResult? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.FileGrepMatch>? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileQueryRequest? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileQueryResponseV2? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.FileV2>? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileV2? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileReadParams? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileReadResult? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FilterCondition? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<double?, int?, string, global::System.DateTime?, object>? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<double?, int?, string, global::System.DateTime?, object>>? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FilterOperator? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FooterItem? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ItemsItem>? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ItemsItem? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.TextItem? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.HeadingItem? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListItem? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.TableItem? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ImageItem? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LinkItem? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FooterItemItemDiscriminator? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FooterItemItemDiscriminatorType? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Form? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.JsonItem>? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.JsonItem? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormSection? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormField? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormTable? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormJsonItemDiscriminator? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormJsonItemDiscriminatorType? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormListItem? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormFieldGrounding? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormFieldField? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<string, bool?, object>? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ValueItemsVariant1Item>? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ValueItemsVariant1Item? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormFieldValueItemsVariant1ItemDiscriminator? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormFieldValueItemsVariant1ItemDiscriminatorType? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormTextGrounding? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.FormListTextItem, global::LlamaParse.FormListItem>>? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.FormListTextItem, global::LlamaParse.FormListItem>? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormListTextItem? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormSectionGrounding? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ItemsItem3>? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ItemsItem3? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormSectionItemDiscriminator? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormSectionItemDiscriminatorType? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormTableGrounding? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, global::LlamaParse.FormTableCellItems, object>>>? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, global::LlamaParse.FormTableCellItems, object>>? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<string, global::LlamaParse.FormTableCellItems, object>? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormTableCellItems? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ItemsItem4>? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ItemsItem4? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormTableCellItemsItemDiscriminator? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormTableCellItemsItemDiscriminatorType? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.FormTextGrounding>? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::LlamaParse.FormTextGrounding>>? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.GroundedLine>? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.GroundedLine? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormsResult? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.FormsResultPage, global::LlamaParse.FailedFormsPage>>? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.FormsResultPage, global::LlamaParse.FailedFormsPage>? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormsResultPage? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.Form>? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.GeminiEmbedding? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<long>? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.GroundedWord>? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.GroundedWord? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.HTTPValidationError? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ValidationError>? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ValidationError? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.HeaderItem? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ItemsItem5>? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ItemsItem5? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.HeaderItemItemDiscriminator? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.HeaderItemItemDiscriminatorType? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.HuggingFaceInferenceAPIEmbedding? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Pooling? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ImageAttachmentRef? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ImageMetadata? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ImageMetadataCategory? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ImageMetadataBBox? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ImagesContentMetadata? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ImageMetadata>? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.IndexCreateRequest? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.IndexProductEntry>? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.IndexProductEntry? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.IndexCreateRequestVectorTarget? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.IndexMetadata? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.IndexQueryResponse? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.IndexResponse>? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.IndexResponse? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.IngestionErrorResponse? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.JobNameMapping? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ItemProcessingResultsResponse? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ProcessingResult>? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ProcessingResult? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.JobDataPoint? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.JobStateTransitions? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.JobDataPointResponse? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.JobDataPoint>? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.JobUsage? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SupportedLLMModelNames? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.TextItem, global::LlamaParse.ListItem>>? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.TextItem, global::LlamaParse.ListItem>? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseAgenticOptions? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseCostOptimizerParameters? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseCropBox? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseFastOptions? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseHtmlOptions? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseIgnoreOptions? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseImageOptions? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseInputOptions? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParsePdfOptions? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseSpreadsheetOptions? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParsePresentationOptions? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseJobFailureConditions? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseMarkdownOptions? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseTables? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseOcrParameters? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseOutputOptions? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseSpatialTextOptions? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseTablesAsSpreadsheetOptions? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.LlamaParseOutputOptionsImagesToSaveVariant1Item>? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseOutputOptionsImagesToSaveVariant1Item? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.LlamaParseOutputOptionsGranularBboxe>? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseOutputOptionsGranularBboxe? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParsePageRanges? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseParameters? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseParametersPriority? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.LlamaParseParametersImagesToSaveVariant1Item>? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseParametersImagesToSaveVariant1Item? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseProcessingControl? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseTimeouts? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseProcessingOptions? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseProcessingOptionsSpecializedChartParsing? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AutoModeConfigurationEntry>? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseProcessingOptionsForms? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseSupportedFileExtensions? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseWebhookConfiguration? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseWebhookConfigurationWebhookOutputFormat? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ManagedIngestionStatus? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ManagedIngestionStatusResponse? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.IngestionErrorResponse>? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ManagedOpenAIEmbedding? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ManagedOpenAIEmbeddingConfig? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MarkdownLineNumberAnnotation? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MarkdownResult? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.MarkdownResultPage, global::LlamaParse.FailedMarkdownPage>>? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.MarkdownResultPage, global::LlamaParse.FailedMarkdownPage>? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MarkdownResultPage? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.MarkdownLineNumberAnnotation>? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MetadataValue? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MetadataFilter? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<int?, double?, string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<int>, object>? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MetadataFilters? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.MetadataFilter, global::LlamaParse.MetadataFilters>>? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.MetadataFilter, global::LlamaParse.MetadataFilters>? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MetadataResult? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.MetadataResultPage>? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MetadataResultPage? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MetadataResultDocument? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MetadataResultDocumentConfidenceBreakdown? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MetadataScalarValue? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MongoStaticFilters? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StringFilter? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.NodeRelationship? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.NumericRangeFilter? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.NumericRangeFilterOperator? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<int?, double?, global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<int?, double?>>>? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<int?, double?>>? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<int?, double?>? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ObjectType? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.OpenAIEmbedding? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Organization? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParsePlanLevel? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.OrganizationQueryResponse? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.OrganizationResponse>? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.OrganizationResponse? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PGVectorDistanceMethod? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PGVectorVectorType? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PageFigureMetadata? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PageScreenshotMetadata? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PaginatedExtractRunsResponse? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ExtractRun>? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PaginatedListCloudDocumentsResponse? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.CloudDocument>? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PaginatedListPipelineFilesResponse? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PipelineFile>? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineFile? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseConcernItem? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseJobDeleteResponse? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseJobQueryResponse? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ParseJobResponse>? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseJobResponse? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseJobResponseStatus? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseLatestVersions? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseRequestConfiguration? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.ParseRequestConfigurationTier?, string>? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseRequestConfigurationTier? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.ParseRequestConfigurationVersion?, string>? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseRequestConfigurationVersion? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.LlamaParseWebhookConfiguration>? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseResultResponse? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LlamaParse.ResultTypeMetadata>? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ResultTypeMetadata? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.TextResult? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StructuredResult? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseV2ParametersTier? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.ParseV2ParametersVersion?, string>? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseV2ParametersVersion? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseVersionsResponse? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ParseVersionsResponseFastItem>? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseVersionsResponseFastItem? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ParseVersionsResponseCostEffectiveItem>? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseVersionsResponseCostEffectiveItem? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ParseVersionsResponseAgenticItem>? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseVersionsResponseAgenticItem? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ParseVersionsResponseAgenticPlu>? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseVersionsResponseAgenticPlu? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParsingJob? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParsingJobJsonResult? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParsingJobMarkdownResult? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParsingJobStructuredResult? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParsingJobTextResult? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PartitionNames? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Pipeline? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineType? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingConfig3? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineEmbeddingConfigDiscriminator? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineEmbeddingConfigDiscriminatorType? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SparseModelConfig? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineConfigurationHashes? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.AutoTransformConfig, global::LlamaParse.AdvancedModeTransformConfig>? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineStatus? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineMetadataConfig? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineCreate? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingConfigVariant12? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineCreateEmbeddingConfigVariant1Discriminator? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineCreateEmbeddingConfigVariant1DiscriminatorType? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.AutoTransformConfig, global::LlamaParse.AdvancedModeTransformConfig, object>? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineDataSource? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineDataSourceStatus? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineDataSourceCreate? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineDataSourceUpdate? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineFileStatus? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineFileCreate? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineFileListResponse? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PipelineFileResponse>? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineFileResponse? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineFileResponseStatus? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineFileUpdate? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineQueryResponse? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PipelineResponse>? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineResponse? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineResponsePipelineType? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineResponseStatus? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineUpdate? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingConfigVariant13? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineUpdateEmbeddingConfigVariant1Discriminator? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineUpdateEmbeddingConfigVariant1DiscriminatorType? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PlaygroundSession? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ChatMessage>? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrievalMode? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ProcessingResultMetadata? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Project? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ProjectQueryResponse? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ProjectResponse>? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ProjectResponse? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ReRankerType? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RelatedNodeInfo? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.ObjectType?, string, object>? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RerankConfig2? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrievalParams? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrievalResult? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StaticFields? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrieveParams? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.ValueFilter, global::System.Collections.Generic.IList<global::LlamaParse.NumericRangeFilter>, object>? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ValueFilter? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.NumericRangeFilter>? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrieveResult? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.RetrievalResult>? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrieveResults? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.TextNodeWithScore>? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.TextNodeWithScore? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Retriever? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrieverCreate? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrieverUpdate? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Revision? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RevisionType? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RevisionBBox? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.RevisionTargetSpan>? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RevisionTargetSpan? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SearchRequest? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SessionCreate? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SessionDetail? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.EventsItem>? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EventsItem? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ThinkingDeltaEvent? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.TextDeltaEvent? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ThinkingEvent? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.TextEvent? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ToolCallEvent? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ToolResultEvent? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StopEvent? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.UserInputEvent? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SessionDetailEventDiscriminator? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SessionDetailEventDiscriminatorType? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SessionList? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ChatSessionSummary>? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SparseModelType? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitCategory? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitConfiguration? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.SplitCategory>? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitStrategy? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitCreateRequest? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitCreateRequestBeta? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitDocumentInput? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitJobQueryResponse? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.SplitJobResponse>? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitJobResponse? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitJobQueryResponseBeta? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.SplitJobResponseBeta>? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitJobResponseBeta? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitJobResponseDocumentInputType? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitResultResponse? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.SplitSegmentResponse>? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitSegmentResponse? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitStrategyAllowUncategorized? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SpreadsheetV1ParametersTier? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SpreadsheetV1ParametersTableMergeSensitivity? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AttachmentRef>? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Usage? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StringFilterOperator? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.StructuredResultPage, global::LlamaParse.FailedStructuredPage>>? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.StructuredResultPage, global::LlamaParse.FailedStructuredPage>? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StructuredResultPage? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ItemsItem7>? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ItemsItem7? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StructuredResultPageItemDiscriminator? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StructuredResultPageItemDiscriminatorType? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.Revision>? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?, double?, object>>>? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?, double?, object>>? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<string, int?, double?, object>? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ParseConcernItem>? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.TextNode? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.RelatedNodeInfo, global::System.Collections.Generic.IList<global::LlamaParse.RelatedNodeInfo>>? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.RelatedNodeInfo>? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.TextResultPage>? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.TextResultPage? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.UsageMetric? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.UsageMetricEventType? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.UsageMetricAggregateBucket? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.UsageMetricAggregateResponse? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.UsageMetricAggregateResponseGroupByItem>? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.UsageMetricAggregateResponseGroupByItem? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.UsageMetricAggregateBucket>? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.UsageMetricQueryResponse? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.UsageMetric>? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?>>? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<string, int?>? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ValueFilterOperator? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<string, int?, bool?, double?, global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?, bool?, double?>>>? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?, bool?, double?>>? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<string, int?, bool?, double?>? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VertexTextEmbedding? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VertexEmbeddingMode? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigCreateRequest? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigCreateRequestWebhookEventsVariant1Item>? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigCreateRequestWebhookEventsVariant1Item? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigCreateRequestWebhookOutputFormat? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigQueryResponse? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigResponse>? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigResponse? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigResponseWebhookEventsVariant1Item>? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigResponseWebhookEventsVariant1Item? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigResponseWebhookOutputFormat? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigUpdateRequest? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigUpdateRequestWebhookEventsVariant1Item>? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigUpdateRequestWebhookEventsVariant1Item? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigUpdateRequestWebhookOutputFormat? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item>? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PipelineDataSourceCreate>? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PipelineFileCreate>? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.CloudDocumentCreate>? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListProjectJobDataPointsApiV1JobDataPointsGetJobType? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item>? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetStatusRefreshPolicy? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PaginatedListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsPaginatedGetStatusRefreshPolicy? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListSplitJobsApiV1SplitJobsGetStatus? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem>? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetType? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1Item>? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1Item? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item>? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListSplitJobsApiV1BetaSplitJobsGetStatus? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item>? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListParseJobsApiV2ParseGetStatus? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListClassifyJobsApiV2ClassifyGetStatus? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListExtractJobsApiV2ExtractGetStatus? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListPipelinesApiV2PipelinesGetPipelineType? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListBatchesApiV2BatchesGetStatus? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.DataSource>? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.EmbeddingModelConfig>? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.Organization>? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.Project>? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PageScreenshotMetadata>? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PageFigureMetadata>? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.Pipeline>? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PipelineDataSource>? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.TextNode>? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.Retriever>? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.LlamaParseSupportedFileExtensions>? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ExtractJob>? Type728 { get; set; }

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
        public global::System.Collections.Generic.List<global::LlamaParse.JobDataPoint>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<global::LlamaParse.TextItem, global::LlamaParse.ListItem>>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.LlamaParseOutputOptionsImagesToSaveVariant1Item>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.LlamaParseOutputOptionsGranularBboxe>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.LlamaParseParametersImagesToSaveVariant1Item>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AutoModeConfigurationEntry>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.IngestionErrorResponse>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<global::LlamaParse.MarkdownResultPage, global::LlamaParse.FailedMarkdownPage>>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.MarkdownLineNumberAnnotation>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<int?, double?, string, global::System.Collections.Generic.List<string>, global::System.Collections.Generic.List<double>, global::System.Collections.Generic.List<int>, object>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<global::LlamaParse.MetadataFilter, global::LlamaParse.MetadataFilters>>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.MetadataResultPage>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<int?, double?, global::System.Collections.Generic.List<global::LlamaParse.AnyOf<int?, double?>>>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<int?, double?>>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.OrganizationResponse>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ExtractRun>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.CloudDocument>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.PipelineFile>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ParseJobResponse>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.LlamaParseWebhookConfiguration>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ParseVersionsResponseFastItem>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ParseVersionsResponseCostEffectiveItem>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ParseVersionsResponseAgenticItem>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ParseVersionsResponseAgenticPlu>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.PipelineFileResponse>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.PipelineResponse>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ChatMessage>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ProjectResponse>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.ValueFilter, global::System.Collections.Generic.List<global::LlamaParse.NumericRangeFilter>, object>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.NumericRangeFilter>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.RetrievalResult>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.TextNodeWithScore>? ListType89 { get; set; }
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
        public global::System.Collections.Generic.List<global::LlamaParse.Retriever>? ListType136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.LlamaParseSupportedFileExtensions>? ListType137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ExtractJob>? ListType138 { get; set; }
    }
}