using UnityEngine;

[CreateAssetMenu(fileName = "NewMainData", menuName = "MainData", order = 53)]
public class MainData : ScriptableObject
{
    public OreData stoneData;
    public OreData ironData;
    public OreData goldData;
    public OtherData otherData;
    public MineData classicMineData;
    public MineData ironMineData;
    public MineData goldMineData;
    public PrestigeData phoneData;
    public PrestigeData PCData;
    public PrestigeData flatData;
}