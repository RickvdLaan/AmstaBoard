using System.ComponentModel;

namespace AmstaJanBonga.Business.Enums
{
    public enum RoleTypeEnum : byte
    {
        [Description("Root")]
        Root = 0,
        [Description("Manager")]
        Manager = 1,
        [Description("Employee")]
        Employee = 2,
        [Description("Trainee")]
        Trainee = 3
    }
}
