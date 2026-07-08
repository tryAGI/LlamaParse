# LlamaParse

[![Nuget package](https://img.shields.io/nuget/vpre/LlamaParse)](https://www.nuget.org/packages/LlamaParse/)
[![dotnet](https://github.com/tryAGI/LlamaParse/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/LlamaParse/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/LlamaParse)](https://github.com/tryAGI/LlamaParse/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official LlamaParse OpenAPI specification](https://api.cloud.llamaindex.ai/api/openapi.json) using [AutoSDK](https://github.com/HavenDV/AutoSDK)
- Covers the current LlamaParse Platform surface: Parse, Extract, Classify, Split, Sheets, Index, Retrieval, files, directories, batches, usage metrics, and webhook configuration APIs.
- Supports current Parse options from the official API, including user metadata, cost optimizer settings, saved configuration IDs, webhook configuration IDs, and per-request usage tags.
- Retrieval Harness endpoints are generated for retrieve, find files, grep files, and read files workflows.
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Targets .NET 10.

### Usage
```csharp
using LlamaParse;

using var client = new LlamaParseClient(apiKey);

var requestOptions = LlamaParseRequestOptions.CreateWithUsageTags("team:search", "env:prod");
var job = await client.V2.ParseFileApiV2ParsePostAsync(
    tier: "agentic",
    version: "latest",
    sourceUrl: "https://example.com/document.pdf",
    userMetadata: new Dictionary<string, string>
    {
        ["customer"] = "acme",
    },
    requestOptions: requestOptions);
```

<!-- EXAMPLES:START -->
<!-- EXAMPLES:END -->

## Support

Priority place for bugs: https://github.com/tryAGI/LlamaParse/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/LlamaParse/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
