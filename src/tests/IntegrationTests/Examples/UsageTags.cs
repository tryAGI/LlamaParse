/*
order: 20
title: Usage Tags
slug: usage-tags

Track LlamaParse usage by adding the Usage-Tags header to any generated request.
*/

namespace LlamaParse.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void UsageTags_CreateRequestOptionsAddsHeader()
    {
        var requestOptions = LlamaParseRequestOptions.CreateWithUsageTags("team:search", "env:test");

        requestOptions.Headers.Should().ContainKey(LlamaParseRequestOptions.UsageTagsHeaderName);
        requestOptions.Headers[LlamaParseRequestOptions.UsageTagsHeaderName].Should().Be("team:search,env:test");
    }

    [TestMethod]
    public void UsageTags_WithUsageTagsPreservesExistingHeaders()
    {
        var requestOptions = new AutoSDKRequestOptions
        {
            Headers =
            {
                ["X-Correlation-ID"] = "request-123",
            },
        };

        requestOptions.WithUsageTags("team:search");

        requestOptions.Headers["X-Correlation-ID"].Should().Be("request-123");
        requestOptions.Headers[LlamaParseRequestOptions.UsageTagsHeaderName].Should().Be("team:search");
    }

    [TestMethod]
    public void UsageTags_WithUsageTagsValidatesInput()
    {
        var empty = () => LlamaParseRequestOptions.CreateWithUsageTags();
        var blank = () => LlamaParseRequestOptions.CreateWithUsageTags("team:search", " ");
        var comma = () => LlamaParseRequestOptions.CreateWithUsageTags("team:search,env:test");
        var tooMany = () => LlamaParseRequestOptions.CreateWithUsageTags("team:a", "team:b", "team:c", "team:d", "team:e");

        empty.Should().Throw<ArgumentException>();
        blank.Should().Throw<ArgumentException>();
        comma.Should().Throw<ArgumentException>();
        tooMany.Should().Throw<ArgumentOutOfRangeException>();
    }
}
