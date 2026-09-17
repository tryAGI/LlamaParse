
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Which configurations to address: `project` for ones a job references by ID, or `project_default` for ones every job in the project notifies.<br/>
    /// Default Value: project
    /// </summary>
    public enum UpdateWebhookConfigApiV1BetaWebhookConfigsConfigIdPutTenantType
    {
        /// <summary>
        /// `project` for ones a job references by ID, or `project_default` for ones every job in the project notifies.
        /// </summary>
        Project,
        /// <summary>
        /// `project` for ones a job references by ID, or `project_default` for ones every job in the project notifies.
        /// </summary>
        ProjectDefault,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateWebhookConfigApiV1BetaWebhookConfigsConfigIdPutTenantTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateWebhookConfigApiV1BetaWebhookConfigsConfigIdPutTenantType value)
        {
            return value switch
            {
                UpdateWebhookConfigApiV1BetaWebhookConfigsConfigIdPutTenantType.Project => "project",
                UpdateWebhookConfigApiV1BetaWebhookConfigsConfigIdPutTenantType.ProjectDefault => "project_default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateWebhookConfigApiV1BetaWebhookConfigsConfigIdPutTenantType? ToEnum(string value)
        {
            return value switch
            {
                "project" => UpdateWebhookConfigApiV1BetaWebhookConfigsConfigIdPutTenantType.Project,
                "project_default" => UpdateWebhookConfigApiV1BetaWebhookConfigsConfigIdPutTenantType.ProjectDefault,
                _ => null,
            };
        }
    }
}