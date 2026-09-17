
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Which configurations to address: `project` for ones a job references by ID, or `project_default` for ones every job in the project notifies.<br/>
    /// Default Value: project
    /// </summary>
    public enum ListWebhookConfigsApiV1BetaWebhookConfigsGetTenantType
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
    public static class ListWebhookConfigsApiV1BetaWebhookConfigsGetTenantTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListWebhookConfigsApiV1BetaWebhookConfigsGetTenantType value)
        {
            return value switch
            {
                ListWebhookConfigsApiV1BetaWebhookConfigsGetTenantType.Project => "project",
                ListWebhookConfigsApiV1BetaWebhookConfigsGetTenantType.ProjectDefault => "project_default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListWebhookConfigsApiV1BetaWebhookConfigsGetTenantType? ToEnum(string value)
        {
            return value switch
            {
                "project" => ListWebhookConfigsApiV1BetaWebhookConfigsGetTenantType.Project,
                "project_default" => ListWebhookConfigsApiV1BetaWebhookConfigsGetTenantType.ProjectDefault,
                _ => null,
            };
        }
    }
}