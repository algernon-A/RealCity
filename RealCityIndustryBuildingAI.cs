﻿using ColossalFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealCity
{
    public class RealCityIndustryBuildingAI
    {
        public static int CustomGetResourcePrice(TransferManager.TransferReason material)
        {
            switch (material)
            {
                case TransferManager.TransferReason.AnimalProducts:
                    return 1500;
                case TransferManager.TransferReason.Flours:
                    return 1500;
                case TransferManager.TransferReason.Paper:
                    return 2000;
                case TransferManager.TransferReason.PlanedTimber:
                    return 2000;
                case TransferManager.TransferReason.Petroleum:
                    return 3000;
                case TransferManager.TransferReason.Plastics:
                    return 3000;
                case TransferManager.TransferReason.Glass:
                    return 2300;
                case TransferManager.TransferReason.Metals:
                    return 2300;
                case TransferManager.TransferReason.LuxuryProducts:
                    return 10000;
                case TransferManager.TransferReason.Oil:
                    return 200;
                case TransferManager.TransferReason.Ore:
                    return 160;
                case TransferManager.TransferReason.Logs:
                    return 130;
                case TransferManager.TransferReason.Grain:
                    return 100;
                case TransferManager.TransferReason.Goods:
                    return 0;
                case TransferManager.TransferReason.Petrol:
                    return 0;
                case TransferManager.TransferReason.Food:
                    return 0;
                case TransferManager.TransferReason.Lumber:
                    return 0;
                case TransferManager.TransferReason.Coal:
                    return 0;
                case TransferManager.TransferReason.Shopping:
                case TransferManager.TransferReason.ShoppingB:
                case TransferManager.TransferReason.ShoppingC:
                case TransferManager.TransferReason.ShoppingD:
                case TransferManager.TransferReason.ShoppingE:
                case TransferManager.TransferReason.ShoppingH:
                    return 0;
                case TransferManager.TransferReason.Entertainment:
                case TransferManager.TransferReason.EntertainmentB:
                case TransferManager.TransferReason.EntertainmentC:
                case TransferManager.TransferReason.EntertainmentD:
                    return 0;
                default: return 0;
            }
        }

        public static float GetResourcePrice(TransferManager.TransferReason material)
        {
            switch (material)
            {
                case TransferManager.TransferReason.Goods:
                    return 3f;
                case TransferManager.TransferReason.Petrol:
                    return 3f;
                case TransferManager.TransferReason.Food:
                    return 1.5f;
                case TransferManager.TransferReason.Lumber:
                    return 2.0f;
                case TransferManager.TransferReason.Coal:
                    return 2.3f;
                case TransferManager.TransferReason.Shopping:
                case TransferManager.TransferReason.ShoppingB:
                case TransferManager.TransferReason.ShoppingC:
                case TransferManager.TransferReason.ShoppingD:
                case TransferManager.TransferReason.ShoppingE:
                case TransferManager.TransferReason.ShoppingH:
                    return 4f;
                case TransferManager.TransferReason.Entertainment:
                case TransferManager.TransferReason.EntertainmentB:
                case TransferManager.TransferReason.EntertainmentC:
                case TransferManager.TransferReason.EntertainmentD:
                    return 1f;
                default: return CustomGetResourcePrice(material) /100f;
            }
        }
    }
}
