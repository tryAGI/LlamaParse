#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LlamaParse
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EventsItem : global::System.IEquatable<EventsItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.SessionGetAPIResponseEventDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LlamaParse.ThinkingDeltaEvent? ThinkingDelta { get; init; }
#else
        public global::LlamaParse.ThinkingDeltaEvent? ThinkingDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ThinkingDelta))]
#endif
        public bool IsThinkingDelta => ThinkingDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickThinkingDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LlamaParse.ThinkingDeltaEvent? value)
        {
            value = ThinkingDelta;
            return IsThinkingDelta;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ThinkingDeltaEvent PickThinkingDelta() => IsThinkingDelta
            ? ThinkingDelta!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ThinkingDelta' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LlamaParse.TextDeltaEvent? TextDelta { get; init; }
#else
        public global::LlamaParse.TextDeltaEvent? TextDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextDelta))]
#endif
        public bool IsTextDelta => TextDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTextDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LlamaParse.TextDeltaEvent? value)
        {
            value = TextDelta;
            return IsTextDelta;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.TextDeltaEvent PickTextDelta() => IsTextDelta
            ? TextDelta!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextDelta' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LlamaParse.ThinkingEvent? Thinking { get; init; }
#else
        public global::LlamaParse.ThinkingEvent? Thinking { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Thinking))]
#endif
        public bool IsThinking => Thinking != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickThinking(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LlamaParse.ThinkingEvent? value)
        {
            value = Thinking;
            return IsThinking;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ThinkingEvent PickThinking() => IsThinking
            ? Thinking!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Thinking' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LlamaParse.TextEvent? Text { get; init; }
#else
        public global::LlamaParse.TextEvent? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LlamaParse.TextEvent? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.TextEvent PickText() => IsText
            ? Text!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LlamaParse.ToolCallEvent? ToolCall { get; init; }
#else
        public global::LlamaParse.ToolCallEvent? ToolCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolCall))]
#endif
        public bool IsToolCall => ToolCall != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickToolCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LlamaParse.ToolCallEvent? value)
        {
            value = ToolCall;
            return IsToolCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ToolCallEvent PickToolCall() => IsToolCall
            ? ToolCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolCall' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LlamaParse.ToolResultEvent? ToolResult { get; init; }
#else
        public global::LlamaParse.ToolResultEvent? ToolResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolResult))]
#endif
        public bool IsToolResult => ToolResult != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickToolResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LlamaParse.ToolResultEvent? value)
        {
            value = ToolResult;
            return IsToolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.ToolResultEvent PickToolResult() => IsToolResult
            ? ToolResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolResult' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LlamaParse.StopEvent? Stop { get; init; }
#else
        public global::LlamaParse.StopEvent? Stop { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Stop))]
#endif
        public bool IsStop => Stop != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStop(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LlamaParse.StopEvent? value)
        {
            value = Stop;
            return IsStop;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.StopEvent PickStop() => IsStop
            ? Stop!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Stop' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LlamaParse.UserInputEvent? UserInput { get; init; }
#else
        public global::LlamaParse.UserInputEvent? UserInput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserInput))]
