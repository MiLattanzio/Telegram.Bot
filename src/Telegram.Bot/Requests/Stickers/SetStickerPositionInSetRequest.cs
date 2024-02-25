// ReSharper disable once CheckNamespace

using System.Diagnostics.CodeAnalysis;

namespace Telegram.Bot.Requests;

/// <summary>
/// Use this method to move a sticker in a set created by the bot to a specific position.
/// Returns <see langword="true"/> on success.
/// </summary>
[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class SetStickerPositionInSetRequest : RequestBase<bool>
{
    /// <summary>
    /// <see cref="InputFileId">File identifier</see> of the sticker
    /// </summary>
    [JsonProperty(Required = Required.Always)]
    public required InputFileId Sticker { get; init; }

    /// <summary>
    /// New sticker position in the set, zero-based
    /// </summary>
    [JsonProperty(Required = Required.Always)]
    public required int Position { get; init; }

    /// <summary>
    /// Initializes a new request with sticker and position
    /// </summary>
    /// <param name="sticker">
    /// <see cref="InputFileId">File identifier</see> of the sticker
    /// </param>
    /// <param name="position">New sticker position in the set, zero-based</param>
    [SetsRequiredMembers]
    [Obsolete("Use parameterless constructor with required parameters")]
    public SetStickerPositionInSetRequest(InputFileId sticker, int position)
        : this()
    {
        Sticker = sticker;
        Position = position;
    }

    /// <summary>
    /// Initializes a new request
    /// </summary>
    public SetStickerPositionInSetRequest()
        : base("setStickerPositionInSet")
    { }
}
