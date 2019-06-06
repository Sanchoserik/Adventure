using Assets.Code.SystemScripts.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.Items
{
    public interface IItemFabric
    {
        A_Item createPotionAirUpMix1S(ItemsData data);
        A_Item createPotionAirUpMix2M(ItemsData data);
        A_Item createPotionAirUpMix3G(ItemsData data);
        A_Item createPotionAirUpMix4U(ItemsData data);
        A_Item createPotionDarknessUpMix1S(ItemsData data);
        A_Item createPotionDarknessUpMix2M(ItemsData data);
        A_Item createPotionDarknessUpMix3G(ItemsData data);
        A_Item createPotionDarknessUpMix4U(ItemsData data);
        A_Item createPotionDeathUpMix1S(ItemsData data);
        A_Item createPotionDeathUpMix2M(ItemsData data);
        A_Item createPotionDeathUpMix3G(ItemsData data);
        A_Item createPotionDeathUpMix4U(ItemsData data);
        A_Item createPotionEarthUpMix1S(ItemsData data);
        A_Item createPotionEarthUpMix2M(ItemsData data);
        A_Item createPotionEarthUpMix3G(ItemsData data);
        A_Item createPotionEarthUpMix4U(ItemsData data);
        A_Item createPotionFireUpMix1S(ItemsData data);
        A_Item createPotionFireUpMix2M(ItemsData data);
        A_Item createPotionFireUpMix3G(ItemsData data);
        A_Item createPotionFireUpMix4U(ItemsData data);
        A_Item createPotionLifeUpMix1S(ItemsData data);
        A_Item createPotionLifeUpMix2M(ItemsData data);
        A_Item createPotionLifeUpMix3G(ItemsData data);
        A_Item createPotionLifeUpMix4G(ItemsData data);
        A_Item createPotionLightningUpMix1S(ItemsData data);
        A_Item createPotionLightningUpMix2M(ItemsData data);
        A_Item createPotionLightningUpMix3G(ItemsData data);
        A_Item createPotionLightningUpMix4U(ItemsData data);
        A_Item createPotionLightUpMix1S(ItemsData data);
        A_Item createPotionLightUpMix2M(ItemsData data);
        A_Item createPotionLightUpMix3G(ItemsData data);
        A_Item createPotionLightUpMix4U(ItemsData data);
        A_Item createPotionPhysUpMix1S(ItemsData data);
        A_Item createPotionPhysUpMix2M(ItemsData data);
        A_Item createPotionPhysUpMix3G(ItemsData data);
        A_Item createPotionPhysUpMix4U(ItemsData data);
        A_Item createPotionWaterUpMix1S(ItemsData data);
        A_Item createPotionWaterUpMix2M(ItemsData data);
        A_Item createPotionWaterUpMix3G(ItemsData data);
        A_Item createPotionWaterUpMix4U(ItemsData data);

        A_Item createPotionHealP1S(ItemsData data);
        A_Item createPotionHealP2M(ItemsData data);
        A_Item createPotionHealP3G(ItemsData data);
        A_Item createPotionHealP4U(ItemsData data);
        A_Item createPotionHealReP1S(ItemsData data);
        A_Item createPotionHealReP2M(ItemsData data);
        A_Item createPotionHealReP3G(ItemsData data);
        A_Item createPotionHealReP4U(ItemsData data);

        A_Item createPotionEneP1S(ItemsData data);
        A_Item createPotionEneP2M(ItemsData data);
        A_Item createPotionEneP3G(ItemsData data);
        A_Item createPotionEneP4U(ItemsData data);
        A_Item createPotionEneReP1S(ItemsData data);
        A_Item createPotionEneReP2M(ItemsData data);
        A_Item createPotionEneReP3G(ItemsData data);
        A_Item createPotionEneReP4U(ItemsData data);

        A_Item createTalismanDefAir1S(ItemsData data);
        A_Item createTalismanDefAir2M(ItemsData data);
        A_Item createTalismanDefAir3G(ItemsData data);
        A_Item createTalismanDefAir4U(ItemsData data);
        A_Item createTalismanDefDarkness1S(ItemsData data);
        A_Item createTalismanDefDarkness2M(ItemsData data);
        A_Item createTalismanDefDarkness3G(ItemsData data);
        A_Item createTalismanDefDarkness4U(ItemsData data);
        A_Item createTalismanDefDeath1S(ItemsData data);
        A_Item createTalismanDefDeath2M(ItemsData data);
        A_Item createTalismanDefDeath3G(ItemsData data);
        A_Item createTalismanDefDeath4U(ItemsData data);
        A_Item createTalismanDefEarth1S(ItemsData data);
        A_Item createTalismanDefEarth2M(ItemsData data);
        A_Item createTalismanDefEarth3G(ItemsData data);
        A_Item createTalismanDefEarth4U(ItemsData data);
        A_Item createTalismanDefFire1S(ItemsData data);
        A_Item createTalismanDefFire2M(ItemsData data);
        A_Item createTalismanDefFire3G(ItemsData data);
        A_Item createTalismanDefFire4U(ItemsData data);
        A_Item createTalismanDefLight1S(ItemsData data);
        A_Item createTalismanDefLight2M(ItemsData data);
        A_Item createTalismanDefLight3G(ItemsData data);
        A_Item createTalismanDefLight4U(ItemsData data);
        A_Item createTalismanDefLightning1S(ItemsData data);
        A_Item createTalismanDefLightning2M(ItemsData data);
        A_Item createTalismanDefLightning3G(ItemsData data);
        A_Item createTalismanDefLightning4U(ItemsData data);
        A_Item createTalismanDefWater1S(ItemsData data);
        A_Item createTalismanDefWater2M(ItemsData data);
        A_Item createTalismanDefWater3G(ItemsData data);
        A_Item createTalismanDefWater4U(ItemsData data);
        A_Item createTalismanDefPhys1S(ItemsData data);
        A_Item createTalismanDefPhys2M(ItemsData data);
        A_Item createTalismanDefPhys3G(ItemsData data);
        A_Item createTalismanDefPhys4U(ItemsData data);
    }
}
