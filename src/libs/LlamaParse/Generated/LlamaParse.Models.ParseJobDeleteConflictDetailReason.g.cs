
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// `job_running`: cancel the job, then delete it. `held_by_evaluate`: a document in Evaluate reads its ground truth from the job; remove the document from Evaluate, or delete the project.
    /// </summary>
    public enum ParseJobDeleteConflictDetailReason
    {
        /// <summary>
        /// cancel the job, then delete it. `held_by_evaluate`: a document in Evaluate reads its ground truth from the job; remove the document from Evaluate, or delete the project.
        /// </summary>
        HeldByEvaluate,
        /// <summary>
        /// cancel the job, then delete it. `held_by_evaluate`: a document in Evaluate reads its ground truth from the job; remove the document from Evaluate, or delete the project.
        /// </summary>
        JobRunning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ParseJobDeleteConflictDetailReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ParseJobDeleteConflictDetailReason value)
        {
            return value switch
            {
                ParseJobDeleteConflictDetailReason.HeldByEvaluate => "held_by_evaluate",
                ParseJobDeleteConflictDetailReason.JobRunning => "job_running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ParseJobDeleteConflictDetailReason? ToEnum(string value)
        {
            return value switch
            {
                "held_by_evaluate" => ParseJobDeleteConflictDetailReason.HeldByEvaluate,
                "job_running" => ParseJobDeleteConflictDetailReason.JobRunning,
                _ => null,
            };
        }
    }
}