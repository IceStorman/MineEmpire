using UnityEngine;
using UnityEngine.UI;

public class InventoryStandartPlant : MonoBehaviour
{
    [SerializeField] private GameObject InventoryStandartPlantPanel;
    [SerializeField] private GameObject PlantStandart;

    [SerializeField] private Text stoneText;
    [SerializeField] private Text ironText;
    [SerializeField] private Text goldText;

    [SerializeField] private Text recycleStoneText;
    [SerializeField] private Text recycleIronText;
    [SerializeField] private Text recycleGoldText;

    [SerializeField] private MainData mainData;

    private bool isOpen = false;

    private void Start()
    {
        InventoryStandartPlantPanel.SetActive(false);
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
    public void Close()
    {       
        InventoryStandartPlantPanel.SetActive(false);
        isOpen = false;    
    }

    public void Click()
    {
        if (!isOpen)
        {
            InventoryStandartPlantPanel.SetActive(true);
            isOpen = true;
        }
        else if (isOpen)
        {
            InventoryStandartPlantPanel.SetActive(false);
            isOpen = false;
        }
    }
}

