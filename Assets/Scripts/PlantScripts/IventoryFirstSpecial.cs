using UnityEngine;
using UnityEngine.UI;

public class IventoryFirstSpecial : MonoBehaviour
{
    [SerializeField] private GameObject InventoryFirstSpecialPlant;
  
    [SerializeField] private Text benitoiteText;
    [SerializeField] private Text copperText;
    [SerializeField] private Text diamondText;

    [SerializeField] private Text recycleBenitoiteText;
    [SerializeField] private Text recycleCopperText;
    [SerializeField] private Text recycleDiamondText;

    [SerializeField] private MainData mainData;

    private bool isOpen = false;

    private void Start()
    {
        InventoryFirstSpecialPlant.SetActive(false);
    }

    private void Update()
    {
        UpdateUI();
    }

    private void UpdateUI()
    {
        benitoiteText.text = mainData.benitoiteData.ore.ToString();
        copperText.text = mainData.copperData.ore.ToString();
        diamondText.text = mainData.diamondData.ore.ToString();
        recycleBenitoiteText.text = mainData.benitoiteData.recycleOre.ToString("F2");
        recycleCopperText.text = mainData.copperData.recycleOre.ToString("F2");
        recycleDiamondText.text = mainData.diamondData.recycleOre.ToString("F2");
    }
    public void Close()
    {
        InventoryFirstSpecialPlant.SetActive(false);
        isOpen = false;
    }

    public void Click()
    {
        if (!isOpen)
        {
            InventoryFirstSpecialPlant.SetActive(true);
            isOpen = true;
        }
        else 
        {
            InventoryFirstSpecialPlant.SetActive(false);
            isOpen = false;
        }
    }
}
