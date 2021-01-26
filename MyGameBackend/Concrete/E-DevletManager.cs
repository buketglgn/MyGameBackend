using MyGameBackend.Abstract;
using MyGameBackend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameBackend.Concrete
{
    public class E_DevletManager : IE_DevletManager
    {
        public bool IfRealPlayer(Player player)
        {
            return true;
        }
    }
}
