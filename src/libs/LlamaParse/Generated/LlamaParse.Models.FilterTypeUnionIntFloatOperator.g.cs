
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public enum FilterTypeUnionIntFloatOperator
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
    public static class FilterTypeUnionIntFloatOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterTypeUnionIntFloatOperator value)
        {
            return value switch
            {
                FilterTypeUnionIntFloatOperator.Eq => "eq",
                FilterTypeUnionIntFloatOperator.Gt => "gt",
                FilterTypeUnionIntFloatOperator.Gte => "gte",
                FilterTypeUnionIntFloatOperator.In => "in",
                FilterTypeUnionIntFloatOperator.Lt => "lt",
                FilterTypeUnionIntFloatOperator.Lte => "lte",
                FilterTypeUnionIntFloatOperator.Ne => "ne",
                FilterTypeUnionIntFloatOperator.Nin => "nin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterTypeUnionIntFloatOperator? ToEnum(string value)
        {
            return value switch
            {
                "eq" => FilterTypeUnionIntFloatOperator.Eq,
                "gt" => FilterTypeUnionIntFloatOperator.Gt,
                "gte" => FilterTypeUnionIntFloatOperator.Gte,
                "in" => FilterTypeUnionIntFloatOperator.In,
                "lt" => FilterTypeUnionIntFloatOperator.Lt,
                "lte" => FilterTypeUnionIntFloatOperator.Lte,
                "ne" => FilterTypeUnionIntFloatOperator.Ne,
                "nin" => FilterTypeUnionIntFloatOperator.Nin,
                _ => null,
            };
        }
    }
}