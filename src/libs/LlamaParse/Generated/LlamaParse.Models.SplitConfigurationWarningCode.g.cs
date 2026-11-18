
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// Rule that produced the warning.
    /// </summary>
    public enum SplitConfigurationWarningCode
    {
        /// <summary>
        ///
        /// </summary>
        CatchAllCategory,
        /// <summary>
        ///
        /// </summary>
        MissingDescription,
        /// <summary>
        ///
        /// </summary>
        NearDuplicateDescription,
        /// <summary>
        ///
        /// </summary>
        NearDuplicateName,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SplitConfigurationWarningCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SplitConfigurationWarningCode value)
        {
            return value switch
            {
                SplitConfigurationWarningCode.CatchAllCategory => "catch_all_category",
                SplitConfigurationWarningCode.MissingDescription => "missing_description",
                SplitConfigurationWarningCode.NearDuplicateDescription => "near_duplicate_description",
                SplitConfigurationWarningCode.NearDuplicateName => "near_duplicate_name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SplitConfigurationWarningCode? ToEnum(string value)
        {
            return value switch
            {
                "catch_all_category" => SplitConfigurationWarningCode.CatchAllCategory,
                "missing_description" => SplitConfigurationWarningCode.MissingDescription,
                "near_duplicate_description" => SplitConfigurationWarningCode.NearDuplicateDescription,
                "near_duplicate_name" => SplitConfigurationWarningCode.NearDuplicateName,
                _ => null,
            };
        }
    }
}