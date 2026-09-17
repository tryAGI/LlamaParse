
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Which configurations to address: `project` for ones a job references by ID, or `project_default` for ones every job in the project notifies.<br/>
    /// Default Value: project
    /// </summary>
    public enum GetWebhookConfigApiV1BetaWebhookConfigsConfigIdGetTenantType
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
    public static class GetWebhookConfigApiV1BetaWebhookConfigsConfigIdGetTenantTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWebhookConfigApiV1BetaWebhookConfigsConfigIdGetTenantType value)
        {
            return value switch
            {
                GetWebhookConfigApiV1BetaWebhookConfigsConfigIdGetTenantType.Project => "project",
                GetWebhookConfigApiV1BetaWebhookConfigsConfigIdGetTenantType.ProjectDefault => "project_default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWebhookConfigApiV1BetaWebhookConfigsConfigIdGetTenantType? ToEnum(string value)
        {
            return value switch
            {
                "project" => GetWebhookConfigApiV1BetaWebhookConfigsConfigIdGetTenantType.Project,
                "project_default" => GetWebhookConfigApiV1BetaWebhookConfigsConfigIdGetTenantType.ProjectDefault,
                _ => null,
            };
        }
    }
}