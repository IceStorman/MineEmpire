using UnityEngine;
using UnityEngine.UI;

public class InventoryMechanic : MonoBehaviour
{
    [SerializeField] private GameObject InventoryPanel;

    [SerializeField] private Text stoneText;
    [SerializeField] private Text ironText;
    [SerializeField] private Text goldText;
    [SerializeField] private Text benitoiteText;
    [SerializeField] private Text rubyText;
    [SerializeField] private Text emeraldText;
    [SerializeField] private Text diamondText;
    [SerializeField] private Text onyxText;
    [SerializeField] private Text sapphireText;
    [SerializeField] private Text tinText;
    [SerializeField] private Text copperText;
    [SerializeField] private Text amethystText;

    [SerializeField] private Text recycleStoneText;
    [SerializeField] private Text recycleIronText;
    [SerializeField] private Text recycleGoldText;
    [SerializeField] private Text recycleBenitoiteText;
    [SerializeField] private Text recycleRubyText;
    [SerializeField] private Text recycleEmeraldText;
    [SerializeField] private Text recycleDiamondText;
    [SerializeField] private Text recycleOnyxText;
    [SerializeField] private Text recycleSapphireText;
    [SerializeField] private Text recycleTinText;
    [SerializeField] private Text recycleCopperText;
    [SerializeField] private Text recycleAmethystText;

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
        benitoiteText.text = mainData.benitoiteData.ore.ToString();
        rubyText.text = mainData.rubyData.ore.ToString();
        emeraldText.text = mainData.emeraldData.ore.ToString();
        diamondText.text = mainData.diamondData.ore.ToString();
        onyxText.text = mainData.onyxData.ore.ToString();
        sapphireText.text = mainData.sapphireData.ore.ToString();
        tinText.text = mainData.tinData.ore.ToString();
        copperText.text = mainData.copperData.ore.ToString();
        amethystText.text = mainData.amethystData.ore.ToString();

        recycleStoneText.text = mainData.stoneData.recycleOre.ToString("F2");
        recycleIronText.text = mainData.ironData.recycleOre.ToString("F2");
        recycleGoldText.text = mainData.goldData.recycleOre.ToString("F2");
        recycleCopperText.text = mainData.copperData.recycleOre.ToString("F2");
        recycleTinText.text = mainData.tinData.recycleOre.ToString("F2");
        recycleBenitoiteText.text = mainData.benitoiteData.recycleOre.ToString("F2");
        recycleEmeraldText.text = mainData.emeraldData.recycleOre.ToString("F2");
        recycleRubyText.text = mainData.rubyData.recycleOre.ToString("F2");
        recycleOnyxText.text = mainData.onyxData.recycleOre.ToString("F2");
        recycleSapphireText.text = mainData.sapphireData.recycleOre.ToString("F2");
        recycleDiamondText.text = mainData.diamondData.recycleOre.ToString("F2");
        recycleAmethystText.text = mainData.amethystData.recycleOre.ToString("F2");
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