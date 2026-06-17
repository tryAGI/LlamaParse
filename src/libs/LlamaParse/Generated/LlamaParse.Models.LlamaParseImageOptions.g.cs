
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Image parsing options.
    /// </summary>
    public sealed partial class LlamaParseImageOptions
    {
        /// <summary>
        /// Detect documents photographed with a camera (e.g. phone scans of receipts or forms), then crop, perspective-correct, and flatten uneven lighting and shadows before parsing. Supports JPEG, PNG, WebP, and HEIC/HEIF inputs. Improves results when the document is tilted or surrounded by background. Images that already look like clean scans are left untouched
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("camera_photo_correction")]
        public bool? CameraPhotoCorrection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlamaParseImageOptions" /> class.
        /// </summary>
        /// <param name="cameraPhotoCorrection">
        /// Detect documents photographed with a camera (e.g. phone scans of receipts or forms), then crop, perspective-correct, and flatten uneven lighting and shadows before parsing. Supports JPEG, PNG, WebP, and HEIC/HEIF inputs. Improves results when the document is tilted or surrounded by background. Images that already look like clean scans are left untouched
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LlamaParseImageOptions(
            bool? cameraPhotoCorrection)
        {
            this.CameraPhotoCorrection = cameraPhotoCorrection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlamaParseImageOptions" /> class.
        /// </summary>
        public LlamaParseImageOptions()
        {
        }

    }
}