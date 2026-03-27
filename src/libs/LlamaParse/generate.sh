dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://api.cloud.llamaindex.ai/api/openapi.json

# Fix: Add top-level security array and servers section
# Fix: Rename FilterOperator symbolic enum values to valid C# identifiers
jq '
  .security = [{"HTTPBearer": []}] |
  .servers = [{"url": "https://api.cloud.llamaindex.ai"}] |
  .components.schemas.FilterOperator.enum = [
    "eq", "gt", "lt", "ne", "gte", "lte",
    "in", "nin", "any", "all",
    "text_match", "text_match_insensitive", "contains", "is_empty"
  ]
' openapi.yaml > openapi_fixed.yaml
mv openapi_fixed.yaml openapi.yaml

autosdk generate openapi.yaml \
  --namespace LlamaParse \
  --clientClassName LlamaParseClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
