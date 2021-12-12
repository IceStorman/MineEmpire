using UnityEngine;
using UnityEngine.UI;

public class SecondSpecialPlant : MonoBehaviour
{
    [SerializeField] private GameObject secondSpecialPlant;

    [SerializeField] private Text sapphireText;
    [SerializeField] private Text amethystText;
    [SerializeField] private Text onyxText;
    [SerializeField] private Text recycleSapphireText;
    [SerializeField] private Text recycleAmethystText;
    [SerializeField] private Text recycleOnyxText;
    [SerializeField] private Text amountOfRecycleSapphireText;
    [SerializeField] private Text amountOfRecycleAmethystText;
    [SerializeField] private Text amountOfRecycleOnyxText;
    [SerializeField] private Text amountOfRecycleReciveSapphireText;
    [SerializeField] private Text amountOfRecycleReceiveAmethystText;
    [SerializeField] private Text amountOfRecycleReceiveOnyxText;

    [SerializeField] private MainData mainData;

    private void Start()
    {
        secondSpecialPlant.SetActive(false);
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
        amountOfRecycleSapphireText.text = mainData.sapphireData.amountOfRecycle.ToString("00");
        amountOfRecycleAmethystText.text = mainData.amethystData.amountOfRecycle.ToString("00");
        amountOfRecycleOnyxText.text = mainData.onyxData.amountOfRecycle.ToString("00");
        amountOfRecycleReciveSapphireText.text = mainData.sapphireData.amountOfRecycleReceive.ToString("F2");
        amountOfRecycleReceiveAmethystText.text = mainData.amethystData.amountOfRecycleReceive.ToString("F2");
        amountOfRecycleReceiveOnyxText.text = mainData.onyxData.amountOfRecycleReceive.ToString("F2");
    }

    public void Open()
    {
        secondSpecialPlant.SetActive(true);
    }

    public void Close()
    {
        secondSpecialPlant.SetActive(false);
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


    public void RecycleSapphire()
    {
        RecycleResource(mainData.sapphireData, sapphireText, recycleSapphireText);
    }

    public void RecycleAmethyst()
    {
        RecycleResource(mainData.amethystData, amethystText, recycleAmethystText);
    }

    public void RecycleOnyx()
    {
        RecycleResource(mainData.onyxData, onyxText, recycleOnyxText);
    }
}
