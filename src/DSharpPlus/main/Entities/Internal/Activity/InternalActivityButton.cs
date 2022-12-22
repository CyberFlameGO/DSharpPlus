using System.Text.Json.Serialization;

namespace DSharpPlus.Entities.Internal;

public sealed record InternalActivityButton
{
    /// <summary>
    /// The text shown on the button (1-32 characters).
    /// </summary>
    [JsonPropertyName("label")]
    public required string Label { get; init; }

    /// <summary>
    /// The url opened when clicking the button (1-512 characters).
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; init; }
}
