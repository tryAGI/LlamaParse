# Microsoft.Extensions.AI Integration

LlamaParse provides `AIFunction` tools compatible with
[Microsoft.Extensions.AI](https://www.nuget.org/packages/Microsoft.Extensions.AI),
allowing any `IChatClient` to parse documents via LlamaParse.

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsParseUrlTool()` | `ParseDocumentUrl` | Parses a document from a URL and returns markdown. Uploads, polls for completion, and returns the result. |
| `AsGetJobStatusTool()` | `GetParsingJobStatus` | Checks the status of a parsing job by job ID. |
| `AsGetJobResultTool()` | `GetParsingJobResult` | Retrieves the parsed markdown content of a completed job. |
| `AsSupportedExtensionsTool()` | `GetSupportedFileExtensions` | Lists all file extensions supported by LlamaParse. |

## Usage

```csharp
using LlamaParse;
using Microsoft.Extensions.AI;

var llamaParse = new LlamaParseClient(apiKey);

// Create tools
var tools = new[]
{
    llamaParse.AsParseUrlTool(),
    llamaParse.AsGetJobStatusTool(),
    llamaParse.AsGetJobResultTool(),
    llamaParse.AsSupportedExtensionsTool(),
};

// Use with any IChatClient
var response = await chatClient.GetResponseAsync(
    "Parse this PDF and summarize it: https://example.com/doc.pdf",
    new ChatOptions { Tools = tools });
```

## Tool Details

### ParseDocumentUrl

A blocking tool that:
1. Uploads the URL for parsing
2. Polls until the job completes (configurable interval and max attempts)
3. Returns the parsed markdown content

Parameters:
- `url` (required): The URL of the document to parse
- `parsingInstruction` (optional): Instructions to guide the extraction

```csharp
var tool = llamaParse.AsParseUrlTool(
    pollingIntervalMs: 2000,    // Poll every 2 seconds
    maxPollingAttempts: 60);    // Timeout after 120 seconds
```

### GetParsingJobStatus / GetParsingJobResult

For async workflows, use these tools separately:
1. Start a parse job via the LlamaParse API
2. Use `GetParsingJobStatus` to check if the job is complete
3. Use `GetParsingJobResult` to retrieve the markdown content

### GetSupportedFileExtensions

Returns a JSON array of all 130+ file formats supported by LlamaParse
(PDF, DOCX, PPTX, HTML, and more).
