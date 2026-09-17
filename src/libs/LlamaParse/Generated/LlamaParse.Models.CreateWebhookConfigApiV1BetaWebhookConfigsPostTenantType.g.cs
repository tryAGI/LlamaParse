
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Which configurations to address: `project` for ones a job references by ID, or `project_default` for ones every job in the project notifies.<br/>
    /// Default Value: project
    /// </summary>
    public enum CreateWebhookConfigApiV1BetaWebhookConfigsPostTenantType
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
    public static class CreateWebhookConfigApiV1BetaWebhookConfigsPostTenantTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWebhookConfigApiV1BetaWebhookConfigsPostTenantType value)
        {
            return value switch
            {
                CreateWebhookConfigApiV1BetaWebhookConfigsPostTenantType.Project => "project",
                CreateWebhookConfigApiV1BetaWebhookConfigsPostTenantType.ProjectDefault => "project_default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWebhookConfigApiV1BetaWebhookConfigsPostTenantType? ToEnum(string value)
        {
            return value switch
            {
                "project" => CreateWebhookConfigApiV1BetaWebhookConfigsPostTenantType.Project,
                "project_default" => CreateWebhookConfigApiV1BetaWebhookConfigsPostTenantType.ProjectDefault,
                _ => null,
            };
        }
    }
}