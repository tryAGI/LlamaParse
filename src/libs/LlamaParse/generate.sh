#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://api.cloud.llamaindex.ai/api/openapi.json

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -L -o openapi.yaml https://api.cloud.llamaindex.ai/api/openapi.json

# Fix 1: Add servers section and rename FilterOperator symbolic enum values to valid C# identifiers
jq '
  .servers = [{"url": "https://api.cloud.llamaindex.ai"}] |
  .components.schemas.FilterOperator.enum = [
    "eq", "gt", "lt", "ne", "gte", "lte",
    "in", "nin", "any", "all",
    "text_match", "text_match_insensitive", "contains", "is_empty"
  ]
' openapi.yaml > openapi_fixed.yaml
mv openapi_fixed.yaml openapi.yaml

# Auth: --security-scheme ensures AutoSDK generates Bearer constructors.
autosdk generate openapi.yaml \
  --namespace LlamaParse \
  --clientClassName LlamaParseClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
