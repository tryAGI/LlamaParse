
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public enum UsageMetricAggregateResponseGroupByItem
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
    public static class UsageMetricAggregateResponseGroupByItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageMetricAggregateResponseGroupByItem value)
        {
            return value switch
            {
                UsageMetricAggregateResponseGroupByItem.Day => "day",
                UsageMetricAggregateResponseGroupByItem.EventType => "event_type",
                UsageMetricAggregateResponseGroupByItem.ProjectId => "project_id",
                UsageMetricAggregateResponseGroupByItem.Tier => "tier",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageMetricAggregateResponseGroupByItem? ToEnum(string value)
        {
            return value switch
            {
                "day" => UsageMetricAggregateResponseGroupByItem.Day,
                "event_type" => UsageMetricAggregateResponseGroupByItem.EventType,
                "project_id" => UsageMetricAggregateResponseGroupByItem.ProjectId,
                "tier" => UsageMetricAggregateResponseGroupByItem.Tier,
                _ => null,
            };
        }
    }
}