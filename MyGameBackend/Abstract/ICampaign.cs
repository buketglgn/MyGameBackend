using MyGameBackend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameBackend.Abstract
{
   public interface ICampaign
    {
        void Apply(List<Games> games, Player player);
        //List<Games> newPrices();
    }
}
