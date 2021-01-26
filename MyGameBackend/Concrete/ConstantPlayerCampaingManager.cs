using MyGameBackend.Abstract;
using MyGameBackend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameBackend.Concrete
{
    public class ConstantPlayerCampaingManager : ICampaign
    {

        List<Games> newPriceConst = new List<Games>();
        //en az 2 yıllık oyunculara özel kampanyalar.
        public void Apply(List<Games> games, Player player)
        {
            Console.WriteLine("2 YILI DOLDURANLARA ÖZEL İNDİRİMİNDE OLAN OYUNLAR LİSTELENİYOR..");
            Console.WriteLine("%20 İNDİRİM..");
             for (int i = 0; i < games.Count; i++)
            {
                games[i].GamePrice -= games[i].GamePrice * 0.20;
                Console.WriteLine(games[i].GameName + " =" + games[i].GamePrice);
            }
            foreach (var item in games)
            {
                newPriceConst.Add(item);

            }
            //foreach (var item in newPriceConst)
            //{
            //    Console.WriteLine(item.GameName + " = " + item.GamePrice);
            //}
        }

        public List<Games> newPrices()
        {
            return newPriceConst;
        }
    }
}
