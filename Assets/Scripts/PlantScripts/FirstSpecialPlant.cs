using UnityEngine;
using UnityEngine.UI;

public class FirstSpecialPlant : MonoBehaviour
{
    [SerializeField] private GameObject firstSpecialPlant;

    [SerializeField] private Text benitoiteText;
    [SerializeField] private Text copperText;
    [SerializeField] private Text tinText;
    [SerializeField] private Text recycleBenitoiteText;
    [SerializeField] private Text recycleCopperText;
    [SerializeField] private Text recycleTinText;
    [SerializeField] private Text amountOfRecycleReciveBenitoiteText;
    [SerializeField] private Text amountOfRecycleReceiveCopperText;
    [SerializeField] private Text amountOfRecycleReceiveTinText;

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
        tinText.text = mainData.tinData.ore.ToString();
        recycleBenitoiteText.text = mainData.benitoiteData.recycleOre.ToString("F2");
        recycleCopperText.text = mainData.copperData.recycleOre.ToString("F2");
        recycleTinText.text = mainData.tinData.recycleOre.ToString("F2");
        amountOfRecycleReciveBenitoiteText.text = mainData.benitoiteData.amountOfRecycleReceive.ToString("F2");
        amountOfRecycleReceiveCopperText.text = mainData.copperData.amountOfRecycleReceive.ToString("F2");
        amountOfRecycleReceiveTinText.text = mainData.tinData.amountOfRecycleReceive.ToString("F2");
    }

    public void Open()
    {
        firstSpecialPlant.SetActive(true);
    }

    public void Close()
    {
        firstSpecialPlant.SetActive(false);
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
