using UnityEngine;
using UnityEngine.UI;

public class InventoryMechanic : MonoBehaviour
{
    [SerializeField] private GameObject InventoryPanel;

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
        InventoryPanel.SetActive(false);
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

    public void Click()
    {
        if (!isOpen)
        {
            InventoryPanel.SetActive(true);
            isOpen = true;
        }
        else if (isOpen)
        {
            InventoryPanel.SetActive(false);
            isOpen = false;
        }
    }
}