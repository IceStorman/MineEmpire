using UnityEngine;

[CreateAssetMenu(fileName = "NewMainData", menuName = "MainData", order = 53)]
public class MainData : ScriptableObject
{
    public OreData stoneData;
    public OreData ironData;
    public OreData goldData;
    public OreData benitoiteData;
    public OreData rubyData;
    public OreData emeraldData;

    public OtherData otherData;

    public MineData classicMineData;
    public MineData ironMineData;
    public MineData goldMineData;

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
}