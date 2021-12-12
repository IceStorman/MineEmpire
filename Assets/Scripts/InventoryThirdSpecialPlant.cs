using UnityEngine;
using UnityEngine.UI;

public class InventoryThirdSpecialPlant : MonoBehaviour
{
    [SerializeField] private GameObject InventoryFirstSpecialPlant;
    [SerializeField] private GameObject ThirdSpecialPlant;

    [SerializeField] private Text emeraldText;
    [SerializeField] private Text rubyText;
    [SerializeField] private Text tinText;

    [SerializeField] private Text recycleEmeraldText;
    [SerializeField] private Text recycleRubyText;
    [SerializeField] private Text recycleTinText;

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
        emeraldText.text = mainData.emeraldData.ore.ToString();
        rubyText.text = mainData.rubyData.ore.ToString();
        tinText.text = mainData.tinData.ore.ToString();
        recycleEmeraldText.text = mainData.emeraldData.recycleOre.ToString("F2");
        recycleRubyText.text = mainData.rubyData.recycleOre.ToString("F2");
        recycleTinText.text = mainData.tinData.recycleOre.ToString("F2");
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
        else if (isOpen)
        {
            InventoryFirstSpecialPlant.SetActive(false);
            isOpen = false;
        }
    }  
}
