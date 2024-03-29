﻿using System.ComponentModel;

namespace AmstaJanBonga.Business.Enums
{
    public enum RoleTypeEnum : byte
    {
        [Description("Applicatiebeheerder")]
        Root = 0,
        [Description("Afdelingshoofd")]
        Manager = 1,
        [Description("Medewerker")]
        Employee = 2,
        [Description("Stagiair")]
        Trainee = 3
    }
}
