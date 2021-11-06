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
        if(oreData.ore >= 1)
        {
            oreData.ore--;
            recourceText.text = oreData.ore.ToString();
            oreData.recycleOre += oreData.recycleCount;
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