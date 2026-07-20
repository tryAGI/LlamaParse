
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Usage metrics aggregated by the requested dimensions.
    /// </summary>
    public sealed partial class UsageMetricAggregateResponse
    {
        /// <summary>
        /// Dimensions used to group metrics
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LlamaParse.UsageMetricAggregateResponseGroupByItem> GroupBy { get; set; }

        /// <summary>
        /// Aggregated metric groups
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buckets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LlamaParse.UsageMetricAggregateBucket> Buckets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageMetricAggregateResponse" /> class.
        /// </summary>
        /// <param name="groupBy">
        /// Dimensions used to group metrics
        /// </param>
        /// <param name="buckets">
        /// Aggregated metric groups
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageMetricAggregateResponse(
            global::System.Collections.Generic.IList<global::LlamaParse.UsageMetricAggregateResponseGroupByItem> groupBy,
            global::System.Collections.Generic.IList<global::LlamaParse.UsageMetricAggregateBucket> buckets)
        {
            this.GroupBy = groupBy ?? throw new global::System.ArgumentNullException(nameof(groupBy));
            this.Buckets = buckets ?? throw new global::System.ArgumentNullException(nameof(buckets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageMetricAggregateResponse" /> class.
        /// </summary>
        public UsageMetricAggregateResponse()
        {
        }

    }
}