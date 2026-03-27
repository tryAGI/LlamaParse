/* order: 10, title: MEAI Tools, slug: meai-tools */

using Microsoft.Extensions.AI;

namespace LlamaParse.IntegrationTests;

public partial class Tests
{
    //// LlamaParse provides AIFunction tools that can be used with any
    //// `Microsoft.Extensions.AI.IChatClient` to give AI agents the ability
    //// to parse documents from URLs and retrieve results.

    [TestMethod]
    public async Task Meai_AsParseUrlTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that parses a document from a URL:
        var tool = client.AsParseUrlTool(
            pollingIntervalMs: 2000,
            maxPollingAttempts: 60);

        tool.Name.Should().Be("ParseDocumentUrl");
        tool.Description.Should().Contain("URL");
        tool.Description.Should().Contain("markdown");
    }

    [TestMethod]
    public async Task Meai_AsGetJobStatusTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that checks the status of a parsing job:
        var tool = client.AsGetJobStatusTool();

        tool.Name.Should().Be("GetParsingJobStatus");
        tool.Description.Should().Contain("status");
    }

    [TestMethod]
    public async Task Meai_AsGetJobResultTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that retrieves the parsed markdown result:
        var tool = client.AsGetJobResultTool();

        tool.Name.Should().Be("GetParsingJobResult");
        tool.Description.Should().Contain("markdown");
    }

    [TestMethod]
    public async Task Meai_AsSupportedExtensionsTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that lists supported file extensions:
        var tool = client.AsSupportedExtensionsTool();

        tool.Name.Should().Be("GetSupportedFileExtensions");
        tool.Description.Should().Contain("extension");

        //// The tool returns a JSON array of supported file extensions.
        var result = await tool.InvokeAsync(
            cancellationToken: CancellationToken.None);

        result.Should().NotBeNull();
        Console.WriteLine($"SupportedExtensions result: {result}");
    }
}
