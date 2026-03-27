#nullable enable

namespace LlamaParse
{
    public partial interface IParsingClient
    {
        /// <summary>
        /// Get Supported File Extensions<br/>
        /// Get a list of supported file extensions
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LlamaParse.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LlamaParse.LlamaParseSupportedFileExtensions>> GetSupportedFileExtensionsApiV1ParsingSupportedFileExtensionsGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}