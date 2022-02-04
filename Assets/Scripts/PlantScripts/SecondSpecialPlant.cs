using UnityEngine;
using UnityEngine.UI;

public class SecondSpecialPlant : MonoBehaviour
{
    [SerializeField] private GameObject secondSpecialPlant;

    [SerializeField] private Text emeraldText;
    [SerializeField] private Text rubyText;
    [SerializeField] private Text onyxText;
    [SerializeField] private Text recycleEmeraldText;
    [SerializeField] private Text recycleRubyText;
    [SerializeField] private Text recycleOnyxText;
    [SerializeField] private Text amountOfRecycleReciveEmeraldText;
    [SerializeField] private Text amountOfRecycleReceiveRubyText;
    [SerializeField] private Text amountOfRecycleReceiveOnyxText;

    [SerializeField] private MainData mainData;

    private void Start()
    {
        secondSpecialPlant.SetActive(false);
    }

    private void Update()
    {
        UpdateUI();
        if (Input.GetKeyDown(KeyCode.Escape)) Close();
    }

    private void UpdateUI()
    {
        emeraldText.text = mainData.emeraldData.ore.ToString();
        rubyText.text = mainData.rubyData.ore.ToString();
        onyxText.text = mainData.onyxData.ore.ToString();
        recycleEmeraldText.text = mainData.emeraldData.recycleOre.ToString("F2");
        recycleRubyText.text = mainData.rubyData.recycleOre.ToString("F2");
        recycleOnyxText.text = mainData.onyxData.recycleOre.ToString("F2");
        amountOfRecycleReciveEmeraldText.text = mainData.emeraldData.amountOfRecycleReceive.ToString("F2");
        amountOfRecycleReceiveRubyText.text = mainData.rubyData.amountOfRecycleReceive.ToString("F2");
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
