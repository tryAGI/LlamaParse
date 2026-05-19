
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public enum FilterTypeStrOperator
    {
        /// <summary>
        /// 
        /// </summary>
        Eq,
        /// <summary>
        /// 
        /// </summary>
        Gt,
        /// <summary>
        /// 
        /// </summary>
        Gte,
        /// <summary>
        /// 
        /// </summary>
        In,
        /// <summary>
        /// 
        /// </summary>
        Lt,
        /// <summary>
        /// 
        /// </summary>
        Lte,
        /// <summary>
        /// 
        /// </summary>
        Ne,
        /// <summary>
        /// 
        /// </summary>
        Nin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilterTypeStrOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterTypeStrOperator value)
        {
            return value switch
            {
                FilterTypeStrOperator.Eq => "eq",
                FilterTypeStrOperator.Gt => "gt",
                FilterTypeStrOperator.Gte => "gte",
                FilterTypeStrOperator.In => "in",
                FilterTypeStrOperator.Lt => "lt",
                FilterTypeStrOperator.Lte => "lte",
                FilterTypeStrOperator.Ne => "ne",
                FilterTypeStrOperator.Nin => "nin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterTypeStrOperator? ToEnum(string value)
        {
            return value switch
            {
                "eq" => FilterTypeStrOperator.Eq,
                "gt" => FilterTypeStrOperator.Gt,
                "gte" => FilterTypeStrOperator.Gte,
                "in" => FilterTypeStrOperator.In,
                "lt" => FilterTypeStrOperator.Lt,
                "lte" => FilterTypeStrOperator.Lte,
                "ne" => FilterTypeStrOperator.Ne,
                "nin" => FilterTypeStrOperator.Nin,
                _ => null,
            };
        }
    }
}