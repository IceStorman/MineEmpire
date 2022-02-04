using UnityEngine;
using UnityEngine.UI;

public class ThirdSpecialPlant : MonoBehaviour
{
    [SerializeField] private GameObject thirdSpecialPlant;

    [SerializeField] private Text sapphireText;
    [SerializeField] private Text amethystText;
    [SerializeField] private Text diamondText;
    [SerializeField] private Text recycleSapphireText;
    [SerializeField] private Text recycleAmethystText;
    [SerializeField] private Text recycleDiamondText;
    [SerializeField] private Text amountOfRecycleReciveSapphireText;
    [SerializeField] private Text amountOfRecycleReceiveAmethystText;
    [SerializeField] private Text amountOfRecycleReceiveDiamondText;

    [SerializeField] private MainData mainData;

    private void Start()
    {
        thirdSpecialPlant.SetActive(false);
    }

    private void Update()
    {
        UpdateUI();
    }

    private void UpdateUI()
    {
        sapphireText.text = mainData.sapphireData.ore.ToString();
        amethystText.text = mainData.amethystData.ore.ToString();
        diamondText.text = mainData.diamondData.ore.ToString();
        recycleSapphireText.text = mainData.sapphireData.recycleOre.ToString("F2");
        recycleAmethystText.text = mainData.amethystData.recycleOre.ToString("F2");
        recycleDiamondText.text = mainData.diamondData.recycleOre.ToString("F2");
        amountOfRecycleReciveSapphireText.text = mainData.sapphireData.amountOfRecycleReceive.ToString("F2");
        amountOfRecycleReceiveAmethystText.text = mainData.amethystData.amountOfRecycleReceive.ToString("F2");
        amountOfRecycleReceiveDiamondText.text = mainData.diamondData.amountOfRecycleReceive.ToString("F2");
    }

    public void Open()
    {
        thirdSpecialPlant.SetActive(true);
    }

    public void Close()
    {
        thirdSpecialPlant.SetActive(false);
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
