
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Owner tenant type.
    /// </summary>
    public enum WebhookConfigResponseTenantType
    {
        /// <summary>
        ///
        /// </summary>
        Project,
        /// <summary>
        ///
        /// </summary>
        ProjectDefault,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookConfigResponseTenantTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookConfigResponseTenantType value)
        {
            return value switch
            {
                WebhookConfigResponseTenantType.Project => "project",
                WebhookConfigResponseTenantType.ProjectDefault => "project_default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookConfigResponseTenantType? ToEnum(string value)
        {
            return value switch
            {
                "project" => WebhookConfigResponseTenantType.Project,
                "project_default" => WebhookConfigResponseTenantType.ProjectDefault,
                _ => null,
            };
        }
    }
}