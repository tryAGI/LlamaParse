
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Vector store filter operator.
    /// </summary>
    public enum FilterOperator
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Any,
        /// <summary>
        /// 
        /// </summary>
        Contains,
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
        IsEmpty,
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
        /// <summary>
        /// 
        /// </summary>
        TextMatch,
        /// <summary>
        /// 
        /// </summary>
        TextMatchInsensitive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilterOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterOperator value)
        {
            return value switch
            {
                FilterOperator.All => "all",
                FilterOperator.Any => "any",
                FilterOperator.Contains => "contains",
                FilterOperator.Eq => "eq",
                FilterOperator.Gt => "gt",
                FilterOperator.Gte => "gte",
                FilterOperator.In => "in",
                FilterOperator.IsEmpty => "is_empty",
                FilterOperator.Lt => "lt",
                FilterOperator.Lte => "lte",
                FilterOperator.Ne => "ne",
                FilterOperator.Nin => "nin",
                FilterOperator.TextMatch => "text_match",
                FilterOperator.TextMatchInsensitive => "text_match_insensitive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterOperator? ToEnum(string value)
        {
            return value switch
            {
                "all" => FilterOperator.All,
                "any" => FilterOperator.Any,
                "contains" => FilterOperator.Contains,
                "eq" => FilterOperator.Eq,
                "gt" => FilterOperator.Gt,
                "gte" => FilterOperator.Gte,
                "in" => FilterOperator.In,
                "is_empty" => FilterOperator.IsEmpty,
                "lt" => FilterOperator.Lt,
                "lte" => FilterOperator.Lte,
                "ne" => FilterOperator.Ne,
                "nin" => FilterOperator.Nin,
                "text_match" => FilterOperator.TextMatch,
                "text_match_insensitive" => FilterOperator.TextMatchInsensitive,
                _ => null,
            };
        }
    }
}