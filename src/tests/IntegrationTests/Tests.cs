namespace LlamaParse.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static LlamaParseClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("LLAMAPARSE_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("LLAMAPARSE_API_KEY environment variable is not found.");

        var client = new LlamaParseClient(apiKey);
        
        return client;
    }
}
