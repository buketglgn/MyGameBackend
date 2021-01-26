using MyGameBackend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameBackend.Abstract
{
   public interface ICampaignManager
    {
        void AddCampaign(Campaings campaing);
        void DeleteCampaing(Campaings campaing);
    }
}
