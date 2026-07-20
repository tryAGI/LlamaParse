
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public enum AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem
    {
        /// <summary>
        /// 
        /// </summary>
        Day,
        /// <summary>
        /// 
        /// </summary>
        EventType,
        /// <summary>
        /// 
        /// </summary>
        ProjectId,
        /// <summary>
        /// 
        /// </summary>
        Tier,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem value)
        {
            return value switch
            {
                AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem.Day => "day",
                AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem.EventType => "event_type",
                AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem.ProjectId => "project_id",
                AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem.Tier => "tier",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem? ToEnum(string value)
        {
            return value switch
            {
                "day" => AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem.Day,
                "event_type" => AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem.EventType,
                "project_id" => AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem.ProjectId,
                "tier" => AggregateUsageMetricsApiV1BetaUsageMetricsAggregateGetGroupByItem.Tier,
                _ => null,
            };
        }
    }
}