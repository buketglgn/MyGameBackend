using MyGameBackend.Abstract;
using MyGameBackend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameBackend.Concrete
{
    public class StudentCampaingManager : ICampaign
    {     
        // ögrencilere özel kampanya
        List<Games> newPrice = new List<Games>();
        public void Apply(List<Games> games , Player player)
        {
            Console.WriteLine("ÖGRENCİ İNDİRİMİNDE OLAN OYUNLAR LİSTELENİYOR..");
            Console.WriteLine("%10 indirim ..");
            for (int i = 0; i < games.Count; i++)
            {
                games[i].GamePrice -=  games[i].GamePrice * 0.10;
               
            }
            foreach (var item in games)
            {
                newPrice.Add(item);

            }
            foreach (var item in newPrice)
            {
                Console.WriteLine(item.GameName + " = " + item.GamePrice);
            }
 
        }
  
        //public List<Games> newPrices()
        //{     
        //    return newPrice;
            
        //}
    }
}
