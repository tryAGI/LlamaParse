using System.Text.Json;
using Microsoft.Extensions.AI;

namespace LlamaParse;

/// <summary>
/// Extensions for using LlamaParseClient operations as MEAI tools with any IChatClient.
/// </summary>
public static class LlamaParseToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that parses a document from a URL and returns
    /// the parsed markdown content. This is a blocking operation that uploads, polls for
    /// completion, and returns the result.
    /// </summary>
    /// <param name="client">The LlamaParse client.</param>
    /// <param name="pollingIntervalMs">Polling interval in milliseconds (default: 2000).</param>
    /// <param name="maxPollingAttempts">Maximum polling attempts before timeout (default: 60).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsParseUrlTool(
        this LlamaParseClient client,
        int pollingIntervalMs = 2000,
        int maxPollingAttempts = 60)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string url, string? parsingInstruction, CancellationToken cancellationToken) =>
            {
                // Upload the URL for parsing
                var job = await client.Parsing.UploadFileApiV1ParsingUploadPostAsync(
                    inputUrl: url,
                    parsingInstruction: parsingInstruction,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                // Poll until the job completes
                for (var i = 0; i < maxPollingAttempts; i++)
                {
                    var status = await client.Parsing.GetJobApiV1ParsingJobJobIdGetAsync(
                        jobId: job.Id,
                        cancellationToken: cancellationToken).ConfigureAwait(false);

                    if (status.Status == StatusEnum.Success)
                    {
                        // Fetch the markdown result
                        var result = await client.Parsing.GetJobResultApiV1ParsingJobJobIdResultMarkdownGetAsync(
                            jobId: job.Id,
                            cancellationToken: cancellationToken).ConfigureAwait(false);

                        return result.Markdown;
                    }

                    if (status.Status is StatusEnum.Error)
                    {
                        return $"Parsing failed for URL '{url}'.";
                    }

                    await Task.Delay(pollingIntervalMs, cancellationToken).ConfigureAwait(false);
                }

                return $"Parsing timed out for URL '{url}' after {maxPollingAttempts * pollingIntervalMs / 1000} seconds.";
            },
            name: "ParseDocumentUrl",
            description: "Parses a document from a URL (PDF, DOCX, PPTX, HTML, etc.) and returns the content as markdown. Accepts an optional parsing instruction to guide the extraction. Supports 130+ file formats.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that checks the status of a parsing job.
    /// </summary>
    /// <param name="client">The LlamaParse client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsGetJobStatusTool(this LlamaParseClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string jobId, CancellationToken cancellationToken) =>
            {
                var job = await client.Parsing.GetJobApiV1ParsingJobJobIdGetAsync(
                    jobId: jobId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(new
                {
                    id = job.Id,
                    status = job.Status.ToString(),
                });
            },
            name: "GetParsingJobStatus",
            description: "Checks the status of a LlamaParse parsing job by job ID. Returns the job ID and current status (PENDING, SUCCESS, ERROR).");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that retrieves the markdown result of a completed parsing job.
    /// </summary>
    /// <param name="client">The LlamaParse client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsGetJobResultTool(this LlamaParseClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string jobId, CancellationToken cancellationToken) =>
            {
                var result = await client.Parsing.GetJobResultApiV1ParsingJobJobIdResultMarkdownGetAsync(
                    jobId: jobId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return result.Markdown;
            },
            name: "GetParsingJobResult",
            description: "Retrieves the parsed markdown content of a completed LlamaParse job by job ID. Use GetParsingJobStatus first to verify the job has completed.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists supported file extensions.
    /// </summary>
    /// <param name="client">The LlamaParse client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsSupportedExtensionsTool(this LlamaParseClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var result = await client.Parsing.GetSupportedFileExtensionsApiV1ParsingSupportedFileExtensionsGetAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(result);
            },
            name: "GetSupportedFileExtensions",
            description: "Lists all file extensions supported by LlamaParse for document parsing (PDF, DOCX, PPTX, HTML, and 130+ more).");
    }
}
