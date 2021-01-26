using MyGameBackend.Abstract;
using MyGameBackend.Concrete;
using MyGameBackend.Entities;
using System;
using System.Collections.Generic;

namespace MyGameBackend
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.PlayerId = 1;
            player1.PlayerName = "Buket";
            player1.PlayerSurname = "GÜLGÜN";
            player1.DateOfBirth = new DateTime(1996, 12, 23);
            player1.NationaltyId = "1111111111";
            player1.IsStudent = true; //player1 ögrenci olsun
            player1.KayıtOlmaTarihi = new DateTime(2015, 12, 23);

            Player player2 = new Player();
            player2.PlayerId = 2;
            player2.PlayerName = "Ceylin";
            player2.PlayerSurname = "GÜLGÜNn";
            player2.DateOfBirth = new DateTime(2007, 7, 10);
            player2.NationaltyId = "22222222";
            player2.IsStudent = true;      //player 2 ögrenci 
            player2.KayıtOlmaTarihi = new DateTime(2020, 12, 12);

            Player player3 = new Player();
            player3.PlayerId = 3;
            player3.PlayerName = "Bertan";
            player3.PlayerSurname = "TANER";
            player3.DateOfBirth = new DateTime(1994, 11, 12);
            player3.NationaltyId = "33333333";
            player3.IsStudent = true;  //player3 ögrenci olsun.
            player3.KayıtOlmaTarihi = new DateTime(2019, 5, 10);

            Player player4 = new Player();
            player4.PlayerId = 4;
            player4.PlayerName = "Bülent";
            player4.PlayerSurname = "Gülgügll";
            player4.DateOfBirth = new DateTime(1971,11,12);
            player4.NationaltyId = "4444444444";
            player4.IsStudent = false;  //player3 ögrenci olsun.
            player4.KayıtOlmaTarihi = new DateTime(2017,5,10);

            E_DevletManager edevletManager = new E_DevletManager();

            PlayerManager playerManager = new PlayerManager(edevletManager);
            Console.WriteLine("OYUNCU EKLENİYOR..");
            playerManager.Add(player1);
            playerManager.Add(player2);
            playerManager.Add(player3);

            Console.WriteLine("OYUNCU SİLİNİYOR..");
            playerManager.Delete(player2);

            Console.WriteLine("OYUNCU GÜNCELLENİYOR..");
            Console.WriteLine(playerManager.Update(player1, new Player
            {
                PlayerId = 5,
                PlayerName = "Gülsevim",
                PlayerSurname = "Gülgünnn",
                DateOfBirth = new DateTime(1973, 12, 8),
                NationaltyId = "444444",
                IsStudent=false,
                KayıtOlmaTarihi=new DateTime(2017,7,9)
                
            }));

            Console.WriteLine("OYUNCULAR LİSTELENİYOR..");
            playerManager.List();

            Games game1 = new Games();
            game1.GameId = 1;
            game1.GameName = "Call Of Duty";
            game1.GamePrice = 69;

            Games game2 = new Games();
            game2.GameId = 2;
            game2.GameName = "SIMS 4";
            game2.GamePrice = 222;

            Games game3 = new Games();
            game3.GameId = 3;
            game3.GameName = "FIFA 21";
            game3.GamePrice = 349;

            Games game4 = new Games();
            game4.GameId = 4;
            game4.GameName = "VOLARANT";
            game4.GamePrice = 60;

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Add(game2);
            gameManager.Add(game3);

            SatisManager satisManager = new SatisManager();
            

            StudentCampaingManager studentCampaing = new StudentCampaingManager();

            Campaings studentCampaing1 = new Campaings();
            studentCampaing1.CampaignName = "For Student Campaign";
            studentCampaing1.Percentage = 25;


            // ICampaignManager camaignForConstantPlayer = new ConstantPlayerCampaingManager();

            BaseCampaingManager campaingManager = new BaseCampaingManager();
            campaingManager.AddCampaign(studentCampaing1);

            Console.WriteLine("OYUNLAR LİSTELENİYOR");  
            gameManager.List();
            ICampaign studentCampaign = new StudentCampaingManager();
            ICampaign constantCampaign = new ConstantPlayerCampaingManager();
            studentCampaign.Apply(new List<Games> { game1, game2,game3,game4 }, player3);
            constantCampaign.Apply(new List<Games> { game1,game2, game3,game4 }, player2);

            //fiyatlar indirimde ise degismis halleri ile çalışır.
            satisManager.Sold(player1, game1);
            satisManager.Sold(player2, game3);
            satisManager.Sold(player4, game3);
            satisManager.Sold(player3, game4);

            //satisManager.goster();

            Console.ReadLine();

            
            


        }
    }
}
