
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
        public const string DefaultBaseUrl = "https://api.cloud.llamaindex.ai/";

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

        /// <inheritdoc/>
        public global::LlamaParse.AutoSDKClientOptions Options { get; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; } = global::LlamaParse.SourceGenerationContext.Default;


        /// <summary>
        /// 
        /// </summary>
        public BetaClient Beta => new BetaClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public ClassifierClient Classifier => new ClassifierClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public DataSinksClient DataSinks => new DataSinksClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public DataSourcesClient DataSources => new DataSourcesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingModelConfigsClient EmbeddingModelConfigs => new EmbeddingModelConfigsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public LlamaExtractClient LlamaExtract => new LlamaExtractClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public OrganizationsClient Organizations => new OrganizationsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public PageFiguresClient PageFigures => new PageFiguresClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public PageScreenshotsClient PageScreenshots => new PageScreenshotsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public ParsingClient Parsing => new ParsingClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public PipelineDataSourcesClient PipelineDataSources => new PipelineDataSourcesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public PipelineFilesClient PipelineFiles => new PipelineFilesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public PipelinesClient Pipelines => new PipelinesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public ProjectsClient Projects => new ProjectsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public RetrieversClient Retrievers => new RetrieversClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public V2Client V2 => new V2Client(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
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
            bool disposeHttpClient = true) : this(
                httpClient,
                baseUri,
                authorizations,
                options: null,
                disposeHttpClient: disposeHttpClient)
        {
        }

        /// <summary>
        /// Creates a new instance of the LlamaParseClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public LlamaParseClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::LlamaParse.EndPointAuthorization>? authorizations = null,
            global::LlamaParse.AutoSDKClientOptions? options = null,
            bool disposeHttpClient = true)
        {

            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::LlamaParse.EndPointAuthorization>();
            Options = options ?? new global::LlamaParse.AutoSDKClientOptions();
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