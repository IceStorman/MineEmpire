using UnityEngine;
using Newtonsoft.Json;
using System.IO;

public class Save : MonoBehaviour
{
    [SerializeField] private MainData mainData;
    [SerializeField] private StreamWriter sw;
    [SerializeField] private StreamReader sr;

    private void Start()
    {
        LoadData();
        InvokeRepeating(nameof(SaveData), 5f, 10f);
    }

    public void SaveData()
    {
        string saveData = JsonConvert.SerializeObject(mainData);

        sw = new StreamWriter("SaveFile.svdata");
        sw.WriteLine(saveData);
        sw.Close();
        Debug.Log($"Data has been saved {Time.realtimeSinceStartup}");
    }

    public void LoadData()
    {
        sr = new StreamReader("SaveFile.svdata");
        MainData m = JsonConvert.DeserializeObject<MainData>(sr.ReadLine());

        LoadOtherData(m.otherData);

        LoadOreData(mainData.stoneData, m.stoneData);
        LoadOreData(mainData.ironData, m.ironData);
        LoadOreData(mainData.goldData, m.goldData);
        LoadOreData(mainData.benitoiteData, m.benitoiteData);
        LoadOreData(mainData.rubyData, m.rubyData);
        LoadOreData(mainData.emeraldData, m.emeraldData);
        LoadOreData(mainData.diamondData, m.diamondData);
        LoadOreData(mainData.onyxData, m.onyxData);
        LoadOreData(mainData.sapphireData, m.sapphireData);
        LoadOreData(mainData.tinData, m.tinData);
        LoadOreData(mainData.copperData, m.copperData);
        LoadOreData(mainData.amethystData, m.amethystData);

        LoadMineData(mainData.classicMineData, m.classicMineData);
        LoadMineData(mainData.ironMineData, m.ironMineData);
        LoadMineData(mainData.goldMineData, m.goldMineData);

        LoadPrestigeData(mainData.phoneData, m.phoneData);
        LoadPrestigeData(mainData.PCData, m.PCData);
        LoadPrestigeData(mainData.flatData, m.flatData);

        sr.Close();
    }

    private void LoadOtherData(OtherData o)
    {
        mainData.otherData.money = o.money;
        mainData.otherData.lvl = o.lvl;
        mainData.otherData.exp = o.exp;
        mainData.otherData.maxExp = o.maxExp;
        mainData.otherData.lastIndex = o.lastIndex;
        mainData.otherData.timer = o.timer;
    }

    private void LoadOreData(OreData oreData, OreData o)
    {
        oreData.amountOfRecycle = o.amountOfRecycle;
        oreData.amountOfRecycleReceive = o.amountOfRecycleReceive;
        oreData.ore = o.ore;
        oreData.recycleCount = o.recycleCount;
        oreData.recycleOre = o.recycleOre;
        oreData.recycleOreCost = o.recycleOreCost;
        oreData.recycleOreGive = o.recycleOreGive;
    }

    private void LoadMineData(MineData mineData, MineData m)
    {
        mineData.isOpened = m.isOpened;
        mineData.cost = m.cost;
    }

    private void LoadPrestigeData(PrestigeData prestigeData, PrestigeData p)
    {
        prestigeData.canUpgrade = p.canUpgrade;
        prestigeData.thingCost = p.thingCost;
        prestigeData.wasBought = p.wasBought;
    }
}