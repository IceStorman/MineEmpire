using UnityEngine;
using UnityEngine.UI;

public class InventorySecondSpecial : MonoBehaviour
{
    [SerializeField] private GameObject InventorySecondSpecialPlantPanel;

    [SerializeField] private Text sapphireText;
    [SerializeField] private Text amethystText;
    [SerializeField] private Text onyxText;

    [SerializeField] private Text recycleSapphireText;
    [SerializeField] private Text recycleAmethystText;
    [SerializeField] private Text recycleOnyxText;

    [SerializeField] private MainData mainData;

    private bool isOpen = false;

    private void Start()
    {
        InventorySecondSpecialPlantPanel.SetActive(false);
    }

    private void Update()
    {
        UpdateUI();
    }

    private void UpdateUI()
    {
        sapphireText.text = mainData.sapphireData.ore.ToString();
        amethystText.text = mainData.amethystData.ore.ToString();
        onyxText.text = mainData.onyxData.ore.ToString();
        recycleSapphireText.text = mainData.sapphireData.recycleOre.ToString("F2");
        recycleAmethystText.text = mainData.amethystData.recycleOre.ToString("F2");
        recycleOnyxText.text = mainData.onyxData.recycleOre.ToString("F2");
    }
    public void Close()
    {
        InventorySecondSpecialPlantPanel.SetActive(false);
        isOpen = false;
    }

    public void Click()
    {
        if (!isOpen)
        {
            InventorySecondSpecialPlantPanel.SetActive(true);
            isOpen = true;
        }
        else if (isOpen)
        {
            InventorySecondSpecialPlantPanel.SetActive(false);
            isOpen = false;
        }
    }
}
