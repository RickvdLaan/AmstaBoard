using System.ComponentModel;

namespace AmstaJanBonga.Business.Enums
{
    public enum ShiftTypeEnum : byte
    {
        [Description("Dag")]
        Day = 0,
        [Description("Avond")]
        Evening = 1
    }
}