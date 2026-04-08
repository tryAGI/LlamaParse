#nullable enable

namespace LlamaParse
{
    public partial interface IRetrieversClient
    {
        /// <summary>
        /// Delete Retriever<br/>
        /// Delete a Retriever by ID.
        /// </summary>
        /// <param name="retrieverId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteRetrieverApiV1RetrieversRetrieverIdDeleteAsync(
            global::System.Guid retrieverId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}