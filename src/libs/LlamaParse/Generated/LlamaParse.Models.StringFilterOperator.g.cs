
#nullable enable

namespace LlamaParse
{
    /// <summary>
    ///
    /// </summary>
    public enum StringFilterOperator
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
    public static class StringFilterOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StringFilterOperator value)
        {
            return value switch
            {
                StringFilterOperator.Eq => "eq",
                StringFilterOperator.Gt => "gt",
                StringFilterOperator.Gte => "gte",
                StringFilterOperator.In => "in",
                StringFilterOperator.Lt => "lt",
                StringFilterOperator.Lte => "lte",
                StringFilterOperator.Ne => "ne",
                StringFilterOperator.Nin => "nin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StringFilterOperator? ToEnum(string value)
        {
            return value switch
            {
                "eq" => StringFilterOperator.Eq,
                "gt" => StringFilterOperator.Gt,
                "gte" => StringFilterOperator.Gte,
                "in" => StringFilterOperator.In,
                "lt" => StringFilterOperator.Lt,
                "lte" => StringFilterOperator.Lte,
                "ne" => StringFilterOperator.Ne,
                "nin" => StringFilterOperator.Nin,
                _ => null,
            };
        }
    }
}