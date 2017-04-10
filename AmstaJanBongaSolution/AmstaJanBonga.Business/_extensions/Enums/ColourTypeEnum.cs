using System.ComponentModel;

namespace AmstaJanBonga.Business.Enums
{
    public enum ColourTypeEnum : byte
    {
        [Description("Grijs")]
        Default = 0,
        [Description("Rood")]
        Red = 1,
        [Description("Groen")]
        Green = 2,
        [Description("Blauw")]
        Blue = 3,
        [Description("Paars")]
        Purple = 4,
        [Description("Oranje")]
        Orange = 5
    }
}
