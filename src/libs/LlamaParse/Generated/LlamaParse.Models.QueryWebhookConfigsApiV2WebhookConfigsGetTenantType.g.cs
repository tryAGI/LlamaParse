
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Which configurations to address: `project` for ones a job references by ID, or `project_default` for ones every job in the project notifies.<br/>
    /// Default Value: project
    /// </summary>
    public enum QueryWebhookConfigsApiV2WebhookConfigsGetTenantType
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
    public static class QueryWebhookConfigsApiV2WebhookConfigsGetTenantTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueryWebhookConfigsApiV2WebhookConfigsGetTenantType value)
        {
            return value switch
            {
                QueryWebhookConfigsApiV2WebhookConfigsGetTenantType.Project => "project",
                QueryWebhookConfigsApiV2WebhookConfigsGetTenantType.ProjectDefault => "project_default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueryWebhookConfigsApiV2WebhookConfigsGetTenantType? ToEnum(string value)
        {
            return value switch
            {
                "project" => QueryWebhookConfigsApiV2WebhookConfigsGetTenantType.Project,
                "project_default" => QueryWebhookConfigsApiV2WebhookConfigsGetTenantType.ProjectDefault,
                _ => null,
            };
        }
    }
}