using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    [SerializeField] private MainData mainData;

    public void ResetProgress()
    {
        ResetPrestigeData(mainData.phoneData, 400, true);
        ResetPrestigeData(mainData.PCData, 1300, false);
        ResetPrestigeData(mainData.flatData, 7000, false);
        ResetPrestigeData(mainData.carData, 4500, false);
        ResetPrestigeData(mainData.mansionData, 10000, false);
        ResetPrestigeData(mainData.helicopterData, 14000, false);
        ResetPrestigeData(mainData.yachtData, 19000, false);
        ResetPrestigeData(mainData.privatePlaneData, 25000, false);
        ResetPrestigeData(mainData.rocketData, 50000, false);
        ResetPrestigeData(mainData.planetData, 200000, false);
        ResetOtherData(mainData.otherData);
        ResetMineData(mainData.classicMineData, true);
        ResetMineData(mainData.ironMineData, false);
        ResetMineData(mainData.goldMineData, false);
        ResetMineData(mainData.tinMineData, false);
        ResetMineData(mainData.copperMineData, false);
        ResetMineData(mainData.benitoiteMineData, false);
        ResetMineData(mainData.diamondMineData, false);
        ResetMineData(mainData.emeraldMineData, false);
        ResetMineData(mainData.rubyMineData, false);
        ResetMineData(mainData.onyxMineData, false);
        ResetMineData(mainData.sapphireMineData, false);
        ResetMineData(mainData.amethystMineData, false);
        ResetOreData(mainData.stoneData);
        ResetOreData(mainData.ironData);
        ResetOreData(mainData.goldData);
        ResetOreData(mainData.benitoiteData);
        ResetOreData(mainData.amethystData);
        ResetOreData(mainData.copperData);
        ResetOreData(mainData.diamondData);
        ResetOreData(mainData.emeraldData);
        ResetOreData(mainData.onyxData);
        ResetOreData(mainData.rubyData);
        ResetOreData(mainData.sapphireData);
        ResetOreData(mainData.tinData);
        ResetPlantData(mainData.allPlantsData.firstSpecialSectionData);
        ResetPlantData(mainData.allPlantsData.secondSpecialSectionData);
        ResetPlantData(mainData.allPlantsData.thirdSpecialSectionData);
        ResetAchivementData(mainData.achivementData.haveYouDone, mainData.achivementData.haveYouEarned);
        Debug.LogWarning("Reseted");
    }

    private void ResetAchivementData(List<bool> list, List<bool> list2)
    {
        for (int i = 0; i < list.Count; i++) list[i] = false;
        for (int i = 0; i < list2.Count; i++) list2[i] = false;
    }

    private void ResetPrestigeData(PrestigeData prestigeData, float classicPrize, bool standartBool)
    {
        prestigeData.wasBought = false;
        prestigeData.canUpgrade = standartBool;
        prestigeData.thingCost = classicPrize;
    }

    private void ResetOtherData(OtherData otherData)
    {
        otherData.money = 0;
        otherData.lvl = 1;
        otherData.exp = 0;
        otherData.maxExp = 10;
        otherData.timer = 600;
        otherData.lastIndex = 0;
    }

    private void ResetMineData(MineData mineData, bool standartBool)
    {
        mineData.isUnlocked = standartBool;
    }

    private void ResetOreData(OreData oreData)
    {
        oreData.ore = 0;
        oreData.recycleOre = 0;
        oreData.recycleOreSellCost = oreData.defaultOreSellCost;
        oreData.recycleOreBuyCost = (oreData.defaultOreSellCost * 107) / 100;
        oreData.numberNeededToDecrease = 50;
    }

    private void ResetPlantData(PlantsData plantsData)
    {
        plantsData.isRented = false;
        plantsData.rentTime = 0;
    }
}
