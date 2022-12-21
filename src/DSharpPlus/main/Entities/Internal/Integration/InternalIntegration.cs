using System;
using DSharpPlus.Core.Attributes;
using DSharpPlus.Core.Enums;
using System.Text.Json.Serialization;

namespace DSharpPlus.Core.Entities
{
    [InternalGatewayPayload("INTEGRATION_CREATE", "INTEGRATION_UPDATE")]
    public sealed record InternalIntegration
    {
        /// <summary>
        /// The integration id.
        /// </summary>
        [JsonPropertyName("id")]
        public InternalSnowflake Id { get; init; } = null!;

        /// <summary>
        /// The integration name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; init; } = null!;

        /// <summary>
        /// The integration type (twitch, youtube, or discord).
        /// </summary>
        [JsonPropertyName("type")]
        public InternalIntegrationType Type { get; init; }

        /// <summary>
        /// Is this integration enabled.
        /// </summary>
        /// <remarks>
        /// Not provided for Internal Bot integrations.
        /// </remarks>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; init; }

        /// <summary>
        /// Is this integration syncing.
        /// </summary>
        /// <remarks>
        /// Not provided for Internal Bot integrations.
        /// </remarks>
        [JsonPropertyName("syncing")]
        public Optional<bool> Syncing { get; init; }

        /// <summary>
        /// The id that this integration uses for "subscribers".
        /// </summary>
        /// <remarks>
        /// Not provided for Internal Bot integrations.
        /// </remarks>
        [JsonPropertyName("role_id")]
        public Optional<string> RoleId { get; init; }

        /// <summary>
        /// Whether emoticons should be synced for this integration (twitch only currently).
        /// </summary>
        /// <remarks>
        /// Not provided for Internal Bot integrations.
        /// </remarks>
        [JsonPropertyName("enable_emoticons")]
        public Optional<bool> EnableEmoticons { get; init; }

        /// <summary>
        /// The behavior of expiring subscribers.
        /// </summary>
        /// <remarks>
        /// Not provided for Internal Bot integrations.
        /// </remarks>
        [JsonPropertyName("expire_behavior")]
        public Optional<InternalIntegrationExpireBehavior> ExpireBehavior { get; init; }

        /// <summary>
        /// The grace period (in days) before expiring subscribers.
        /// </summary>
        /// <remarks>
        /// Not provided for Internal Bot integrations.
        /// </remarks>
        [JsonPropertyName("expire_grace_period")]
        public Optional<int> ExpireGracePeriod { get; init; }

        /// <summary>
        /// The user for this integration.
        /// </summary>
        /// <remarks>
        /// Not provided for Internal Bot integrations.
        /// </remarks>
        [JsonPropertyName("user")]
        public Optional<InternalUser> User { get; init; }

        /// <summary>
        /// The integration account information.
        /// </summary>
        [JsonPropertyName("account")]
        public InternalIntegrationAccount Account { get; init; } = null!;

        /// <summary>
        /// When this integration was last synced.
        /// </summary>
        /// <remarks>
        /// Not provided for Internal Bot integrations.
        /// </remarks>
        [JsonPropertyName("synced_at")]
        public Optional<DateTimeOffset> SyncedAt { get; init; }

        /// <summary>
        /// How many subscribers this integration has.
        /// </summary>
        /// <remarks>
        /// Not provided for Internal Bot integrations.
        /// </remarks>
        [JsonPropertyName("subscriber_count")]
        public Optional<int> SubscriberCount { get; init; }

        /// <summary>
        /// Has this integration been revoked.
        /// </summary>
        /// <remarks>
        /// Not provided for Internal Bot integrations.
        /// </remarks>
        [JsonPropertyName("revoked")]
        public Optional<bool> Revoked { get; init; }

        /// <summary>
        /// The bot/OAuth2 application for discord integrations.
        /// </summary>
        [JsonPropertyName("application")]
        public Optional<InternalIntegrationApplication> Application { get; init; }

        /// <summary>
        /// Sent on gateway integration events such as INTEGRATION_CREATE or INTEGRATION_UPDATE.
        /// </summary>
        public Optional<InternalSnowflake> GuildId { get; init; }
    }
}
