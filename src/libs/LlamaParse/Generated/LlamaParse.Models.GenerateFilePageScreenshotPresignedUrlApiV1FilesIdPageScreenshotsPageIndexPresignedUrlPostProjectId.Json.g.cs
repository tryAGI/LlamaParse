#nullable enable

namespace LlamaParse
{
    public sealed partial class GenerateFilePageScreenshotPresignedUrlApiV1FilesIdPageScreenshotsPageIndexPresignedUrlPostProjectId
    {
        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the generated default JsonSerializerContext.
        /// </summary>
        public string ToJson()
        {
            return ToJson(global::LlamaParse.SourceGenerationContext.Default);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            if (jsonSerializerOptions is null)
            {
                return ToJson(global::LlamaParse.SourceGenerationContext.Default);
            }

            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::LlamaParse.GenerateFilePageScreenshotPresignedUrlApiV1FilesIdPageScreenshotsPageIndexPresignedUrlPostProjectId? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::LlamaParse.GenerateFilePageScreenshotPresignedUrlApiV1FilesIdPageScreenshotsPageIndexPresignedUrlPostProjectId),
                jsonSerializerContext) as global::LlamaParse.GenerateFilePageScreenshotPresignedUrlApiV1FilesIdPageScreenshotsPageIndexPresignedUrlPostProjectId;
        }

        /// <summary>
        /// Deserializes a JSON string using the generated default JsonSerializerContext.
        /// </summary>
        public static global::LlamaParse.GenerateFilePageScreenshotPresignedUrlApiV1FilesIdPageScreenshotsPageIndexPresignedUrlPostProjectId? FromJson(
            string json)
        {
            return FromJson(
                json,
                global::LlamaParse.SourceGenerationContext.Default);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::LlamaParse.GenerateFilePageScreenshotPresignedUrlApiV1FilesIdPageScreenshotsPageIndexPresignedUrlPostProjectId? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            if (jsonSerializerOptions is null)
            {
                return FromJson(
                    json,
                    global::LlamaParse.SourceGenerationContext.Default);
            }

            return global::System.Text.Json.JsonSerializer.Deserialize<global::LlamaParse.GenerateFilePageScreenshotPresignedUrlApiV1FilesIdPageScreenshotsPageIndexPresignedUrlPostProjectId>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::LlamaParse.GenerateFilePageScreenshotPresignedUrlApiV1FilesIdPageScreenshotsPageIndexPresignedUrlPostProjectId?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::LlamaParse.GenerateFilePageScreenshotPresignedUrlApiV1FilesIdPageScreenshotsPageIndexPresignedUrlPostProjectId),
                jsonSerializerContext).ConfigureAwait(false)) as global::LlamaParse.GenerateFilePageScreenshotPresignedUrlApiV1FilesIdPageScreenshotsPageIndexPresignedUrlPostProjectId;
        }

        /// <summary>
        /// Deserializes a JSON stream using the generated default JsonSerializerContext.
        /// </summary>
        public static global::System.Threading.Tasks.ValueTask<global::LlamaParse.GenerateFilePageScreenshotPresignedUrlApiV1FilesIdPageScreenshotsPageIndexPresignedUrlPostProjectId?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream)
        {
            return FromJsonStreamAsync(
                jsonStream,
                global::LlamaParse.SourceGenerationContext.Default);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::LlamaParse.GenerateFilePageScreenshotPresignedUrlApiV1FilesIdPageScreenshotsPageIndexPresignedUrlPostProjectId?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            if (jsonSerializerOptions is null)
            {
                return FromJsonStreamAsync(
                    jsonStream,
                    global::LlamaParse.SourceGenerationContext.Default);
            }

            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::LlamaParse.GenerateFilePageScreenshotPresignedUrlApiV1FilesIdPageScreenshotsPageIndexPresignedUrlPostProjectId?>(
                jsonStream,
                jsonSerializerOptions);
        }
    }
}
