using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Core.Resources.Enums
{
    public enum ContactTypeEnum
    {
        [Description("Phone")]
        PHONE = 1,

        [Description("Email")]
        EMAIL = 2,

        [Description("Whatsapp")]
        WHATSAPP = 3,
    }
}
