using UnityEngine;
using UnityEngine.UI;

public class StandartPlantPanel : MonoBehaviour
{
    [SerializeField] private GameObject standartPlantPanel;

    [SerializeField] private Text stoneText;
    [SerializeField] private Text ironText;
    [SerializeField] private Text goldText;
    [SerializeField] private Text recycleStoneText;
    [SerializeField] private Text recycleIronText;
    [SerializeField] private Text recycleGoldText;
    [SerializeField] private Text amountOfRecycleStoneText;
    [SerializeField] private Text amountOfRecycleIronText;
    [SerializeField] private Text amountOfRecycleGoldText;
    [SerializeField] private Text amountOfRecycleStoneReciveText;
    [SerializeField] private Text amountOfRecycleReceiveIronText;
    [SerializeField] private Text amountOfRecycleReceiveGoldText;

    [SerializeField] private MainData mainData;

    private void Start()
    {
        standartPlantPanel.SetActive(false);
    }

    private void Update()
    {
        UpdateUI();
    }

    private void UpdateUI()
    {
        stoneText.text = mainData.stoneData.ore.ToString();
        ironText.text = mainData.ironData.ore.ToString();
        goldText.text = mainData.goldData.ore.ToString();
        recycleStoneText.text = mainData.stoneData.recycleOre.ToString("F2");
        recycleIronText.text = mainData.ironData.recycleOre.ToString("F2");
        recycleGoldText.text = mainData.goldData.recycleOre.ToString("F2");
        amountOfRecycleStoneText.text = mainData.stoneData.amountOfRecycle.ToString("00");
        amountOfRecycleIronText.text = mainData.ironData.amountOfRecycle.ToString("00");
        amountOfRecycleGoldText.text = mainData.goldData.amountOfRecycle.ToString("00");
        amountOfRecycleStoneReciveText.text = mainData.stoneData.amountOfRecycleReceive.ToString("F2");
        amountOfRecycleReceiveIronText.text = mainData.ironData.amountOfRecycleReceive.ToString("F2");
        amountOfRecycleReceiveGoldText.text = mainData.goldData.amountOfRecycleReceive.ToString("F2");
    }

    public void Open()
    {
        standartPlantPanel.SetActive(true);
    }

    public void Close()
    {
        standartPlantPanel.SetActive(false);
    }

    private void RecycleResource(OreData oreData, Text recourceText, Text recycleRecourceText)
    {
        if (oreData.ore >= oreData.amountOfRecycle)
        {
            recourceText.text = oreData.ore.ToString();
            oreData.recycleOre += (oreData.amountOfRecycle * oreData.recycleOreCost);
            oreData.ore -= oreData.amountOfRecycle;
            recycleRecourceText.text = oreData.recycleOre.ToString("F2");
        }
    }
   

    public void RecycleStone()
    {
        RecycleResource(mainData.stoneData, stoneText, recycleStoneText);
    }

    public void RecycleIron()
    {
        RecycleResource(mainData.ironData, ironText, recycleIronText);
    }

    public void RecycleGold()
    {
        RecycleResource(mainData.goldData, goldText, recycleGoldText);
    }
}