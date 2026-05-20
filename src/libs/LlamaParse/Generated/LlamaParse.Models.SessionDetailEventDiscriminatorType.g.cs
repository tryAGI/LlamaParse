
#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public enum SessionDetailEventDiscriminatorType
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
    public static class SessionDetailEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionDetailEventDiscriminatorType value)
        {
            return value switch
            {
                SessionDetailEventDiscriminatorType.Stop => "stop",
                SessionDetailEventDiscriminatorType.Text => "text",
                SessionDetailEventDiscriminatorType.TextDelta => "text_delta",
                SessionDetailEventDiscriminatorType.Thinking => "thinking",
                SessionDetailEventDiscriminatorType.ThinkingDelta => "thinking_delta",
                SessionDetailEventDiscriminatorType.ToolCall => "tool_call",
                SessionDetailEventDiscriminatorType.ToolResult => "tool_result",
                SessionDetailEventDiscriminatorType.UserInput => "user_input",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionDetailEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "stop" => SessionDetailEventDiscriminatorType.Stop,
                "text" => SessionDetailEventDiscriminatorType.Text,
                "text_delta" => SessionDetailEventDiscriminatorType.TextDelta,
                "thinking" => SessionDetailEventDiscriminatorType.Thinking,
                "thinking_delta" => SessionDetailEventDiscriminatorType.ThinkingDelta,
                "tool_call" => SessionDetailEventDiscriminatorType.ToolCall,
                "tool_result" => SessionDetailEventDiscriminatorType.ToolResult,
                "user_input" => SessionDetailEventDiscriminatorType.UserInput,
                _ => null,
            };
        }
    }
}