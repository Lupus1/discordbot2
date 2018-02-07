using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aoe_test_bot_2.Core.UserAccounts
{
    public class UserAccount
    {
        public ulong ID { get; set; }

        public uint Geld { get; set;  } 

        public uint XP { get; set; }

        public string Color { get; set; }
    }
}
