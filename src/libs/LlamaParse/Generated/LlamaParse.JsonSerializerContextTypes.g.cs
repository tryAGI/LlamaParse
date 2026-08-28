
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
        public global::LlamaParse.DocumentCountByStatusResponse? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingModelConfig? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingConfig? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.GeminiEmbeddingConfig? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.HuggingFaceInferenceAPIEmbeddingConfig? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.OpenAIEmbeddingConfig? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VertexAIEmbeddingConfig? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingModelConfigEmbeddingConfigDiscriminator? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingModelConfigEmbeddingConfigDiscriminatorType? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingModelConfigCreate? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingConfig2? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingModelConfigCreateEmbeddingConfigDiscriminator? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingModelConfigUpdate? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingConfigVariant1? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingModelConfigUpdateEmbeddingConfigVariant1Discriminator? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorType? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractAgent? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractConfig? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractAgentCreate? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<object, string>? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractAgentUpdate? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractConfigPriority2? Type252 { get; set; }
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
        public global::LlamaParse.AnyOf<global::LlamaParse.ExtractModels?, string, object>? Type256 { get; set; }
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
        public global::LlamaParse.ExtractJob? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractJobStatus? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.File? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractJobCreate? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractJobCreatePriority2? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<object, string, object>? Type266 { get; set; }
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
        public global::LlamaParse.AnyOf<object, global::System.Collections.Generic.IList<object>, object>? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractRun? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractState? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractSchemaGenerateRequest? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractSchemaGenerateResponse? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractSchemaValidateRequest? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractSchemaValidateResponse? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractStatelessRequest? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileData? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractUsage? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2Job? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2JobMetadata2? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2JobCreate? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2JobQueryResponse? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ExtractV2Job>? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2ParametersTier? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2ParametersExtractionTarget? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2SchemaGenerateRequest? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2SchemaValidateRequest? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ExtractV2SchemaValidateResponse? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FailedFormsPage? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FailedMarkdownPage? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FailedStructuredPage? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileAttachmentListResponse? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.FileAttachmentMetadata>? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileAttachmentMetadata? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileCountByStatusResponse? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileFilter? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileFindEntry? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileFindParams? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileFindResult? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.FileFindEntry>? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileGrepMatch? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileGrepParams? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileGrepResult? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.FileGrepMatch>? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileQueryRequest? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileQueryResponseV2? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.FileV2>? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileV2? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileReadParams? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FileReadResult? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FilterCondition? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<double?, int?, string, global::System.DateTime?, object>? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<double?, int?, string, global::System.DateTime?, object>>? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FilterOperator? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FooterItem? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ItemsItem>? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ItemsItem? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.TextItem? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.HeadingItem? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListItem? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.TableItem? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ImageItem? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LinkItem? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FooterItemItemDiscriminator? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FooterItemItemDiscriminatorType? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Form? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.JsonItem>? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.JsonItem? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormSection? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormField? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormTable? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormJsonItemDiscriminator? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormJsonItemDiscriminatorType? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormListItem? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormFieldField? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<string, bool?, object>? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ValueItemsVariant1Item>? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ValueItemsVariant1Item? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormFieldValueItemsVariant1ItemDiscriminator? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormFieldValueItemsVariant1ItemDiscriminatorType? Type344 { get; set; }
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
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, global::LlamaParse.FormTableCellItems, object>>>? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, global::LlamaParse.FormTableCellItems, object>>? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<string, global::LlamaParse.FormTableCellItems, object>? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormTableCellItems? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ItemsItem4>? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ItemsItem4? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormTableCellItemsItemDiscriminator? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormTableCellItemsItemDiscriminatorType? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormsResult? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.FormsResultPage, global::LlamaParse.FailedFormsPage>>? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.FormsResultPage, global::LlamaParse.FailedFormsPage>? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.FormsResultPage? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.Form>? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.GeminiEmbedding? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.HTTPValidationError? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ValidationError>? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ValidationError? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.HeaderItem? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ItemsItem5>? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ItemsItem5? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.HeaderItemItemDiscriminator? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.HeaderItemItemDiscriminatorType? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.HuggingFaceInferenceAPIEmbedding? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Pooling? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ImageAttachmentRef? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ImageMetadata? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ImageMetadataCategory2? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ImageMetadataBBox2? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ImagesContentMetadata? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ImageMetadata>? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.IndexCreateRequest? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.IndexProductEntry>? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.IndexProductEntry? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.IndexCreateRequestVectorTarget? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.IndexMetadata? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.IndexQueryResponse? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.IndexResponse>? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.IndexResponse? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.IngestionErrorResponse? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.JobNameMapping? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ItemProcessingResultsResponse? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ProcessingResult>? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ProcessingResult? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.JobDataPoint? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.JobStateTransitions? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.JobDataPointResponse? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.JobDataPoint>? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.JobUsage? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SupportedLLMModelNames? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.TextItem, global::LlamaParse.ListItem>>? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.TextItem, global::LlamaParse.ListItem>? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseAgenticOptions? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseCostOptimizerParameters? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseCropBox? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseFastOptions? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseHtmlOptions? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseIgnoreOptions? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseImageOptions? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseInputOptions? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParsePdfOptions? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseSpreadsheetOptions? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParsePresentationOptions? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseJobFailureConditions? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseMarkdownOptions? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseTables? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseOcrParameters? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseOutputOptions? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseSpatialTextOptions? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseTablesAsSpreadsheetOptions? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.LlamaParseOutputOptionsImagesToSaveVariant1Item>? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseOutputOptionsImagesToSaveVariant1Item? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.LlamaParseOutputOptionsGranularBboxe>? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseOutputOptionsGranularBboxe? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParsePageRanges? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseParameters? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseParametersPriority2? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.LlamaParseParametersImagesToSaveVariant1Item>? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseParametersImagesToSaveVariant1Item? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseProcessingControl? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseTimeouts? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseProcessingOptions? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseProcessingOptionsSpecializedChartParsing2? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AutoModeConfigurationEntry>? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseProcessingOptionsForms2? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseSupportedFileExtensions? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.LlamaParseWebhookConfigurationWebhookOutputFormat2? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ManagedIngestionStatus? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ManagedIngestionStatusResponse? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.IngestionErrorResponse>? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ManagedOpenAIEmbedding? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ManagedOpenAIEmbeddingConfig? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MarkdownLineNumberAnnotation? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MarkdownResult? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.MarkdownResultPage, global::LlamaParse.FailedMarkdownPage>>? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.MarkdownResultPage, global::LlamaParse.FailedMarkdownPage>? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MarkdownResultPage? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.MarkdownLineNumberAnnotation>? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MetadataValue? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MetadataFilter? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<int?, double?, string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<int>, object>? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MetadataFilters? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.MetadataFilter, global::LlamaParse.MetadataFilters>>? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.MetadataFilter, global::LlamaParse.MetadataFilters>? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MetadataResult? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.MetadataResultPage>? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MetadataResultPage? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MetadataResultDocument2? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MetadataResultDocumentConfidenceBreakdown2? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MetadataScalarValue? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.MongoStaticFilters? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StringFilter? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.NodeRelationship? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.NumericRangeFilter? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.NumericRangeFilterOperator? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<int?, double?, global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<int?, double?>>>? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<int?, double?>>? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<int?, double?>? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ObjectType? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.OpenAIEmbedding? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Organization? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParsePlanLevel? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.OrganizationQueryResponse? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.OrganizationResponse>? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.OrganizationResponse? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PGVectorDistanceMethod? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PGVectorVectorType? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PageFigureMetadata? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PageScreenshotMetadata? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PaginatedExtractRunsResponse? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ExtractRun>? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PaginatedListCloudDocumentsResponse? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.CloudDocument>? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PaginatedListPipelineFilesResponse? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PipelineFile>? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineFile? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseConcernItem? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseJobQueryResponse? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ParseJobResponse>? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseJobResponse? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseJobResponseStatus? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseRequestConfiguration? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.ParseRequestConfigurationTier?, string>? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseRequestConfigurationTier? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.ParseRequestConfigurationVersion?, string>? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseRequestConfigurationVersion? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseResultResponse? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LlamaParse.ResultTypeMetadata>? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ResultTypeMetadata? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.TextResult? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StructuredResult? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseV2ParametersTier? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.ParseV2ParametersVersion?, string>? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseV2ParametersVersion? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseVersionsResponse? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ParseVersionsResponseFastItem>? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseVersionsResponseFastItem? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ParseVersionsResponseCostEffectiveItem>? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseVersionsResponseCostEffectiveItem? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ParseVersionsResponseAgenticItem>? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseVersionsResponseAgenticItem? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ParseVersionsResponseAgenticPlu>? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParseVersionsResponseAgenticPlu? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParsingJob? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParsingJobJsonResult? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParsingJobMarkdownResult? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParsingJobStructuredResult? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ParsingJobTextResult? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PartitionNames? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Pipeline? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineType? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingConfig3? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineEmbeddingConfigDiscriminator? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineEmbeddingConfigDiscriminatorType? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SparseModelConfig? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineConfigurationHashes? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.AutoTransformConfig, global::LlamaParse.AdvancedModeTransformConfig>? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineStatus2? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineMetadataConfig2? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineCreate? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingConfigVariant12? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineCreateEmbeddingConfigVariant1Discriminator? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineCreateEmbeddingConfigVariant1DiscriminatorType? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.AutoTransformConfig, global::LlamaParse.AdvancedModeTransformConfig, object>? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineDataSource? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineDataSourceStatus2? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineDataSourceCreate? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineDataSourceUpdate? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineFileStatus2? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineFileCreate? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineFileListResponse? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PipelineFileResponse>? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineFileResponse? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineFileResponseStatus2? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineFileUpdate? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineUpdate? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EmbeddingConfigVariant13? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineUpdateEmbeddingConfigVariant1Discriminator? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PipelineUpdateEmbeddingConfigVariant1DiscriminatorType? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PlaygroundSession? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ChatMessage>? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrievalMode? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ProcessingResultMetadata? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Project? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ProjectQueryResponse? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ProjectResponse>? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ProjectResponse? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ReRankerType? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RelatedNodeInfo? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.ObjectType?, string, object>? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RerankConfig2? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrievalParams? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrievalResult? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StaticFields? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrieveParams? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.ValueFilter, global::System.Collections.Generic.IList<global::LlamaParse.NumericRangeFilter>, object>? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ValueFilter? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.NumericRangeFilter>? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrieveResult? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.RetrievalResult>? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrieveResults? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.TextNodeWithScore>? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.TextNodeWithScore? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Retriever? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrieverCreate? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RetrieverUpdate? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Revision? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RevisionType? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RevisionBBox? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.RevisionTargetSpan>? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.RevisionTargetSpan? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SearchRequest? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SessionCreate? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SessionDetail? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.EventsItem>? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.EventsItem? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ThinkingDeltaEvent? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.TextDeltaEvent? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ThinkingEvent? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.TextEvent? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ToolCallEvent? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ToolResultEvent? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StopEvent? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.UserInputEvent? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SessionDetailEventDiscriminator? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SessionDetailEventDiscriminatorType? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SessionList? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ChatSessionSummary>? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SparseModelType? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitCategory? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitConfiguration? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.SplitCategory>? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitStrategy? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitCreateRequest? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitCreateRequestBeta? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitDocumentInput? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitJobQueryResponse? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.SplitJobResponse>? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitJobResponse? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitJobQueryResponseBeta? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.SplitJobResponseBeta>? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitJobResponseBeta? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitJobResponseDocumentInputType? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitResultResponse? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.SplitSegmentResponse>? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitSegmentResponse? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SplitStrategyAllowUncategorized? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SpreadsheetV1ParametersTier? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.SpreadsheetV1ParametersTableMergeSensitivity? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AttachmentRef>? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.Usage? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StringFilterOperator? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<global::LlamaParse.StructuredResultPage, global::LlamaParse.FailedStructuredPage>>? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.StructuredResultPage, global::LlamaParse.FailedStructuredPage>? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StructuredResultPage? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ItemsItem7>? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ItemsItem7? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StructuredResultPageItemDiscriminator? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.StructuredResultPageItemDiscriminatorType? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.Revision>? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?, double?, object>>>? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?, double?, object>>? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<string, int?, double?, object>? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ParseConcernItem>? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.TextNode? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.RelatedNodeInfo, global::System.Collections.Generic.IList<global::LlamaParse.RelatedNodeInfo>>? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.RelatedNodeInfo>? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.TextResultPage>? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.TextResultPage? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.UsageMetric? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.UsageMetricEventType? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.UsageMetricAggregateBucket? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.UsageMetricAggregateResponse? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.UsageMetricAggregateResponseGroupByItem>? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.UsageMetricAggregateResponseGroupByItem? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.UsageMetricAggregateBucket>? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.UsageMetricQueryResponse? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.UsageMetric>? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?>>? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<string, int?>? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ValueFilterOperator? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<string, int?, bool?, double?, global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?, bool?, double?>>>? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AnyOf<string, int?, bool?, double?>>? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<string, int?, bool?, double?>? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VertexTextEmbedding? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.VertexEmbeddingMode? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigCreateRequest? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigCreateRequestWebhookEventsVariant1Item>? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigCreateRequestWebhookEventsVariant1Item? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigCreateRequestWebhookOutputFormat2? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigResponse? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigResponseWebhookEventsVariant1Item>? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigResponseWebhookEventsVariant1Item? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigResponseWebhookOutputFormat2? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigUpdateRequest? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigUpdateRequestWebhookEventsVariant1Item>? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigUpdateRequestWebhookEventsVariant1Item? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigUpdateRequestWebhookOutputFormat2? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item>? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PipelineDataSourceCreate>? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PipelineFileCreate>? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.CloudDocumentCreate>? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListProjectJobDataPointsApiV1JobDataPointsGetJobType? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item>? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetStatusRefreshPolicy? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.PaginatedListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsPaginatedGetStatusRefreshPolicy? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListSplitJobsApiV1SplitJobsGetStatus2? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem>? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetType2? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1Item>? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1Item? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item>? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListSplitJobsApiV1BetaSplitJobsGetStatus2? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item>? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListParseJobsApiV2ParseGetStatus2? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListClassifyJobsApiV2ClassifyGetStatus2? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListExtractJobsApiV2ExtractGetStatus2? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.ListBatchesApiV2BatchesGetStatus2? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.DataSink>? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.DataSource>? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.EmbeddingModelConfig>? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.Organization>? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.Project>? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PageScreenshotMetadata>? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PageFigureMetadata>? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.Pipeline>? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.PipelineDataSource>? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.TextNode>? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.Retriever>? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.LlamaParseSupportedFileExtensions>? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ExtractJob>? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.ExtractAgent>? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LlamaParse.WebhookConfigResponse>? Type711 { get; set; }

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
        public global::System.Collections.Generic.List<global::LlamaParse.LlamaParseOutputOptionsImagesToSaveVariant1Item>? ListType55 { get; set; }
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
        public global::System.Collections.Generic.List<global::LlamaParse.MarkdownLineNumberAnnotation>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<int?, double?, string, global::System.Collections.Generic.List<string>, global::System.Collections.Generic.List<double>, global::System.Collections.Generic.List<int>, object>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<global::LlamaParse.MetadataFilter, global::LlamaParse.MetadataFilters>>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.MetadataResultPage>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<int?, double?, global::System.Collections.Generic.List<global::LlamaParse.AnyOf<int?, double?>>>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<int?, double?>>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.OrganizationResponse>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ExtractRun>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.CloudDocument>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.PipelineFile>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ParseJobResponse>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ParseVersionsResponseFastItem>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ParseVersionsResponseCostEffectiveItem>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ParseVersionsResponseAgenticItem>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ParseVersionsResponseAgenticPlu>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.PipelineFileResponse>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ChatMessage>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ProjectResponse>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.ValueFilter, global::System.Collections.Generic.List<global::LlamaParse.NumericRangeFilter>, object>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.NumericRangeFilter>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.RetrievalResult>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.TextNodeWithScore>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.RevisionTargetSpan>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.EventsItem>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ChatSessionSummary>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.SplitCategory>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.SplitJobResponse>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.SplitJobResponseBeta>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.SplitSegmentResponse>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AttachmentRef>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<string, global::System.Collections.Generic.List<string>>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<global::LlamaParse.StructuredResultPage, global::LlamaParse.FailedStructuredPage>>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ItemsItem7>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.Revision>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::LlamaParse.AnyOf<string, int?, double?, object>>>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<string, int?, double?, object>>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ParseConcernItem>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<global::LlamaParse.RelatedNodeInfo, global::System.Collections.Generic.List<global::LlamaParse.RelatedNodeInfo>>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.RelatedNodeInfo>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.TextResultPage>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.UsageMetricAggregateResponseGroupByItem>? ListType102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.UsageMetricAggregateBucket>? ListType103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.UsageMetric>? ListType104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<string, int?>>? ListType105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LlamaParse.AnyOf<string, int?, bool?, double?, global::System.Collections.Generic.List<global::LlamaParse.AnyOf<string, int?, bool?, double?>>>? ListType106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AnyOf<string, int?, bool?, double?>>? ListType107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.WebhookConfigCreateRequestWebhookEventsVariant1Item>? ListType108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.WebhookConfigResponseWebhookEventsVariant1Item>? ListType109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.WebhookConfigUpdateRequestWebhookEventsVariant1Item>? ListType110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.WebhookConfigurationWebhookEventsVariant1Item>? ListType111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.PipelineDataSourceCreate>? ListType112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.PipelineFileCreate>? ListType113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.CloudDocumentCreate>? ListType114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item>? ListType115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem>? ListType116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ListDirectoriesApiV1BetaDirectoriesGetTypesVariant1Item>? ListType117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item>? ListType118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item>? ListType119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.DataSink>? ListType120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.DataSource>? ListType121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.EmbeddingModelConfig>? ListType122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.Organization>? ListType123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.Project>? ListType124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.PageScreenshotMetadata>? ListType125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.PageFigureMetadata>? ListType126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.Pipeline>? ListType127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.PipelineDataSource>? ListType128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.TextNode>? ListType129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.Retriever>? ListType130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.LlamaParseSupportedFileExtensions>? ListType131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ExtractJob>? ListType132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.ExtractAgent>? ListType133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LlamaParse.WebhookConfigResponse>? ListType134 { get; set; }
    }
}