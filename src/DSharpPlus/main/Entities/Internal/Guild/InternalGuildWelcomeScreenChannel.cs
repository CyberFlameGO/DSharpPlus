using System.Text.Json.Serialization;

namespace DSharpPlus.Entities.Internal;

public sealed record InternalGuildWelcomeScreenChannel
{
    /// <summary>
    /// The channel's id.
    /// </summary>
    [JsonPropertyName("channel_id")]
    public required Snowflake ChannelId { get; init; } 

    /// <summary>
    /// The description shown for the channel.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; init; }

    /// <summary>
    /// The emoji id, if the emoji is custom.
    /// </summary>
    [JsonPropertyName("emoji_id")]
    public Snowflake? EmojiId { get; init; }

    /// <summary>
    /// The emoji name if custom, the unicode character if standard, or null if no emoji is set.
    /// </summary>
    [JsonPropertyName("emoji_name")]
    public string? EmojiName { get; init; } 
}
