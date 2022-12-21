using DSharpPlus.Core.Entities;
using System.Text.Json.Serialization;

namespace DSharpPlus.Core.Entities.VoiceGateway.Commands
{
    /// <summary>
    /// Once connected to the voice WebSocket endpoint, we can send an <see cref="Enums.InternalVoiceOpCode.Identify"/> payload.
    /// </summary>
    public sealed record InternalVoiceIdentifyCommand
    {
        /// <summary>
        /// Also known as the guild id.
        /// </summary>
        [JsonPropertyName("server_id")]
        public InternalSnowflake ServerId { get; init; } = null!;

        [JsonPropertyName("user_id")]
        public InternalSnowflake UserId { get; init; } = null!;

        [JsonPropertyName("session_id")]
        public string SessionId { get; init; } = null!;

        [JsonPropertyName("token")]
        public string Token { get; init; } = null!;
    }
}
