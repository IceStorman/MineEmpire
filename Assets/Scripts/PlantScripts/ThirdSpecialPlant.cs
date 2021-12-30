using UnityEngine;
using UnityEngine.UI;

public class ThirdSpecialPlant : MonoBehaviour
{
    [SerializeField] private GameObject thirdSpecialPlant;

    [SerializeField] private Text emeraldText;
    [SerializeField] private Text rubyText;
    [SerializeField] private Text tinText;
    [SerializeField] private Text recycleEmeraldText;
    [SerializeField] private Text recycleRubyText;
    [SerializeField] private Text recycleTinText;
    [SerializeField] private Text amountOfRecycleEmeraldText;
    [SerializeField] private Text amountOfRecycleRubyText;
    [SerializeField] private Text amountOfRecycleTinText;
    [SerializeField] private Text amountOfRecycleReciveEmeraldText;
    [SerializeField] private Text amountOfRecycleReceiveRubyText;
    [SerializeField] private Text amountOfRecycleReceiveTinText;

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
        emeraldText.text = mainData.emeraldData.ore.ToString();
        rubyText.text = mainData.rubyData.ore.ToString();
        tinText.text = mainData.tinData.ore.ToString();
        recycleEmeraldText.text = mainData.emeraldData.recycleOre.ToString("F2");
        recycleRubyText.text = mainData.rubyData.recycleOre.ToString("F2");
        recycleTinText.text = mainData.tinData.recycleOre.ToString("F2");
        amountOfRecycleEmeraldText.text = mainData.emeraldData.amountOfRecycle.ToString("00");
        amountOfRecycleRubyText.text = mainData.rubyData.amountOfRecycle.ToString("00");
        amountOfRecycleTinText.text = mainData.tinData.amountOfRecycle.ToString("00");
        amountOfRecycleReciveEmeraldText.text = mainData.emeraldData.amountOfRecycleReceive.ToString("F2");
        amountOfRecycleReceiveRubyText.text = mainData.rubyData.amountOfRecycleReceive.ToString("F2");
        amountOfRecycleReceiveTinText.text = mainData.tinData.amountOfRecycleReceive.ToString("F2");
    }

    public void Open()
    {
        thirdSpecialPlant.SetActive(true);
    }

    public void Close()
    {
        thirdSpecialPlant.SetActive(false);
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


    public void RecycleEmerald()
    {
        RecycleResource(mainData.emeraldData, emeraldText, recycleEmeraldText);
    }

    public void RecycleRuby()
    {
        RecycleResource(mainData.rubyData, rubyText, recycleRubyText);
    }

    public void RecycleTin()
    {
        RecycleResource(mainData.tinData, tinText, recycleTinText);
    }
}
