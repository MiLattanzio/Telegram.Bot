namespace Telegram.Bot.Requests;

/// <summary>Removes verification from a chat that is currently verified on behalf of the organization represented by the bot.<para>Returns: </para></summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public partial class RemoveChatVerificationRequest() : RequestBase<bool>("removeChatVerification"), IChatTargetable
{
    /// <summary>Unique identifier for the target chat or username of the target channel (in the format <c>@channelusername</c>)</summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public required ChatId ChatId { get; set; }
}
