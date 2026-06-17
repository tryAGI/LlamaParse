
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Detect documents photographed with a camera (e.g. phone scans of receipts or forms), then crop, perspective-correct, and flatten uneven lighting and shadows before parsing. Supports JPEG, PNG, WebP, and HEIC/HEIF inputs. Improves results when the document is tilted or surrounded by background. Images that already look like clean scans are left untouched
    /// </summary>
    public sealed partial class LlamaParseImageOptionsCameraPhotoCorrection
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}