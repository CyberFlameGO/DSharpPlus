using System.Collections.Generic;
using Newtonsoft.Json;

namespace DSharpPlus.Core.RestEntities
{
    public sealed record DiscordInteractionResolvedData
    {
        /// <summary>
        /// The ids and User objects.
        /// </summary>
        [JsonProperty("users", NullValueHandling = NullValueHandling.Ignore)]
        public Optional<IReadOnlyDictionary<DiscordSnowflake, DiscordUser>> Users { get; init; }

        /// <summary>
        /// The ids and partial Member objects.
        /// </summary>
        [JsonProperty("members", NullValueHandling = NullValueHandling.Ignore)]
        public Optional<IReadOnlyDictionary<DiscordSnowflake, DiscordGuildMember>> Members { get; init; }

        /// <summary>
        /// The ids and Role objects.
        /// </summary>
        [JsonProperty("roles", NullValueHandling = NullValueHandling.Ignore)]
        public Optional<IReadOnlyDictionary<DiscordSnowflake, DiscordRole>> Roles { get; init; }

        /// <summary>
        /// The ids and partial Channel objects.
        /// </summary>
        [JsonProperty("channels", NullValueHandling = NullValueHandling.Ignore)]
        public Optional<IReadOnlyDictionary<DiscordSnowflake, DiscordChannel>> Channels { get; init; }

        /// <summary>
        /// The ids and partial Message objects.
        /// </summary>
        [JsonProperty("messages", NullValueHandling = NullValueHandling.Ignore)]
        public Optional<IReadOnlyDictionary<DiscordSnowflake, DiscordMessage>> Messages { get; init; }

        /// <summary>
        /// The ids and attachment objects.
        /// </summary>
        [JsonProperty("attachments", NullValueHandling = NullValueHandling.Ignore)]
        public Optional<IReadOnlyDictionary<DiscordSnowflake, DiscordAttachment>> Attachments { get; init; }
    }
}
