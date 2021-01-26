using MyGameBackend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameBackend.Abstract
{
   public interface IPlayerManager
    {
        void Add(Player player);
        void Delete(Player player);
        string Update(Player player, Player newPlayer);
        void List();
    }
}
