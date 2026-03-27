# Authentication

The LlamaParse API uses Bearer token authentication.

## Getting an API Key

1. Sign up at [cloud.llamaindex.ai](https://cloud.llamaindex.ai/)
2. Navigate to the API keys section
3. Create a new API key

## Client Initialization

```csharp
using LlamaParse;

var client = new LlamaParseClient(
    apiKey: Environment.GetEnvironmentVariable("LLAMAPARSE_API_KEY")!);
```

## Environment Variables

For integration tests, set the following environment variable:

```bash
export LLAMAPARSE_API_KEY=your-api-key-here
```
