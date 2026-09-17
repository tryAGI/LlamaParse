
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Which configurations to address: `project` for ones a job references by ID, or `project_default` for ones every job in the project notifies.<br/>
    /// Default Value: project
    /// </summary>
    public enum DeleteWebhookConfigApiV1BetaWebhookConfigsConfigIdDeleteTenantType
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
    public static class DeleteWebhookConfigApiV1BetaWebhookConfigsConfigIdDeleteTenantTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteWebhookConfigApiV1BetaWebhookConfigsConfigIdDeleteTenantType value)
        {
            return value switch
            {
                DeleteWebhookConfigApiV1BetaWebhookConfigsConfigIdDeleteTenantType.Project => "project",
                DeleteWebhookConfigApiV1BetaWebhookConfigsConfigIdDeleteTenantType.ProjectDefault => "project_default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteWebhookConfigApiV1BetaWebhookConfigsConfigIdDeleteTenantType? ToEnum(string value)
        {
            return value switch
            {
                "project" => DeleteWebhookConfigApiV1BetaWebhookConfigsConfigIdDeleteTenantType.Project,
                "project_default" => DeleteWebhookConfigApiV1BetaWebhookConfigsConfigIdDeleteTenantType.ProjectDefault,
                _ => null,
            };
        }
    }
}