using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatWPF.ADO;

namespace ChatWPF.Data
{
    internal class DBConnection
    {
        public static ChatLMLEntities connection = new ChatLMLEntities();
    }
}
