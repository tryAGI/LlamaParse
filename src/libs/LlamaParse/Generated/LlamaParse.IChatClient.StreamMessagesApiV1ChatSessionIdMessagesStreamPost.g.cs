#nullable enable

namespace LlamaParse
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Stream Messages<br/>
        /// Stream agent events for a chat turn as Server-Sent Events.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StreamMessagesApiV1ChatSessionIdMessagesStreamPostAsync(
            string sessionId,

            global::LlamaParse.ChatParams request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stream Messages<br/>
        /// Stream agent events for a chat turn as Server-Sent Events.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LlamaParse.AutoSDKHttpResponse<string>> StreamMessagesApiV1ChatSessionIdMessagesStreamPostAsResponseAsync(
            string sessionId,

            global::LlamaParse.ChatParams request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stream Messages<br/>
        /// Stream agent events for a chat turn as Server-Sent Events.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="indexIds">
        /// Indexes to retrieve data from.
        /// </param>
        /// <param name="prompt">
        /// User message for this chat turn.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> StreamMessagesApiV1ChatSessionIdMessagesStreamPostAsync(
            string sessionId,
            global::System.Collections.Generic.IList<string> indexIds,
            string prompt,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::LlamaParse.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}