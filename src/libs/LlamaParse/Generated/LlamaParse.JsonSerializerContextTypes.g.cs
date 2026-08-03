
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
        public global::LlamaParse.AutoModeParsingConfTier2? Type36 { get; set; }
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
        public global::LlamaParse.AutoModeParsingConfSpecializedChartParsing2? Type39 { get; set; }
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
        public global::LlamaParse.BatchParseJobConfigPriority2? Type70 { get; set; }
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
        public global::LlamaParse.ClassificationResult? Type109 { get; set; }
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
        public global::LlamaParse.ClassifyJobCreate? Type115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.LlamaParseWebhookConfiguration>? Type117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.LlamaParseWebhookConfiguration? Type118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ClassifyJobListResponse? Type119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ClassifyJob>? Type120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ClassifyJobResults? Type121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.FileClassification>? Type122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.FileClassification? Type123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ClassifyV2Configuration? Type125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ClassifyV2Rule>? Type126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ClassifyV2Rule? Type127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ClassifyV2ParsingConfiguration? Type128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ClassifyV2JobCreateRequest? Type129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ClassifyV2JobQueryResponse? Type130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ClassifyV2JobResponse>? Type131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ClassifyV2JobResponse? Type132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ClassifyV2JobResponseStatus? Type133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ClassifyV2JobResponseDocumentInputType? Type134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ClassifyV2Result? Type135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ClassifyV2Parameters? Type136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.CloudAstraDBVectorStore? Type137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.CloudAzStorageBlobDataSource? Type138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.CloudAzureAISearchVectorStore? Type139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.CloudBoxDataSource? Type140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.CloudConfluenceDataSource? Type141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.FailureHandlingConfig? Type142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.CloudDocument? Type143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.CloudDocumentCreate? Type144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.CloudGoogleDriveDataSource? Type145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.CloudJiraDataSource? Type146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.CloudJiraDataSourceV2? Type147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.CloudJiraDataSourceV2ApiVersion? Type148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.CloudMilvusVectorStore? Type149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.CloudMongoDBAtlasVectorSearch? Type150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.CloudNotionPageDataSource? Type151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.CloudOneDriveDataSource? Type152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.CloudPineconeVectorStore? Type153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.CloudPostgresVectorStore? Type154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.PGVectorHNSWSettings? Type155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.CloudQdrantVectorStore? Type156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.CloudS3DataSource? Type157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.CloudSharepointDataSource? Type158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.CloudSlackDataSource? Type159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.CodeItem? Type160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.BBox>? Type161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.CohereEmbedding? Type162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.CohereEmbeddingConfig? Type163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.CompositeRetrievalMode? Type164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.CompositeRetrievalParams? Type165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ReRankConfig? Type166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.CompositeRetrievalResult? Type167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.CompositeRetrievedTextNodeWithScore>? Type168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.CompositeRetrievedTextNodeWithScore? Type169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PageScreenshotNodeWithScore>? Type170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.PageScreenshotNodeWithScore? Type171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PageFigureNodeWithScore>? Type172 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.PageFigureNodeWithScore? Type173 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.CompositeRetrievedTextNode? Type174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ConfigurableDataSinkNames? Type175 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ConfigurableDataSourceNames? Type176 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ConfigurationCreateRequest? Type177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.Parameters? Type178 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.SplitV1Parameters? Type179 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ExtractV2Parameters? Type180 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ParseV2Parameters? Type181 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.SpreadsheetV1Parameters? Type182 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.UntypedParameters? Type183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ConfigurationCreateRequestParametersDiscriminator? Type184 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ConfigurationCreateRequestParametersDiscriminatorProductType? Type185 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ConfigurationQueryResponse? Type186 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ConfigurationResponse>? Type187 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ConfigurationResponse? Type188 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ConfigurationResponseProductType? Type189 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.Parameters2? Type190 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ConfigurationResponseParametersDiscriminator? Type191 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ConfigurationResponseParametersDiscriminatorProductType? Type192 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ConfigurationUpdateRequest? Type193 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ParametersVariant1? Type194 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ConfigurationUpdateRequestParametersVariant1Discriminator? Type195 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ConfigurationUpdateRequestParametersVariant1DiscriminatorProductType? Type196 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.DataSink? Type197 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.DataSinkCreate? Type198 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.DataSinkUpdate? Type199 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.DataSource? Type200 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.AnyOf<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>? Type201 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type202 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.DataSourceReaderVersionMetadata? Type203 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.DataSourceCreate? Type204 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.DataSourceReaderVersionMetadataReaderVersion2? Type205 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.DataSourceSyncRequest? Type206 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.DataSourceUpdate? Type207 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.DeleteRequest? Type208 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.DeleteResponse? Type209 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.DirectRetrievalParams? Type210 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.RetrieverPipeline>? Type211 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.RetrieverPipeline? Type212 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.DirectoryCreateRequest? Type213 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.DirectoryCreateRequestType? Type214 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.DirectoryFileBulkDeleteRequest? Type215 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.DirectoryFileCreateRequest? Type216 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.MetadataDict? Type217 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.DirectoryFileQueryResponse? Type218 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.DirectoryFileResponse>? Type219 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.DirectoryFileResponse? Type220 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.PresignedUrl? Type221 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.DirectoryFileUpdateRequest? Type222 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.DirectoryQueryResponse? Type223 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.DirectoryResponse>? Type224 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.DirectoryResponse? Type225 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.DirectoryResponseType2? Type226 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.DirectoryUpdateRequest? Type227 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.DocumentChunkMode? Type228 { get; set; }
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
        public global::LlamaParse.ExtractAgentUpdate? Type249 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ExtractConfigPriority2? Type250 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ExtractTarget? Type251 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ExtractMode? Type252 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.PublicModelName? Type253 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.ExtractModels?, string, object>? Type254 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ExtractModels? Type255 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ExtractConfiguration? Type256 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ExtractConfigurationTier? Type257 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ExtractConfigurationExtractionTarget? Type258 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ExtractJob? Type259 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ExtractJobStatus? Type260 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.File? Type261 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ExtractJobCreate? Type262 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ExtractJobCreatePriority2? Type263 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.AnyOf<object, string, object>? Type264 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ExtractJobCreateBatch? Type265 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ExtractJobMetadata? Type266 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ExtractedFieldMetadata? Type267 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ExtractJobUsage? Type268 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ExtractResultset? Type269 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.AnyOf<object, global::System.Collections.Generic.IList<object>, object>? Type270 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ExtractRun? Type271 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ExtractState? Type272 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ExtractSchemaGenerateRequest? Type273 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ExtractSchemaGenerateResponse? Type274 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ExtractSchemaValidateRequest? Type275 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ExtractSchemaValidateResponse? Type276 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ExtractStatelessRequest? Type277 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.FileData? Type278 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ExtractV2Job? Type279 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ExtractV2JobMetadata2? Type280 { get; set; }
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
        public global::LlamaParse.ExtractedRegionSummary? Type289 { get; set; }
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
        public global::System.Collections.Generic.Dictionary<string, int>? Type298 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.FileFilter? Type299 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.FileFindEntry? Type300 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.FileFindParams? Type301 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.FileFindResult? Type302 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.FileFindEntry>? Type303 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.FileGrepMatch? Type304 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.FileGrepParams? Type305 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.FileGrepResult? Type306 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.FileGrepMatch>? Type307 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.FileQueryRequest? Type308 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.FileQueryResponseV2? Type309 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.FileV2>? Type310 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.FileV2? Type311 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.FileReadParams? Type312 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.FileReadResult? Type313 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.FilterCondition? Type314 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.AnyOf<double?, int?, string, global::System.DateTime?, object>? Type315 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<double?, int?, string, global::System.DateTime?, object>>? Type316 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.FilterOperator? Type317 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.FooterItem? Type318 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ItemsItem>? Type319 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ItemsItem? Type320 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.TextItem? Type321 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.HeadingItem? Type322 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ListItem? Type323 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.TableItem? Type324 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ImageItem? Type325 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.LinkItem? Type326 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.FooterItemItemDiscriminator? Type327 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.FooterItemItemDiscriminatorType? Type328 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.Form? Type329 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.JsonItem>? Type330 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.JsonItem? Type331 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.FormSection? Type332 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.FormField? Type333 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.FormTable? Type334 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.FormJsonItemDiscriminator? Type335 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.FormJsonItemDiscriminatorType? Type336 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.FormListItem? Type337 { get; set; }
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
        public global::System.Collections.Generic.IList<global::LlamaParse.ItemsItem3>? Type347 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ItemsItem3? Type348 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.FormSectionItemDiscriminator? Type349 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.FormSectionItemDiscriminatorType? Type350 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, global::LlamaParse.FormTableCellItems, object>>>? Type351 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, global::LlamaParse.FormTableCellItems, object>>? Type352 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.AnyOf<string, global::LlamaParse.FormTableCellItems, object>? Type353 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.FormTableCellItems? Type354 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ItemsItem4>? Type355 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ItemsItem4? Type356 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.FormTableCellItemsItemDiscriminator? Type357 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.FormTableCellItemsItemDiscriminatorType? Type358 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.FormsResult? Type359 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.FormsResultPage, global::LlamaParse.FailedFormsPage>>? Type360 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.FormsResultPage, global::LlamaParse.FailedFormsPage>? Type361 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.FormsResultPage? Type362 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.Form>? Type363 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.GeminiEmbedding? Type364 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.HTTPValidationError? Type365 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ValidationError>? Type366 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ValidationError? Type367 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.HeaderItem? Type368 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ItemsItem5>? Type369 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ItemsItem5? Type370 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.HeaderItemItemDiscriminator? Type371 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.HeaderItemItemDiscriminatorType? Type372 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.HuggingFaceInferenceAPIEmbedding? Type373 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.Pooling? Type374 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ImageAttachmentRef? Type375 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ImageMetadata? Type376 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ImageMetadataCategory2? Type377 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ImageMetadataBBox2? Type378 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ImagesContentMetadata? Type379 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ImageMetadata>? Type380 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.IndexCreateRequest? Type381 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.IndexProductEntry>? Type382 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.IndexProductEntry? Type383 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.IndexCreateRequestVectorTarget? Type384 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.IndexMetadata? Type385 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.IndexQueryResponse? Type386 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.IndexResponse>? Type387 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.IndexResponse? Type388 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.IngestionErrorResponse? Type389 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.JobNameMapping? Type390 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ItemProcessingResultsResponse? Type391 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ProcessingResult>? Type392 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ProcessingResult? Type393 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.JobDataPoint? Type394 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.JobStateTransitions? Type395 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.JobDataPointResponse? Type396 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.JobDataPoint>? Type397 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.SupportedLLMModelNames? Type398 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.TextItem, global::LlamaParse.ListItem>>? Type399 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.TextItem, global::LlamaParse.ListItem>? Type400 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.LlamaParseAgenticOptions? Type401 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.LlamaParseCostOptimizerParameters? Type402 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.LlamaParseCropBox? Type403 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.LlamaParseFastOptions? Type404 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.LlamaParseHtmlOptions? Type405 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.LlamaParseIgnoreOptions? Type406 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.LlamaParseImageOptions? Type407 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.LlamaParseInputOptions? Type408 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.LlamaParsePdfOptions? Type409 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.LlamaParseSpreadsheetOptions? Type410 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.LlamaParsePresentationOptions? Type411 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.LlamaParseJobFailureConditions? Type412 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.LlamaParseMarkdownOptions? Type413 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.LlamaParseTables? Type414 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.LlamaParseOcrParameters? Type415 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.LlamaParseOutputOptions? Type416 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.LlamaParseSpatialTextOptions? Type417 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.LlamaParseTablesAsSpreadsheetOptions? Type418 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.LlamaParseOutputOptionsImagesToSaveItem>? Type419 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.LlamaParseOutputOptionsImagesToSaveItem? Type420 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.LlamaParseOutputOptionsGranularBboxe>? Type421 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.LlamaParseOutputOptionsGranularBboxe? Type422 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.LlamaParsePageRanges? Type423 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.LlamaParseParameters? Type424 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.LlamaParseParametersPriority2? Type425 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.LlamaParseParametersImagesToSaveVariant1Item>? Type426 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.LlamaParseParametersImagesToSaveVariant1Item? Type427 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.LlamaParseProcessingControl? Type428 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.LlamaParseTimeouts? Type429 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.LlamaParseProcessingOptions? Type430 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.LlamaParseProcessingOptionsSpecializedChartParsing2? Type431 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AutoModeConfigurationEntry>? Type432 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.LlamaParseProcessingOptionsForms2? Type433 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.LlamaParseSupportedFileExtensions? Type434 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.LlamaParseWebhookConfigurationWebhookOutputFormat2? Type435 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ManagedIngestionStatus? Type436 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ManagedIngestionStatusResponse? Type437 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.IngestionErrorResponse>? Type438 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ManagedOpenAIEmbedding? Type439 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ManagedOpenAIEmbeddingConfig? Type440 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.MarkdownResult? Type441 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.MarkdownResultPage, global::LlamaParse.FailedMarkdownPage>>? Type442 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.MarkdownResultPage, global::LlamaParse.FailedMarkdownPage>? Type443 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.MarkdownResultPage? Type444 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.MetadataValue? Type445 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.MetadataFilter? Type446 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.AnyOf<int?, double?, string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<int>, object>? Type447 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type448 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.MetadataFilters? Type449 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.MetadataFilter, global::LlamaParse.MetadataFilters>>? Type450 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.MetadataFilter, global::LlamaParse.MetadataFilters>? Type451 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.MetadataResult? Type452 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.MetadataResultPage>? Type453 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.MetadataResultPage? Type454 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.MetadataScalarValue? Type455 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.MongoStaticFilters? Type456 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.StringFilter? Type457 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.NodeRelationship? Type458 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.NumericRangeFilter? Type459 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.NumericRangeFilterOperator? Type460 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.AnyOf<int?, double?, global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<int?, double?>>>? Type461 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<int?, double?>>? Type462 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.AnyOf<int?, double?>? Type463 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ObjectType? Type464 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.OpenAIEmbedding? Type465 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.Organization? Type466 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ParsePlanLevel? Type467 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.OrganizationQueryResponse? Type468 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.OrganizationResponse>? Type469 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.OrganizationResponse? Type470 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.PGVectorDistanceMethod? Type471 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.PGVectorVectorType? Type472 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.PageFigureMetadata? Type473 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.PageScreenshotMetadata? Type474 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.PaginatedExtractRunsResponse? Type475 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ExtractRun>? Type476 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.PaginatedListCloudDocumentsResponse? Type477 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.CloudDocument>? Type478 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.PaginatedListPipelineFilesResponse? Type479 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PipelineFile>? Type480 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.PipelineFile? Type481 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ParseConcernItem? Type482 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ParseJobQueryResponse? Type483 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ParseJobResponse>? Type484 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ParseJobResponse? Type485 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ParseJobResponseStatus? Type486 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ParseRequestConfiguration? Type487 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.ParseRequestConfigurationTier?, string>? Type488 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ParseRequestConfigurationTier? Type489 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.ParseRequestConfigurationVersion?, string>? Type490 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ParseRequestConfigurationVersion? Type491 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ParseResultResponse? Type492 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LlamaParse.ResultTypeMetadata>? Type493 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ResultTypeMetadata? Type494 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.TextResult? Type495 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.StructuredResult? Type496 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ParseV2ParametersTier? Type497 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.ParseV2ParametersVersion?, string>? Type498 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ParseV2ParametersVersion? Type499 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ParseVersionsResponse? Type500 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ParseVersionsResponseFastItem>? Type501 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ParseVersionsResponseFastItem? Type502 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ParseVersionsResponseCostEffectiveItem>? Type503 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ParseVersionsResponseCostEffectiveItem? Type504 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ParseVersionsResponseAgenticItem>? Type505 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ParseVersionsResponseAgenticItem? Type506 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ParseVersionsResponseAgenticPlu>? Type507 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ParseVersionsResponseAgenticPlu? Type508 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ParsingJob? Type509 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ParsingJobJsonResult? Type510 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ParsingJobMarkdownResult? Type511 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ParsingJobStructuredResult? Type512 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ParsingJobTextResult? Type513 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.PartitionNames? Type514 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.Pipeline? Type515 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.PipelineType? Type516 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.EmbeddingConfig3? Type517 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.PipelineEmbeddingConfigDiscriminator? Type518 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.PipelineEmbeddingConfigDiscriminatorType? Type519 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.SparseModelConfig? Type520 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.PipelineConfigurationHashes? Type521 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.AutoTransformConfig, global::LlamaParse.AdvancedModeTransformConfig>? Type522 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.PipelineStatus2? Type523 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.PipelineMetadataConfig2? Type524 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.PipelineCreate? Type525 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.EmbeddingConfigVariant12? Type526 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.PipelineCreateEmbeddingConfigVariant1Discriminator? Type527 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.PipelineCreateEmbeddingConfigVariant1DiscriminatorType? Type528 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.AutoTransformConfig, global::LlamaParse.AdvancedModeTransformConfig, object>? Type529 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.PipelineDataSource? Type530 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.PipelineDataSourceStatus2? Type531 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.PipelineDataSourceCreate? Type532 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.PipelineDataSourceUpdate? Type533 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.PipelineFileStatus2? Type534 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.PipelineFileCreate? Type535 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.PipelineFileListResponse? Type536 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PipelineFileResponse>? Type537 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.PipelineFileResponse? Type538 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.PipelineFileResponseStatus2? Type539 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.PipelineFileUpdate? Type540 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.PipelineUpdate? Type541 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.EmbeddingConfigVariant13? Type542 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.PipelineUpdateEmbeddingConfigVariant1Discriminator? Type543 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.PipelineUpdateEmbeddingConfigVariant1DiscriminatorType? Type544 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.PlaygroundSession? Type545 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ChatMessage>? Type546 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.RetrievalMode? Type547 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ProcessingResultMetadata? Type548 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.Project? Type549 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ProjectQueryResponse? Type550 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ProjectResponse>? Type551 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ProjectResponse? Type552 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ReRankerType? Type553 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.RelatedNodeInfo? Type554 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.ObjectType?, string, object>? Type555 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.RerankConfig2? Type556 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.RetrievalParams? Type557 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.RetrievalResult? Type558 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.StaticFields? Type559 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.RetrieveParams? Type560 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.ValueFilter, global::System.Collections.Generic.IList<global::LlamaParse.NumericRangeFilter>, object>? Type561 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ValueFilter? Type562 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.NumericRangeFilter>? Type563 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.RetrieveResult? Type564 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.RetrievalResult>? Type565 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.RetrieveResults? Type566 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.TextNodeWithScore>? Type567 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.TextNodeWithScore? Type568 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type569 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.Retriever? Type570 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.RetrieverCreate? Type571 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.RetrieverUpdate? Type572 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.Revision? Type573 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.RevisionType? Type574 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.RevisionBBox? Type575 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.RevisionTargetSpan>? Type576 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.RevisionTargetSpan? Type577 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.SearchRequest? Type578 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.SessionCreate? Type579 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.SessionDetail? Type580 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.EventsItem>? Type581 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.EventsItem? Type582 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ThinkingDeltaEvent? Type583 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.TextDeltaEvent? Type584 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ThinkingEvent? Type585 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.TextEvent? Type586 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ToolCallEvent? Type587 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ToolResultEvent? Type588 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.StopEvent? Type589 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.UserInputEvent? Type590 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.SessionDetailEventDiscriminator? Type591 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.SessionDetailEventDiscriminatorType? Type592 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.SessionList? Type593 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ChatSessionSummary>? Type594 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.SparseModelType? Type595 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.SplitCategory? Type596 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.SplitConfiguration? Type597 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.SplitCategory>? Type598 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.SplitStrategy? Type599 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.SplitCreateRequest? Type600 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.SplitCreateRequestBeta? Type601 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.SplitDocumentInput? Type602 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.SplitJobQueryResponse? Type603 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.SplitJobResponse>? Type604 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.SplitJobResponse? Type605 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.SplitJobQueryResponseBeta? Type606 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.SplitJobResponseBeta>? Type607 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.SplitJobResponseBeta? Type608 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.SplitJobResponseDocumentInputType? Type609 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.SplitResultResponse? Type610 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.SplitSegmentResponse>? Type611 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.SplitSegmentResponse? Type612 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.SplitStrategyAllowUncategorized? Type613 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.SpreadsheetJob? Type614 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.SpreadsheetParsingConfig? Type615 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.SpreadsheetJobStatus? Type616 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.SpreadsheetJobParameters? Type617 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ExtractedRegionSummary>? Type618 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.WorksheetMetadata>? Type619 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.WorksheetMetadata? Type620 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.SpreadsheetJobCreate? Type621 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.SpreadsheetJobQueryResponse? Type622 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.SpreadsheetJob>? Type623 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.SpreadsheetParsingConfigTier? Type624 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.SpreadsheetParsingConfigTableMergeSensitivity? Type625 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.SpreadsheetResultType? Type626 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.SpreadsheetV1ParametersTier? Type627 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.SpreadsheetV1ParametersTableMergeSensitivity? Type628 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AttachmentRef>? Type629 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.Usage? Type630 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.StringFilterOperator? Type631 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type632 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.StructuredResultPage, global::LlamaParse.FailedStructuredPage>>? Type633 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.StructuredResultPage, global::LlamaParse.FailedStructuredPage>? Type634 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.StructuredResultPage? Type635 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ItemsItem7>? Type636 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ItemsItem7? Type637 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.StructuredResultPageItemDiscriminator? Type638 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.StructuredResultPageItemDiscriminatorType? Type639 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.Revision>? Type640 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?, double?, object>>>? Type641 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?, double?, object>>? Type642 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.AnyOf<string, int?, double?, object>? Type643 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ParseConcernItem>? Type644 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.TextNode? Type645 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.RelatedNodeInfo, global::System.Collections.Generic.IList<global::LlamaParse.RelatedNodeInfo>>? Type646 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.RelatedNodeInfo>? Type647 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.TextResultPage>? Type648 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.TextResultPage? Type649 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.UsageMetric? Type650 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.UsageMetricEventType? Type651 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.UsageMetricAggregateBucket? Type652 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.UsageMetricAggregateResponse? Type653 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.UsageMetricAggregateResponseGroupByItem>? Type654 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.UsageMetricAggregateResponseGroupByItem? Type655 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.UsageMetricAggregateBucket>? Type656 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.UsageMetricQueryResponse? Type657 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.UsageMetric>? Type658 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?>>? Type659 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.AnyOf<string, int?>? Type660 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ValueFilterOperator? Type661 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.AnyOf<string, int?, bool?, double?, global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?, bool?, double?>>>? Type662 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?, bool?, double?>>? Type663 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.AnyOf<string, int?, bool?, double?>? Type664 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.VertexTextEmbedding? Type665 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.VertexEmbeddingMode? Type666 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.WebhookConfigCreateRequest? Type667 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigCreateRequestWebhookEventsVariant1Item>? Type668 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.WebhookConfigCreateRequestWebhookEventsVariant1Item? Type669 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.WebhookConfigCreateRequestWebhookOutputFormat2? Type670 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.WebhookConfigResponse? Type671 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigResponseWebhookEventsVariant1Item>? Type672 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.WebhookConfigResponseWebhookEventsVariant1Item? Type673 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.WebhookConfigResponseWebhookOutputFormat2? Type674 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.WebhookConfigUpdateRequest? Type675 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigUpdateRequestWebhookEventsVariant1Item>? Type676 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.WebhookConfigUpdateRequestWebhookEventsVariant1Item? Type677 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.WebhookConfigUpdateRequestWebhookOutputFormat2? Type678 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item>? Type679 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item? Type680 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PipelineDataSourceCreate>? Type681 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PipelineFileCreate>? Type682 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.CloudDocumentCreate>? Type683 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ListProjectJobDataPointsApiV1JobDataPointsGetJobType? Type684 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item>? Type685 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item? Type686 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetStatusRefreshPolicy? Type687 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.PaginatedListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsPaginatedGetStatusRefreshPolicy? Type688 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ListSpreadsheetJobsApiV1SheetsJobsGetStatus2? Type689 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ListSplitJobsApiV1SplitJobsGetStatus2? Type690 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem>? Type691 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem? Type692 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ListSpreadsheetJobsApiV1BetaSheetsJobsGetStatus2? Type693 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetType2? Type694 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1Item>? Type695 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1Item? Type696 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item>? Type697 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item? Type698 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ListSplitJobsApiV1BetaSplitJobsGetStatus2? Type699 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item>? Type700 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item? Type701 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ListParseJobsApiV2ParseGetStatus2? Type702 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ListClassifyJobsApiV2ClassifyGetStatus2? Type703 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ListExtractJobsApiV2ExtractGetStatus2? Type704 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ListBatchesApiV2BatchesGetStatus2? Type705 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.DataSink>? Type706 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.DataSource>? Type707 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.EmbeddingModelConfig>? Type708 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.Organization>? Type709 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.Project>? Type710 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PageScreenshotMetadata>? Type711 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PageFigureMetadata>? Type712 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.Pipeline>? Type713 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PipelineDataSource>? Type714 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.TextNode>? Type715 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.Retriever>? Type716 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.LlamaParseSupportedFileExtensions>? Type717 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ExtractJob>? Type718 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ExtractAgent>? Type719 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigResponse>? Type720 { get; set; }

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
        public global::System.Collections.Generic.List<global::System.Guid>? ListType13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.LlamaParseWebhookConfiguration>? ListType14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ClassifyJob>? ListType15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.FileClassification>? ListType16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ClassifyV2Rule>? ListType18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ClassifyV2JobResponse>? ListType19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.BBox>? ListType20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.CompositeRetrievedTextNodeWithScore>? ListType21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.PageScreenshotNodeWithScore>? ListType22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.PageFigureNodeWithScore>? ListType23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ConfigurationResponse>? ListType24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.AnyOf<object, global::System.Collections.Generic.List<object>, string, int?, double?, bool?, object>? ListType25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.RetrieverPipeline>? ListType27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.DirectoryFileResponse>? ListType28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.DirectoryResponse>? ListType29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.AnyOf<object, global::System.Collections.Generic.List<object>, object>? ListType30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ExtractV2Job>? ListType31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.FileAttachmentMetadata>? ListType32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.FileFindEntry>? ListType33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.FileGrepMatch>? ListType34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.FileV2>? ListType35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<double?, int?, string, global::System.DateTime?, object>>? ListType36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ItemsItem>? ListType37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.JsonItem>? ListType38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ValueItemsVariant1Item>? ListType39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<global::LlamaParse.FormListTextItem, global::LlamaParse.FormListItem>>? ListType40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ItemsItem3>? ListType41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::LlamaParse.AnyOf<string, global::LlamaParse.FormTableCellItems, object>>>? ListType42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<string, global::LlamaParse.FormTableCellItems, object>>? ListType43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ItemsItem4>? ListType44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<global::LlamaParse.FormsResultPage, global::LlamaParse.FailedFormsPage>>? ListType45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.Form>? ListType46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ValidationError>? ListType47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ItemsItem5>? ListType48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ImageMetadata>? ListType49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.IndexProductEntry>? ListType50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.IndexResponse>? ListType51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ProcessingResult>? ListType52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.JobDataPoint>? ListType53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<global::LlamaParse.TextItem, global::LlamaParse.ListItem>>? ListType54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.LlamaParseOutputOptionsImagesToSaveItem>? ListType55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.LlamaParseOutputOptionsGranularBboxe>? ListType56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.LlamaParseParametersImagesToSaveVariant1Item>? ListType57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AutoModeConfigurationEntry>? ListType58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.IngestionErrorResponse>? ListType59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<global::LlamaParse.MarkdownResultPage, global::LlamaParse.FailedMarkdownPage>>? ListType60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.AnyOf<int?, double?, string, global::System.Collections.Generic.List<string>, global::System.Collections.Generic.List<double>, global::System.Collections.Generic.List<int>, object>? ListType61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<global::LlamaParse.MetadataFilter, global::LlamaParse.MetadataFilters>>? ListType63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.MetadataResultPage>? ListType64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.AnyOf<int?, double?, global::System.Collections.Generic.List<global::LlamaParse.AnyOf<int?, double?>>>? ListType65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<int?, double?>>? ListType66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.OrganizationResponse>? ListType67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ExtractRun>? ListType68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.CloudDocument>? ListType69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.PipelineFile>? ListType70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ParseJobResponse>? ListType71 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ParseVersionsResponseFastItem>? ListType72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ParseVersionsResponseCostEffectiveItem>? ListType73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ParseVersionsResponseAgenticItem>? ListType74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ParseVersionsResponseAgenticPlu>? ListType75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.PipelineFileResponse>? ListType76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ChatMessage>? ListType77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ProjectResponse>? ListType78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.ValueFilter, global::System.Collections.Generic.List<global::LlamaParse.NumericRangeFilter>, object>? ListType79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.NumericRangeFilter>? ListType80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.RetrievalResult>? ListType81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.TextNodeWithScore>? ListType82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.RevisionTargetSpan>? ListType83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.EventsItem>? ListType84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ChatSessionSummary>? ListType85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.SplitCategory>? ListType86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.SplitJobResponse>? ListType87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.SplitJobResponseBeta>? ListType88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.SplitSegmentResponse>? ListType89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ExtractedRegionSummary>? ListType90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.WorksheetMetadata>? ListType91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.SpreadsheetJob>? ListType92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AttachmentRef>? ListType93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.AnyOf<string, global::System.Collections.Generic.List<string>>? ListType94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<global::LlamaParse.StructuredResultPage, global::LlamaParse.FailedStructuredPage>>? ListType95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ItemsItem7>? ListType96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.Revision>? ListType97 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::LlamaParse.AnyOf<string, int?, double?, object>>>? ListType98 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<string, int?, double?, object>>? ListType99 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ParseConcernItem>? ListType100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.RelatedNodeInfo, global::System.Collections.Generic.List<global::LlamaParse.RelatedNodeInfo>>? ListType101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.RelatedNodeInfo>? ListType102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.TextResultPage>? ListType103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.UsageMetricAggregateResponseGroupByItem>? ListType104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.UsageMetricAggregateBucket>? ListType105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.UsageMetric>? ListType106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<string, int?>>? ListType107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.AnyOf<string, int?, bool?, double?, global::System.Collections.Generic.List<global::LlamaParse.AnyOf<string, int?, bool?, double?>>>? ListType108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<string, int?, bool?, double?>>? ListType109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.WebhookConfigCreateRequestWebhookEventsVariant1Item>? ListType110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.WebhookConfigResponseWebhookEventsVariant1Item>? ListType111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.WebhookConfigUpdateRequestWebhookEventsVariant1Item>? ListType112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item>? ListType113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.PipelineDataSourceCreate>? ListType114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.PipelineFileCreate>? ListType115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.CloudDocumentCreate>? ListType116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item>? ListType117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem>? ListType118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1Item>? ListType119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item>? ListType120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item>? ListType121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.DataSink>? ListType122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.DataSource>? ListType123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.EmbeddingModelConfig>? ListType124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.Organization>? ListType125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.Project>? ListType126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.PageScreenshotMetadata>? ListType127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.PageFigureMetadata>? ListType128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.Pipeline>? ListType129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.PipelineDataSource>? ListType130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.TextNode>? ListType131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.Retriever>? ListType132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.LlamaParseSupportedFileExtensions>? ListType133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ExtractJob>? ListType134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ExtractAgent>? ListType135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.WebhookConfigResponse>? ListType136 { get; set; }
    }
}