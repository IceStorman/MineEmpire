using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "NewMainData", menuName = "MainData", order = 53)]
public class MainData : ScriptableObject
{
    public List<OreData> allOresDatas = new List<OreData>(12);

    public OreData stoneData;
    public OreData ironData;
    public OreData goldData;
    public OreData benitoiteData;
    public OreData rubyData;
    public OreData emeraldData;
    public OreData diamondData;
    public OreData onyxData;
    public OreData sapphireData;
    public OreData tinData;
    public OreData copperData;
    public OreData amethystData;

    public OtherData otherData;

    public MineData classicMineData;
    public MineData ironMineData;
    public MineData goldMineData;
    public MineData benitoiteMineData;
    public MineData diamondMineData;
    public MineData amethystMineData;
    public MineData rubyMineData;
    public MineData copperMineData;
    public MineData tinMineData;
    public MineData sapphireMineData;
    public MineData onyxMineData;
    public MineData emeraldMineData;

    public PrestigeData phoneData;
    public PrestigeData PCData;
    public PrestigeData flatData;
    public PrestigeData carData;
    public PrestigeData mansionData;
    public PrestigeData helicopterData;
    public PrestigeData yachtData;
    public PrestigeData privatePlaneData;
    public PrestigeData rocketData;
    public PrestigeData planetData;

    public List<PickaxeData> pickaxesList = new List<PickaxeData>(6);

    public AchivementData achivementData;

    public AllPlantsData allPlantsData;
}