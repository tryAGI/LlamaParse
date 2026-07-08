using System.Collections.Generic;

namespace LlamaParse;

/// <summary>
/// Helpers for LlamaParse request-level options that are represented as HTTP headers.
/// </summary>
public static class LlamaParseRequestOptions
{
    /// <summary>
    /// Header used by LlamaParse billing metrics to attribute usage to up to four custom tags.
    /// </summary>
    public const string UsageTagsHeaderName = "Usage-Tags";

    /// <summary>
    /// Maximum number of usage tags accepted by LlamaParse on a single request.
    /// </summary>
    public const int MaxUsageTags = 4;

    /// <summary>
    /// Creates request options with the LlamaParse usage tags header set.
    /// </summary>
    /// <param name="usageTags">One to four non-empty usage tags.</param>
    /// <returns>Request options that can be passed to generated SDK methods.</returns>
    public static AutoSDKRequestOptions CreateWithUsageTags(params string[] usageTags)
    {
        return new AutoSDKRequestOptions().WithUsageTags(usageTags);
    }

    /// <summary>
    /// Adds or replaces the LlamaParse usage tags header on existing request options.
    /// </summary>
    /// <param name="requestOptions">Request options to mutate.</param>
    /// <param name="usageTags">One to four non-empty usage tags.</param>
    /// <returns>The same request options instance for chaining.</returns>
    public static AutoSDKRequestOptions WithUsageTags(
        this AutoSDKRequestOptions requestOptions,
        params string[] usageTags)
    {
        return requestOptions.WithUsageTags((IEnumerable<string?>)usageTags);
    }

    /// <summary>
    /// Adds or replaces the LlamaParse usage tags header on existing request options.
    /// </summary>
    /// <param name="requestOptions">Request options to mutate.</param>
    /// <param name="usageTags">One to four non-empty usage tags.</param>
    /// <returns>The same request options instance for chaining.</returns>
    public static AutoSDKRequestOptions WithUsageTags(
        this AutoSDKRequestOptions requestOptions,
        IEnumerable<string?> usageTags)
    {
        ArgumentNullException.ThrowIfNull(requestOptions);
        ArgumentNullException.ThrowIfNull(usageTags);

        var normalizedTags = NormalizeUsageTags(usageTags);
        requestOptions.Headers[UsageTagsHeaderName] = string.Join(",", normalizedTags);

        return requestOptions;
    }

    private static List<string> NormalizeUsageTags(IEnumerable<string?> usageTags)
    {
        var normalizedTags = new List<string>();
        foreach (var usageTag in usageTags)
        {
            var normalizedTag = usageTag?.Trim();
            if (string.IsNullOrWhiteSpace(normalizedTag))
            {
                throw new ArgumentException("Usage tags cannot be empty.", nameof(usageTags));
            }

            foreach (var character in normalizedTag)
            {
                if (character == ',')
                {
                    throw new ArgumentException("Usage tags cannot contain commas.", nameof(usageTags));
                }
            }

            normalizedTags.Add(normalizedTag);
        }

        if (normalizedTags.Count == 0)
        {
            throw new ArgumentException("At least one usage tag is required.", nameof(usageTags));
        }

        if (normalizedTags.Count > MaxUsageTags)
        {
            throw new ArgumentOutOfRangeException(
                nameof(usageTags),
                normalizedTags.Count,
                $"LlamaParse accepts at most {MaxUsageTags} usage tags per request.");
        }

        return normalizedTags;
    }
}
