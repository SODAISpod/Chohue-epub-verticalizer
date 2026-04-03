namespace Chohue.Core.Enums;

public enum OpfReadResult
{
    Success,
    Fail,
    FinishDueToEpub3Takeover,
    NeedPandocForEpub2To3,
    PandocConvertError
}
