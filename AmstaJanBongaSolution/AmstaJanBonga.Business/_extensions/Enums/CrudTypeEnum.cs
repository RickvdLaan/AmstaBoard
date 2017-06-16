using System.ComponentModel;

namespace AmstaJanBonga.Business.Enums
{
    public enum CrudTypeEnum
    {
        [Description("Create")]
        Create,
        [Description("Read")]
        Read,
        [Description("Update")]
        Update,
        [Description("Delete")]
        Delete
    }
}
