using MyGameBackend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameBackend.Abstract
{
    public  class BaseCampaingManager : ICampaignManager
    {
        List<Campaings> campaigns = new List<Campaings>();
        public  void AddCampaign(Campaings campaign)
        {
            campaigns.Add(campaign);
            Console.WriteLine(campaign.CampaignName+" adlı kampanya eklendi");
        }
        public  void DeleteCampaing(Campaings campaing)
        {
            for (int i = 0; i < campaigns.Count; i++)
            {
                if (campaigns[i].Equals(campaing))
                {
                    campaigns.RemoveAt(i);
                }
                Console.WriteLine(campaing.CampaignName+" adlı kampanya silindi");
            }
        }
    }
}
