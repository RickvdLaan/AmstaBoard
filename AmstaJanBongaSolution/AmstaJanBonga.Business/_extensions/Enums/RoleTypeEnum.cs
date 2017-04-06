using System.ComponentModel;

namespace AmstaJanBonga.Business.Enums
{
    public enum RoleTypeEnum : byte
    {
        [Description("Root")]
        Root = 0,
        [Description("Afdelingshoofd")]
        Manager = 1,
        [Description("Personeel")]
        Employee = 2,
        [Description("Stagiair")]
        Trainee = 3
    }
}
