# CLAUDE.md — LlamaParse SDK

## Overview

Auto-generated C# SDK for [LlamaParse](https://cloud.llamaindex.ai/) (LlamaCloud) — document parsing, extraction, pipelines, retrievers, classifiers, embeddings, and project management.
OpenAPI spec from `https://api.cloud.llamaindex.ai/api/openapi.json`.

## Build & Test

```bash
dotnet build LlamaParse.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth:

```csharp
var client = new LlamaParseClient(apiKey); // LLAMAPARSE_API_KEY env var
```

## Key Files

- `src/libs/LlamaParse/openapi.yaml` — OpenAPI spec (downloaded from LlamaCloud API)
- `src/libs/LlamaParse/generate.sh` — Downloads spec, fixes servers/enum values, runs autosdk with `--security-scheme Http:Header:Bearer`
- `src/libs/LlamaParse/Generated/` — **Never edit** — auto-generated code (~4500 files)
- `src/tests/IntegrationTests/Tests.cs` — Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` — Example tests (also generate docs)

## Spec Notes

- `--security-scheme Http:Header:Bearer` handles auth; `jq` injects `servers` section
- `FilterOperator` enum values are renamed from symbolic operators (`==`, `>`, `<`, etc.) to valid C# identifiers (`eq`, `gt`, `lt`, etc.)
- Uses `--exclude-deprecated-operations` flag

## Sub-client Pattern

LlamaCloud API has tagged operations generating sub-clients:
- `client.Parsing.*` — Upload documents for parsing, get parsing results (text, markdown, images)
- `client.Files.*` — File management (upload, list, get, delete)
- `client.Pipelines.*` — Pipeline management (CRUD, run, configure)
- `client.PipelineFiles.*` — Manage files within pipelines
- `client.PipelineDataSources.*` — Pipeline data source configuration
- `client.DataSources.*` — Data source management
- `client.DataSinks.*` — Data sink management
- `client.Retrievers.*` — Retriever configuration and execution
- `client.Classifier.*` — Document classification
- `client.LlamaExtract.*` — Structured data extraction from documents
- `client.EmbeddingModelConfigs.*` — Embedding model configuration
- `client.Projects.*` — Project management
- `client.Organizations.*` — Organization management
- `client.PageScreenshots.*` — Page screenshot retrieval
- `client.PageFigures.*` — Page figure extraction
- `client.Beta.*` — Beta endpoints
- `client.V2.*` — V2 API endpoints

## MEAI

No MEAI interface implemented — LlamaParse is a document parsing/extraction platform with no matching MEAI interface.
