
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public enum FilterTypeUnionStrIntBoolFloatOperator
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
    public static class FilterTypeUnionStrIntBoolFloatOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterTypeUnionStrIntBoolFloatOperator value)
        {
            return value switch
            {
                FilterTypeUnionStrIntBoolFloatOperator.Eq => "eq",
                FilterTypeUnionStrIntBoolFloatOperator.Gt => "gt",
                FilterTypeUnionStrIntBoolFloatOperator.Gte => "gte",
                FilterTypeUnionStrIntBoolFloatOperator.In => "in",
                FilterTypeUnionStrIntBoolFloatOperator.Lt => "lt",
                FilterTypeUnionStrIntBoolFloatOperator.Lte => "lte",
                FilterTypeUnionStrIntBoolFloatOperator.Ne => "ne",
                FilterTypeUnionStrIntBoolFloatOperator.Nin => "nin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterTypeUnionStrIntBoolFloatOperator? ToEnum(string value)
        {
            return value switch
            {
                "eq" => FilterTypeUnionStrIntBoolFloatOperator.Eq,
                "gt" => FilterTypeUnionStrIntBoolFloatOperator.Gt,
                "gte" => FilterTypeUnionStrIntBoolFloatOperator.Gte,
                "in" => FilterTypeUnionStrIntBoolFloatOperator.In,
                "lt" => FilterTypeUnionStrIntBoolFloatOperator.Lt,
                "lte" => FilterTypeUnionStrIntBoolFloatOperator.Lte,
                "ne" => FilterTypeUnionStrIntBoolFloatOperator.Ne,
                "nin" => FilterTypeUnionStrIntBoolFloatOperator.Nin,
                _ => null,
            };
        }
    }
}