using UnityEngine;
using UnityEngine.UI;

public class FirstSpecialPlant : MonoBehaviour
{
    [SerializeField] private GameObject firstSpecialPlant;

    [SerializeField] private Text benitoiteText;
    [SerializeField] private Text copperText;
    [SerializeField] private Text diamondText;
    [SerializeField] private Text recycleBenitoiteText;
    [SerializeField] private Text recycleCopperText;
    [SerializeField] private Text recycleDiamondText;
    [SerializeField] private Text amountOfRecycleBenitoiteText;
    [SerializeField] private Text amountOfRecycleCopperText;
    [SerializeField] private Text amountOfRecycleDiamondText;
    [SerializeField] private Text amountOfRecycleReciveBenitoiteText;
    [SerializeField] private Text amountOfRecycleReceiveCopperText;
    [SerializeField] private Text amountOfRecycleReceiveDiamondText;

    [SerializeField] private MainData mainData;

    private void Start()
    {
        firstSpecialPlant.SetActive(false);
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
        amountOfRecycleBenitoiteText.text = mainData.benitoiteData.amountOfRecycle.ToString("00");
        amountOfRecycleCopperText.text = mainData.copperData.amountOfRecycle.ToString("00");
        amountOfRecycleDiamondText.text = mainData.diamondData.amountOfRecycle.ToString("00");
        amountOfRecycleReciveBenitoiteText.text = mainData.benitoiteData.amountOfRecycleReceive.ToString("F2");
        amountOfRecycleReceiveCopperText.text = mainData.copperData.amountOfRecycleReceive.ToString("F2");
        amountOfRecycleReceiveDiamondText.text = mainData.diamondData.amountOfRecycleReceive.ToString("F2");
    }

    public void Open()
    {
        firstSpecialPlant.SetActive(true);
    }

    public void Close()
    {
        firstSpecialPlant.SetActive(false);
    }

    private void RecycleResource(OreData oreData, Text recourceText, Text recycleRecourceText)
    {
        if (oreData.ore >= oreData.amountOfRecycle)
        {
            recourceText.text = oreData.ore.ToString();
            oreData.recycleOre += (oreData.amountOfRecycle * oreData.recycleCount);
            oreData.ore -= oreData.amountOfRecycle;
            recycleRecourceText.text = oreData.recycleOre.ToString("F2");
        }
    }


    public void RecycleBenitoite()
    {
        RecycleResource(mainData.benitoiteData, benitoiteText, recycleBenitoiteText);
    }

    public void RecycleCopper()
    {
        RecycleResource(mainData.copperData, copperText, recycleCopperText);
    }

    public void RecycleDiamond()
    {
        RecycleResource(mainData.diamondData, diamondText, recycleDiamondText);
    }
}
