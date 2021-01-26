using MyGameBackend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameBackend.Abstract
{
   public interface IGameManager
    {
        void Add(Games game);
        void List();
    }
}
