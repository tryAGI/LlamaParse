
#nullable enable

namespace LlamaParse
{
    /// <summary>
    ///
    /// </summary>
    public enum NumericRangeFilterOperator
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
    public static class NumericRangeFilterOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NumericRangeFilterOperator value)
        {
            return value switch
            {
                NumericRangeFilterOperator.Eq => "eq",
                NumericRangeFilterOperator.Gt => "gt",
                NumericRangeFilterOperator.Gte => "gte",
                NumericRangeFilterOperator.In => "in",
                NumericRangeFilterOperator.Lt => "lt",
                NumericRangeFilterOperator.Lte => "lte",
                NumericRangeFilterOperator.Ne => "ne",
                NumericRangeFilterOperator.Nin => "nin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NumericRangeFilterOperator? ToEnum(string value)
        {
            return value switch
            {
                "eq" => NumericRangeFilterOperator.Eq,
                "gt" => NumericRangeFilterOperator.Gt,
                "gte" => NumericRangeFilterOperator.Gte,
                "in" => NumericRangeFilterOperator.In,
                "lt" => NumericRangeFilterOperator.Lt,
                "lte" => NumericRangeFilterOperator.Lte,
                "ne" => NumericRangeFilterOperator.Ne,
                "nin" => NumericRangeFilterOperator.Nin,
                _ => null,
            };
        }
    }
}