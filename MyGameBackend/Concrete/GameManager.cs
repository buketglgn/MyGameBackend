using MyGameBackend.Abstract;
using MyGameBackend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameBackend.Concrete
{
    public class GameManager : IGameManager
    {
        List<Games> games = new List<Games>();
        public void Add(Games game)
        {
            games.Add(game);
            Console.WriteLine(game.GameName+" ADLI OYUN SİSTEME EKLENDİ");
        }

        public void List()
        {
            foreach (var game in games)
            {
                Console.WriteLine(game.GameName+" "+game.GamePrice+" TL");
            }
        }
    }
}
