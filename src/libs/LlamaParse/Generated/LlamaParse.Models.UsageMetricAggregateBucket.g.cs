
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// A group of usage metric totals.
    /// </summary>
    public sealed partial class UsageMetricAggregateBucket
    {
        /// <summary>
        /// Values defining this group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Dimensions { get; set; }

        /// <summary>
        /// Credits consumed in this group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_credits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalCredits { get; set; }

        /// <summary>
        /// Metric units in this group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalValue { get; set; }

        /// <summary>
        /// Usage records in this group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MetricCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageMetricAggregateBucket" /> class.
        /// </summary>
        /// <param name="dimensions">
        /// Values defining this group
        /// </param>
        /// <param name="totalCredits">
        /// Credits consumed in this group
        /// </param>
        /// <param name="totalValue">
        /// Metric units in this group
        /// </param>
        /// <param name="metricCount">
        /// Usage records in this group
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageMetricAggregateBucket(
            global::System.Collections.Generic.Dictionary<string, string> dimensions,
            double totalCredits,
            int totalValue,
            int metricCount)
        {
            this.Dimensions = dimensions ?? throw new global::System.ArgumentNullException(nameof(dimensions));
            this.TotalCredits = totalCredits;
            this.TotalValue = totalValue;
            this.MetricCount = metricCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageMetricAggregateBucket" /> class.
        /// </summary>
        public UsageMetricAggregateBucket()
        {
        }

    }
}