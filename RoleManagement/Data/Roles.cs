using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace RoleManagement.Data
{
    public enum Roles
    {
        [Description("HR")]
        HR,
        [Description("IT")]
        IT,
        [Description("Marketing")]
        Marketing,
        [Description("Destek")]
        D
    }
}
