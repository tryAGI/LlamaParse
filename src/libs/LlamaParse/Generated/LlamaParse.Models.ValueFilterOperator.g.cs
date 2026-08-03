
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public enum ValueFilterOperator
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
    public static class ValueFilterOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ValueFilterOperator value)
        {
            return value switch
            {
                ValueFilterOperator.Eq => "eq",
                ValueFilterOperator.Gt => "gt",
                ValueFilterOperator.Gte => "gte",
                ValueFilterOperator.In => "in",
                ValueFilterOperator.Lt => "lt",
                ValueFilterOperator.Lte => "lte",
                ValueFilterOperator.Ne => "ne",
                ValueFilterOperator.Nin => "nin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ValueFilterOperator? ToEnum(string value)
        {
            return value switch
            {
                "eq" => ValueFilterOperator.Eq,
                "gt" => ValueFilterOperator.Gt,
                "gte" => ValueFilterOperator.Gte,
                "in" => ValueFilterOperator.In,
                "lt" => ValueFilterOperator.Lt,
                "lte" => ValueFilterOperator.Lte,
                "ne" => ValueFilterOperator.Ne,
                "nin" => ValueFilterOperator.Nin,
                _ => null,
            };
        }
    }
}