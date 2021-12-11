using UnityEngine;
using Newtonsoft.Json;
using System.IO;

public class Save : MonoBehaviour
{
    [SerializeField] private MainData mainData;

    private void Start()
    {
        LoadData();
        InvokeRepeating(nameof(SaveData), 5f, 10f);
    }

    public void SaveData()
    {
        Debug.Log("starting save");
        string saveData = JsonConvert.SerializeObject(mainData, Formatting.Indented);

        StreamWriter sw = new StreamWriter("SaveFile.svdata");
        sw.WriteLine(EncryptionMechanic.Shifrovka(saveData, "password"));
        sw.Close();

        sw = new StreamWriter("SaveFile.json");
        sw.WriteLine(saveData);
        sw.Close();

        Debug.Log($"Data has been saved {Time.realtimeSinceStartup}");
    }

    public void LoadData()
    {
        Debug.Log("starting load");
        StreamReader sr = new StreamReader("SaveFile.svdata");
        string encryptedData = EncryptionMechanic.DeShifrovka(sr.ReadLine(), "password");
        MainData jsonMainData = JsonConvert.DeserializeObject<MainData>(encryptedData);

        LoadOtherData(jsonMainData.otherData);

        LoadOreData(mainData.stoneData, jsonMainData.stoneData);
        LoadOreData(mainData.ironData, jsonMainData.ironData);
        LoadOreData(mainData.goldData, jsonMainData.goldData);
        LoadOreData(mainData.benitoiteData, jsonMainData.benitoiteData);
        LoadOreData(mainData.rubyData, jsonMainData.rubyData);
        LoadOreData(mainData.emeraldData, jsonMainData.emeraldData);
        LoadOreData(mainData.diamondData, jsonMainData.diamondData);
        LoadOreData(mainData.onyxData, jsonMainData.onyxData);
        LoadOreData(mainData.sapphireData, jsonMainData.sapphireData);
        LoadOreData(mainData.tinData, jsonMainData.tinData);
        LoadOreData(mainData.copperData, jsonMainData.copperData);
        LoadOreData(mainData.amethystData, jsonMainData.amethystData);

        LoadMineData(mainData.classicMineData, jsonMainData.classicMineData);
        LoadMineData(mainData.ironMineData, jsonMainData.ironMineData);
        LoadMineData(mainData.goldMineData, jsonMainData.goldMineData);

        LoadPrestigeData(mainData.phoneData, jsonMainData.phoneData);
        LoadPrestigeData(mainData.PCData, jsonMainData.PCData);
        LoadPrestigeData(mainData.flatData, jsonMainData.flatData);
        LoadPrestigeData(mainData.carData, jsonMainData.carData);
        LoadPrestigeData(mainData.mansionData, jsonMainData.mansionData);
        LoadPrestigeData(mainData.helicopterData, jsonMainData.helicopterData);
        LoadPrestigeData(mainData.yachtData, jsonMainData.yachtData);
        LoadPrestigeData(mainData.privatePlaneData, jsonMainData.privatePlaneData);
        LoadPrestigeData(mainData.rocketData, jsonMainData.rocketData);
        LoadPrestigeData(mainData.planetData, jsonMainData.planetData);

        sr.Close();
        Debug.Log("Load has been ended");
    }

    private void LoadOtherData(OtherData jsonOtherData)
    {
        Debug.Log("starting load other data");
        if(jsonOtherData == null)
        {
            Debug.LogWarning("jsonOtherData is null");
            mainData.otherData.money = 0;
            mainData.otherData.lvl = 1;
            mainData.otherData.exp = 0;
            mainData.otherData.maxExp = 10;
            mainData.otherData.lastIndex = 0;
            mainData.otherData.timer = 600;
            SaveData();
        }
        mainData.otherData.money = jsonOtherData.money;
        mainData.otherData.lvl = jsonOtherData.lvl;
        mainData.otherData.exp = jsonOtherData.exp;
        mainData.otherData.maxExp = jsonOtherData.maxExp;
        mainData.otherData.lastIndex = jsonOtherData.lastIndex;
        mainData.otherData.timer = jsonOtherData.timer;
        Debug.Log("Load other data has been ended");
    }

    private void LoadOreData(OreData oreData, OreData jsonOreData)
    {
        if (jsonOreData == null)
        {
            jsonOreData.amountOfRecycle = 0;
            jsonOreData.amountOfRecycleReceive = 0;
            jsonOreData.ore = 0;
            jsonOreData.recycleCount = 0;
            jsonOreData.recycleOre = 0;
            jsonOreData.recycleOreCost = jsonOreData.defaultOreCost;
            return;
        }
        oreData.amountOfRecycle = jsonOreData.amountOfRecycle;
        oreData.amountOfRecycleReceive = jsonOreData.amountOfRecycleReceive;
        oreData.ore = jsonOreData.ore;
        oreData.recycleCount = jsonOreData.recycleCount;
        oreData.recycleOre = jsonOreData.recycleOre;
        oreData.recycleOreCost = jsonOreData.recycleOreCost;
        oreData.recycleOreGive = jsonOreData.recycleOreGive;
    }

    private void LoadMineData(MineData mineData, MineData m)
    {
        mineData.isUnlocked = m.isUnlocked;
        mineData.cost = m.cost;
    }

    private void LoadPrestigeData(PrestigeData prestigeData, PrestigeData p)
    {
        prestigeData.canUpgrade = p.canUpgrade;
        prestigeData.thingCost = p.thingCost;
        prestigeData.wasBought = p.wasBought;
    }
}