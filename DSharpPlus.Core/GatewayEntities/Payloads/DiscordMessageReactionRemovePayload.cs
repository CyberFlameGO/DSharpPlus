using DSharpPlus.Core.Attributes;
using DSharpPlus.Core.RestEntities;
using Newtonsoft.Json;

namespace DSharpPlus.Core.GatewayEntities.Payloads
{
    /// <summary>
    /// Sent when a user removes a reaction from a message.
    /// </summary>
    [DiscordGatewayPayload("MESSAGE_REACTION_REMOVE")]
    public sealed record DiscordMessageReactionRemovePayload
    {
        /// <summary>
        /// The id of the user.
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public DiscordSnowflake UserId { get; init; } = null!;

        /// <summary>
        /// The id of the channel.
        /// </summary>
        [JsonProperty("channel_id", NullValueHandling = NullValueHandling.Ignore)]
        public DiscordSnowflake ChannelId { get; init; } = null!;

        /// <summary>
        /// The id of the message.
        /// </summary>
        [JsonProperty("message_id", NullValueHandling = NullValueHandling.Ignore)]
        public DiscordSnowflake MessageId { get; init; } = null!;

        /// <summary>
        /// The id of the guild.
        /// </summary>
        [JsonProperty("guild_id", NullValueHandling = NullValueHandling.Ignore)]
        public Optional<DiscordSnowflake> GuildId { get; init; }

        /// <summary>
        /// The emoji used to react.
        /// </summary>
        [JsonProperty("emoji", NullValueHandling = NullValueHandling.Ignore)]
        public DiscordEmoji Emoji { get; init; } = null!;
    }
}
