using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Code.Items.Potions;
using Assets.Code.SystemScripts.DataStructures;

namespace Assets.Code.Items
{
    public class ItemFabric : IItemFabric
    {
        public A_Item createPotionAirUpMix1S(ItemsData data)
        {
            return new AirUpMix1S( 
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]), 
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionAirUpMix2M(ItemsData data)
        {
            return new AirUpMix2M(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionAirUpMix3G(ItemsData data)
        {
            return new AirUpMix3G(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionAirUpMix4U(ItemsData data)
        {
            return new AirUpMix4U(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionDarknessUpMix1S(ItemsData data)
        {
            return new DarknessUpMix1S(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionDarknessUpMix2M(ItemsData data)
        {
            return new DarknessUpMix2M(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionDarknessUpMix3G(ItemsData data)
        {
            return new DarknessUpMix3G(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionDarknessUpMix4U(ItemsData data)
        {
            return new DarknessUpMix4U(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionDeathUpMix1S(ItemsData data)
        {
            return new DeathUpMix1S(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionDeathUpMix2M(ItemsData data)
        {
            return new DeathUpMix2M(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionDeathUpMix3G(ItemsData data)
        {
            return new DeathUpMix3G(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionDeathUpMix4U(ItemsData data)
        {
            return new DeathUpMix4U(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionEarthUpMix1S(ItemsData data)
        {
            return new EarthUpMix1S(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionEarthUpMix2M(ItemsData data)
        {
            return new EarthUpMix2M(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionEarthUpMix3G(ItemsData data)
        {
            return new EarthUpMix3G(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionEarthUpMix4U(ItemsData data)
        {
            return new EarthUpMix4U(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionEneP1S(ItemsData data)
        {
            return new EneP1S(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionEneP2M(ItemsData data)
        {
            return new EneP2M(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionEneP3G(ItemsData data)
        {
            return new EneP3G(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionEneP4U(ItemsData data)
        {
            return new EneP4U(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionEneReP1S(ItemsData data)
        {
            return new EneReP1S(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionEneReP2M(ItemsData data)
        {
            return new EneReP2M(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionEneReP3G(ItemsData data)
        {
            return new EneReP3G(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionEneReP4U(ItemsData data)
        {
            return new EneReP4U(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionFireUpMix1S(ItemsData data)
        {
            return new FireUpMix1S(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionFireUpMix2M(ItemsData data)
        {
            return new FireUpMix2M(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionFireUpMix3G(ItemsData data)
        {
            return new FireUpMix3G(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionFireUpMix4U(ItemsData data)
        {
            return new FireUpMix4U(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionHealP1S(ItemsData data)
        {
            return new HealP1S(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionHealP2M(ItemsData data)
        {
            return new HealP2M(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionHealP3G(ItemsData data)
        {
            return new HealP3G(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionHealP4U(ItemsData data)
        {
            return new HealP4U(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionHealReP1S(ItemsData data)
        {
            return new HealReP1S(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionHealReP2M(ItemsData data)
        {
            return new HealReP2M(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionHealReP3G(ItemsData data)
        {
            return new HealReP3G(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionHealReP4U(ItemsData data)
        {
            return new HealReP4U(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionLifeUpMix1S(ItemsData data)
        {
            return new LifeUpMix1S(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionLifeUpMix2M(ItemsData data)
        {
            return new LifeUpMix2M(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionLifeUpMix3G(ItemsData data)
        {
            return new LifeUpMix3G(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionLifeUpMix4G(ItemsData data)
        {
            return new LifeUpMix4U(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionLightningUpMix1S(ItemsData data)
        {
            return new LightningUpMix1S(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionLightningUpMix2M(ItemsData data)
        {
            return new LightningUpMix2M(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionLightningUpMix3G(ItemsData data)
        {
            return new LightningUpMix3G(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionLightningUpMix4U(ItemsData data)
        {
            return new LightningUpMix4U(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionLightUpMix1S(ItemsData data)
        {
            return new LightUpMix1S(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionLightUpMix2M(ItemsData data)
        {
            return new LightUpMix2M(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionLightUpMix3G(ItemsData data)
        {
            return new LightUpMix3G(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionLightUpMix4U(ItemsData data)
        {
            return new LightUpMix4U(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionPhysUpMix1S(ItemsData data)
        {
            return new PhysUpMix1S(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionPhysUpMix2M(ItemsData data)
        {
            return new PhysUpMix2M(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionPhysUpMix3G(ItemsData data)
        {
            return new PhysUpMix3G(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionPhysUpMix4U(ItemsData data)
        {
            return new PhysUpMix4U(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionWaterUpMix1S(ItemsData data)
        {
            return new WaterUpMix1S(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionWaterUpMix2M(ItemsData data)
        {
            return new WaterUpMix2M(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionWaterUpMix3G(ItemsData data)
        {
            return new WaterUpMix3G(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createPotionWaterUpMix4U(ItemsData data)
        {
            return new WaterUpMix4U(
                Convert.ToInt32(data.itemsParameters["val"]),
                Convert.ToInt32(data.itemsParameters["time"]),
                Convert.ToInt32(data.itemsParameters["buyPrice"]),
                Convert.ToInt32(data.itemsParameters["sellPrice"]));
        }

        public A_Item createTalismanDefAir1S(ItemsData data)
        {
            throw new NotImplementedException();
        }

        public A_Item createTalismanDefAir2M(ItemsData data)
        {
            throw new NotImplementedException();
        }

        public A_Item createTalismanDefAir3G(ItemsData data)
        {
            throw new NotImplementedException();
        }

        public A_Item createTalismanDefAir4U(ItemsData data)
        {
            throw new NotImplementedException();
        }

        public A_Item createTalismanDefDarkness1S(ItemsData data)
        {
            throw new NotImplementedException();
        }

        public A_Item createTalismanDefDarkness2M(ItemsData data)
        {
            throw new NotImplementedException();
        }

        public A_Item createTalismanDefDarkness3G(ItemsData data)
        {
            throw new NotImplementedException();
        }

        public A_Item createTalismanDefDarkness4U(ItemsData data)
        {
            throw new NotImplementedException();
        }

        public A_Item createTalismanDefDeath1S(ItemsData data)
        {
            throw new NotImplementedException();
        }

        public A_Item createTalismanDefDeath2M(ItemsData data)
        {
            throw new NotImplementedException();
        }

        public A_Item createTalismanDefDeath3G(ItemsData data)
        {
            throw new NotImplementedException();
        }

        public A_Item createTalismanDefDeath4U(ItemsData data)
        {
            throw new NotImplementedException();
        }

        public A_Item createTalismanDefEarth1S(ItemsData data)
        {
            throw new NotImplementedException();
        }

        public A_Item createTalismanDefEarth2M(ItemsData data)
        {
            throw new NotImplementedException();
        }

        public A_Item createTalismanDefEarth3G(ItemsData data)
        {
            throw new NotImplementedException();
        }

        public A_Item createTalismanDefEarth4U(ItemsData data)
        {
            throw new NotImplementedException();
        }

        public A_Item createTalismanDefFire1S(ItemsData data)
        {
            throw new NotImplementedException();
        }

        public A_Item createTalismanDefFire2M(ItemsData data)
        {
            throw new NotImplementedException();
        }

        public A_Item createTalismanDefFire3G(ItemsData data)
        {
            throw new NotImplementedException();
        }

        public A_Item createTalismanDefFire4U(ItemsData data)
        {
            throw new NotImplementedException();
        }

        public A_Item createTalismanDefLight1S(ItemsData data)
        {
            throw new NotImplementedException();
        }

        public A_Item createTalismanDefLight2M(ItemsData data)
        {
            throw new NotImplementedException();
        }

        public A_Item createTalismanDefLight3G(ItemsData data)
        {
            throw new NotImplementedException();
        }

        public A_Item createTalismanDefLight4U(ItemsData data)
        {
            throw new NotImplementedException();
        }

        public A_Item createTalismanDefLightning1S(ItemsData data)
        {
            throw new NotImplementedException();
        }

        public A_Item createTalismanDefLightning2M(ItemsData data)
        {
            throw new NotImplementedException();
        }

        public A_Item createTalismanDefLightning3G(ItemsData data)
        {
            throw new NotImplementedException();
        }

        public A_Item createTalismanDefLightning4U(ItemsData data)
        {
            throw new NotImplementedException();
        }

        public A_Item createTalismanDefPhys1S(ItemsData data)
        {
            throw new NotImplementedException();
        }

        public A_Item createTalismanDefPhys2M(ItemsData data)
        {
            throw new NotImplementedException();
        }

        public A_Item createTalismanDefPhys3G(ItemsData data)
        {
            throw new NotImplementedException();
        }

        public A_Item createTalismanDefPhys4U(ItemsData data)
        {
            throw new NotImplementedException();
        }

        public A_Item createTalismanDefWater1S(ItemsData data)
        {
            throw new NotImplementedException();
        }

        public A_Item createTalismanDefWater2M(ItemsData data)
        {
            throw new NotImplementedException();
        }

        public A_Item createTalismanDefWater3G(ItemsData data)
        {
            throw new NotImplementedException();
        }

        public A_Item createTalismanDefWater4U(ItemsData data)
        {
            throw new NotImplementedException();
        }
    }
}
