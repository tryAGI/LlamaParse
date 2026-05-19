
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public enum SessionGetAPIResponseEventDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Stop,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        TextDelta,
        /// <summary>
        /// 
        /// </summary>
        Thinking,
        /// <summary>
        /// 
        /// </summary>
        ThinkingDelta,
        /// <summary>
        /// 
        /// </summary>
        ToolCall,
        /// <summary>
        /// 
        /// </summary>
        ToolResult,
        /// <summary>
        /// 
        /// </summary>
        UserInput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionGetAPIResponseEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionGetAPIResponseEventDiscriminatorType value)
        {
            return value switch
            {
                SessionGetAPIResponseEventDiscriminatorType.Stop => "stop",
                SessionGetAPIResponseEventDiscriminatorType.Text => "text",
                SessionGetAPIResponseEventDiscriminatorType.TextDelta => "text_delta",
                SessionGetAPIResponseEventDiscriminatorType.Thinking => "thinking",
                SessionGetAPIResponseEventDiscriminatorType.ThinkingDelta => "thinking_delta",
                SessionGetAPIResponseEventDiscriminatorType.ToolCall => "tool_call",
                SessionGetAPIResponseEventDiscriminatorType.ToolResult => "tool_result",
                SessionGetAPIResponseEventDiscriminatorType.UserInput => "user_input",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionGetAPIResponseEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "stop" => SessionGetAPIResponseEventDiscriminatorType.Stop,
                "text" => SessionGetAPIResponseEventDiscriminatorType.Text,
                "text_delta" => SessionGetAPIResponseEventDiscriminatorType.TextDelta,
                "thinking" => SessionGetAPIResponseEventDiscriminatorType.Thinking,
                "thinking_delta" => SessionGetAPIResponseEventDiscriminatorType.ThinkingDelta,
                "tool_call" => SessionGetAPIResponseEventDiscriminatorType.ToolCall,
                "tool_result" => SessionGetAPIResponseEventDiscriminatorType.ToolResult,
                "user_input" => SessionGetAPIResponseEventDiscriminatorType.UserInput,
                _ => null,
            };
        }
    }
}