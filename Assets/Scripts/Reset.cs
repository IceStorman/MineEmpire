using UnityEngine;

public class Reset : MonoBehaviour
{
    [SerializeField] private MainData mainData;

    public void ResetProgress()
    {
        ResetPrestigeData(mainData.phoneData, 700, true);
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
        ResetOreData(mainData.stoneData, 7.9f);
        ResetOreData(mainData.ironData, 23.7f);
        ResetOreData(mainData.goldData, 42.3f);
        ResetOreData(mainData.benitoiteData, 0f);
        ResetOreData(mainData.amethystData, 0f);
        ResetOreData(mainData.copperData, 0f);
        ResetOreData(mainData.diamondData, 0f);
        ResetOreData(mainData.emeraldData, 0f);
        ResetOreData(mainData.onyxData, 0f);
        ResetOreData(mainData.rubyData, 0f);
        ResetOreData(mainData.sapphireData, 0f);
        ResetOreData(mainData.tinData, 0f);
        Debug.LogWarning("Reseted");
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
        mineData.isOpened = standartBool;
    }

    private void ResetOreData(OreData oreData, float standartCost)
    {
        oreData.ore = 0;
        oreData.recycleOre = 0;
        oreData.recycleOreCost = standartCost;
    }
}
