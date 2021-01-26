using MyGameBackend.Abstract;
using MyGameBackend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameBackend.Concrete
{
    public class SatisManager : ISatisManager

    {
        //StudentCampaingManager students = new StudentCampaingManager();

        public void Sold(Player player, Games game)
        {
            if ((player.IsStudent)==true)
            {

                Console.WriteLine(player.PlayerName + " Adlı oyuncu " + game.GameName + " adlı oyunu satın aldı");
                Console.WriteLine("Ödenecek ücret: " + game.GamePrice + "TL");
            }
            else if(player.KayıtOlmaTarihi >= (new DateTime(2021, 11, 10)))
            {
                Console.WriteLine(player.PlayerName + " Adlı oyuncu " + game.GameName + " adlı oyunu satın aldı");
                Console.WriteLine("Ödenecek ücret: " + game.GamePrice + "TL");

            }
            else
            {
                Console.WriteLine(player.PlayerName + " Adlı oyuncu " + game.GameName + " adlı oyunu almak için");
                Console.WriteLine("ÖGRENCİ İNDİRİMNDEN VEYA 2 YILLIK ŞART İNDİRİMNDEN  YARARLANAMAZSINIZ.");
            }
            
        }
        //public void goster()
        //{
        //    List<Games> yeni = students.newPrices();
        //    foreach (var item in yeni)
        //    {
        //        Console.WriteLine("student için yeni fiyatlar yazıyor..  "+item.GameName+" =="+item.GamePrice);
        //    }
        //}
    }
}
