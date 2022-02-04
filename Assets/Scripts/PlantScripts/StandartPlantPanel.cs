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
    [SerializeField] private Text amountOfRecycleStoneReciveText;
    [SerializeField] private Text amountOfRecycleReceiveIronText;
    [SerializeField] private Text amountOfRecycleReceiveGoldText;

    [SerializeField] private MainData mainData;

    private void Start()
    {
        standartPlantPanel.SetActive(false);
    }

    private void FixedUpdate()
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

    public void RecycleResource(OreData oreData)
    {        
        oreData.recycleOre += oreData.amountOfRecycleReceive;     
        oreData.ore = 0;
        oreData.amountOfRecycleReceive = 0;
    }
    public void OpenOre(OreData oreData)
    {
        oreData.amountOfRecycleReceive = (oreData.ore * oreData.recycleCount);
    } 
   
}