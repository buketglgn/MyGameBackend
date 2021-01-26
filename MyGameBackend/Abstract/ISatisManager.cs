using MyGameBackend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameBackend.Abstract
{
   public interface ISatisManager
    {
        void Sold(Player player, Games game);
    }
}
