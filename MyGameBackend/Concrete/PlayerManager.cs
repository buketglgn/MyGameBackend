using MyGameBackend.Abstract;
using MyGameBackend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameBackend.Concrete
{
    public class PlayerManager : IPlayerManager
    {
        Player tempPlayer;
        
        List<Player> players = new List<Player>();

        IE_DevletManager _edevletManager;

        public PlayerManager(IE_DevletManager edevletManager)
        {
            _edevletManager = edevletManager;
        }

        public void Add(Player player)
        {
            if (_edevletManager.IfRealPlayer(player))
            {
                Console.WriteLine(player.PlayerName+" "+player.PlayerSurname+" ADLI OYUNCU SİSTEME EKLENDİ ");
                players.Add(player);
            }
            else
            {
                Console.WriteLine("E-devlet üzerinden böyle bir kisi bulunamadı..");
            }
        }

        public void Delete(Player player)
        {
            Console.WriteLine(player.PlayerName+" "+player.PlayerSurname+" ADLI OYUNCU SİLİNDİ..");
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].Equals(player))
                {
                    players.RemoveAt(i);
                }

            }
        }

        public string Update(Player player, Player newPlayer)
        {
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].Equals(player))
                {
                    tempPlayer = newPlayer;
                    newPlayer = players[i];
                    players[i] = tempPlayer;
                }
            }
            return player.PlayerName+" "+player.PlayerSurname;
            
        }

        public void List()
        {
            foreach (var player in players)
            {
                Console.WriteLine(player.PlayerId+" "+player.PlayerName+" "+player.PlayerSurname);
            }
        }
    }
}
