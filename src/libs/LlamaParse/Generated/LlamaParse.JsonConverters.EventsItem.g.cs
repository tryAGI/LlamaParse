#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace LlamaParse.JsonConverters
{
    /// <inheritdoc />
    public class EventsItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LlamaParse.EventsItem>
    {
        /// <inheritdoc />
        public override global::LlamaParse.EventsItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.SessionGetAPIResponseEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.SessionGetAPIResponseEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LlamaParse.SessionGetAPIResponseEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::LlamaParse.ThinkingDeltaEvent? thinkingDelta = default;
            if (discriminator?.Type == global::LlamaParse.SessionGetAPIResponseEventDiscriminatorType.ThinkingDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.ThinkingDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.ThinkingDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LlamaParse.ThinkingDeltaEvent)}");
                thinkingDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LlamaParse.TextDeltaEvent? textDelta = default;
            if (discriminator?.Type == global::LlamaParse.SessionGetAPIResponseEventDiscriminatorType.TextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.TextDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.TextDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LlamaParse.TextDeltaEvent)}");
                textDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LlamaParse.ThinkingEvent? thinking = default;
            if (discriminator?.Type == global::LlamaParse.SessionGetAPIResponseEventDiscriminatorType.Thinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.ThinkingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.ThinkingEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LlamaParse.ThinkingEvent)}");
                thinking = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LlamaParse.TextEvent? text = default;
            if (discriminator?.Type == global::LlamaParse.SessionGetAPIResponseEventDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.TextEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.TextEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LlamaParse.TextEvent)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LlamaParse.ToolCallEvent? toolCall = default;
            if (discriminator?.Type == global::LlamaParse.SessionGetAPIResponseEventDiscriminatorType.ToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.ToolCallEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.ToolCallEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LlamaParse.ToolCallEvent)}");
                toolCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LlamaParse.ToolResultEvent? toolResult = default;
            if (discriminator?.Type == global::LlamaParse.SessionGetAPIResponseEventDiscriminatorType.ToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.ToolResultEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.ToolResultEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LlamaParse.ToolResultEvent)}");
                toolResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LlamaParse.StopEvent? stop = default;
            if (discriminator?.Type == global::LlamaParse.SessionGetAPIResponseEventDiscriminatorType.Stop)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.StopEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.StopEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LlamaParse.StopEvent)}");
                stop = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LlamaParse.UserInputEvent? userInput = default;
            if (discriminator?.Type == global::LlamaParse.SessionGetAPIResponseEventDiscriminatorType.UserInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.UserInputEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.UserInputEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LlamaParse.UserInputEvent)}");
                userInput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::LlamaParse.EventsItem(
                discriminator?.Type,
                thinkingDelta,

                textDelta,

                thinking,

                text,

                toolCall,

                toolResult,

                stop,

                userInput
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LlamaParse.EventsItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsThinkingDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.ThinkingDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.ThinkingDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LlamaParse.ThinkingDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThinkingDelta!, typeInfo);
            }
            else if (value.IsTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.TextDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.TextDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LlamaParse.TextDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextDelta!, typeInfo);
            }
            else if (value.IsThinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.ThinkingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.ThinkingEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LlamaParse.ThinkingEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Thinking!, typeInfo);
            }
            else if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.TextEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.TextEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LlamaParse.TextEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!, typeInfo);
            }
            else if (value.IsToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.ToolCallEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.ToolCallEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LlamaParse.ToolCallEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolCall!, typeInfo);
            }
            else if (value.IsToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.ToolResultEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.ToolResultEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LlamaParse.ToolResultEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolResult!, typeInfo);
            }
            else if (value.IsStop)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.StopEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.StopEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LlamaParse.StopEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Stop!, typeInfo);
            }
            else if (value.IsUserInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LlamaParse.UserInputEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LlamaParse.UserInputEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LlamaParse.UserInputEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UserInput!, typeInfo);
            }
        }
    }
}