#endif
        public bool IsUserInput => UserInput != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUserInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LlamaParse.UserInputEvent? value)
        {
            value = UserInput;
            return IsUserInput;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::LlamaParse.UserInputEvent PickUserInput() => IsUserInput
            ? UserInput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UserInput' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventsItem(global::LlamaParse.ThinkingDeltaEvent value) => new EventsItem((global::LlamaParse.ThinkingDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LlamaParse.ThinkingDeltaEvent?(EventsItem @this) => @this.ThinkingDelta;

        /// <summary>
        /// 
        /// </summary>
        public EventsItem(global::LlamaParse.ThinkingDeltaEvent? value)
        {
            ThinkingDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventsItem FromThinkingDelta(global::LlamaParse.ThinkingDeltaEvent? value) => new EventsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventsItem(global::LlamaParse.TextDeltaEvent value) => new EventsItem((global::LlamaParse.TextDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LlamaParse.TextDeltaEvent?(EventsItem @this) => @this.TextDelta;

        /// <summary>
        /// 
        /// </summary>
        public EventsItem(global::LlamaParse.TextDeltaEvent? value)
        {
            TextDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventsItem FromTextDelta(global::LlamaParse.TextDeltaEvent? value) => new EventsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventsItem(global::LlamaParse.ThinkingEvent value) => new EventsItem((global::LlamaParse.ThinkingEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LlamaParse.ThinkingEvent?(EventsItem @this) => @this.Thinking;

        /// <summary>
        /// 
        /// </summary>
        public EventsItem(global::LlamaParse.ThinkingEvent? value)
        {
            Thinking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventsItem FromThinking(global::LlamaParse.ThinkingEvent? value) => new EventsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventsItem(global::LlamaParse.TextEvent value) => new EventsItem((global::LlamaParse.TextEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LlamaParse.TextEvent?(EventsItem @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public EventsItem(global::LlamaParse.TextEvent? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventsItem FromText(global::LlamaParse.TextEvent? value) => new EventsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventsItem(global::LlamaParse.ToolCallEvent value) => new EventsItem((global::LlamaParse.ToolCallEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LlamaParse.ToolCallEvent?(EventsItem @this) => @this.ToolCall;

        /// <summary>
        /// 
        /// </summary>
        public EventsItem(global::LlamaParse.ToolCallEvent? value)
        {
            ToolCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventsItem FromToolCall(global::LlamaParse.ToolCallEvent? value) => new EventsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventsItem(global::LlamaParse.ToolResultEvent value) => new EventsItem((global::LlamaParse.ToolResultEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LlamaParse.ToolResultEvent?(EventsItem @this) => @this.ToolResult;

        /// <summary>
        /// 
        /// </summary>
        public EventsItem(global::LlamaParse.ToolResultEvent? value)
        {
            ToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventsItem FromToolResult(global::LlamaParse.ToolResultEvent? value) => new EventsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventsItem(global::LlamaParse.StopEvent value) => new EventsItem((global::LlamaParse.StopEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LlamaParse.StopEvent?(EventsItem @this) => @this.Stop;

        /// <summary>
        /// 
        /// </summary>
        public EventsItem(global::LlamaParse.StopEvent? value)
        {
            Stop = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventsItem FromStop(global::LlamaParse.StopEvent? value) => new EventsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventsItem(global::LlamaParse.UserInputEvent value) => new EventsItem((global::LlamaParse.UserInputEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LlamaParse.UserInputEvent?(EventsItem @this) => @this.UserInput;

        /// <summary>
        /// 
        /// </summary>
        public EventsItem(global::LlamaParse.UserInputEvent? value)
        {
            UserInput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EventsItem FromUserInput(global::LlamaParse.UserInputEvent? value) => new EventsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public EventsItem(
            global::LlamaParse.SessionGetAPIResponseEventDiscriminatorType? type,
            global::LlamaParse.ThinkingDeltaEvent? thinkingDelta,
            global::LlamaParse.TextDeltaEvent? textDelta,
            global::LlamaParse.ThinkingEvent? thinking,
            global::LlamaParse.TextEvent? text,
            global::LlamaParse.ToolCallEvent? toolCall,
            global::LlamaParse.ToolResultEvent? toolResult,
            global::LlamaParse.StopEvent? stop,
            global::LlamaParse.UserInputEvent? userInput
            )
        {
            Type = type;

            ThinkingDelta = thinkingDelta;
            TextDelta = textDelta;
            Thinking = thinking;
            Text = text;
            ToolCall = toolCall;
            ToolResult = toolResult;
            Stop = stop;
            UserInput = userInput;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            UserInput as object ??
            Stop as object ??
            ToolResult as object ??
            ToolCall as object ??
            Text as object ??
            Thinking as object ??
            TextDelta as object ??
            ThinkingDelta as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ThinkingDelta?.ToString() ??
            TextDelta?.ToString() ??
            Thinking?.ToString() ??
            Text?.ToString() ??
            ToolCall?.ToString() ??
            ToolResult?.ToString() ??
            Stop?.ToString() ??
            UserInput?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsThinkingDelta && !IsTextDelta && !IsThinking && !IsText && !IsToolCall && !IsToolResult && !IsStop && !IsUserInput || !IsThinkingDelta && IsTextDelta && !IsThinking && !IsText && !IsToolCall && !IsToolResult && !IsStop && !IsUserInput || !IsThinkingDelta && !IsTextDelta && IsThinking && !IsText && !IsToolCall && !IsToolResult && !IsStop && !IsUserInput || !IsThinkingDelta && !IsTextDelta && !IsThinking && IsText && !IsToolCall && !IsToolResult && !IsStop && !IsUserInput || !IsThinkingDelta && !IsTextDelta && !IsThinking && !IsText && IsToolCall && !IsToolResult && !IsStop && !IsUserInput || !IsThinkingDelta && !IsTextDelta && !IsThinking && !IsText && !IsToolCall && IsToolResult && !IsStop && !IsUserInput || !IsThinkingDelta && !IsTextDelta && !IsThinking && !IsText && !IsToolCall && !IsToolResult && IsStop && !IsUserInput || !IsThinkingDelta && !IsTextDelta && !IsThinking && !IsText && !IsToolCall && !IsToolResult && !IsStop && IsUserInput;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::LlamaParse.ThinkingDeltaEvent, TResult>? thinkingDelta = null,
            global::System.Func<global::LlamaParse.TextDeltaEvent, TResult>? textDelta = null,
            global::System.Func<global::LlamaParse.ThinkingEvent, TResult>? thinking = null,
            global::System.Func<global::LlamaParse.TextEvent, TResult>? text = null,
            global::System.Func<global::LlamaParse.ToolCallEvent, TResult>? toolCall = null,
            global::System.Func<global::LlamaParse.ToolResultEvent, TResult>? toolResult = null,
            global::System.Func<global::LlamaParse.StopEvent, TResult>? stop = null,
            global::System.Func<global::LlamaParse.UserInputEvent, TResult>? userInput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsThinkingDelta && thinkingDelta != null)
            {
                return thinkingDelta(ThinkingDelta!);
            }
            else if (IsTextDelta && textDelta != null)
            {
                return textDelta(TextDelta!);
            }
            else if (IsThinking && thinking != null)
            {
                return thinking(Thinking!);
            }
            else if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsToolCall && toolCall != null)
            {
                return toolCall(ToolCall!);
            }
            else if (IsToolResult && toolResult != null)
            {
                return toolResult(ToolResult!);
            }
            else if (IsStop && stop != null)
            {
                return stop(Stop!);
            }
            else if (IsUserInput && userInput != null)
            {
                return userInput(UserInput!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::LlamaParse.ThinkingDeltaEvent>? thinkingDelta = null,

            global::System.Action<global::LlamaParse.TextDeltaEvent>? textDelta = null,

            global::System.Action<global::LlamaParse.ThinkingEvent>? thinking = null,

            global::System.Action<global::LlamaParse.TextEvent>? text = null,

            global::System.Action<global::LlamaParse.ToolCallEvent>? toolCall = null,

            global::System.Action<global::LlamaParse.ToolResultEvent>? toolResult = null,

            global::System.Action<global::LlamaParse.StopEvent>? stop = null,

            global::System.Action<global::LlamaParse.UserInputEvent>? userInput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsThinkingDelta)
            {
                thinkingDelta?.Invoke(ThinkingDelta!);
            }
            else if (IsTextDelta)
            {
                textDelta?.Invoke(TextDelta!);
            }
            else if (IsThinking)
            {
                thinking?.Invoke(Thinking!);
            }
            else if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsToolCall)
            {
                toolCall?.Invoke(ToolCall!);
            }
            else if (IsToolResult)
            {
                toolResult?.Invoke(ToolResult!);
            }
            else if (IsStop)
            {
                stop?.Invoke(Stop!);
            }
            else if (IsUserInput)
            {
                userInput?.Invoke(UserInput!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::LlamaParse.ThinkingDeltaEvent>? thinkingDelta = null,
            global::System.Action<global::LlamaParse.TextDeltaEvent>? textDelta = null,
            global::System.Action<global::LlamaParse.ThinkingEvent>? thinking = null,
            global::System.Action<global::LlamaParse.TextEvent>? text = null,
            global::System.Action<global::LlamaParse.ToolCallEvent>? toolCall = null,
            global::System.Action<global::LlamaParse.ToolResultEvent>? toolResult = null,
            global::System.Action<global::LlamaParse.StopEvent>? stop = null,
            global::System.Action<global::LlamaParse.UserInputEvent>? userInput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsThinkingDelta)
            {
                thinkingDelta?.Invoke(ThinkingDelta!);
            }
            else if (IsTextDelta)
            {
                textDelta?.Invoke(TextDelta!);
            }
            else if (IsThinking)
            {
                thinking?.Invoke(Thinking!);
            }
            else if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsToolCall)
            {
                toolCall?.Invoke(ToolCall!);
            }
            else if (IsToolResult)
            {
                toolResult?.Invoke(ToolResult!);
            }
            else if (IsStop)
            {
                stop?.Invoke(Stop!);
            }
            else if (IsUserInput)
            {
                userInput?.Invoke(UserInput!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ThinkingDelta,
                typeof(global::LlamaParse.ThinkingDeltaEvent),
                TextDelta,
                typeof(global::LlamaParse.TextDeltaEvent),
                Thinking,
                typeof(global::LlamaParse.ThinkingEvent),
                Text,
                typeof(global::LlamaParse.TextEvent),
                ToolCall,
                typeof(global::LlamaParse.ToolCallEvent),
                ToolResult,
                typeof(global::LlamaParse.ToolResultEvent),
                Stop,
                typeof(global::LlamaParse.StopEvent),
                UserInput,
                typeof(global::LlamaParse.UserInputEvent),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(EventsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::LlamaParse.ThinkingDeltaEvent?>.Default.Equals(ThinkingDelta, other.ThinkingDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::LlamaParse.TextDeltaEvent?>.Default.Equals(TextDelta, other.TextDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::LlamaParse.ThinkingEvent?>.Default.Equals(Thinking, other.Thinking) &&
                global::System.Collections.Generic.EqualityComparer<global::LlamaParse.TextEvent?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::LlamaParse.ToolCallEvent?>.Default.Equals(ToolCall, other.ToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::LlamaParse.ToolResultEvent?>.Default.Equals(ToolResult, other.ToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::LlamaParse.StopEvent?>.Default.Equals(Stop, other.Stop) &&
                global::System.Collections.Generic.EqualityComparer<global::LlamaParse.UserInputEvent?>.Default.Equals(UserInput, other.UserInput) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EventsItem obj1, EventsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EventsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EventsItem obj1, EventsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EventsItem o && Equals(o);
        }
    }
}
